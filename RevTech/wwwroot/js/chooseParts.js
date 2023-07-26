function loadAllParts(engineId, carModelId) {
    loadTurbos(engineId);
    loadExhaustKits(engineId, carModelId);
    loadSuperchargers(engineId);
    loadEcus(engineId);
    loadTcus();
    loadFuelPumps(engineId);
    loadInjectorKits(engineId);
    loadOilCoolers(engineId);
    loadSparkPlugs(engineId);

    var findPartsButton = document.getElementById('find-parts-button');

    findPartsButton.style.display = 'none';
}

function loadTurbos(engineId) {
    $.ajax({
        url: '/Parts/LoadTurbos',
        type: 'GET',
        data: {
            engineId: engineId
        },
        success: function (data) {
            generateTurboViews(data);
        },
        error: function (error) {
            console.error(error);
        }
    });
}

function generateTurboViews(turbos) {
    var turboContainer = document.getElementById('turbo-container');
    turboContainer.innerHTML = '';

    var turboWrapper = document.createElement('div');
    turboWrapper.classList.add('part-wrapper');

    turbos.forEach(function (turbo) {
        var turboView = document.createElement('div');
        turboView.classList.add('part-view');
        turboView.classList.add('selectable');
        turboView.setAttribute('id', `turbo-${turbo.id}`);
        turboView.innerHTML = `
            <h4 class="part-model">${turbo.modelName}</h4>
            <h4 class="part-manufacturer">${turbo.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${turbo.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${turbo.torqueBoost}</p>
            <p class="part-pressure">Pressure Boost: ${turbo.pressureBoost}</p>
            <img class="part-image" src="${turbo.imageURL}" alt="${turbo.modelName}" />
            <p class="part-price">Price: ${turbo.price}</p>
        `;

        turboView.addEventListener('click', function () {
            selectPart('turbo', turbo.id);
        });


        turboWrapper.appendChild(turboView);
    });

    turboContainer.appendChild(turboWrapper);
}

function loadExhaustKits(engineId, carModelId) {
    $.ajax({
        url: '/Parts/LoadExhaustKits',
        type: 'GET',
        data: {
            engineId: engineId,
            carModelId: carModelId
        },
        success: function (data) {
            generateExhaustKitViews(data);
        },
        error: function (error) {
            console.error(error);
        }
    });
}

function generateExhaustKitViews(exhaustKits) {
    var exhaustKitContainer = document.getElementById('exhaustKit-container');
    exhaustKitContainer.innerHTML = ''; // Clear the existing content

    var exhaustKitWrapper = document.createElement('div');
    exhaustKitWrapper.classList.add('part-wrapper');

    exhaustKits.forEach(function (exhaustKit) {
        var exhaustKitView = document.createElement('div');
        exhaustKitView.classList.add('part-view');
        exhaustKitView.classList.add('selectable');
        exhaustKitView.setAttribute('id', `exhaustKit-${exhaustKit.id}`);
        exhaustKitView.innerHTML = `
            <h4 class="part-model">${exhaustKit.model}</h4>
            <h4 class="part-manufacturer">${exhaustKit.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${exhaustKit.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${exhaustKit.torqueBoost}</p>
            <img class="part-image" src="${exhaustKit.imageURl}" alt="${exhaustKit.model}" />
            <p class="part-price">Price: ${exhaustKit.price}</p>
        `;

        exhaustKitView.addEventListener('click', function () {
            selectPart('exhaustKit', exhaustKit.id);
        });

        exhaustKitWrapper.appendChild(exhaustKitView);
    });

    exhaustKitContainer.appendChild(exhaustKitWrapper);
}

function loadSuperchargers(engineId) {
    $.ajax({
        url: '/Parts/LoadSuperchargers',
        type: 'GET',
        data: {
            engineId: engineId,
        },
        success: function (data) {
            // Process the data returned from the server
            generateSuperchargerViews(data);
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error(error);
        }
    });
}

