// 封装的 SDK 功能模块  
var GameSDK = (function() {  
    function config() {  
        // 初始化 SDK 配置  
        S4Sdk.config({  
            onLogin: function(userId, encrypt) {
                // console.log("11111=====>>>>>",userId+'==='+encrypt)
                // cp需要传的参数
                var resconfig = {
                    gameCode: "FZHF",  
                    packageName: "com.mengyu.girl",  
                    language: "TW",  
                    os: "H5",
                    siteCode: 'FZHFANDROID',
                }
                GameSDK.handleLogin(userId, encrypt, resconfig);  
            },  
            onLogout: function() {  
                console.log("User logged out");  
            }  
        });
    }  
    config();
    // 获取 URL 参数方法  
    function getAllURLParams(url) {  
        var queryParams = {};  
        var urlParams = url.split('?')[1];  
        if (urlParams) {  
            var params = urlParams.split('&');  
            for (var i = 0; i < params.length; i++) {  
                var param = params[i].split('=');  
                queryParams[param[0]] = decodeURIComponent(param[1] || '');  
            }  
        }  
        return queryParams;  
    }  

    // 登录处理  
    function handleLogin(userId, encrypt, config) {    
        $.ajax({  
            url: "https://mengyugame.erosir.com/espgaq/port/hgLogin.do",  
            data: {  
                userId: userId,  
                ck: encrypt,  
                gameCode: config.gameCode,  
                packageName: config.packageName,  
                language: config.language,  
                os: config.os,  
            },  
            type: "POST",  
            dataType: "jsonp",  
            success: function(resdata) {  
                console.log("Login Response===>", resdata);
                // 请求成功后的数据例子
                // {
                //     "msg": "登錄成功",
                //     "code": "1400",
                //     "passport": "2000172363604641217",
                //     "sessionID": "XNfuJEcSOvGGU%2BjSWk4l9KJy7k0Z%2Fo3BnS8IkL5P1084QtfLN0AGHCvdmEIqed4Xzh1fZSbIN%2B9eeul5ubOQJe%2BC1O9MPf68DNdHakxU2S8KyqjWji5lUwAIoFeiQPifdpEXPLXqjai%2F",
                //     "type": "login"
                // }
                $.ajax({  
                    url: "https://mengyugame.erosir.com/espgar/login/userMobileAuth.do",  
                    data: {  
                        sitecode: config.siteCode,
                        type: resdata.type,
                        os: config.os,
                        SessionID_LP: resdata.sessionID,
                        language: config.language,
                        gameCode: config.gameCode,
                        packageName: config.packageName,
                        onid: '',
                        tag: '',
                        attrnetwork: '',
                        link_id: '',
                        uuid: '',
                    },  
                    type: "POST",  
                    dataType: "jsonp",  
                    success: function(res) {  
                        console.log("Login Response===>", res);
                        // 请求成功后的数据例子
                        // {
                        //     "msg": "登錄成功",
                        //     "toCacheInfo": {
                        //         "sitecode": "FZHFANDROID",
                        //         "passport": "2000172363604641217",
                        //         "t": "1723708556217",
                        //         "ck": "89a0f04f85990d2c18bd4ca3a74cf1d5",
                        //         "username": "172363604641217"
                        //     },
                        //     "code": "1406",
                        //     "toGameInfo": {
                        //         "sitecode": "FZHFANDROID",
                        //         "passport": "2000172363604641217",
                        //         "t": "1723708556214",
                        //         "ck": "2088102a7f7e038e700258e9e2177daa",
                        //         "siteUserName": "10334",
                        //         "model": "1",
                        //         "version": "0"
                        //     }
                        // }
                         window['onLoginSuccess'](res);
                    },  
                    error: function(error) {  
                        console.log("Login Error===>", error);  
                    }  
                });
            },  
            error: function(error) {  
                console.log("Login Error===>", error);  
            }  
        });  
    }  

    // 登录方法  
    function login() {
        console.log("login");  
        S4Sdk.login();  
    }  

    // 支付方法  
    function pay(config) {  
        var allParams = getAllURLParams(window.location.href);  
        $.ajax({  
            url: "https://mengyugame.erosir.com/sspgae/iapHg/initpay.do",  
            data: {  
                passport: config.passport,  
                siteCode: config.siteCode,  
                itemCode: config.itemCode,  
                gameCode: allParams.gameCode || config.defaultGameCode || "FZHF",  
                packageName: allParams.packageName || config.defaultPackageName || "com.mengyu.girl",  
                language: allParams.language || config.defaultLanguage || "TW",  
                os: allParams.os || config.defaultOS || "H5",  
                serverCode: config.serverCode || 'fzhf4',  
                roleid: config.roleId || "10",  
                tokenParams: config.tokenParams || '100004_8000152687265040008_101',  
                onid: ''  
            },  
            type: "POST",  
            dataType: "jsonp",  
            success: function(resdata) {  
                console.log("Payment Response===>", resdata);  
                let goods = {  
                    "game_goods_id": resdata.game_goods_id,  
                    "game_goods_name": resdata.game_goods_name,  
                    "game_goods_amount": resdata.game_goods_amount,  
                    "game_goods_ccy": resdata.game_goods_ccy,  
                    "game_preload": resdata.game_preload,  
                    "game_order_id": resdata.game_order_id,  
                };  
                S4Sdk.purchase(goods);  
            },  
            error: function(error) {  
                console.log("Payment Error===>", error);  
            }  
        });  
    }  

    return { 
        handleLogin: handleLogin,
        login: login,  
        pay: pay  
    };  
})();  

// 在页面加载时初始化 SDK  
window.onload = function() {  
    // 初始化 SDK 配置  
    S4Sdk.config({  
        onLogin: function(userId, encrypt) {
            // console.log("11111=====>>>>>",userId+'==='+encrypt)
            // cp需要传的参数
            var resconfig = {
                gameCode: "FZHF",  
                packageName: "com.mengyu.girl",  
                language: "TW",  
                os: "H5",
                siteCode: 'FZHFANDROID',
            }
            GameSDK.handleLogin(userId, encrypt, resconfig);  
        },  
        onLogout: function() {  
            console.log("User logged out");  
        }  
    });  
};  
