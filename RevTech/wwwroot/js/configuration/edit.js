﻿let configuration;
let configurationId;

window.onload = async function () {
     configurationId = localStorage.getItem('editConfigurationId');
    let engineId = localStorage.getItem('engineId');
    let carModelId = localStorage.getItem('carModelId');
    await generateConfiguration(configurationId);
    loadTurbos(engineId);
    loadExhaustKits(engineId, carModelId);
    loadFuelPumps(engineId);
    loadInjectorKits(engineId);
    loadOilCoolers(engineId);
    loadSuperchargers(engineId);
    loadEcus(engineId);
    loadSparkPlugs(engineId);
    loadTcus();
}

function generateConfiguration(configurationId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/Configuration/GetJsonEditModel',
            type: 'GET',
            data: {
                configurationId: configurationId
            },
            success: function (model) {
                // Process the data returned from the server
                configuration = JSON.parse(model)
                assignSelectedParts(JSON.parse(model));
                resolve(); // Resolve the promise when the Ajax request is successful
            },
            error: function (error) {
                // Handle any errors that occurred during the request
                console.error(error);
                reject(error); // Reject the promise if there's an error
            }
        });
    });
}


function assignSelectedParts(modelObject) {

    selectedParts['tcu'] = modelObject.TCUTuningId;
    selectedParts['turbo'] = modelObject.TurboKitId;
    selectedParts['exhaustKit'] = modelObject.ExhaustKitId;
    selectedParts['supercharger'] = modelObject.SuperchargerKitId;
    selectedParts['ecu'] = modelObject.ECUTuningId;
    selectedParts['fuelPump'] = modelObject.FuelPumpId;
    selectedParts['injectorKit'] = modelObject.InjectorKitId;
    selectedParts['oilCooler'] = modelObject.OilCoolerId;
    selectedParts['sparkPlug'] = modelObject.SparkPlugsId;
}

function hasChangesMade(modelObject) {
    if (selectedParts['tcu'] !== modelObject.TCUTuningId) {
        return true;
    }

    // Check if the Turbo value is different
    if (selectedParts['turbo'] !== modelObject.TurboKitId) {
        return true;
    }

    // Check if the ExhaustKit value is different
    if (selectedParts['exhaustKit'] !== modelObject.ExhaustKitId) {
        return true;
    }

    // Check if the Supercharger value is different
    if (selectedParts['supercharger'] !== modelObject.SuperchargerKitId) {
        return true;
    }

    // Check if the ECU value is different
    if (selectedParts['ecu'] !== modelObject.ECUTuningId) {
        return true;
    }

    // Check if the FuelPump value is different
    if (selectedParts['fuelPump'] !== modelObject.FuelPumpId) {
        return true;
    }

    // Check if the InjectorKit value is different
    if (selectedParts['injectorKit'] !== modelObject.InjectorKitId) {
        return true;
    }

    // Check if the OilCooler value is different
    if (selectedParts['oilCooler'] !== modelObject.OilCoolerId) {
        return true;
    }

    if (selectedParts['sparkPlug'] !== modelObject.SparkPlugsId) {
        return true;
    }

    return false;
}

function loadTurbos(engineId) {
    $.ajax({
        url: '/Parts/LoadTurbos',
        type: 'GET',
        data: {
            engineId: engineId
        },
        success: function (data) {
            // Process the data returned from the server
            generateTurboViews(data);

        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error(error);
        }
    });
}
let selectedParts = {
    tcu: null,
    turbo: null,
    exhaustKit: null,
    supercharger: null,
    ecu: null,
    fuelPump: null,
    injectorKit: null,
    oilCooler: null,
    sparkPlug: null
};


