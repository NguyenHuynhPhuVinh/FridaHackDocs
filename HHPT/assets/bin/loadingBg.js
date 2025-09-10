//自动创建一个加载背景.当laya启动之后,自动释放.
var bgImgSrc = "loading_";
var bgGifSrc = "loading.gif";
var gifWidth = 90;
var waitOverFiled = "window.canceWebLoadingBg";//等待某个属性或者条件为真时,关闭加载界面.
var gifDiv = document.createElement("div");
var bgImg = new Image();
var canvas1 = document.createElement("canvas");
function loadingBginit(resourceUrl) {
	
	var n=Math.floor(Math.random() * 10) + 1;
	bgImgSrc = resourceUrl + bgImgSrc+n+".jpg";

	bgGifSrc = resourceUrl + bgGifSrc;
	bgImg.src = bgImgSrc;
	document.body.onload = validateIE;
	update();

	validate();
}

window.onLoadingBgOverHander;//加载背景图片显示时，执行的函数






try {
	canvas1.style = "position: absolute; z-index:1000000;left:0px;top:0px";
} catch (e) { };
document.body.appendChild(canvas1);
var ctx = canvas1.getContext("2d");
var screenW;
var screenH;
document.body.appendChild(gifDiv);
window.addEventListener("resize", update)
function update() {
	/* screenW = document.documentElement.clientWidth;
	screenH = document.documentElement.clientHeight;
	gifDiv.style="width:"+screenW+"px;height:"+screenH+"px;background: url("+bgGifSrc+") no-repeat center center;position:absolute;z-index:1000001;background-size: "+screenW/(720/gifWidth)+"px "+screenW/(720/gifWidth)+"px;"
	canvas1.width = screenW;
	canvas1.height = screenH;
	var w = screenW;
	var h = screenH;
	if (w < h) {
		// ctx.translate(w / 2, h / 2);
		ctx.translate(w / 2 + bgImg.height / 2, - bgImg.height);
		ctx.rotate(90 * Math.PI / 180);
		ctx.drawImage(bgImg, screenH / 2 - bgImg.height / 2, screenW / 2 - bgImg.width / 2, bgImg.width, bgImg.height);

	} else {
		ctx.drawImage(bgImg, screenW / 2 - bgImg.width / 2, screenH / 2 - bgImg.height / 2, bgImg.width, bgImg.height);

	} */
	
	screenW = document.documentElement.clientWidth;
	screenH = document.documentElement.clientHeight;
	gifDiv.style="width:"+screenW+"px;height:"+screenH+"px;background: url("+bgGifSrc+") no-repeat center center;position:absolute;z-index:1000001;background-size: "+screenW/(720/gifWidth)+"px "+screenW/(720/gifWidth)+"px;"
	canvas1.width=screenW;
	canvas1.height=screenH;
	var w=screenW;
	var h=screenH;
	if(w<h)
	{
		ctx.translate(w,0);
		ctx.rotate(90*Math.PI/180);
		ctx.drawImage(bgImg,0,0,h,w);
		 
	}else{
		ctx.drawImage(bgImg,0,0,w,h);
		 
	}
}

function validateIE() {

	var ag = navigator.userAgent.toLowerCase();
	var dw = /msie 10.0|msie 9.0|msie 8.0|msie 7.0|msie 6.0/i.test(ag) || !/chrome/i.test(ag) && (/se 2.x/i.test(ag) || /qqbrowser/i.test(ag));//搜狗/QQ兼容模式
	return;
	if (ag.indexOf("mobile") > -1) return;
	if (!dw && canvas1.getContext && ag.indexOf("mozilla/5.0") >= 0 && ag.indexOf("trident/") >= 0) {
		alert("浏览器设置不支持游戏,请将360浏览器切换到极速模式或者使用其他浏览器");
	}
	if (dw || !webglEnabled() || !canvas1.getContext) {

		/*var html = "<div class='h5-ietip-box'><div class='h5-ietip-head'>";
		html += "<i class='h5-ietip-cancel' onclick='removetip()'></i></div>";
		html += "<div class='h5-ietip-body'><p class='h5-ietip-warn'>抱歉，您正在使用的浏览器版本过低，<br>无法进入游戏...</p>";
		html += "<p class='h5-ietip-text'>您可以：<br>1. 将浏览器切回高速模式或极速模式。<br>2. 使用其它浏览器进入游戏</p>";
		html += "</div></div>"*/;
		var html = "<div style='font-size:30px;color:#ff0000;'><br> 抱歉，您正在使用的浏览器版本过低，<br>无法进入游戏...<br>您可以：<br>1. 将浏览器切回高速模式或极速模式。<br> <img src='changeIE.jpg'/><br>2. 使用其它浏览器进入游戏。</div>"
		var div = document.createElement("DIV");
		//div.id="h5-ietip";
		//div.className = "h5-ietip";
		div.innerHTML = html;
		document.body.appendChild(div);
		//alert(html); 
		return true;
	} else {

		return false;

	}
}

function webglEnabled() {
	var cav = document.createElement("canvas");
	var names = ["webgl", "experimental-webgl", "webkit-3d", "moz-webgl"], gl;
	for (var i = 0; i < names.length; i++) {
		try {
			gl = cav.getContext(names[i]);
		} catch (e) { }

		if (gl) return true;
	}

	return false;
}


var lastWait = 0;

bgImg.onload = function () {
	/* update();
	if (window.onLoadingBgOverHander) {
		setTimeout(function () {
			window.onLoadingBgOverHander();
		}, 3000);
	} else {
		lastWait = new Date().getTime();
		waitLoading();
	} */
	
	update();
	if(window.onLoadingBgOverHander)
	{
		window.onLoadingBgOverHander();
	}else
	{
		lastWait=new Date().getTime();
		waitLoading();
	}
}
function waitLoading() {
	/* if (new Date().getTime() - lastWait > 30000) {
		return;
	}
	setTimeout(function () {
		if (window.onLoadingBgOverHander) {
			window.onLoadingBgOverHander();
		} else {
			waitLoading();
		}
	}, 3000); */
	
	if(new Date().getTime()-lastWait>30000)
	{
		return;
	}
	setTimeout(function()
	{
		if(window.onLoadingBgOverHander)
		{
			window.onLoadingBgOverHander();
		}else
		{
			waitLoading();
		}
	},300);
}


function validate() {
	if (isGameInitOk()) {

		gifDiv.parentNode.removeChild(gifDiv);
		canvas1.parentNode.removeChild(canvas1);
		bgImg = null;
		window.removeEventListener("resize", update)


		//var di=document.createElement("div");
		//di.id="myTestDiv"
		//di.height=screenH;
		//di.width=screenW;
		//document.body.appendChild(di);
	} else {
		window.requestAnimationFrame(validate);
	}

}
function isGameInitOk() {
	var o = window;
	var arr = waitOverFiled.split(".");
	var s = "";
	for (var i = 0; i < arr.length; i++) {
		o = o[arr[i]];
		s += arr[i] + ".";
		if (!o) {
			return false;
		}
	}
	return true;
}
