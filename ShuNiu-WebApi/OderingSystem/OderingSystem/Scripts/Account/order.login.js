var JSDEMO = function () {
    var _v = {
        account: {
            Id: "",
            RoleId: "",
            Name: "",
            ChineseName: "",
            PassWord: "",
        }

    }
	var _e = {
		register: function () {
			window.location.href = "/Page/Register.html";
		},
		login: function () {
		    _v.user.Name = $("#login-username").val();
		    _v.user.PassWord = $("#Password").val();
		    _v.user.UserType = 1;
		    if ($("#login-username").val() == "") {
		        alert("用户名不能为空!");
		        return false;
		    }
		    if ($("#Password").val() == "") {
		        alert("密码不能为空!");
		        return false;
		    }
		    $.ajax({
		        type: "post",
		        url: "/odata/LoginAccount/AccountService.Login/",
		        //url: "odata/People",
		        async: false,
		        contentType: 'application/json',
		        data: JSON.stringify({ "account": _v.account }),
		        success: function (result) {
		            if (result) {
		                switch (results) {
		                    case 0:
		                        break;
		                    case 1:
		                        alert("用户名或密码错误");
		                        break;
		                    case 2:
		                        window.location.href = "";
		                        break;
		                    case 3:
		                        window.location.href = "";
		                        break;
		                    case 4:
		                        window.location.href = "";
		                        break;
		                    default:
		                        break;
		                }
		            }
		        },
		        error: function (XMLHttpRequest, textStatus, errorThrown) {//请求失败处理函数
		            console.log("请求失败，无法获取分组数据");
		        }
		    });
		},

	}
	var _f = {
		initClick: function () {
			$("#register").click(function () {
				_e.register();
			});
			$("#login-button").click(function () {
			    _e.login();
			});
		},
		initEvent: function () {
		    $("#login-username").keypress(function (e) {
		        if (e.keyCode == 13) {
		            if ($("#login-username").val() == "") {
		                alert("用户名不能为空!");
		                return false;
		            }
		            $("#login-button").trigger('click');
		        }
		    });
		    $("#Password").keypress(function (e) {
		        if (e.keyCode == 13) {
		            if ($("#Password").val() == "") {
		                alert("密码不能为空!");
		                return false;
		            }
		            $("#login-button").trigger('click');
		        }
		    });
		},
	}
	return {
		Init: function () {
		    _f.initClick();
		    _.initEvent();
		}
	};
}();

//Dom加载完后立即执行   初始化
$(function () {
	JSDEMO.Init();
});