let modal = document.getElementById("modal");
let btn = document.getElementById('admin-reg-button');
let span = document.getElementById("close");
let registerButton = document.getElementById("register-button");

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
    let inputPassword = $("#admin-password").val();

    $.ajax({
        url: '/Admin/Register',
        type: 'POST',
        data: { inputPassword: inputPassword },
        dataType: 'json',
        success: function (data) {
            if (data.success) {
                alert('Registration successful! IMPORTANT!! Log out of your account and login again so you can succesfully access your new Administrator Actions!');
                
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