function generateTurboViews(turbos) {
    document.getElementById('turbo-container').scrollIntoView();
    let turboContainer = document.getElementById('turbo-container');
    turboContainer.innerHTML = ''; // Clear the existing content

    let titleElement = document.createElement('div');
    titleElement.classList.add('part-title');
    if (turbos.length === 0) {
        titleElement.innerHTML = 'No Turbos are available for this model!';
    } else if (turbos.length === 1) {
        titleElement.innerHTML = '1 Turbo available is for this model:';
    } else {
        titleElement.innerHTML = `${turbos.length} Turbos are available for this model:`;
    }
    turboContainer.appendChild(titleElement);

    let turboWrapper = document.createElement('div');
    turboWrapper.classList.add('part-wrapper');

    turbos.forEach(function (turbo) {
        let turboView = document.createElement('div');
        turboView.classList.add('part-view');
        turboView.classList.add('selectable');
        turboView.setAttribute('id', `turbo-${turbo.id}`);
        if (selectedParts['turbo'] === turbo.id) {
            turboView.classList.add('selected');
        }
        turboView.innerHTML = `
            <h4 class="part-model">${turbo.modelName}</h4>
            <h4 class="part-manufacturer">${turbo.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${turbo.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${turbo.torqueBoost}</p>
            <p class="part-pressure">Pressure Boost: ${turbo.pressureBoost}</p>
            <img class="part-image" src="${turbo.imageURL}" alt="${turbo.modelName}" />
            <p class="part-price">Price: $${turbo.price}</p>
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
            // Process the data returned from the server
            generateExhaustKitViews(data);
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error(error);
        }
    });
}

function generateExhaustKitViews(exhaustKits) {
    let exhaustKitContainer = document.getElementById('exhaustKit-container');
    exhaustKitContainer.innerHTML = ''; // Clear the existing content

    let titleElement = document.createElement('div');
    titleElement.classList.add('part-title');
    if (exhaustKits.length === 0) {
        titleElement.innerHTML = 'No Exhaust Kits are available for this model!';
    } else if (exhaustKits.length === 1) {
        titleElement.innerHTML = '1 Exhaust Kit is available for this model:';
    } else {
        titleElement.innerHTML = `${exhaustKits.length} Exhaust Kits are available for this model:`;
    }
    exhaustKitContainer.appendChild(titleElement);

    let exhaustKitWrapper = document.createElement('div');
    exhaustKitWrapper.classList.add('part-wrapper');

    exhaustKits.forEach(function (exhaustKit) {
        let exhaustKitView = document.createElement('div');
        exhaustKitView.classList.add('part-view');
        exhaustKitView.classList.add('selectable');
        exhaustKitView.setAttribute('id', `exhaustKit-${exhaustKit.id}`);
        if (selectedParts['exhaustKit'] === exhaustKit.id) {
            exhaustKitView.classList.add('selected');
        }
        exhaustKitView.innerHTML = `
            <h4 class="part-model">${exhaustKit.model}</h4>
            <h4 class="part-manufacturer">${exhaustKit.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${exhaustKit.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${exhaustKit.torqueBoost}</p>
            <img class="part-image" src="${exhaustKit.imageURl}" alt="${exhaustKit.model}" />
            <p class="part-price">Price: $${exhaustKit.price}</p>
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
    let superchargerContainer = document.getElementById('supercharger-container');
    superchargerContainer.innerHTML = ''; // Clear the existing content

    let titleElement = document.createElement('div');
    titleElement.classList.add('part-title');
    if (superchargers.length === 0) {
        titleElement.innerHTML = 'No Superchargers are available for this model!';
    } else if (superchargers.length === 1) {
        titleElement.innerHTML = '1 Supercharger is available for this model:';
    } else {
        titleElement.innerHTML = `${superchargers.length} Superchargers are available for this model:`;
    }
    superchargerContainer.appendChild(titleElement);


    let superchargerWrapper = document.createElement('div');
    superchargerWrapper.classList.add('part-wrapper');

    superchargers.forEach(function (supercharger) {
        let superchargerView = document.createElement('div');
        superchargerView.classList.add('part-view');
        superchargerView.classList.add('selectable');
        superchargerView.setAttribute('id', `supercharger-${supercharger.id}`);
        if (selectedParts['supercharger'] === supercharger.id) {
            superchargerView.classList.add('selected');
        }
        superchargerView.innerHTML = `
            <h4 class="part-model">${supercharger.modelName}</h4>
            <h4 class="part-manufacturer">${supercharger.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${supercharger.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${supercharger.torqueBoost}</p>
            <img class="part-image" src="${supercharger.imageURL}" alt="${supercharger.modelName}" />
            <p class="part-price">Price: $${supercharger.price}</p>
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
    let ecuContainer = document.getElementById('ecu-container');
    ecuContainer.innerHTML = ''; // Clear the existing content


    let titleElement = document.createElement('div');
    titleElement.classList.add('part-title');
    if (ecus.length === 0) {
        titleElement.innerHTML = 'No ECUs are available for this model!';
    } else if (ecus.length === 1) {
        titleElement.innerHTML = '1 ECU is available for this model:';
    } else {
        titleElement.innerHTML = `${ecus.length} ECUs are available for this model:`;
    }
    ecuContainer.appendChild(titleElement);


    let ecuWrapper = document.createElement('div');
    ecuWrapper.classList.add('part-wrapper');

    ecus.forEach(function (ecu) {
        let ecuView = document.createElement('div');
        ecuView.classList.add('part-view');
        ecuView.classList.add('selectable');
        ecuView.setAttribute('id', `ecu-${ecu.id}`);
        if (selectedParts['ecu'] === ecu.id) {
            ecuView.classList.add('selected');
        }
        ecuView.innerHTML = `
            <h4 class="part-model">${ecu.name}</h4>
            <h4 class="part-manufacturer">${ecu.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${ecu.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${ecu.torqueBoost}</p>
            <img class="part-image" src="${ecu.imageURL}" alt="${ecu.name}" />
            <p class="part-price">Price: $${ecu.price}</p>
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
    let tcuContainer = document.getElementById('tcu-container');
    tcuContainer.innerHTML = ''; // Clear the existing content

    let titleView = document.createElement('div');
    titleView.classList.add('part-title');
    titleView.innerHTML = 'Select a TCU Adaptation Software:';

    tcuContainer.appendChild(titleView);

    let tcuWrapper = document.createElement('div');
    tcuWrapper.classList.add('part-wrapper');

    tcus.forEach(function (tcu) {
        let tcuView = document.createElement('div');
        tcuView.classList.add('part-view');
        tcuView.classList.add('selectable');
        tcuView.setAttribute('id', `tcu-${tcu.id}`);
        if (selectedParts['tcu'] === tcu.id) {
            tcuView.classList.add('selected');
        }
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
    let fuelPumpContainer = document.getElementById('fuelPump-container');
    fuelPumpContainer.innerHTML = ''; // Clear the existing content

    let titleElement = document.createElement('div');
    titleElement.classList.add('part-title');
    if (fuelPumps.length === 0) {
        titleElement.innerHTML = 'No Fuel Pumps are available for this model!';
    } else if (fuelPumps.length === 1) {
        titleElement.innerHTML = '1 Fuel Pump is available for this model:';
    } else {
        titleElement.innerHTML = `${fuelPumps.length} Fuel Pumps are available for this model:`;
    }
    fuelPumpContainer.appendChild(titleElement);



    let fuelPumpWrapper = document.createElement('div');
    fuelPumpWrapper.classList.add('part-wrapper');

    fuelPumps.forEach(function (fuelPump) {
        let fuelPumpView = document.createElement('div');
        fuelPumpView.classList.add('part-view');
        fuelPumpView.classList.add('selectable');
        fuelPumpView.setAttribute('id', `fuelPump-${fuelPump.id}`);
        if (selectedParts['fuelPump'] === fuelPump.id) {
            fuelPumpView.classList.add('selected');
        }
        fuelPumpView.innerHTML = `
            <h4 class="part-model">${fuelPump.model}</h4>
            <h4 class="part-manufacturer">${fuelPump.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${fuelPump.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${fuelPump.torqueBoost}</p>
            <img class="part-image" src="${fuelPump.imageURl}" alt="${fuelPump.model}" />
            <p class="part-price">Price: $${fuelPump.price}</p>
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
    let injectorKitContainer = document.getElementById('injectorKit-container');
    injectorKitContainer.innerHTML = ''; // Clear the existing content

    let titleElement = document.createElement('div');
    titleElement.classList.add('part-title');
    if (injectorKits.length === 0) {
        titleElement.innerHTML = 'No Injector Kits are available for this model!';
    } else if (injectorKits.length === 1) {
        titleElement.innerHTML = '1 Injector Kit is available for this model:';
    } else {
        titleElement.innerHTML = `${injectorKits.length} Injector Kits are available for this model:`;
    }
    injectorKitContainer.appendChild(titleElement);


    let injectorKitWrapper = document.createElement('div');
    injectorKitWrapper.classList.add('part-wrapper');

    injectorKits.forEach(function (injectorKit) {
        let injectorKitView = document.createElement('div');
        injectorKitView.classList.add('part-view');
        injectorKitView.classList.add('selectable');
        injectorKitView.setAttribute('id', `injectorKit-${injectorKit.id}`);
        if (selectedParts['injectorKit'] === injectorKit.id) {
            injectorKitView.classList.add('selected');
        }
        injectorKitView.innerHTML = `
            <h4 class="part-model">${injectorKit.model}</h4>
            <h4 class="part-manufacturer">${injectorKit.manufacturer}</h4>
            <p class="part-horsepower">Horsepower Boost: ${injectorKit.horsePowerBoost}</p>
            <p class="part-torque">Torque Boost: ${injectorKit.torqueBoost}</p>
            <img class="part-image" src="${injectorKit.imageURL}" alt="${injectorKit.model}" />
            <p class="part-price">Price: $${injectorKit.price}</p>
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
    let oilCoolerContainer = document.getElementById('oilCooler-container');
    oilCoolerContainer.innerHTML = ''; // Clear the existing content

    let titleElement = document.createElement('div');
    titleElement.classList.add('part-title');
    if (oilCoolers.length === 0) {
        titleElement.innerHTML = 'No Oil Coolers are available for this model!';
    } else if (oilCoolers.length === 1) {
        titleElement.innerHTML = '1 Oil Cooler is available for this model:';
    } else {
        titleElement.innerHTML = `${oilCoolers.length} Oil Coolers are available for this model:`;
    }
    oilCoolerContainer.appendChild(titleElement);


    let oilCoolerWrapper = document.createElement('div');
    oilCoolerWrapper.classList.add('part-wrapper');

    oilCoolers.forEach(function (oilCooler) {
        let oilCoolerView = document.createElement('div');
        oilCoolerView.classList.add('part-view');
        oilCoolerView.classList.add('selectable');
        oilCoolerView.setAttribute('id', `oilCooler-${oilCooler.id}`);
        if (selectedParts['oilCooler'] === oilCooler.id) {
            oilCoolerView.classList.add('selected');
        }
        oilCoolerView.innerHTML = `
            <h4 class="part-model">${oilCooler.model}</h4>
            <h4 class="part-manufacturer">${oilCooler.manufacturer}</h4>
            <img class="part-image" src="${oilCooler.imageURL}" alt="${oilCooler.model}" />
            <p class="part-price">Price: $${oilCooler.price}</p>
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
    let sparkPlugContainer = document.getElementById('sparkPlug-container');
    sparkPlugContainer.innerHTML = ''; // Clear the existing content

    let titleElement = document.createElement('div');
    titleElement.classList.add('part-title');
    if (sparkPlugs.length === 0) {
        titleElement.innerHTML = 'No Spark Plugs Kits are available for this model!';
    } else if (sparkPlugs.length === 1) {
        titleElement.innerHTML = '1 Spark Plug Kit is available for this model:';
    } else {
        titleElement.innerHTML = `${sparkPlugs.length} Spark Plug Kits are available for this model:`;
    }
    sparkPlugContainer.appendChild(titleElement);


    let sparkPlugWrapper = document.createElement('div');
    sparkPlugWrapper.classList.add('part-wrapper');

    sparkPlugs.forEach(function (sparkplug) {
        let sparkPlugView = document.createElement('div');
        sparkPlugView.classList.add('part-view');
        sparkPlugView.classList.add('selectable');
        sparkPlugView.setAttribute('id', `sparkPlug-${sparkplug.id}`);
        if (selectedParts['sparkPlug'] === sparkplug.id) {
            sparkPlugView.classList.add('selected');
        }
        sparkPlugView.setAttribute('id', `sparkPlug-${sparkplug.id}`); // Set a unique ID for each spark plug

        sparkPlugView.innerHTML = `
            <h4 class="part-manufacturer">${sparkplug.manufacturer}</h4>
            <img class="part-image" src="${sparkplug.imageURl}" alt="${sparkplug.manufacturer} Spark Plug" />
            <p class="part-price">Price: $${sparkplug.price}</p>
        `;

        sparkPlugView.addEventListener('click', function () {
            selectPart('sparkPlug', sparkplug.id);
        });

        sparkPlugWrapper.appendChild(sparkPlugView);
    });

    sparkPlugContainer.appendChild(sparkPlugWrapper);
}


function selectPart(partType, partId) {
    let selectedPartView = document.getElementById(`${partType}-${partId}`);
    let isSelected = selectedPartView.classList.contains('selected');

    // Get the ID of the previously selected part of the same type
    let previousPartId = selectedParts[partType];

    // Deselect the previously selected part of the same type, if any
    if (previousPartId !== null) {
        let previousPartView = document.getElementById(`${partType}-${previousPartId}`);
        if (previousPartId !== partId) {
            previousPartView.classList.remove('selected');
            selectedParts[partType] = null;
        }
    }

    // Toggle the selection state of the part view
    selectedPartView.classList.toggle('selected', !isSelected);
    let editConfigurationButton = document.getElementById('edit-configuration-button');
    // Update the selected parts object
    selectedParts[partType] = isSelected ? null : partId;
    if (hasChangesMade(configuration)) {
        editConfigurationButton.style.display = 'block';
    }
    else {
        editConfigurationButton.style.display = 'none';
    }

}
function editConfiguration() {
    // Perform the AJAX POST request
    $.ajax({
        url: '/Configuration/Edit',
        type: 'POST',
        data: {
            selectedParts: selectedParts,
            configurationId: configurationId
        },
        success: function (response) {
            window.location.href = response.redirectUrl;
            // Handle the successful response from the server, if needed
        },
        error: function (error) {
            // Handle any errors that occurred during the request
            console.error('Error editing configuration:', error);
        }
    });
}