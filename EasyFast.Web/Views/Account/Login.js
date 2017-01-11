var Login = function () {

    var handleLogin = function () {

        $('.login-form').validate({
            errorElement: 'span', //default input error message container
            errorClass: 'help-block', // default input error message class
            focusInvalid: false, // do not focus the last invalid input
            rules: {
                TenancyName: {
                    required: false
                },
                UserName: {
                    required: true
                },
                Password: {
                    required: true
                },
                RememberMe: {
                    required: false
                }
            },

            messages: {
                username: {
                    required: "用户名必填！"
                },
                password: {
                    required: "密码必填！"
                }
            },

            invalidHandler: function (event, validator) { //display error alert on form submit   
                $('.alert-danger', $('.login-form')).show();
            },

            highlight: function (element) { // hightlight error inputs
                $(element)
                    .closest('.form-group').addClass('has-error'); // set error class to the control group
            },

            success: function (label) {
                label.closest('.form-group').removeClass('has-error');
                label.remove();
            },

            errorPlacement: function (error, element) {
                error.insertAfter(element.closest('.input-icon'));
            },

            submitHandler: function (form) {
                abp.ui.setBusy('#login-form',
                    abp.ajax({
                        url: '/Account/Login',
                        type: 'POST',
                        data: JSON.stringify({
                            TenancyName: $('#TenancyName').val(),
                            UserName: $('#UserName').val(),
                            Password: $('#Password').val(),
                            RememberMe: $('#RememberMe').is(':checked'),
                            returnUrlHash: $('#ReturnUrlHash').val()
                        })
                    }).done(function (data) {
                        
                    }).fail(function (data) {
                        //此处应换成原生模板错误提示方式
                        abp.message.error(data.details, '提示：登录失败！');
                    })
                );
            }
        });

        $('.login-form input').keypress(function (e) {
            if (e.which == 13) {
                if ($('.login-form').validate().form()) {
                    $('.login-form').submit(); //form validation success, call ajax form submit
                }
                return false;
            }
        });

        $('.forget-form input').keypress(function (e) {
            if (e.which == 13) {
                if ($('.forget-form').validate().form()) {
                    $('.forget-form').submit();
                }
                return false;
            }
        });

        $('#forget-password').click(function () {
            $('.login-form').hide();
            $('.forget-form').show();
        });

        $('#back-btn').click(function () {
            $('.login-form').show();
            $('.forget-form').hide();
        });
    }




    return {
        //main function to initiate the module
        init: function () {

            handleLogin();

            // init background slide images
            $('.login-bg').backstretch([
                "/Content/images/login/login_bg1.jpg",
                "/Content/images/login/login_bg2.jpg",
				"/Content/images/login/login_bg3.jpg",
				"/Content/images/login/login_bg4.jpg",
				"/Content/images/login/login_bg5.jpg",
				"/Content/images/login/login_bg6.jpg",
				"/Content/images/login/login_bg7.jpg",
				"/Content/images/login/login_bg8.jpg",
				"/Content/images/login/login_bg9.jpg",
                "/Content/images/login/login_bg10.jpg"
            ], {
                fade: 1000,
                duration: 8000
            }
            );

            $('.forget-form').hide();

        }

    };

}();

jQuery(document).ready(function () {
    Login.init();
});