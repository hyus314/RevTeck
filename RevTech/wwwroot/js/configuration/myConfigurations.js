function showConfirmation(configurationId, manufacturer, carModel) {
    const modal = document.getElementById("confirmationModal");
    const confirmationMessage = `Do you want to remove your ${manufacturer} ${carModel} configuration?`;

    document.getElementById("confirmationMessage").innerText = confirmationMessage;

    modal.style.display = "block";

    document.getElementById("yesButton").onclick = function () {
        modal.style.display = "none";
        removeConfiguration(configurationId);
    };

    document.getElementById("noButton").onclick = function () {
        modal.style.display = "none";
    };
}

function removeConfiguration(configurationId) {
    $.ajax({
        url: `/Configuration/Remove`,
        type: 'POST',
        data: { configurationId: configurationId },
        success: function (data) {
            if (data.redirectUrl) {
                window.location.href = data.redirectUrl;
            } else {
                // Handle the case where the redirectUrl is missing or invalid
            }
        },
        error: function (xhr, status, error) {
            // Handle the error response (if needed)
            console.error("Error removing configuration:", error);
        }
    });
}

function storeInformation(configurationId, engineId, carModelId) {
    localStorage.setItem('editConfigurationId', configurationId);
    localStorage.setItem('engineId', engineId);
    localStorage.setItem('carModelId', carModelId);
}