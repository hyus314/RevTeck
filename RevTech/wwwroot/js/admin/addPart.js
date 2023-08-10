function showForm(formId) {
    // Get references to the clicked part and its form
    let clickedPart = document.querySelector(`[data-form="${formId}"]`);
    let correspondingForm = document.getElementById(formId);

    // Check if the clicked part was already selected
    let wasAlreadySelected = clickedPart.classList.contains("selected");

    // Deselect all parts and hide all forms
    let allParts = document.querySelectorAll(".performance-part");
    let allForms = document.querySelectorAll(".part-form");

    allParts.forEach(part => part.classList.remove("selected"));
    allForms.forEach(form => form.style.display = "none");

    // If it wasn't already selected, select it and show its form
    if (!wasAlreadySelected) {
        clickedPart.classList.add("selected");
        correspondingForm.style.display = "block";
    }
}

document.addEventListener("DOMContentLoaded", function () {
    fetch('/Admin/GetEnginesForPart') 
        .then(response => response.json())
        .then(data => populateDropdown(data))
        .catch(error => console.error('Error fetching data:', error));
});

function populateDropdown(data) {
    const dropdown = document.getElementById("dropdownData");

    // Iterate over each data item and add it to the dropdown
    data.forEach(engine => {
        const option = document.createElement('option');
        option.value = engine.id;
        option.textContent = engine.name;

        dropdown.appendChild(option);
    });
}

document.getElementById('turboForm').addEventListener('submit', function (event) {
    event.preventDefault();  // Prevent the default form submission

    const formData = {
        'modelName': document.getElementById('modelName').value,
        'manufacturer': document.getElementById('manufacturer').value,
        'horsePowerBoost': document.getElementById('horsePowerBoost').value,
        'torqueBoost': document.getElementById('torqueBoost').value,
        'pressureBoost': document.getElementById('pressureBoost').value,
        'imageURL': document.getElementById('imageURL').value,
        'price': document.getElementById('price').value,
        'engineId': document.getElementById('dropdownData').value
    };

    // Use fetch to send a POST request with JSON data
    fetch('/Admin/AddTurbo', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(formData)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(data => {
            console.log('Success:', data);
            if (data.redirectUrl) {
                window.location.href = data.redirectUrl;
            }
        })
        .catch(error => {
            console.error('Error:', error);
        });

});