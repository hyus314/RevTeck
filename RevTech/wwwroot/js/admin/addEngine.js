$(document).ready(function () {
    $.ajax({
        url: "/Vehicle/GetAllCarModels",  // Adjust with your actual endpoint
        method: "GET",
        dataType: "json",
        success: function (data) {
            const carModelsDropdown = $('#carModels');
            carModelsDropdown.empty();

            // Assuming data is an array of car models with id and name properties
            data.forEach(model => {
                carModelsDropdown.append(`<option value="${model.id}">${model.manufacturerName} ${model.modelName}</option>`);
            });
        },
        error: function (error) {
            console.error("There was an error fetching the car models:", error);
        }
    });
});