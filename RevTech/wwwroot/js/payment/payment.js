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

// Add this script at the end of the body tag.

document.addEventListener('DOMContentLoaded', function () {
    const stripe = Stripe('pk_test_...'); // Replace with your publishable key
    const elements = stripe.elements();
    const card = elements.create('card');
    card.mount('#card-element');

    card.addEventListener('change', function (event) {
        const displayError = document.getElementById('card-errors');
        if (event.error) {
            displayError.textContent = event.error.message;
        } else {
            displayError.textContent = '';
        }
    });

    const form = document.getElementById('paymentForm');
    const submitButton = document.getElementById('submit-button');

    submitButton.addEventListener('click', function (event) {
        event.preventDefault();

        // Manually collect and validate other form fields
        const firstName = form.querySelector("[name='FirstName']").value;
        const lastName = form.querySelector("[name='LastName']").value;
        // ... collect other fields ...

        // Create an object to hold all form data
        let formData = {
            'FirstName': firstName,
            'LastName': lastName,
            // ... other fields ...
        };

        stripe.createPaymentMethod({
            type: 'card',
            card: card,
        }).then(function (result) {
            if (result.error) {
                const displayError = document.getElementById('card-errors');
                displayError.textContent = result.error.message;
            } else {
                // Add the Stripe PaymentMethod ID to the form data
                formData['PaymentMethodId'] = result.paymentMethod.id;

                // Send data to server
                fetch('/ProcessPayment', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(formData)
                })
                    .then(response => response.json())
                    .then(data => {
                        console.log("Server response:", data);
                    })
                    .catch((error) => {
                        console.error('Error:', error);
                    });
            }
        });
    });
});
