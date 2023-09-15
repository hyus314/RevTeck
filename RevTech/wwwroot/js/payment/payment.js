document.addEventListener("DOMContentLoaded", function () {

    $.ajax({
        url: '/Payment/GetAllPartsForPayment',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            if (data && data.length > 0) {
                var listItems = '';

                for (var i = 0; i < data.length; i++) {
                    var partItem = '<li class="part-item">';

                    partItem += '<div class="part-info">';

                    if (data[i].partType) {
                        partItem += '<span class="part-type">' + data[i].partType + ':</span> ';
                    }

                    if (data[i].partManufacturer) {
                        partItem += '<span class="part-manufacturer">' + data[i].partManufacturer + '</span> ';
                    }

                    if (data[i].partModel) {
                        partItem += '<span class="part-model">' + data[i].partModel + '</span> ';
                    }

                    partItem += '</div>';

                    if (data[i].partPrice) {
                        partItem += '<span class="part-price">' + '$' + parseFloat(data[i].partPrice).toFixed(2) + '</span>';
                    }

                    partItem += '</li>';

                    listItems += partItem;
                }

                $('#orderedPartsList').html('<ul>' + listItems + '</ul>');
            } 
        },
        error: function (error) {
            console.error('Error fetching ordered parts:', error);
        }
    });
});

document.querySelector("[name='FirstName']").addEventListener('input', function (e) {
    const value = e.target.value;
    e.target.value = value.replace(/[^A-Za-z]/g, '');
});

document.querySelector("[name='LastName']").addEventListener('input', function (e) {
    const value = e.target.value;
    e.target.value = value.replace(/[^A-Za-z]/g, '');
});

document.querySelector("[name='PhoneNumber']").addEventListener('input', function (e) {
    const value = e.target.value;
    e.target.value = value.replace(/[^0-9]/g, '');
});

const validCities = ['Sofia', 'Plovdiv', 'Varna', 'Burgas', 'Ruse']; // Add more cities if needed

// Function to enforce valid city names and alphabets only
function enforceValidCities(event) {
    // Enforce alphabets only
    event.target.value = event.target.value.replace(/[^a-zA-Z]/g, '');

    const value = event.target.value;
    const cityError = document.getElementById('cityError');

    // Check if the city is valid
    if (!validCities.includes(value)) {
        cityError.textContent = "Please enter a valid city in Bulgaria.";
    } else {
        cityError.textContent = "";
    }
}

const cityInput = document.querySelector("[name='City']");
cityInput.addEventListener('input', enforceValidCities);



document.addEventListener('DOMContentLoaded', function () {
    const stripe = Stripe('pk_test_51NpqC7LRIi0RJQWsYfoGk4ZoWSqaGnoxwcEOS6xc7BKeDQwysiL8T7e4Vg7YBuJvFsjHHhDbS7VWLtCl7NrMQrvm001F7uvEc4'); // Replace with your publishable key
    const elements = stripe.elements();

    const style = {
        base: {
            fontSize: '16px',
            color: '#32325d',
            padding: '10px 12px', // Add padding
            border: '1px solid #000000', // Add border
            backgroundColor: '#ffffff',
            '::placeholder': {
                color: '#aab7c4',
            },
            ':focus': {
                backgroundColor: '#f7f9fc',
                borderColor: '#000000', // Black border when focused
            },
            '.StripeElement--complete': {
                backgroundColor: '#e6f7ff',
                borderColor: '#000000', // Black border when complete
            },
        },
        invalid: {
            color: '#fa755a',
            iconColor: '#fa755a',
            backgroundColor: '#ffe6e6',
            borderColor: '#fa755a', // Border color when invalid
        },
    };

   

    const cardNumber = elements.create('cardNumber', { style: style });
    const cardExpiry = elements.create('cardExpiry', { style: style });
    const cardCvc = elements.create('cardCvc', { style: style });
    const cardZip = elements.create('postalCode', { style: style });

    cardNumber.mount('#card-number-element');
    cardExpiry.mount('#card-expiry-element');
    cardCvc.mount('#card-cvc-element');
    cardZip.mount('#card-zip-element');

    // Add real-time validation errors display
    cardNumber.addEventListener('change', function (event) {
        displayError(event);
    });

    cardExpiry.addEventListener('change', function (event) {
        displayError(event);
    });

    cardCvc.addEventListener('change', function (event) {
        displayError(event);
    });

    cardZip.addEventListener('change', function (event) {
        displayError(event);
    });

    function displayError(event) {
        const displayError = document.getElementById('card-errors');
        if (event.error) {
            displayError.textContent = event.error.message;
        } else {
            displayError.textContent = '';
        }
    }

    const form = document.getElementById('paymentForm');
    const submitButton = document.getElementById('submit-button');

    submitButton.addEventListener('click', function (event) {
        event.preventDefault();

        // Manually collect and validate other form fields
        const firstName = form.querySelector("[name='FirstName']").value;
        const lastName = form.querySelector("[name='LastName']").value;
        const phoneNumber = form.querySelector("[name = 'PhoneNumber']").value;
        const city = form.querySelector("[name = 'City']").value;
        const country = form.querySelector("[name = 'Country']").value;
        const deliveryAddress = form.querySelector("[name = 'Address']").value;

        let formData = {
            'FirstName': firstName,
            'LastName': lastName,
            'PhoneNumber': phoneNumber,
            'City': city,
            'Country': country,
            'DeliveryAddress': deliveryAddress
        };

        stripe.createPaymentMethod({
            type: 'card',
            card: cardNumber,
        }).then(function (result) {
            if (result.error) {
                const displayError = document.getElementById('card-errors');
                displayError.textContent = result.error.message;
            } else {
                formData['PaymentMethodId'] = result.paymentMethod.id;

                fetch('Payment/ProceedToPaymentIntent', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(formData)
                })
                    .then(response => response.json())
                    .then(data => {
                        console.log("Server response:", data);

                        // Assuming your server responds with a JSON object containing the clientSecret
                        const clientSecret = data.clientSecret;

                        // Proceed to confirm the payment with the clientSecret
                        stripe.confirmCardPayment(clientSecret, {
                            payment_method: {
                                card: cardElement,
                                billing_details: {
                                    name: `${formData.FirstName} ${formData.LastName}`,
                                    address: {
                                        city: formData.City,
                                        country: formData.Country
                                    }
                                }
                            }
                        }).then((result) => {
                            if (result.error) {
                                // Show error to your customer (e.g., error.message)
                                console.log(result.error.message);
                            } else {
                                // The payment has been processed!
                                if (result.paymentIntent.status === 'succeeded') {
                                    // Show a success message to your customer
                                    // There's a risk of the customer closing the window before the callback
                                    // execution. Set up a webhook or plugin to listen for the
                                    // payment_intent.succeeded event that handles any business critical
                                    // post-payment actions.
                                    console.log('Payment succeeded:', result.paymentIntent.id);
                                }
                            }
                        });

                    })
                    .catch((error) => {
                        console.error('Error:', error);
                    });

            }
        });
    });
});
