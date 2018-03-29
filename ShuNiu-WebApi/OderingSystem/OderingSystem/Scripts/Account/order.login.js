var JSDEMO = function () {
	var _e = {
		register: function () {
			window.location.href = "/Page/Register.html";
		}
	}
	var _f = {
		initClick: function () {
			$("#register").click(function () {
				_e.register();
			});
		}
	}
	return {
		Init: function () {
			_f.initClick();
		}
	};
}();

//Dom加载完后立即执行   初始化
$(function () {
	JSDEMO.Init();
});