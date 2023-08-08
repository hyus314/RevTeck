function showConfirmation(carModelId, manufacturer, carModel) {
    const modal = document.getElementById("confirmationModal");
    const confirmationMessage = `Do you want to remove ${manufacturer} ${carModel} from the Database? All the configurations that include this model will also be deleted.`;

    document.getElementById("confirmationMessage").innerText = confirmationMessage;

    modal.style.display = "block";

    document.getElementById("yesButton").onclick = function () {
        modal.style.display = "none";
        removeVehicle(carModelId);
    };

    document.getElementById("noButton").onclick = function () {
        modal.style.display = "none";
    };
}

function removeVehicle(carModelId) {
    $.ajax({
        url: `/Admin/RemoveVehicle`,
        type: 'POST',
        data: { carModelId: carModelId },
        success: function (data) {
            if (data.redirectUrl) {
                window.location.href = data.redirectUrl;
            } else {
                // Handle the case where the redirectUrl is missing or invalid
                console.error("Invalid redirect URL:", data.redirectUrl);
            }
        },
        error: function (xhr, status, error) {
            // Handle the error response (if needed)
            console.error("Error removing configuration:", error);
        }
    });
}