function generateSuperchargerViews(superchargers) {
    var superchargerContainer = document.getElementById('supercharger-container');
    superchargerContainer.innerHTML = ''; // Clear the existing content

    var superchargerWrapper = document.createElement('div');
    superchargerWrapper.classList.add('part-wrapper');

    superchargers.forEach(function (supercharger) {
        var superchargerView = document.createElement('div');
        superchargerView.classList.add('part-view');
        superchargerView.classList.add('selectable');
        superchargerView.setAttribute('id', `supercharger-${supercharger.id}`);
        superchargerView.innerHTML = `
            <h4 class="part-model">${supercharger.modelName}</h4>
            <h4 class="part-manufacturer">${supercharger.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${supercharger.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${supercharger.torqueBoost}</p>
            <img class="part-image" src="${supercharger.imageURL}" alt="${supercharger.modelName}" />
            <p class="part-price">Price: ${supercharger.price}</p>
        `;

        superchargerView.addEventListener('click', function () {
            selectPart('supercharger', supercharger.id);
        });

        superchargerWrapper.appendChild(superchargerView);
    });

    superchargerContainer.appendChild(superchargerWrapper);
}

function loadEcus(engineId) {
    $.ajax({
        url: '/Parts/LoadEcuTunings',
        type: 'GET',
        data: {
            engineId: engineId,
        },
        success: function (data) {
            // Process the data returned from the server
            generateEcuViews(data);
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error(error);
        }
    });
}

function generateEcuViews(ecus) {
    var ecuContainer = document.getElementById('ecu-container');
    ecuContainer.innerHTML = ''; // Clear the existing content

    var ecuWrapper = document.createElement('div');
    ecuWrapper.classList.add('part-wrapper');

    ecus.forEach(function (ecu) {
        var ecuView = document.createElement('div');
        ecuView.classList.add('part-view');
        ecuView.classList.add('selectable');
        ecuView.setAttribute('id', `ecu-${ecu.id}`);
        ecuView.innerHTML = `
            <h4 class="part-model">${ecu.name}</h4>
            <h4 class="part-manufacturer">${ecu.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${ecu.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${ecu.torqueBoost}</p>
            <img class="part-image" src="${ecu.imageURL}" alt="${ecu.name}" />
            <p class="part-price">Price: ${ecu.price}</p>
        `;

        ecuView.addEventListener('click', function () {
            selectPart('ecu', ecu.id);
        });

        ecuWrapper.appendChild(ecuView);
    });

    ecuContainer.appendChild(ecuWrapper);
}

function loadTcus() {
    $.ajax({
        url: '/Parts/LoadTcuTunings',
        type: 'GET',
        success: function (data) {
            // Process the data returned from the server
            generateTcuViews(data);
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error(error);
        }
    });
}

function generateTcuViews(tcus) {
    var tcuContainer = document.getElementById('tcu-container');
    tcuContainer.innerHTML = ''; // Clear the existing content

    var tcuWrapper = document.createElement('div');
    tcuWrapper.classList.add('part-wrapper');

    tcus.forEach(function (tcu) {
        var tcuView = document.createElement('div');
        tcuView.classList.add('part-view');
        tcuView.classList.add('selectable');
        tcuView.setAttribute('id', `tcu-${tcu.id}`);
        tcuView.innerHTML = `
            <h4 class="part-model">${tcu.name}</h4>
            <img class="part-image" src="${tcu.imageURL}" alt="${tcu.name}" />
            <p class="part-tcu-description">Description: ${tcu.description}</p>
        `;

        tcuView.addEventListener('click', function () {
            selectPart('tcu', tcu.id);
        });

        tcuWrapper.appendChild(tcuView);
    });

    tcuContainer.appendChild(tcuWrapper);
}

function loadFuelPumps(engineId) {
    $.ajax({
        url: '/Parts/LoadFuelPumps',
        type: 'GET',
        data: {
            engineId: engineId,
        },
        success: function (data) {
            // Process the data returned from the server
            generateFuelPumpViews(data);
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error(error);
        }
    });
}

