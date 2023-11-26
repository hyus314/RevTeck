document.addEventListener("DOMContentLoaded", function () {

    $.ajax({
        url: '/Payment/GetAllPartsForPayment',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            if (data && data.length > 0) {
                let listItems = '';

                for (let i = 0; i < data.length; i++) {
                    let partItem = '<li class="part-item">';

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

const validCities = ['Sofia', 'Plovdiv', 'letna', 'Burgas', 'Ruse']; // Add more cities if needed

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
    const stripe = Stripe('pk_test_51NpqC7LRIi0RJQWsYfoGk4ZoWSqaGnoxwcEOS6xc7BKeDQwysiL8T7e4Vg7YBuJvFsjHHhDbS7VWLtCl7NrMQrvm001F7uvEc4');
    const elements = stripe.elements();

    const style = {
        base: {
            fontSize: '16px',
            color: '#32325d',
            padding: '10px 12px',
            border: '1px solid #000000',
            backgroundColor: '#ffffff',
            '::placeholder': {
                color: '#aab7c4',
            },
        },
        invalid: {
            color: '#fa755a',
            iconColor: '#fa755a',
            backgroundColor: '#ffe6e6',
            borderColor: '#fa755a',
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

    // Assuming you have a reference to your submit button and form elements
    const submitButton = document.getElementById('submit-button');
    const form = document.querySelector("#paymentForm");
    // Add a loading spinner next to the button when clicked
    submitButton.addEventListener('click', async function (event) {
        event.preventDefault();

        // Show loading spinner and disable button
        submitButton.innerHTML = 'Processing... <div class="loader"></div>';
        submitButton.disabled = true;

        // Show the processing modal
        $('#paymentModal').modal('show');
        document.getElementById('processingState').style.display = 'block';
        document.getElementById('successState').style.display = 'none';
        document.getElementById('failState').style.display = 'none';

        const firstName = form.querySelector("[name='FirstName']").value;
        const lastName = form.querySelector("[name='LastName']").value;
        const phoneNumber = form.querySelector("[name='PhoneNumber']").value;
        const city = form.querySelector("[name='City']").value;
        const country = form.querySelector("[name='Country']").value;
        const deliveryAddress = form.querySelector("[name='Address']").value;

        let formData = {
            'FirstName': firstName,
            'LastName': lastName,
            'PhoneNumber': phoneNumber,
            'City': city,
            'Country': country,
            'DeliveryAddress': deliveryAddress,
            'PaymentMethodId': null
        };

        const result = await stripe.createPaymentMethod({
            type: 'card',
            card: cardNumber
        });

        if (result.error) {
            const displayError = document.getElementById('card-errors');
            displayError.textContent = result.error.message;
            // Revert button to original state
            submitButton.textContent = 'Pay Now';
            submitButton.disabled = false;
        } else {
            formData['PaymentMethodId'] = result.paymentMethod.id;
            const response = await fetch('Payment/ProceedToPaymentIntent', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    paymentMethodId: formData.PaymentMethodId,
                    firstName: formData.FirstName,
                    lastName: formData.LastName,
                    city: formData.City,
                    deliveryAddress: formData.DeliveryAddress,
                    country: formData.Country
                })
            });

            const success = await response.json();

            // Update modal based on payment success or failure
            if (success.result == true) {
                document.getElementById('processingState').style.display = 'none';
                document.getElementById('successState').style.display = 'block';

                // Redirect to home page after 3 seconds
                setTimeout(function () {
                    window.location.href = "/"; // Change this to your home page URL
                }, 3000);
            } else {
                document.getElementById('processingState').style.display = 'none';
                document.getElementById('failState').style.display = 'block';
            }

            // Revert button to original state
            submitButton.textContent = 'Pay Now';
            submitButton.disabled = false;
        }
    });

});
