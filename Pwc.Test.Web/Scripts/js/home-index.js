var IndexHomeModule = (function () {


    var Init = function () {

        $('#mainform').validate({
            rules: {
                "fio": {
                    required: true
                },
                "captcha_response": {
                    required: true
                },
            },
            messages: {

                "fio": {
                    required: "This field is required"
                },

                "captcha_response": {
                    required: "This field is required"
                },

            },
            errorClass: "my-error-class",
            submitHandler: function (form) {
                AjaxPostCall();
                ReloadModel();
                return false; 
            }
        });


        $(document).ajaxStart(function () {
            $("#loading").show();
            $("#sendbtn").prop('disabled', true);
            $("#responcetext").html("");
            $("#emptyResult").hide();
        }).ajaxStop(function () {
            $("#loading").hide();
            $("#sendbtn").prop('disabled', false);
        });
    };

    var ReloadModel = function () {
        $.ajax({
            url: "/home/ReloadModel",
            success: function (response) {
                $("#captcha_token").val(response.captcha_token);
                $("#captcha_sid").val(response.captcha_sid);
                $("#form_build_id").val(response.form_build_id);
                $("#exception_text").text(response.exception_text);
                $("#captchaimg").attr("src", response.captcha_url);
            }
        });
    }

    var AjaxPostCall = function () {
        $.ajax({
            url: "/home/postdata",
            type: "POST",
            data: $('#mainform').serialize(),
            success: function (result) {
                if (result == "")
                {
                    $("#emptyResult").show();
                }
                else
                {
                    $("#responcetext").html(result);
                    
                }
                
            }
        });
    };

    return {
        Init: Init
    };

})();

$(document).ready(function () {
    IndexHomeModule.Init();
});