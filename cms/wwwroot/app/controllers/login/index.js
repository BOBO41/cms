var loginController = function() {
    this.Initialize = function () {
        RegisterEvents();
    }

    var RegisterEvents = function () {
        $("#btnLogin").on('click', function (e) {
            e.preventDefault();
            var user = $("#txtEmail").val();
            var password = $("#txtPassword").val();
            Login(user, password);
        });
    }

    var Login = function (user, pass) {
        $.ajax({
            type: 'POST',
            data: {
                UserName: user,
                Password: pass
            },
            dateType: 'json',
            url: '/admin/login/authen',
            success: function (res) {
                if (res.Success) {
                    window.location.href = Defines.HomeAdmin;
                }
                else {
                    common.notify('Login is incorrect', 'error');
                }
            }
        })
    }
}