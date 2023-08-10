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
