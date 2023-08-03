var modal = document.getElementById("modal");
var btn = document.getElementById('admin-reg-button');
var span = document.getElementById("close");
var registerButton = document.getElementById("register-button");

btn.onclick = function () {
    modal.style.display = "block";
}

span.onclick = function () {
    modal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

registerButton.onclick = function () {
    const password = document.getElementById("admin-password").value;
    // Here you can add code to handle the registration logic
    alert("Admin registration attempted with password: " + password);
    modal.style.display = "none";
}