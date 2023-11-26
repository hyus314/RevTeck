document.addEventListener("DOMContentLoaded", function () {
    let images = document.querySelectorAll(".manufacturer_img");

    images.forEach(function (image) {
        image.addEventListener("click", function () {
            let selectedImage = document.querySelector(".manufacturer_img.selected");
            if (selectedImage) {
                selectedImage.classList.remove("selected");
            }
            this.classList.add("selected");
        });
    });
});
function getModelsByManufacturer(manufacturerId) {
    $.ajax({
        url: "/Vehicle/GetModelsByManufacturer",
        method: "GET",
        data: { manufacturerId: manufacturerId },
        success: function (response) {
            console.log(response); // Log the response object to the console

            let modelsContainer = $("#modelsContainer");
            modelsContainer.empty();

            for (let i = 0; i < response.length; i++) {
                let model = response[i];
                let modelHTML =
                    '<div class="model-car">' +
                    '<div class="model-info">' +
                    '<h2>' + model.modelName + '</h2>' +
                    '<div class="model-car-img">' +
                    '<img src="' + model.imageURL + '" alt="Model Image">' +
                    '</div>' +
                    '</div>' +
                    '<div class="model-year">' +
                    '<p>Production Years</p>' +
                    '<p>From: ' + model.yearCreated_Start + '</p>' +
                    '<p>To: ' + model.yearCreated_End + '</p>' +
                    '</div>' +
                    '<button class="select-button" data-bs-toggle="modal" data-bs-target="#enginesModal" data-model-id="' + model.id + '" onclick="getEnginesByModel(' + model.id + ')">Select This Vehicle Model</button>' +
                    '</div>';

                modelsContainer.append(modelHTML);
            }
        },
        error: function () {
            console.log("Error occurred while retrieving models.");
        }
    });
}
$(document).on("click", ".select-button", function () {
    let modelId = $(this).closest(".model-car").data("model-id");
    getEnginesByModel(modelId); // Call a function to retrieve and display the engines
});


function getEnginesByModel(carModelId) {
    $.ajax({
        url: "/Vehicle/GetEnginesByModel",
        method: "GET",
        data: { carModelId: carModelId },
        success: function (response) {
            console.log(response); // Log the response object to the console

            let enginesContainer = $("#enginesContainer");
            enginesContainer.empty();

            for (let i = 0; i < response.length; i++) {
                let engine = response[i];
                let engineHTML ='<div  class="engine">' +
                    '<h3>' + engine.name + '</h3>' +
                    '<p>Horsepower: ' + engine.horsePower + '</p>' +
                    '<p>Torque: ' + engine.torque + '</p>' +
                    '<button class="select-engine-button" onclick="assignVehicleToUser(' + engine.id + ',' + carModelId + ')">Select</button>' +
                    '</div>';

                enginesContainer.append(engineHTML);
            }

            // Show the engines modal
            $("#enginesModal").modal("show");
        },
        error: function () {
            console.log("Error occurred while retrieving engines for the car model.");
        },
    });
}

function assignVehicleToUser(engineId, carModelId) {
    $.ajax({
        url: "/Configuration/AssignVehicleToUser",
        method: "POST",
        data: { engineId: engineId, carModelId: carModelId },
        success: function () {
            // Hide the modal
            $("#enginesModal").modal("hide");

            // Redirect to the desired view
            window.location.href = "/Configuration/ChooseParts";
        },
        error: function () {
            console.log("Error occurred while assigning the vehicle to the user.");
        }
    });
}