function generateFuelPumpViews(fuelPumps) {
    var fuelPumpContainer = document.getElementById('fuelPump-container');
    fuelPumpContainer.innerHTML = ''; // Clear the existing content

    var fuelPumpWrapper = document.createElement('div');
    fuelPumpWrapper.classList.add('part-wrapper');

    fuelPumps.forEach(function (fuelPump) {
        var fuelPumpView = document.createElement('div');
        fuelPumpView.classList.add('part-view');
        fuelPumpView.classList.add('selectable');
        fuelPumpView.setAttribute('id', `fuelPump-${fuelPump.id}`);
        fuelPumpView.innerHTML = `
            <h4 class="part-model">${fuelPump.model}</h4>
            <h4 class="part-manufacturer">${fuelPump.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${fuelPump.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${fuelPump.torqueBoost}</p>
            <img class="part-image" src="${fuelPump.imageURl}" alt="${fuelPump.model}" />
            <p class="part-price">Price: ${fuelPump.price}</p>
        `;

        fuelPumpView.addEventListener('click', function () {
            selectPart('fuelPump', fuelPump.id);
        });

        fuelPumpWrapper.appendChild(fuelPumpView);
    });

    fuelPumpContainer.appendChild(fuelPumpWrapper);
}

function loadInjectorKits(engineId) {
    $.ajax({
        url: '/Parts/LoadInjectorKits',
        type: 'GET',
        data: {
            engineId: engineId,
        },
        success: function (data) {
            // Process the data returned from the server
            generateInjectorKitsViews(data);
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error(error);
        }
    });
}

function generateInjectorKitsViews(injectorKits) {
    var injectorKitContainer = document.getElementById('injectorKit-container');
    injectorKitContainer.innerHTML = ''; // Clear the existing content

    var injectorKitWrapper = document.createElement('div');
    injectorKitWrapper.classList.add('part-wrapper');

    injectorKits.forEach(function (injectorKit) {
        var injectorKitView = document.createElement('div');
        injectorKitView.classList.add('part-view');
        injectorKitView.classList.add('selectable');
        injectorKitView.setAttribute('id', `injectorKit-${injectorKit.id}`);
        injectorKitView.innerHTML = `
            <h4 class="part-model">${injectorKit.model}</h4>
            <h4 class="part-manufacturer">${injectorKit.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${injectorKit.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${injectorKit.torqueBoost}</p>
            <img class="part-image" src="${injectorKit.imageURL}" alt="${injectorKit.model}" />
            <p class="part-price">Price: ${injectorKit.price}</p>
        `;

        injectorKitView.addEventListener('click', function () {
            selectPart('injectorKit', injectorKit.id);
        });

        injectorKitWrapper.appendChild(injectorKitView);
    });

    injectorKitContainer.appendChild(injectorKitWrapper);
}

function loadOilCoolers(engineId) {
    $.ajax({
        url: '/Parts/LoadOilCoolers',
        type: 'GET',
        data: {
            engineId: engineId,
        },
        success: function (data) {
            // Process the data returned from the server
            generateOilCoolersViews(data);
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error(error);
        }
    });
}
function generateOilCoolersViews(oilCoolers) {
    var oilCoolerContainer = document.getElementById('oilCooler-container');
    oilCoolerContainer.innerHTML = ''; // Clear the existing content

    var oilCoolerWrapper = document.createElement('div');
    oilCoolerWrapper.classList.add('part-wrapper');

    oilCoolers.forEach(function (oilCooler) {
        var oilCoolerView = document.createElement('div');
        oilCoolerView.classList.add('part-view');
        oilCoolerView.classList.add('selectable');
        oilCoolerView.setAttribute('id', `oilCooler-${oilCooler.id}`);
        oilCoolerView.innerHTML = `
            <h4 class="part-model">${oilCooler.model}</h4>
            <h4 class="part-manufacturer">${oilCooler.manufacturer}</h4>
            <img class="part-image" src="${oilCooler.imageURL}" alt="${oilCooler.model}" />
            <p class="part-price">Price: ${oilCooler.price}</p>
        `;

        oilCoolerView.addEventListener('click', function () {
            selectPart('oilCooler', oilCooler.id);
        });

        oilCoolerWrapper.appendChild(oilCoolerView);
    });

    oilCoolerContainer.appendChild(oilCoolerWrapper);
}

