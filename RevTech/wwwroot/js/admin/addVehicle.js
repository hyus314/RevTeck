document.addEventListener('DOMContentLoaded', function () {
    const yearStartDropdown = document.getElementById('yearStartDropdown');
    const yearEndDropdown = document.getElementById('yearEndDropdown');

    for (let year = 1995; year <= 2023; year++) {
        yearStartDropdown.options.add(new Option(year, year));
        yearEndDropdown.options.add(new Option(year, year));
    }

    yearStartDropdown.addEventListener('change', function () {
        document.getElementById('yearCreated_Start').value = this.value;
    });

    yearEndDropdown.addEventListener('change', function () {
        document.getElementById('yearCreated_End').value = this.value;
    });
});

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

