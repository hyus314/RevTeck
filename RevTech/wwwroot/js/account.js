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


function submitAdminForm() {
    var inputPassword = $("#admin-password").val();

    $.ajax({
        url: '/Admin/Register',
        type: 'POST',
        data: { inputPassword: inputPassword },
        dataType: 'json',
        success: function (data) {
            if (data.success) {
                alert('Registration successful! Please wait you will be redirected to the main page.');
                
                setTimeout(function () {
                    window.location.href = '/Home/Index'; 
                }, 2500);
            } else {
                alert('Registration failed: ' + data.error);
            }
        },
        error: function (xhr, status, error) {
            console.error('Error:', error);
        }
    });
}