function loadSparkPlugs(engineId) {
    $.ajax({
        url: '/Parts/LoadSparkPlugs',
        type: 'GET',
        data: {
            engineId: engineId,
        },
        success: function (data) {
            // Process the data returned from the server
            generateSparkPlugsViews(data);
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error(error);
        }
    });
}
function generateSparkPlugsViews(sparkPlugs) {
    var sparkPlugContainer = document.getElementById('sparkPlug-container');
    sparkPlugContainer.innerHTML = ''; // Clear the existing content

    var sparkPlugWrapper = document.createElement('div');
    sparkPlugWrapper.classList.add('part-wrapper');

    sparkPlugs.forEach(function (sparkplug) {
        var sparkPlugView = document.createElement('div');
        sparkPlugView.classList.add('part-view');
        sparkPlugView.classList.add('selectable');
        sparkPlugView.setAttribute('id', `sparkPlug-${sparkplug.id}`); // Set a unique ID for each spark plug

        sparkPlugView.innerHTML = `
            <h4 class="part-manufacturer">${sparkplug.manufacturer}</h4>
            <img class="part-image" src="${sparkplug.imageURl}" alt="${sparkplug.manufacturer} Spark Plug" />
            <p class="part-price">Price: ${sparkplug.price}</p>
        `;

        sparkPlugView.addEventListener('click', function () {
            selectPart('sparkPlug', sparkplug.id);
        });

        sparkPlugWrapper.appendChild(sparkPlugView);
    });

    sparkPlugContainer.appendChild(sparkPlugWrapper);
}

var selectedParts = {
    tcu:null,
    turbo: null,
    exhaustKit: null,
    supercharger: null,
    ecu: null,
    fuelPump: null,
    injectorKit: null,
    oilCooler: null,
    sparkPlug: null
};

var selectedPartsJson = JSON.stringify(selectedParts);

function selectPart(partType, partId) {
    var selectedPartView = document.getElementById(`${partType}-${partId}`);
    var isSelected = selectedPartView.classList.contains('selected');

    // Get the ID of the previously selected part of the same type
    var previousPartId = selectedParts[partType];

    // Deselect the previously selected part of the same type, if any
    if (previousPartId !== null) {
        var previousPartView = document.getElementById(`${partType}-${previousPartId}`);
        if (previousPartId !== partId) {
            previousPartView.classList.remove('selected');
            selectedParts[partType] = null;
        }
    }

    // Toggle the selection state of the part view
    selectedPartView.classList.toggle('selected', !isSelected);

    // Update the selected parts object
    selectedParts[partType] = isSelected ? null : partId;

    // Check if at least one part is selected
    var isAnyPartSelected = Object.values(selectedParts).some(partId => partId !== null);
    var createConfigurationButton = document.getElementById('create-configuration-button');
    createConfigurationButton.style.display = isAnyPartSelected ? 'block' : 'none';

   
}

var isButtonClicked = false;

function createConfiguration() {
    if (!isButtonClicked) {
        var carModelId = document.getElementById('create-configuration-button').getAttribute('data-carModel-id');
        var engineId = document.getElementById('create-configuration-button').getAttribute('data-engine-id');

        // Transfer the selectedParts dictionary to the controller action
        // using an AJAX request
        $.ajax({
            url: '/Configuration/CreateConfiguration',
            type: 'POST',
            data: {
                selectedParts: selectedParts,
                engineId: engineId,
                carModelId: carModelId
            },
            success: function (response) {
                // Check if the response contains the redirect URL
                if (response.redirectUrl) {
                    // Perform the redirection using JavaScript
                    window.location.href = response.redirectUrl;
                } else {
                    // Handle other responses as needed
                    // For example, show success messages, etc.
                }
            },
            error: function (error) {
                // Handle any errors that occurred during the request
                console.error(error);
            },
            complete: function () {
                // Re-enable the button after the AJAX request is complete
                document.getElementById('create-configuration-button').disabled = false;
                isButtonClicked = false;
            }
        });

        // Set the flag to true to prevent multiple clicks
        isButtonClicked = true;

        // Disable the button to prevent multiple clicks while the AJAX request is ongoing
        document.getElementById('create-configuration-button').disabled = true;
    }
}