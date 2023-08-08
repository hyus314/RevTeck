document.addEventListener('DOMContentLoaded', function () {
    const yearStartDropdown = document.getElementById('yearStartDropdown');
    const yearEndDropdown = document.getElementById('yearEndDropdown');

    for (let year = 1995; year <= 2023; year++) {
        yearStartDropdown.options.add(new Option(year, year));
        yearEndDropdown.options.add(new Option(year, year));
    }

    // Select the year from the ViewModel for Start and End
    yearStartDropdown.value = document.getElementById('yearCreated_Start').value;
    yearEndDropdown.value = document.getElementById('yearCreated_End').value;

    yearStartDropdown.addEventListener('change', function () {
        document.getElementById('yearCreated_Start').value = this.value;
    });

    yearEndDropdown.addEventListener('change', function () {
        document.getElementById('yearCreated_End').value = this.value;
    });

    // Manufacturer selection code
    document.querySelectorAll('.manufacturer-item').forEach(item => {
        item.addEventListener('click', event => {
            document.querySelectorAll('.manufacturer-item').forEach(otherItem => {
                otherItem.classList.remove('selected-manufacturer');
            });

            item.classList.add('selected-manufacturer');

            const manufacturerId = item.getAttribute('data-id');
            document.getElementById('manufacturerId').value = manufacturerId;
        });
    });

    // Highlight the manufacturer from ViewModel
    const currentManufacturerId = document.getElementById('manufacturerId').value;
    const currentManufacturerDiv = document.querySelector(`.manufacturer-item[data-id="${currentManufacturerId}"]`);
    if (currentManufacturerDiv) {
        currentManufacturerDiv.classList.add('selected-manufacturer');
    }
});
