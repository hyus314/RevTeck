document.addEventListener('DOMContentLoaded', function () {
    const yearStartDropdown = document.getElementById('yearStartDropdown');
    const yearEndDropdown = document.getElementById('yearEndDropdown');

    // Populate the dropdowns with years
    for (let year = 2000; year <= 2023; year++) {
        yearStartDropdown.options.add(new Option(year, year));
        yearEndDropdown.options.add(new Option(year, year));
    }

    // Add event listeners to update hidden input fields with selected values
    yearStartDropdown.addEventListener('change', function () {
        document.getElementById('yearCreated_Start').value = this.value;
    });

    yearEndDropdown.addEventListener('change', function () {
        document.getElementById('yearCreated_End').value = this.value;
    });
});