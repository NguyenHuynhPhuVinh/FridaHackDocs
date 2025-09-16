class <Module>
{
}

class AuthSdkInfo
{
    static string Version = "6.2.2";
    static string Production = "AuthSDK-6.2.2-prod.aar";
    static string Staging = "AuthSDK-6.2.2-stg.aar";

    /*0x3f86dbc*/ AuthSdkInfo();
}

class DmmGamesIapStoreSubscriptionExtendErrorCode
{
    static string PurchaseCreditError = "E-041-422-010";
    static string PurchaseCreditAltError = "E-041-422-011";
    static string AlreadyPurchasedError = "E-042-422-004";
    static string AlreadyPurchasedAltError = "E-041-422-013";
    static string AlreadyCanceledError = "E-042-422-005";
    static string AlreadyCanceledAltError = "E-041-422-014";

    /*0x3f86dc4*/ DmmGamesIapStoreSubscriptionExtendErrorCode();
}

class ScreenUtility : UnityEngine.MonoBehaviour
{
    static /*0x3f86dcc*/ UnityEngine.DeviceOrientation GetOrientation();
    /*0x3f86df8*/ ScreenUtility();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3f86e00*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3f86ef4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace DMM
{
    namespace Games
    {
        namespace Recibo
        {
            namespace Ui
            {
                class Complete : UnityEngine.MonoBehaviour
                {
                    static string Path = "DMM/Complete";
                    static /*0x0*/ UnityEngine.GameObject _dialog;
                    static /*0x8*/ System.Action _finish;
                    static /*0x10*/ DMM.Games.Recibo.Ui.Complete _instance;
                    /*0x20*/ UnityEngine.UI.Button _returnButton;
                    /*0x28*/ UnityEngine.UI.Button _cancelButton;
                    /*0x30*/ float _amount;
                    /*0x38*/ DMM.Games.Util.DialogCanvasController _canvasController;
                    /*0x40*/ UnityEngine.UI.Image _logo;
                    /*0x48*/ UnityEngine.UI.Text _paymentContinueText;

                    static /*0x3f86efc*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                    static /*0x3f87398*/ void Begin(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, System.Action finish);
                    static /*0x3f87430*/ void Finish();
                    /*0x3f87638*/ Complete();
                    /*0x3f87304*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f87580*/ void LogoDestroy();

                    class <>c
                    {
                        static /*0x0*/ DMM.Games.Recibo.Ui.Complete.<> <>9;
                        static /*0x8*/ UnityEngine.Events.UnityAction <>9__10_0;
                        static /*0x10*/ UnityEngine.Events.UnityAction <>9__10_1;

                        static /*0x3f87640*/ <>c();
                        /*0x3f876a8*/ <>c();
                        /*0x3f876b0*/ void <Init>b__10_0();
                        /*0x3f8770c*/ void <Init>b__10_1();
                    }
                }

                class CouponListSingleton : DMM.Games.Recibo.Ui.SingletonComponent<DMM.Games.Recibo.Ui.CouponListSingleton>
                {
                    /*0x20*/ string _couponId;
                    /*0x28*/ bool _isSelectCoupon;
                    /*0x2c*/ int _toggleSelectIndex;
                    /*0x30*/ System.Collections.Generic.Dictionary<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> _couponList;

                    /*0x3f88084*/ CouponListSingleton();
                    /*0x3f87768*/ System.Collections.Generic.Dictionary<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> get_GetCouponList();
                    /*0x3f87770*/ void SetCouponListData(DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] coupons);
                    /*0x3f87774*/ void CreateCouponListData(DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] coupons);
                    /*0x3f879d4*/ void UpdateCouponListData(string couponId, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData data);
                    /*0x3f87aa0*/ DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData FindCouponListData(string couponId);
                    /*0x3f87c58*/ DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData FindCouponListData(int index);
                    /*0x3f87dc4*/ int GetSelectCouponIndex();
                    /*0x3f87f20*/ void SetBannerCache(string couponId, UnityEngine.Sprite bannerCache);
                    /*0x3f87f84*/ void SetCouponValue(string couponId, int billingAmount, int couponDiscountAmount);
                    /*0x3f87fe0*/ void UpdateDropDownSortValue(string couponId, int index, bool isSelectCoupon);
                    /*0x3f88050*/ string GetSelectCouponId();
                    /*0x3f88058*/ void SetSelectCouponId(string couponId);
                    /*0x3f88060*/ bool GetIsSelectCoupon();
                    /*0x3f88068*/ void SetIsSelectCoupon(bool isSelectCoupon);
                    /*0x3f88074*/ int GetSelectToggleIndex();
                    /*0x3f8807c*/ void SetSelectToggleIndex(int toggleSelectIndex);

                    class CouponListData
                    {
                        /*0x10*/ string <CouponId>k__BackingField;
                        /*0x18*/ string <CouponName>k__BackingField;
                        /*0x20*/ int <BillingAmount>k__BackingField;
                        /*0x24*/ int <CouponDiscountAmount>k__BackingField;
                        /*0x28*/ int <OrderPrice>k__BackingField;
                        /*0x2c*/ int <Index>k__BackingField;
                        /*0x30*/ int <DiscountedAmount>k__BackingField;
                        /*0x38*/ long <AcquiredAtValue>k__BackingField;
                        /*0x40*/ long <UseEndAtValue>k__BackingField;
                        /*0x48*/ UnityEngine.Sprite <BannerCache>k__BackingField;
                        /*0x50*/ bool <IsSelectCoupon>k__BackingField;
                        /*0x58*/ DMM.Games.Recibo.Api.Coupon.Model.CouponModel <CouponModel>k__BackingField;

                        /*0x3f88218*/ CouponListData();
                        /*0x3f87904*/ CouponListData(string couponId, string couponName, int billingAmount, int couponDiscountAmount, int orderPrice, int index, int discountedAmount, long acquiredAtValue, long useEndAtValue, UnityEngine.Sprite bannerCache, bool isSelectCoupon, DMM.Games.Recibo.Api.Coupon.Model.CouponModel couponModel);
                        /*0x3f88154*/ string get_CouponId();
                        /*0x3f8815c*/ void set_CouponId(string value);
                        /*0x3f88164*/ string get_CouponName();
                        /*0x3f8816c*/ void set_CouponName(string value);
                        /*0x3f88174*/ int get_BillingAmount();
                        /*0x3f8817c*/ void set_BillingAmount(int value);
                        /*0x3f88184*/ int get_CouponDiscountAmount();
                        /*0x3f8818c*/ void set_CouponDiscountAmount(int value);
                        /*0x3f88194*/ int get_OrderPrice();
                        /*0x3f8819c*/ void set_OrderPrice(int value);
                        /*0x3f881a4*/ int get_Index();
                        /*0x3f881ac*/ void set_Index(int value);
                        /*0x3f881b4*/ int get_DiscountedAmount();
                        /*0x3f881bc*/ void set_DiscountedAmount(int value);
                        /*0x3f881c4*/ long get_AcquiredAtValue();
                        /*0x3f881cc*/ void set_AcquiredAtValue(long value);
                        /*0x3f881d4*/ long get_UseEndAtValue();
                        /*0x3f881dc*/ void set_UseEndAtValue(long value);
                        /*0x3f881e4*/ UnityEngine.Sprite get_BannerCache();
                        /*0x3f881ec*/ void set_BannerCache(UnityEngine.Sprite value);
                        /*0x3f881f4*/ bool get_IsSelectCoupon();
                        /*0x3f881fc*/ void set_IsSelectCoupon(bool value);
                        /*0x3f88208*/ DMM.Games.Recibo.Api.Coupon.Model.CouponModel get_CouponModel();
                        /*0x3f88210*/ void set_CouponModel(DMM.Games.Recibo.Api.Coupon.Model.CouponModel value);
                        /*0x3f87f7c*/ void SetBannerCache(UnityEngine.Sprite bannerCache);
                        /*0x3f87fd8*/ void SetCouponValue(int billingAmount, int couponDiscountAmount);
                        /*0x3f8803c*/ void SetDropDownSortValue(int index);
                        /*0x3f88044*/ void SetIsSelectCoupon(bool isSelectCoupon);
                    }
                }

                class Loading : UnityEngine.MonoBehaviour
                {
                    static string Path = "DMM/Loading";
                    static /*0x0*/ UnityEngine.GameObject _dialog;
                    static /*0x8*/ DMM.Games.Recibo.Ui.Loading _instance;
                    /*0x20*/ UnityEngine.RectTransform _rt;
                    /*0x28*/ UnityEngine.Vector3 _rot;
                    /*0x38*/ UnityEngine.UI.Image _logo;

                    static /*0x3f88220*/ bool Init();
                    static /*0x3f88584*/ void Show();
                    static /*0x3f885e4*/ void Hide();
                    /*0x3f887ec*/ Loading();
                    /*0x3f88474*/ void Update();
                    /*0x3f883e0*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f88734*/ void LogoDestroy();
                }

                class LogoManager
                {
                    static /*0x0*/ string SubscriptionDmmGamesLogo;
                    static /*0x8*/ string SubscriptionFanzaGamesLogo;
                    static /*0x10*/ UnityEngine.Sprite _logo;

                    static /*0x3f88a14*/ LogoManager();
                    static /*0x3f88800*/ void Init(bool isAdult);
                    static /*0x3f88934*/ UnityEngine.Sprite Load(bool isAdult);
                    static /*0x3f889b4*/ UnityEngine.Sprite Get();
                    static /*0x3f888d8*/ void Release();
                    /*0x3f88a0c*/ LogoManager();
                }

                class ErrorObject
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, string> Details;
                    /*0x10*/ UnityEngine.Purchasing.PurchaseFailureReason _reason;
                    /*0x18*/ UnityEngine.Purchasing.ProductDefinition _productDefinition;
                    /*0x20*/ string _kind;
                    /*0x28*/ int _code;
                    /*0x30*/ string _subscriptionCode;
                    /*0x38*/ string _message;

                    static /*0x3f88b4c*/ ErrorObject();
                    /*0x3f88b44*/ ErrorObject();
                    /*0x3f88ab0*/ UnityEngine.Purchasing.PurchaseFailureReason get_Reason();
                    /*0x3f88ab8*/ void SetReason(int code);
                    /*0x3f88af4*/ UnityEngine.Purchasing.ProductDefinition get_Product();
                    /*0x3f88afc*/ void SetProductDefinition(UnityEngine.Purchasing.ProductDefinition product);
                    /*0x3f88b04*/ string get_Kind();
                    /*0x3f88b0c*/ int get_Code();
                    /*0x3f88b14*/ string get_SubscriptionCode();
                    /*0x3f88b1c*/ string get_Message();
                    /*0x3f88b24*/ void SetKind(string kind);
                    /*0x3f88b2c*/ void SetCode(int code);
                    /*0x3f88b34*/ void SetSubscriptionCode(string code);
                    /*0x3f88b3c*/ void SetMessage(string message);
                }

                class PurchaseProcess : DMM.Games.Recibo.Ui.SingletonComponent<DMM.Games.Recibo.Ui.PurchaseProcess>
                {
                    static string _locale = "ja-JP";
                    static int _quantity = 1;
                    /*0x20*/ DMM.Games.Recibo.Ui.PurchaseState _state;
                    /*0x28*/ DMM.Games.Recibo.Ui.ErrorObject _error;
                    /*0x30*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore _store;
                    /*0x38*/ UnityEngine.Purchasing.ProductDefinition _product;
                    /*0x40*/ string _developerPayload;
                    /*0x48*/ System.Action<System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel>> _successAction;
                    /*0x50*/ System.Action<DMM.Games.Recibo.Ui.ErrorObject> _errorAction;
                    /*0x58*/ bool _isRetry;
                    /*0x5c*/ DMM.Games.Recibo.Ui.PurchaseState _retryState;
                    /*0x60*/ System.Nullable<DMM.Games.Recibo.Api.Model.PointBalanceModel> _pointBalance;
                    /*0x70*/ System.Nullable<DMM.Games.Recibo.Api.Orders.Model.OrdersModel> _grantUserRankPointModel;
                    /*0x80*/ System.Nullable<DMM.Games.Recibo.Api.Order.Model.OrderModel> _order;
                    /*0xf8*/ DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel _availableCoupon;
                    /*0x100*/ System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> _receipt;
                    /*0x188*/ bool _isUpdatePoint;
                    /*0x189*/ bool _isCheckPointCharge;

                    /*0x3f8b3e4*/ PurchaseProcess();
                    /*0x3f88e70*/ void Execution(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Purchasing.ProductDefinition product, string developerPayload, System.Action<System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel>> successAction, System.Action<DMM.Games.Recibo.Ui.ErrorObject> errorAction);
                    /*0x3f88efc*/ void Update();
                    /*0x3f89040*/ void InitSDKState();
                    /*0x3f8912c*/ void CheckErrorState();
                    /*0x3f8915c*/ void ShowErrorDialogState();
                    /*0x3f895e4*/ void ShowRetryDialogState();
                    /*0x3f896a0*/ void CheckOrderPurchasedState();
                    /*0x3f89740*/ void CreateOrderState();
                    /*0x3f899e0*/ void GetBalanceState();
                    /*0x3f89b7c*/ void GetGrantUserRankPoints();
                    /*0x3f89e6c*/ void ShowOrderDialogState();
                    /*0x3f8a1e0*/ void GetAvailableCouponsState();
                    /*0x3f8a3b4*/ void ShowCouponListDialogState();
                    /*0x3f8a53c*/ void CancelState();
                    /*0x3f8a578*/ void PurchasingState();
                    /*0x3f8a798*/ void CompleteState();
                    /*0x3f8a820*/ void FinishState();
                    /*0x3f8b1cc*/ void SetState(DMM.Games.Recibo.Ui.PurchaseState state);
                    /*0x3f8aaf8*/ void ErrorTransition(DMM.Games.Recibo.Ui.ErrorObject error, DMM.Games.Recibo.Ui.PurchaseState retryState);
                    /*0x3f8a9d4*/ DMM.Games.Recibo.Ui.ErrorObject GetErrorObject(int code, string message);
                    /*0x3f8aec8*/ long GetAvailablePoint();
                    /*0x3f8af5c*/ long GetProductPoint();
                    /*0x3f8ad0c*/ long CheckProductPoint();
                    /*0x3f8affc*/ UnityEngine.Texture2D GetProductIcon();
                    /*0x3f8b1d4*/ void CancelOrder(System.Action action);
                    /*0x3f8ae84*/ bool IsAvailablePurchase();
                    /*0x3f8b42c*/ void <ShowRetryDialogState>b__23_0();
                    /*0x3f8b598*/ void <ShowRetryDialogState>b__23_1();
                    /*0x3f8b5a4*/ void <CreateOrderState>b__25_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Order.Model.OrderModel response);
                    /*0x3f8b668*/ void <CreateOrderState>b__25_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f8b6d8*/ void <CreateOrderState>b__25_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f8b71c*/ void <GetBalanceState>b__26_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Model.PointBalanceModel response);
                    /*0x3f8b7bc*/ void <GetBalanceState>b__26_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f8b82c*/ void <GetBalanceState>b__26_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f8b870*/ void <GetGrantUserRankPoints>b__27_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Orders.Model.OrdersModel response);
                    /*0x3f8b8f4*/ void <GetGrantUserRankPoints>b__27_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f8b904*/ void <GetGrantUserRankPoints>b__27_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f8b914*/ void <GetAvailableCouponsState>b__29_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel response);
                    /*0x3f8b94c*/ void <GetAvailableCouponsState>b__29_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f8b9bc*/ void <GetAvailableCouponsState>b__29_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f8ba00*/ void <ShowCouponListDialogState>b__30_0();
                    /*0x3f8bb5c*/ void <ShowCouponListDialogState>b__30_1();
                    /*0x3f8bb68*/ void <PurchasingState>b__32_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel response);
                    /*0x3f8bc28*/ void <PurchasingState>b__32_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f8bc98*/ void <PurchasingState>b__32_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f8bcdc*/ void <CompleteState>b__33_0();

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ DMM.Games.Recibo.Ui.PurchaseProcess <>4__this;
                        /*0x18*/ string url;

                        /*0x3f8ab38*/ <>c__DisplayClass22_0();
                        /*0x3f8bce8*/ void <ShowErrorDialogState>b__0();
                        /*0x3f8be58*/ void <ShowErrorDialogState>b__1();
                        /*0x3f8beb4*/ void <ShowErrorDialogState>b__2();
                    }

                    class <>c__DisplayClass28_0
                    {
                        /*0x10*/ DMM.Games.Recibo.Ui.PurchaseProcess <>4__this;
                        /*0x18*/ bool isAvailablePurchase;
                        /*0x20*/ System.Action <>9__3;
                        /*0x28*/ UnityEngine.Events.UnityAction <>9__4;
                        /*0x30*/ System.Action <>9__6;
                        /*0x38*/ UnityEngine.Events.UnityAction <>9__5;

                        /*0x3f8ae7c*/ <>c__DisplayClass28_0();
                        /*0x3f8c010*/ void <ShowOrderDialogState>b__0();
                        /*0x3f8c21c*/ void <ShowOrderDialogState>b__3();
                        /*0x3f8c244*/ void <ShowOrderDialogState>b__1();
                        /*0x3f8c520*/ void <ShowOrderDialogState>b__4();
                        /*0x3f8c680*/ void <ShowOrderDialogState>b__5();
                        /*0x3f8c73c*/ void <ShowOrderDialogState>b__6();
                        /*0x3f8c764*/ void <ShowOrderDialogState>b__2();
                    }

                    class <>c__DisplayClass42_0
                    {
                        /*0x10*/ System.Action action;

                        /*0x3f8b3dc*/ <>c__DisplayClass42_0();
                        /*0x3f8c784*/ void <CancelOrder>b__0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Order.Model.OrderModel response);
                        /*0x3f8c7a8*/ void <CancelOrder>b__1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f8c7cc*/ void <CancelOrder>b__2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }
                }

                enum PurchaseState
                {
                    None = 0,
                    InitSdk = 1,
                    CheckError = 2,
                    ShowErrorDialog = 3,
                    ShowRetryDialog = 4,
                    GetPurchasedReceiptList = 5,
                    CheckOderPurchased = 6,
                    CreateOder = 7,
                    GetBalance = 8,
                    CheckGrantUserRankPoints = 9,
                    CheckPointBalance = 10,
                    ShowOderDialog = 11,
                    GetAvailableCoupons = 12,
                    ShowCouponListDialog = 13,
                    ShowShortageDialog = 14,
                    ShowConfirmDialog = 15,
                    Cancel = 16,
                    UserValidateBeforePurchase = 17,
                    Purchasing = 18,
                    UserValidateAfterPurchase = 19,
                    Complete = 20,
                    Finish = 21,
                }

                class ShowChargeContinueDialog : UnityEngine.MonoBehaviour
                {
                    static string PayTypeCredit = "credit";
                    static string PayTypePoint = "dmmpoint";
                    static string Path = "DMM/ShowChargeContinueDialog";
                    static /*0x0*/ UnityEngine.GameObject _dialog;
                    static /*0x8*/ DMM.Games.Recibo.Ui.ShowChargeContinueDialog _instance;
                    /*0x20*/ UnityEngine.UI.Button _continueButton;
                    /*0x28*/ UnityEngine.UI.Button _cancelButton;
                    /*0x30*/ UnityEngine.UI.RawImage _productIcon;
                    /*0x38*/ UnityEngine.Texture2D _defaultIcon;
                    /*0x40*/ UnityEngine.UI.Text _productTitle;
                    /*0x48*/ UnityEngine.UI.Text _subTitle;
                    /*0x50*/ DMM.Games.Util.DialogCanvasController _canvasController;
                    /*0x58*/ UnityEngine.UI.Image _logo;

                    static /*0x3f8c7f0*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string productTitle, UnityEngine.Texture2D productIcon, string developerPayload, UnityEngine.Events.UnityAction onCLickContinueButton, UnityEngine.Events.UnityAction onClickCancelButton);
                    static /*0x3f8c46c*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string productTitle, UnityEngine.Texture2D productIcon, string developerPayload, UnityEngine.Events.UnityAction onClickContinueButton, UnityEngine.Events.UnityAction onClickCancelButton);
                    static /*0x3f8c544*/ void Hide();
                    /*0x3f8ce00*/ ShowChargeContinueDialog();
                    /*0x3f8cc90*/ void SetProductTitle(string title);
                    /*0x3f8cddc*/ void SetProductSubTitle(string subTitle);
                    /*0x3f8ccb4*/ void SetProductIcon(UnityEngine.Texture2D icon);
                    /*0x3f8cd48*/ void SetLogo(UnityEngine.Sprite logo);
                }

                class ShowCouponData : UnityEngine.MonoBehaviour
                {
                    static int DISPLAY_TAG_MAX = 4;
                    static int FONT_SIZE_1 = 28;
                    static int FONT_SIZE_2 = 30;
                    static string COLOR_PATTERN_1 = "#DE4A4A";
                    static string COLOR_PATTERN_2 = "#999999";
                    static string COLOR_PATTERN_3 = "#1E1E1E";
                    static string TEXT_PATTERN_1 = "<size={0}><color={1}>{2}</color></size>";
                    static string TEXT_PATTERN_2 = "<color={0}>{1}</color>";
                    static int COUPON_NAME_LENGTH_MAX = 58;
                    static int COUPON_NAME_LENGTH_SP_PORTRAIT_MAX = 60;
                    static int COUPON_NAME_LENGTH_SP_LANDSCAPE_MAX = 55;
                    static float COUPON_TAG_HEIGHT = 40;
                    /*0x20*/ UnityEngine.UI.RawImage[] _bannerImages;
                    /*0x28*/ UnityEngine.Sprite _bannerErrorImage;
                    /*0x30*/ UnityEngine.UI.Toggle _couponToggle;
                    /*0x38*/ UnityEngine.UI.Image _couponToggleBackImage;
                    /*0x40*/ UnityEngine.UI.Image _couponToggleCheckmarkImage;
                    /*0x48*/ UnityEngine.Sprite[] _couponToggleSprite;
                    /*0x50*/ UnityEngine.GameObject[] _tagAreaObjects;
                    /*0x58*/ UnityEngine.UI.GridLayoutGroup[] _tagGridLayout;
                    /*0x60*/ UnityEngine.RectTransform[] _tag1GameObjects;
                    /*0x68*/ UnityEngine.UI.Text[] _tag1Texts;
                    /*0x70*/ UnityEngine.RectTransform[] _tag2GameObjects;
                    /*0x78*/ UnityEngine.UI.Text[] _tag2Texts;
                    /*0x80*/ UnityEngine.GameObject _unAvailablePanel;
                    /*0x88*/ UnityEngine.UI.Text _discountAmount;
                    /*0x90*/ UnityEngine.UI.Text _couponName;
                    /*0x98*/ UnityEngine.UI.Text _numberOfTimesOfUse;
                    /*0xa0*/ UnityEngine.UI.Text _expiryDate;
                    /*0xa8*/ UnityEngine.GameObject _closeFrame;
                    /*0xb0*/ UnityEngine.UI.Button _closeFrameButton;
                    /*0xb8*/ DMM.Games.Recibo.Ui.ShowCouponDetailData _couponDetailData;
                    /*0xc0*/ DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData _coupon;

                    /*0x3f8e184*/ ShowCouponData();
                    /*0x3f8ce08*/ void Init(DMM.Games.Recibo.Ui.ShowCouponDetailData couponDetailData, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon);
                    /*0x3f8cf04*/ void UpdateData(DMM.Games.Recibo.Ui.ShowCouponDetailData couponDetailData, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon);
                    /*0x3f8ce44*/ void SetData(DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon);
                    /*0x3f8cfe8*/ void UpdateCloseFrame(bool isActive);
                    /*0x3f8d03c*/ void SetToggleSprite(bool isAvailable);
                    /*0x3f8d154*/ System.Threading.Tasks.Task LoadBannerImageAsync(string bannerUrl);
                    /*0x3f8d894*/ System.Threading.Tasks.Task LoadImage(string url);
                    /*0x3f8d98c*/ void SetBannerImage(UnityEngine.UI.RawImage image, UnityEngine.Sprite sprite);
                    /*0x3f8d774*/ void UpdateTag(DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon);
                    /*0x3f8d9c0*/ void SetTagAreaActive(int index, bool isActive);
                    /*0x3f8d9fc*/ void SetTagInfo(int id, UnityEngine.RectTransform[] tagGameObjects, UnityEngine.UI.Text[] tagTexts, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData data);
                    /*0x3f8df54*/ void SetTagText(UnityEngine.UI.Text tagText, string colorCode, string text);
                    /*0x3f8dfd4*/ void SetTagFrame(UnityEngine.UI.Image img, string colorCode);
                    /*0x3f8dd8c*/ float GetLabelLength(string text);
                    /*0x3f8e024*/ bool IsOnlyAlphanumeric(string text);
                    /*0x3f8d250*/ void SetDiscountAmount(bool isAvailable, int discountAmount);
                    /*0x3f8d3ec*/ void SetCouponName(string couponName);
                    /*0x3f8d4ec*/ void SetNumberOfTimesOfUse(int remainedCount);
                    /*0x3f8d6d0*/ void SetExpiryDate(string useEndAt);
                    /*0x3f8cf40*/ void SetButtonAction();
                    /*0x3f8e17c*/ void OnCloseFrameButton();
                    /*0x3f8e094*/ string CommaFormat(long number);

                    class <>c
                    {
                        static /*0x0*/ DMM.Games.Recibo.Ui.ShowCouponData.<> <>9;
                        static /*0x8*/ System.Func<char, string> <>9__46_0;

                        static /*0x3f8e18c*/ <>c();
                        /*0x3f8e1f4*/ <>c();
                        /*0x3f8e1fc*/ string <GetLabelLength>b__46_0(char x);
                    }

                    struct <LoadBannerImageAsync>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ DMM.Games.Recibo.Ui.ShowCouponData <>4__this;
                        /*0x38*/ string bannerUrl;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x3f8e230*/ void MoveNext();
                        /*0x3f8e550*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <LoadImage>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ string url;
                        /*0x38*/ DMM.Games.Recibo.Ui.ShowCouponData <>4__this;
                        /*0x40*/ UnityEngine.Networking.UnityWebRequest <www>5__2;
                        /*0x48*/ object <>u__1;

                        /*0x3f8e5b8*/ void MoveNext();
                        /*0x3f8eb74*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class ShowCouponDetailData : UnityEngine.MonoBehaviour
                {
                    static int FONT_SIZE_1 = 28;
                    static int FONT_SIZE_2 = 35;
                    static string COLOR_PATTERN_1 = "#1E1E1E";
                    static string COLOR_PATTERN_2 = "#999999";
                    static string COLOR_PATTERN_3 = "#DE4A4A";
                    static string TEXT_PATTERN = "<size={0}><color={1}>{2}</color></size>";
                    /*0x20*/ UnityEngine.UI.Text _detailDescription;
                    /*0x28*/ UnityEngine.GameObject _unAvailablePanel;
                    /*0x30*/ UnityEngine.UI.Button _openFrameButton;
                    /*0x38*/ DMM.Games.Recibo.Ui.ShowCouponData _couponData;

                    /*0x3f8f5f8*/ ShowCouponDetailData();
                    /*0x3f8ebdc*/ void Init(DMM.Games.Recibo.Ui.ShowCouponData couponData, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon, DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] notice);
                    /*0x3f8ec48*/ void UpdateData(DMM.Games.Recibo.Ui.ShowCouponData couponData, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon, DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] notice);
                    /*0x3f8ec18*/ void SetData(DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon, DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] notice);
                    /*0x3f8ec84*/ void SetButtonAction();
                    /*0x3f8f0c8*/ void OnOpenFrameButton();
                    /*0x3f8f0e4*/ string SetDiscountText(int discountAmount, int discountRate, int maxDiscountAmount);
                    /*0x3f8f3c4*/ string SetUseConditionDetail(int minPayment, int useLimit, int useLimitPerUser);
                    /*0x3f8ed2c*/ void SetDetailDescription(DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon, DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] notice);
                    /*0x3f8f2dc*/ string CommaFormat(long number);
                }

                class ShowCouponListDialog : UnityEngine.MonoBehaviour
                {
                    static string PcPath = "DMM/ShowCouponListDialog";
                    static string SpPortraitPath = "DMM/ShowCouponListDialogSpPortrait";
                    static string SpLandscapePath = "DMM/ShowCouponListDialogSpLandscape";
                    static int COUPON_DISPLAY_MAX = 3;
                    static int PAGE_CHANGE_COUNT = 3;
                    static /*0x0*/ UnityEngine.GameObject _dialog;
                    static /*0x8*/ DMM.Games.Recibo.Ui.ShowCouponListDialog _instance;
                    static /*0x10*/ UnityEngine.Events.UnityAction _cancelButtonAction;
                    static /*0x18*/ UnityEngine.Events.UnityAction _decideButtonAction;
                    /*0x20*/ UnityEngine.UI.Image _logo;
                    /*0x28*/ UnityEngine.UI.Button _cancelButton;
                    /*0x30*/ UnityEngine.UI.Button _decideButton;
                    /*0x38*/ UnityEngine.UI.ToggleGroup _toggleGroup;
                    /*0x40*/ UnityEngine.UI.Toggle[] _toggles;
                    /*0x48*/ UnityEngine.UI.Text _couponCount;
                    /*0x50*/ UnityEngine.UI.Dropdown _couponSortDropdown;
                    /*0x58*/ UnityEngine.GameObject _pageGameObject;
                    /*0x60*/ UnityEngine.UI.Button[] _pageButtons;
                    /*0x68*/ UnityEngine.UI.Text[] _pageTexts;
                    /*0x70*/ int _coupondisplayMax;
                    /*0x78*/ UnityEngine.UI.ScrollRect _scrollRect;
                    /*0x80*/ DMM.Games.Recibo.Ui.ShowCouponData[] _showCouponData;
                    /*0x88*/ DMM.Games.Recibo.Ui.ShowCouponDetailData[] _couponDetailData;
                    /*0x90*/ DMM.Games.Util.DialogCanvasController _canvasController;
                    /*0x98*/ int _pageCount;
                    /*0x9c*/ int _pageMax;
                    /*0xa0*/ int _toggleSelectIndex;
                    /*0xa8*/ string _selectCouponId;
                    /*0xb0*/ DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] _noticeData;
                    /*0xb8*/ System.Collections.Generic.Dictionary<int, int> _toggleList;
                    /*0xc0*/ System.Collections.Generic.Dictionary<int, int> _pageList;
                    /*0xc8*/ DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState _pageState;
                    /*0xcc*/ UnityEngine.Color32 COLOR_PATTERN_1;
                    /*0xd0*/ UnityEngine.Color32 COLOR_PATTERN_2;
                    /*0xd4*/ UnityEngine.Color32 COLOR_PATTERN_3;

                    static /*0x3f8f600*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, DMM.Games.Recibo.Ui.ShowCouponListDialogModel data);
                    static /*0x3f8b124*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, DMM.Games.Recibo.Ui.ShowCouponListDialogModel data);
                    static /*0x3f8ba0c*/ void Hide();
                    /*0x3f920b4*/ ShowCouponListDialog();
                    /*0x3f8f8c8*/ void Initialized();
                    /*0x3f8f9d0*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowCouponListDialogModel data);
                    /*0x3f8fb88*/ void SetCoupon(int totalCount, bool isInit);
                    /*0x3f9086c*/ void UpdateCoupon();
                    /*0x3f90504*/ void UpdateCouponData(bool isInit);
                    /*0x3f90920*/ int SetSortList(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData>> sortedList, int index, bool isAvailable);
                    /*0x3f90204*/ void SortDropDownValue();
                    /*0x3f90cb8*/ void OnDropDownValueChanged(int value);
                    /*0x3f90168*/ void SetCouponCount(int totalCount);
                    /*0x3f8fd40*/ void SetToggleGroupButton();
                    /*0x3f90cc4*/ void OnToggleValueChanged(bool state);
                    /*0x3f90f9c*/ void UpdateToggleData();
                    /*0x3f9115c*/ void SetToggleList(int index, int count);
                    /*0x3f90e38*/ int GetToggleValue(int key);
                    /*0x3f907b0*/ void UpdatePaging(int pageCount);
                    /*0x3f911c4*/ DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState GetPageState(int currentPage, int pageMax);
                    /*0x3f8ff68*/ void SetPageButton();
                    /*0x3f91704*/ System.Collections.Generic.List<int> GetPageIndexList(DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState pageState);
                    /*0x3f91208*/ void UpdatePageValue(DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState pageState, int currentPage);
                    /*0x3f91354*/ void UpdatePageObject(DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState pageState, int currentPage);
                    /*0x3f915a8*/ void UpdatePageText(DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState pageState, int currentPage);
                    /*0x3f91c40*/ void SetPageList(int index, int page);
                    /*0x3f91ca8*/ int GetPageValue(int key);
                    /*0x3f91e04*/ void OnPageButton(int index);
                    /*0x3f91e20*/ void OnPageNextButton(int index);
                    /*0x3f91e4c*/ void OnPageBackButton(int index);
                    /*0x3f91e6c*/ void OnCancelButton();
                    /*0x3f91f74*/ void OnDecideButton();
                    /*0x3f8fbf4*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f8fc88*/ void LogoDestroy();

                    enum PageState
                    {
                        None = 0,
                        TypePage1 = 1,
                        TypePage2 = 2,
                        TypePage3 = 3,
                        TypePage4 = 4,
                        TypePage5 = 5,
                        TypePage6 = 6,
                    }

                    enum PageNumber
                    {
                        None = -1,
                        PageButtonIndex0 = 0,
                        PageButtonIndex1 = 1,
                        PageButtonIndex2 = 2,
                        PageButtonIndex3 = 3,
                        PageButtonIndex4 = 4,
                        PageButtonIndex5 = 5,
                        PageButtonIndex6 = 6,
                    }

                    class <>c
                    {
                        static /*0x0*/ DMM.Games.Recibo.Ui.ShowCouponListDialog.<> <>9;
                        static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData>, int> <>9__46_0;
                        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData>, long> <>9__46_1;
                        static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData>, long> <>9__46_2;

                        static /*0x3f921b4*/ <>c();
                        /*0x3f9221c*/ <>c();
                        /*0x3f92224*/ int <SortDropDownValue>b__46_0(System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> x);
                        /*0x3f92268*/ long <SortDropDownValue>b__46_1(System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> x);
                        /*0x3f922ac*/ long <SortDropDownValue>b__46_2(System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> x);
                    }

                    class <>c__DisplayClass56_0
                    {
                        /*0x10*/ int index;
                        /*0x18*/ DMM.Games.Recibo.Ui.ShowCouponListDialog <>4__this;

                        /*0x3f916fc*/ <>c__DisplayClass56_0();
                        /*0x3f922f0*/ void <SetPageButton>b__0();
                        /*0x3f9232c*/ void <SetPageButton>b__1();
                        /*0x3f92358*/ void <SetPageButton>b__2();
                    }
                }

                class ShowCouponListDialogModel
                {
                    /*0x10*/ DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel <AvailableCoupons>k__BackingField;
                    /*0x18*/ UnityEngine.Events.UnityAction <OnClickPositiveButton>k__BackingField;
                    /*0x20*/ UnityEngine.Events.UnityAction <OnClickNegativeButton>k__BackingField;
                    /*0x28*/ int <SortingOrder>k__BackingField;
                    /*0x30*/ UnityEngine.Sprite <LogoImage>k__BackingField;

                    /*0x3f8b114*/ ShowCouponListDialogModel();
                    /*0x3f923a0*/ DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel get_AvailableCoupons();
                    /*0x3f923a8*/ void set_AvailableCoupons(DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel value);
                    /*0x3f923b0*/ UnityEngine.Events.UnityAction get_OnClickPositiveButton();
                    /*0x3f923b8*/ void set_OnClickPositiveButton(UnityEngine.Events.UnityAction value);
                    /*0x3f923c0*/ UnityEngine.Events.UnityAction get_OnClickNegativeButton();
                    /*0x3f923c8*/ void set_OnClickNegativeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f923d0*/ int get_SortingOrder();
                    /*0x3f923d8*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f923e0*/ void set_LogoImage(UnityEngine.Sprite value);
                }

                class ShowErrorDialog : UnityEngine.MonoBehaviour
                {
                    static string Path = "DMM/ShowErrorDialog";
                    static string InquiryUrl = "https://inquiry.dmm.com/form/16";
                    static /*0x0*/ UnityEngine.GameObject _dialog;
                    static /*0x8*/ DMM.Games.Recibo.Ui.ShowErrorDialog _instance;
                    /*0x20*/ UnityEngine.UI.Text _message;
                    /*0x28*/ UnityEngine.UI.Button _closeButton;
                    /*0x30*/ UnityEngine.UI.Button _inquiryButton;
                    /*0x38*/ UnityEngine.UI.Image _logo;

                    static /*0x3f923e8*/ bool Init(DMM.Games.Recibo.Ui.ShowErrorDialogModel data);
                    static /*0x3f92710*/ void Show(DMM.Games.Recibo.Ui.ShowErrorDialogModel data);
                    static /*0x3f92784*/ void Hide();
                    /*0x3f9298c*/ ShowErrorDialog();
                    /*0x3f925f4*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowErrorDialogModel data);
                    /*0x3f925d0*/ void SetMessage(string message);
                    /*0x3f9267c*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f928d4*/ void LogoDestroy();
                }

                class ShowErrorDialogModel
                {
                    /*0x10*/ string <Message>k__BackingField;
                    /*0x18*/ UnityEngine.Events.UnityAction <OnClickCloseButton>k__BackingField;
                    /*0x20*/ UnityEngine.Events.UnityAction <OnClickInquiryButton>k__BackingField;
                    /*0x28*/ int <SortingOrder>k__BackingField;
                    /*0x30*/ UnityEngine.Sprite <LogoImage>k__BackingField;

                    /*0x3f929dc*/ ShowErrorDialogModel();
                    /*0x3f92994*/ string get_Message();
                    /*0x3f9299c*/ void set_Message(string value);
                    /*0x3f929a4*/ UnityEngine.Events.UnityAction get_OnClickCloseButton();
                    /*0x3f929ac*/ void set_OnClickCloseButton(UnityEngine.Events.UnityAction value);
                    /*0x3f929b4*/ UnityEngine.Events.UnityAction get_OnClickInquiryButton();
                    /*0x3f929bc*/ void set_OnClickInquiryButton(UnityEngine.Events.UnityAction value);
                    /*0x3f929c4*/ int get_SortingOrder();
                    /*0x3f929cc*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f929d4*/ void set_LogoImage(UnityEngine.Sprite value);
                }

                class ShowMaintenanceDialog : UnityEngine.MonoBehaviour
                {
                    static string Path = "DMM/ShowMaintenanceDialog";
                    static /*0x0*/ UnityEngine.GameObject _dialog;
                    static /*0x8*/ DMM.Games.Recibo.Ui.ShowMaintenanceDialog _instance;
                    /*0x20*/ UnityEngine.UI.Button _closeButton;
                    /*0x28*/ UnityEngine.UI.Button _informationButton;
                    /*0x30*/ UnityEngine.UI.Text _closeButtonText;
                    /*0x38*/ UnityEngine.UI.Text _informationButtonText;
                    /*0x40*/ UnityEngine.UI.Text _message;
                    /*0x48*/ UnityEngine.UI.Image _logo;

                    static /*0x3f929ec*/ bool Init(DMM.Games.Recibo.Ui.ShowMaintenanceDialogModel data);
                    static /*0x3f92d84*/ void Show(DMM.Games.Recibo.Ui.ShowMaintenanceDialogModel data);
                    static /*0x3f8bd08*/ void Hide();
                    /*0x3f92eb0*/ ShowMaintenanceDialog();
                    /*0x3f92c68*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowMaintenanceDialogModel data);
                    /*0x3f92c10*/ void SetButtonText(DMM.Games.Recibo.Ui.ShowMaintenanceDialogModel data);
                    /*0x3f92bec*/ void SetMessage(string message);
                    /*0x3f92cf0*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f92df8*/ void LogoDestroy();
                }

                class ShowMaintenanceDialogModel
                {
                    /*0x10*/ string <Message>k__BackingField;
                    /*0x18*/ UnityEngine.Events.UnityAction <OnClickPositiveButton>k__BackingField;
                    /*0x20*/ UnityEngine.Events.UnityAction <OnClickNegativeButton>k__BackingField;
                    /*0x28*/ string <PositiveButtonText>k__BackingField;
                    /*0x30*/ string <NegativeButtonText>k__BackingField;
                    /*0x38*/ int <SortingOrder>k__BackingField;
                    /*0x40*/ UnityEngine.Sprite <LogoImage>k__BackingField;

                    /*0x3f92f20*/ ShowMaintenanceDialogModel();
                    /*0x3f92eb8*/ string get_Message();
                    /*0x3f92ec0*/ void set_Message(string value);
                    /*0x3f92ec8*/ UnityEngine.Events.UnityAction get_OnClickPositiveButton();
                    /*0x3f92ed0*/ void set_OnClickPositiveButton(UnityEngine.Events.UnityAction value);
                    /*0x3f92ed8*/ UnityEngine.Events.UnityAction get_OnClickNegativeButton();
                    /*0x3f92ee0*/ void set_OnClickNegativeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f92ee8*/ string get_PositiveButtonText();
                    /*0x3f92ef0*/ void set_PositiveButtonText(string value);
                    /*0x3f92ef8*/ string get_NegativeButtonText();
                    /*0x3f92f00*/ void set_NegativeButtonText(string value);
                    /*0x3f92f08*/ int get_SortingOrder();
                    /*0x3f92f10*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f92f18*/ void set_LogoImage(UnityEngine.Sprite value);
                }

                class ShowOrderDialog : UnityEngine.MonoBehaviour
                {
                    static string PcPath = "DMM/ShowOrderDialog";
                    static string SpPortraitPath = "DMM/ShowOrderDialogSpPortrait";
                    static string SpLandscapePath = "DMM/ShowOrderDialogSpLandscape";
                    static int COUPON_NAME_LENGTH_MAX = 27;
                    static int COUPON_NAME_LENGTH_SP_PORTRAIT_MAX = 23;
                    static int COUPON_NAME_LENGTH_SP_LANDSCAPE_MAX = 22;
                    static /*0x0*/ UnityEngine.GameObject _dialog;
                    static /*0x8*/ DMM.Games.Recibo.Ui.ShowOrderDialog _instance;
                    static /*0x10*/ bool _isUseCoupon;
                    static /*0x11*/ bool _isSelectCoupon;
                    /*0x20*/ UnityEngine.UI.Button _cancelButton;
                    /*0x28*/ UnityEngine.UI.Button _positiveButton;
                    /*0x30*/ UnityEngine.UI.Text _positiveButtonText;
                    /*0x38*/ UnityEngine.UI.RawImage _productIcon;
                    /*0x40*/ UnityEngine.UI.Text _productTitle;
                    /*0x48*/ UnityEngine.UI.Text _productPoint;
                    /*0x50*/ UnityEngine.UI.Text _availablePoint;
                    /*0x58*/ UnityEngine.UI.Text _periodTimeDescription;
                    /*0x60*/ UnityEngine.UI.Button _termOfPayment;
                    /*0x68*/ UnityEngine.UI.Button _termOfDelivery;
                    /*0x70*/ UnityEngine.UI.Button _returnPolicy;
                    /*0x78*/ UnityEngine.GameObject _userRankInfo;
                    /*0x80*/ UnityEngine.UI.Text _userRankMainText;
                    /*0x88*/ UnityEngine.UI.Text _userRankPointText;
                    /*0x90*/ UnityEngine.GameObject _userRankNotes;
                    /*0x98*/ UnityEngine.GameObject _pointShortage;
                    /*0xa0*/ UnityEngine.GameObject _totalInfo;
                    /*0xa8*/ UnityEngine.GameObject _couponTotalInfo;
                    /*0xb0*/ UnityEngine.UI.Text[] _couponTotalText;
                    /*0xb8*/ UnityEngine.GameObject _couponInfo;
                    /*0xc0*/ UnityEngine.UI.Button _couponSelectChangeButton;
                    /*0xc8*/ UnityEngine.UI.Text _couponUseCountText;
                    /*0xd0*/ UnityEngine.GameObject _couponUseInfo;
                    /*0xd8*/ UnityEngine.UI.Button _couponChangeButton;
                    /*0xe0*/ UnityEngine.UI.Text _couponNameText;
                    /*0xe8*/ UnityEngine.GameObject[] _couponBadge;
                    /*0xf0*/ DMM.Games.Util.DialogCanvasController _canvasController;
                    /*0xf8*/ Dmm.Games.Unity.Purchasing.DeveloperPayload _developerPayload;
                    /*0x100*/ UnityEngine.UI.Image _logo;
                    /*0x108*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore _store;

                    static /*0x3f92f30*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, DMM.Games.Recibo.Ui.ShowOrderDialogModel data);
                    static /*0x3f8b098*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, DMM.Games.Recibo.Ui.ShowOrderDialogModel data);
                    static /*0x3f8c0cc*/ void Hide();
                    static /*0x3f94020*/ void UpdatePositiveButtonText(string text);
                    /*0x3f9469c*/ ShowOrderDialog();
                    /*0x3f94010*/ void SetStore(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                    /*0x3f934b8*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowOrderDialogModel data);
                    /*0x3f93af0*/ void SetPositiveButtonText(string text);
                    /*0x3f93b14*/ void SetAvailablePurchase(bool isAvailablePurchase);
                    /*0x3f93b74*/ void SetUserRankInfo(System.Nullable<DMM.Games.Recibo.Api.Orders.Model.OrdersModel> grantUserRankPointModel);
                    /*0x3f935a8*/ void SetDeveloperPayloadAction(string json);
                    /*0x3f93300*/ void SetProductTitle(string title);
                    /*0x3f93324*/ void SetProductPoint(long point);
                    /*0x3f933a4*/ void SetAvailablePoint(long point);
                    /*0x3f940ac*/ string CommaFormat(long number);
                    /*0x3f93424*/ void SetProductIcon(UnityEngine.Texture2D icon);
                    /*0x3f93d00*/ void SetIsUseCoupon(int couponCount, bool isSelectCoupon);
                    /*0x3f93d64*/ void SetCouponInfo(DMM.Games.Recibo.Ui.ShowOrderDialogModel data, int couponCount, bool isUseCoupon);
                    /*0x3f94578*/ void SetAdvantageousCouponBadge();
                    /*0x3f94194*/ void SetInfoActive(bool isTotalInfoActive, bool isCouponTotalInfoActive, bool isCouponInfoActive, bool isCouponUseInfoActive);
                    /*0x3f9461c*/ void SetTotalInfoActive(bool isActive);
                    /*0x3f9463c*/ void SetCouponTotalInfoActive(bool isActive);
                    /*0x3f94280*/ void SetCouponTotal(long subTotalPoint, long couponPoint, long totalPoint);
                    /*0x3f9465c*/ void SetCouponInfoActive(bool isActive);
                    /*0x3f944dc*/ void SetCouponCount(int count);
                    /*0x3f9467c*/ void SetCouponUseInfoActive(bool isActive);
                    /*0x3f943e0*/ void SetCouponName(string couponName);
                    /*0x3f93ec0*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f93f54*/ void LogoDestroy();
                    /*0x3f946a4*/ void <SetDeveloperPayloadAction>b__49_0();
                    /*0x3f94714*/ void <SetDeveloperPayloadAction>b__49_1();
                    /*0x3f94784*/ void <SetDeveloperPayloadAction>b__49_2();
                }

                class ShowOrderDialogModel
                {
                    /*0x10*/ string <ProductTitle>k__BackingField;
                    /*0x18*/ long <ProductPoint>k__BackingField;
                    /*0x20*/ long <AvailablePoint>k__BackingField;
                    /*0x28*/ string <DeveloperPayload>k__BackingField;
                    /*0x30*/ bool <IsAvailablePurchase>k__BackingField;
                    /*0x38*/ UnityEngine.Texture2D <ProductIcon>k__BackingField;
                    /*0x40*/ UnityEngine.Events.UnityAction <OnClickPositiveButton>k__BackingField;
                    /*0x48*/ UnityEngine.Events.UnityAction <OnClickNegativeButton>k__BackingField;
                    /*0x50*/ UnityEngine.Events.UnityAction <OnClickCupoonChangeButton>k__BackingField;
                    /*0x58*/ int <CouponCounts>k__BackingField;
                    /*0x60*/ string <CouponId>k__BackingField;
                    /*0x68*/ bool <IsSelectCoupon>k__BackingField;
                    /*0x6c*/ int <SortingOrder>k__BackingField;
                    /*0x70*/ UnityEngine.Sprite <LogoImage>k__BackingField;
                    /*0x78*/ System.Nullable<DMM.Games.Recibo.Api.Orders.Model.OrdersModel> <GrantUserRankPointModel>k__BackingField;

                    /*0x3f8aeb8*/ ShowOrderDialogModel();
                    /*0x3f947f4*/ string get_ProductTitle();
                    /*0x3f947fc*/ void set_ProductTitle(string value);
                    /*0x3f94804*/ long get_ProductPoint();
                    /*0x3f9480c*/ void set_ProductPoint(long value);
                    /*0x3f94814*/ long get_AvailablePoint();
                    /*0x3f9481c*/ void set_AvailablePoint(long value);
                    /*0x3f94824*/ string get_DeveloperPayload();
                    /*0x3f9482c*/ void set_DeveloperPayload(string value);
                    /*0x3f94834*/ bool get_IsAvailablePurchase();
                    /*0x3f9483c*/ void set_IsAvailablePurchase(bool value);
                    /*0x3f94848*/ UnityEngine.Texture2D get_ProductIcon();
                    /*0x3f94850*/ void set_ProductIcon(UnityEngine.Texture2D value);
                    /*0x3f94858*/ UnityEngine.Events.UnityAction get_OnClickPositiveButton();
                    /*0x3f94860*/ void set_OnClickPositiveButton(UnityEngine.Events.UnityAction value);
                    /*0x3f94868*/ UnityEngine.Events.UnityAction get_OnClickNegativeButton();
                    /*0x3f94870*/ void set_OnClickNegativeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f94878*/ UnityEngine.Events.UnityAction get_OnClickCupoonChangeButton();
                    /*0x3f94880*/ void set_OnClickCupoonChangeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f94888*/ int get_CouponCounts();
                    /*0x3f94890*/ void set_CouponCounts(int value);
                    /*0x3f94898*/ string get_CouponId();
                    /*0x3f948a0*/ void set_CouponId(string value);
                    /*0x3f948a8*/ bool get_IsSelectCoupon();
                    /*0x3f948b0*/ void set_IsSelectCoupon(bool value);
                    /*0x3f948bc*/ int get_SortingOrder();
                    /*0x3f948c4*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f948cc*/ void set_LogoImage(UnityEngine.Sprite value);
                    /*0x3f948d4*/ System.Nullable<DMM.Games.Recibo.Api.Orders.Model.OrdersModel> get_GrantUserRankPointModel();
                    /*0x3f948e0*/ void set_GrantUserRankPointModel(System.Nullable<DMM.Games.Recibo.Api.Orders.Model.OrdersModel> value);
                }

                class ShowRetryDialog : UnityEngine.MonoBehaviour
                {
                    static string Path = "DMM/ShowRetryDialog";
                    static /*0x0*/ UnityEngine.GameObject _dialog;
                    static /*0x8*/ DMM.Games.Recibo.Ui.ShowRetryDialog _instance;
                    /*0x20*/ UnityEngine.UI.Button _negativeButton;
                    /*0x28*/ UnityEngine.UI.Button _positiveButton;
                    /*0x30*/ UnityEngine.UI.Text _negativeButtonText;
                    /*0x38*/ UnityEngine.UI.Text _positiveButtonText;
                    /*0x40*/ UnityEngine.UI.Text _message;
                    /*0x48*/ UnityEngine.UI.Image _logo;

                    static /*0x3f948f0*/ bool Init(DMM.Games.Recibo.Ui.ShowRetryDialogModel data);
                    static /*0x3f94c88*/ void Show(DMM.Games.Recibo.Ui.ShowRetryDialogModel data);
                    static /*0x3f94cfc*/ void Hide();
                    /*0x3f94f04*/ ShowRetryDialog();
                    /*0x3f94b6c*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowRetryDialogModel data);
                    /*0x3f94b14*/ void SetButtonText(DMM.Games.Recibo.Ui.ShowRetryDialogModel data);
                    /*0x3f94af0*/ void SetMessage(string message);
                    /*0x3f94bf4*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f94e4c*/ void LogoDestroy();
                }

                class ShowRetryDialogModel
                {
                    /*0x10*/ string <Message>k__BackingField;
                    /*0x18*/ UnityEngine.Events.UnityAction <OnClickPositiveButton>k__BackingField;
                    /*0x20*/ UnityEngine.Events.UnityAction <OnClickNegativeButton>k__BackingField;
                    /*0x28*/ string PositiveButtonText;
                    /*0x30*/ string NegativeButtonText;
                    /*0x38*/ int <SortingOrder>k__BackingField;
                    /*0x40*/ UnityEngine.Sprite <LogoImage>k__BackingField;

                    /*0x3f94f54*/ ShowRetryDialogModel();
                    /*0x3f94f0c*/ string get_Message();
                    /*0x3f94f14*/ void set_Message(string value);
                    /*0x3f94f1c*/ UnityEngine.Events.UnityAction get_OnClickPositiveButton();
                    /*0x3f94f24*/ void set_OnClickPositiveButton(UnityEngine.Events.UnityAction value);
                    /*0x3f94f2c*/ UnityEngine.Events.UnityAction get_OnClickNegativeButton();
                    /*0x3f94f34*/ void set_OnClickNegativeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f94f3c*/ int get_SortingOrder();
                    /*0x3f94f44*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f94f4c*/ void set_LogoImage(UnityEngine.Sprite value);
                }

                class SingletonComponent<T> : UnityEngine.MonoBehaviour
                {
                    static /*0x0*/ T _instance;

                    static /*0x3910ae8*/ T get_Instance();
                    static /*0x3821564*/ bool get_HasInstance();
                    /*0x38159dc*/ SingletonComponent();
                    /*0x38159dc*/ void Awake();
                    /*0x38159dc*/ void OnAwake();
                }

                namespace Subscription
                {
                    class ShowContinueDialog : UnityEngine.MonoBehaviour
                    {
                        static string PayTypeCredit = "credit";
                        static string PayTypePoint = "dmmpoint";
                        static string Path = "DMM/Subscription/ShowContinueDialog";
                        static /*0x0*/ UnityEngine.GameObject _dialog;
                        static /*0x8*/ DMM.Games.Recibo.Ui.Subscription.ShowContinueDialog _instance;
                        /*0x20*/ UnityEngine.UI.Text _payTypeText;
                        /*0x28*/ UnityEngine.UI.Button _continueButton;
                        /*0x30*/ UnityEngine.UI.Button _cancelButton;
                        /*0x38*/ UnityEngine.UI.RawImage _productIcon;
                        /*0x40*/ UnityEngine.Texture2D _defaultIcon;
                        /*0x48*/ UnityEngine.UI.Text _productTitle;
                        /*0x50*/ DMM.Games.Util.DialogCanvasController _canvasController;
                        /*0x58*/ UnityEngine.UI.Image _logo;

                        static /*0x3f94fe0*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, string payType, UnityEngine.Events.UnityAction onCLickContinueButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f95518*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, string payType, UnityEngine.Events.UnityAction onClickContinueButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f955c4*/ void Hide();
                        /*0x3f95700*/ ShowContinueDialog();
                        /*0x3f953cc*/ void SetProductTitle(string title);
                        /*0x3f953f0*/ void SetProductIcon(UnityEngine.Texture2D icon);
                        /*0x3f95484*/ void SetLogo(UnityEngine.Sprite logo);
                    }

                    class ShowCreditErrorDialog : UnityEngine.MonoBehaviour
                    {
                        static string Path = "DMM/Subscription/ShowCreditErrorDialog";
                        static string ErrorToUrl = "https://support.dmm.com/form/16";
                        static /*0x0*/ UnityEngine.GameObject _dialog;
                        static /*0x8*/ DMM.Games.Recibo.Ui.Subscription.ShowCreditErrorDialog _instance;
                        /*0x20*/ UnityEngine.UI.Button _errorLinkButton;
                        /*0x28*/ UnityEngine.UI.Text _errorCodeText;
                        /*0x30*/ UnityEngine.UI.Button _errorToButton;
                        /*0x38*/ UnityEngine.UI.Button _creditUpdateButton;
                        /*0x40*/ UnityEngine.UI.Button _cancelButton;
                        /*0x48*/ DMM.Games.Util.DialogCanvasController _canvasController;
                        /*0x50*/ UnityEngine.UI.Image _logo;

                        static /*0x3f95708*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string errorCode, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f95be0*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string errorCode, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f95c70*/ void Hide();
                        /*0x3f95dac*/ ShowCreditErrorDialog();
                        /*0x3f95b64*/ void SetErrorCode(string errorCode);
                        /*0x3f95ad0*/ void SetLogo(UnityEngine.Sprite logo);

                        class <>c
                        {
                            static /*0x0*/ DMM.Games.Recibo.Ui.Subscription.ShowCreditErrorDialog.<> <>9;
                            static /*0x8*/ UnityEngine.Events.UnityAction <>9__11_0;

                            static /*0x3f95db4*/ <>c();
                            /*0x3f95e1c*/ <>c();
                            /*0x3f95e24*/ void <Init>b__11_0();
                        }

                        class <>c__DisplayClass11_0
                        {
                            /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore store;

                            /*0x3f95ac8*/ <>c__DisplayClass11_0();
                            /*0x3f95e8c*/ void <Init>b__1();
                        }
                    }

                    class ShowLoading : UnityEngine.MonoBehaviour
                    {
                        static string Path = "DMM/Subscription/ShowLoadingDialog";
                        static /*0x0*/ UnityEngine.GameObject _dialog;
                        static /*0x8*/ DMM.Games.Recibo.Ui.Subscription.ShowLoading _instance;
                        /*0x20*/ UnityEngine.RectTransform _rt;
                        /*0x28*/ DMM.Games.Util.DialogCanvasController _canvasController;
                        /*0x30*/ UnityEngine.Vector3 _rot;

                        static /*0x3f95f00*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                        static /*0x3f8a960*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                        static /*0x3f89d30*/ void Hide();
                        /*0x3f96138*/ ShowLoading();
                        /*0x3f96070*/ void Update();
                    }

                    class ShowMaintenanceDialog : UnityEngine.MonoBehaviour
                    {
                        static string Path = "DMM/Subscription/ShowMaintenanceDialog";
                        static /*0x0*/ UnityEngine.GameObject _dialog;
                        static /*0x8*/ DMM.Games.Recibo.Ui.Subscription.ShowMaintenanceDialog _instance;
                        /*0x20*/ UnityEngine.UI.Button _maintenanceButton;
                        /*0x28*/ UnityEngine.UI.Button _returnButton;
                        /*0x30*/ UnityEngine.UI.Button _cancelButton;
                        /*0x38*/ UnityEngine.UI.Button _informationButton;
                        /*0x40*/ UnityEngine.UI.Image _logo;
                        /*0x48*/ DMM.Games.Util.DialogCanvasController _canvasController;

                        static /*0x3f9614c*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Events.UnityAction onClickReturnButton, UnityEngine.Events.UnityAction OnClickInfomationButton);
                        static /*0x3f8ab40*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Events.UnityAction onClickReturnButton, UnityEngine.Events.UnityAction OnClickInfomationButton);
                        static /*0x3f96560*/ void Hide();
                        /*0x3f9666c*/ ShowMaintenanceDialog();
                        /*0x3f964cc*/ void SetLogo(UnityEngine.Sprite logo);

                        class <>c__DisplayClass9_0
                        {
                            /*0x10*/ UnityEngine.Events.UnityAction onClickReturnButton;
                            /*0x18*/ UnityEngine.Events.UnityAction OnClickInfomationButton;

                            /*0x3f964c4*/ <>c__DisplayClass9_0();
                            /*0x3f96674*/ void <Init>b__0();
                            /*0x3f96698*/ void <Init>b__1();
                            /*0x3f966bc*/ void <Init>b__2();
                        }
                    }

                    class ShowOrderCompleteDialog : UnityEngine.MonoBehaviour
                    {
                        static string Path = "DMM/Subscription/ShowOrderCompleteDialog";
                        static /*0x0*/ UnityEngine.GameObject _dialog;
                        static /*0x8*/ DMM.Games.Recibo.Ui.Subscription.ShowOrderCompleteDialog _instance;
                        /*0x20*/ UnityEngine.UI.Text _nextPayDay;
                        /*0x28*/ UnityEngine.UI.Button _serviceInfoButton;
                        /*0x30*/ UnityEngine.UI.Button _returnButton;
                        /*0x38*/ UnityEngine.UI.Button _cancelButton;
                        /*0x40*/ DMM.Games.Util.DialogCanvasController _canvasController;
                        /*0x48*/ UnityEngine.UI.Image _logo;

                        static /*0x3f966d8*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, bool isAdult, string nextDay, UnityEngine.Events.UnityAction onClickReturnButton);
                        static /*0x3f96aac*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string nextDay, UnityEngine.Events.UnityAction onClickReturnButton);
                        static /*0x3f96b64*/ void Hide();
                        /*0x3f96d3c*/ ShowOrderCompleteDialog();
                        /*0x3f96ca0*/ void SetNextPayDay(string day);
                        /*0x3f96a18*/ void SetLogo(UnityEngine.Sprite logo);

                        class <>c__DisplayClass9_0
                        {
                            /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore store;

                            /*0x3f96a10*/ <>c__DisplayClass9_0();
                            /*0x3f96d44*/ void <Init>b__0();
                        }
                    }

                    class ShowOrderConfirmDialog : UnityEngine.MonoBehaviour
                    {
                        static string PayTypeCredit = "credit";
                        static string PayTypePoint = "dmmpoint";
                        static string PcPath = "DMM/Subscription/ShowOrderConfirmDialog";
                        static string SpPortraitPath = "DMM/Subscription/ShowOrderConfirmDialogSpPortrait";
                        static string SpLandscapePath = "DMM/Subscription/ShowOrderConfirmDialogSpLandscape";
                        static /*0x0*/ UnityEngine.GameObject _dialog;
                        static /*0x8*/ DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog _instance;
                        /*0x20*/ UnityEngine.UI.Button _changeMethodTextButton;
                        /*0x28*/ UnityEngine.UI.Button _middleButton;
                        /*0x30*/ UnityEngine.UI.Button _bottomButton;
                        /*0x38*/ UnityEngine.UI.Text _bottomButtonText;
                        /*0x40*/ UnityEngine.UI.RawImage _productIcon;
                        /*0x48*/ UnityEngine.Texture2D _defaultIcon;
                        /*0x50*/ DMM.Games.Util.DialogCanvasController _canvasController;
                        /*0x58*/ UnityEngine.UI.Text _productTitle;
                        /*0x60*/ UnityEngine.GameObject _specialObject;
                        /*0x68*/ UnityEngine.UI.Text _special;
                        /*0x70*/ UnityEngine.UI.Text _nextTime;
                        /*0x78*/ UnityEngine.UI.Text _productPoint;
                        /*0x80*/ UnityEngine.UI.Text _availablePoint;
                        /*0x88*/ UnityEngine.UI.Text _payMethod;
                        /*0x90*/ UnityEngine.UI.Button _termOfPayment;
                        /*0x98*/ UnityEngine.UI.Button _termOfDelivery;
                        /*0xa0*/ UnityEngine.UI.Button _returnPolicy;
                        /*0xa8*/ UnityEngine.UI.Button _commercialLaw;
                        /*0xb0*/ UnityEngine.GameObject _pointShortage;
                        /*0xb8*/ UnityEngine.UI.Text _infoViewText;
                        /*0xc0*/ Dmm.Games.Unity.Purchasing.DeveloperPayload _developerPayload;
                        /*0xc8*/ DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog.ShowOrderConfirmDialogState _state;
                        /*0xd0*/ UnityEngine.UI.Image _logo;
                        /*0xd8*/ UnityEngine.UI.Button _cancelButton;

                        static /*0x3f96d60*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, string payload, string payMethod, long availablePoint, bool hasFreeTime, string freeTime, DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog.ShowOrderConfirmDialogState state, string displayPrice, string nextBillingDay, UnityEngine.Events.UnityAction onClickChangeMethodText, UnityEngine.Events.UnityAction onClickMiddleButton, UnityEngine.Events.UnityAction onClickBottomButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f97c84*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, string payload, string payMethod, long availablePoint, bool hasFreeTime, string freeTime, DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog.ShowOrderConfirmDialogState state, string displayPrice, string nextBillingDay, UnityEngine.Events.UnityAction onClickChangeMethodText, UnityEngine.Events.UnityAction onClickMiddleButton, UnityEngine.Events.UnityAction onClickBottomButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f97d8c*/ void Hide();
                        /*0x3f980e0*/ ShowOrderConfirmDialog();
                        /*0x3f97460*/ void SetButtonAction(UnityEngine.Events.UnityAction onClickChangeMethodText, UnityEngine.Events.UnityAction onClickMiddleButton, UnityEngine.Events.UnityAction onClickBottomButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        /*0x3f97f94*/ void SetBottomButtonText(string text);
                        /*0x3f97560*/ void SetShortageActive(DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog.ShowOrderConfirmDialogState state);
                        /*0x3f97744*/ void SetDeveloperPayloadAction(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string json);
                        /*0x3f97314*/ void SetProductTitle(string title);
                        /*0x3f97fc0*/ void SetProductPoint(long point);
                        /*0x3f976c4*/ void SetAvailablePoint(long point);
                        /*0x3f97ff0*/ string CommaFormat(long number);
                        /*0x3f97338*/ void SetProductIcon(UnityEngine.Texture2D icon);
                        /*0x3f980d8*/ void SetState(DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog.ShowOrderConfirmDialogState state);
                        /*0x3f973cc*/ void SetLogo(UnityEngine.Sprite logo);
                        /*0x3f97edc*/ void LogoDestroy();

                        enum ShowOrderConfirmDialogState
                        {
                            Confirm = 0,
                            LessPoint = 1,
                            CreditFail = 2,
                        }

                        class <>c__DisplayClass38_0
                        {
                            /*0x10*/ DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog <>4__this;
                            /*0x18*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore store;

                            /*0x3f97fb8*/ <>c__DisplayClass38_0();
                            /*0x3f980e8*/ void <SetDeveloperPayloadAction>b__0();
                            /*0x3f98160*/ void <SetDeveloperPayloadAction>b__1();
                            /*0x3f981d8*/ void <SetDeveloperPayloadAction>b__2();
                            /*0x3f98250*/ void <SetDeveloperPayloadAction>b__3();
                        }
                    }

                    class ShowRetryDialog : UnityEngine.MonoBehaviour
                    {
                        static string Path = "DMM/Subscription/ShowRetryDialog";
                        static /*0x0*/ UnityEngine.GameObject _dialog;
                        static /*0x8*/ DMM.Games.Recibo.Ui.Subscription.ShowRetryDialog _instance;
                        /*0x20*/ UnityEngine.UI.Button _retryButton;
                        /*0x28*/ UnityEngine.UI.Button _cancelButton;
                        /*0x30*/ DMM.Games.Util.DialogCanvasController _canvasController;
                        /*0x38*/ UnityEngine.UI.Image _logo;

                        static /*0x3f9826c*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Events.UnityAction onClickRetryButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f8ac7c*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Events.UnityAction onClickRetryButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f8b45c*/ void Hide();
                        /*0x3f98558*/ ShowRetryDialog();
                        /*0x3f984c4*/ void SetLogo(UnityEngine.Sprite logo);
                    }

                    class ShowSelectOrderMethodDialog : UnityEngine.MonoBehaviour
                    {
                        static string Path = "DMM/Subscription/ShowSelectOrderMethodDialog";
                        static /*0x0*/ UnityEngine.GameObject _dialog;
                        static /*0x8*/ DMM.Games.Recibo.Ui.Subscription.ShowSelectOrderMethodDialog _instance;
                        /*0x20*/ UnityEngine.UI.Button _pointButton;
                        /*0x28*/ UnityEngine.UI.Button _cardButton;
                        /*0x30*/ UnityEngine.UI.Text _cardButtonText;
                        /*0x38*/ UnityEngine.UI.RawImage _productIcon;
                        /*0x40*/ UnityEngine.Texture2D _defaultIcon;
                        /*0x48*/ UnityEngine.UI.Text _productTitle;
                        /*0x50*/ bool _isCardRegistered;
                        /*0x58*/ UnityEngine.UI.Image _logo;
                        /*0x60*/ DMM.Games.Util.DialogCanvasController _canvasController;
                        /*0x68*/ UnityEngine.UI.Button _cancelButton;

                        static /*0x3f98560*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, bool isCardRegistered, UnityEngine.Events.UnityAction onClickCardButton, UnityEngine.Events.UnityAction onClickPointButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f98adc*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, bool isCardRegistered, UnityEngine.Events.UnityAction onClickCardButton, UnityEngine.Events.UnityAction onClickPointButto, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f98b90*/ void Hide();
                        /*0x3f98ccc*/ ShowSelectOrderMethodDialog();
                        /*0x3f98990*/ void SetProductTitle(string title);
                        /*0x3f989b4*/ void SetProductIcon(UnityEngine.Texture2D icon);
                        /*0x3f98910*/ void SetCardButtonTitle();
                        /*0x3f98a48*/ void SetLogo(UnityEngine.Sprite logo);
                    }

                    class ShowTypicalErrorDialog : UnityEngine.MonoBehaviour
                    {
                        static string Path = "DMM/Subscription/ShowTypicalErrorDialog";
                        static string ErrorToUrl = "https://support.dmm.com/form/16";
                        static /*0x0*/ UnityEngine.GameObject _dialog;
                        static /*0x8*/ DMM.Games.Recibo.Ui.Subscription.ShowTypicalErrorDialog _instance;
                        /*0x20*/ UnityEngine.UI.Text _errorText;
                        /*0x28*/ UnityEngine.UI.Text _errorCodeText;
                        /*0x30*/ UnityEngine.UI.Button _errorToButton;
                        /*0x38*/ UnityEngine.GameObject _cancelError;
                        /*0x40*/ UnityEngine.UI.Button _commercialLaw;
                        /*0x48*/ UnityEngine.UI.Button _cancelButton;
                        /*0x50*/ UnityEngine.UI.Image _logo;
                        /*0x58*/ DMM.Games.Util.DialogCanvasController _canvasController;

                        static /*0x3f98cd4*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string errorText, bool isCommercial, string errorCode, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f8abd0*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string errorText, bool isCommercial, string errorCode, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f8bed4*/ void Hide();
                        /*0x3f992b4*/ ShowTypicalErrorDialog();
                        /*0x3f99290*/ void SetErrorText(string errorText);
                        /*0x3f99214*/ void SetErrorCode(string errorCode);
                        /*0x3f99180*/ void SetLogo(UnityEngine.Sprite logo);

                        class <>c
                        {
                            static /*0x0*/ DMM.Games.Recibo.Ui.Subscription.ShowTypicalErrorDialog.<> <>9;
                            static /*0x8*/ UnityEngine.Events.UnityAction <>9__12_0;

                            static /*0x3f992bc*/ <>c();
                            /*0x3f99324*/ <>c();
                            /*0x3f9932c*/ void <Init>b__12_0();
                        }

                        class <>c__DisplayClass12_0
                        {
                            /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore store;

                            /*0x3f99178*/ <>c__DisplayClass12_0();
                            /*0x3f99394*/ void <Init>b__1();
                        }
                    }

                    class SubscriptionProcess : DMM.Games.Recibo.Ui.SingletonComponent<DMM.Games.Recibo.Ui.Subscription.SubscriptionProcess>
                    {
                        static string PayTypeCredit = "credit";
                        static string PayTypeRecheckCredit = "recheck_credit";
                        static string PayTypePoint = "dmmpoint";
                        /*0x20*/ DMM.Games.Recibo.Ui.Subscription.SubscriptionState _state;
                        /*0x28*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore _store;
                        /*0x30*/ UnityEngine.Purchasing.ProductDefinition _product;
                        /*0x38*/ System.Nullable<DMM.Games.Recibo.Api.Model.PointBalanceModel> _pointBalance;
                        /*0x48*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem _inventoryItem;
                        /*0x50*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel _receipt;
                        /*0x58*/ DMM.Games.Recibo.Ui.ErrorObject _error;
                        /*0x60*/ System.Action<DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel> _successAction;
                        /*0x68*/ System.Action<DMM.Games.Recibo.Ui.ErrorObject> _errorAction;
                        /*0x70*/ string _payType;
                        /*0x78*/ string _developerPayload;
                        /*0x80*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderModel _orderModel;

                        /*0x3f9b3a4*/ SubscriptionProcess();
                        /*0x3f993b0*/ void Execution(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Purchasing.ProductDefinition product, string developerPayload, System.Action<DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel> successAction, System.Action<DMM.Games.Recibo.Ui.ErrorObject> errorAction);
                        /*0x3f994cc*/ void Update();
                        /*0x3f99580*/ void InitSdkState();
                        /*0x3f9966c*/ void CreateOrderState();
                        /*0x3f99974*/ void ReCheckCreditState();
                        /*0x3f99db4*/ void CheckCreditState();
                        /*0x3f99f5c*/ void CheckPointBalanceState();
                        /*0x3f9a104*/ void PurchasingState();
                        /*0x3f9a2d4*/ void CancelState();
                        /*0x3f9ac50*/ void ErrorTransition(DMM.Games.Recibo.Ui.ErrorObject error);
                        /*0x3f9a6f0*/ void FinishState();
                        /*0x3f9a4f4*/ void ChangePaymentMethodState();
                        /*0x3f9a908*/ DMM.Games.Recibo.Ui.Subscription.SubscriptionProcess.SubscriptionItemInfo GetSubscriptionItemInfo(DMM.Games.Recibo.Api.Version2.Product.Model.SubscriptionsOffer offer, DMM.Games.Recibo.Api.Version2.Order.Model.OrderModel orderModel);
                        /*0x3f9a7e4*/ DMM.Games.Recibo.Ui.ErrorObject GetErrorObject(int code, string message);
                        /*0x3f9ac58*/ void ShowErrorResponse(string body, int localCode, long statusCode, string message);
                        /*0x3f9b344*/ long GetAvailablePoint();
                        /*0x3f9b39c*/ void SetState(DMM.Games.Recibo.Ui.Subscription.SubscriptionState state);
                        /*0x3f9b3ec*/ void <CreateOrderState>b__19_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderResponseModel response);
                        /*0x3f9b470*/ void <CreateOrderState>b__19_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f9b4c8*/ void <CreateOrderState>b__19_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f9b58c*/ void <CreateOrderState>b__19_3();
                        /*0x3f9b598*/ void <CreateOrderState>b__19_4();
                        /*0x3f9b5a4*/ void <CheckCreditState>b__21_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Credit.Model.CheckCreditAvaliaResponseModel response);
                        /*0x3f9b778*/ void <CheckCreditState>b__21_3();
                        /*0x3f9b7d4*/ void <CheckCreditState>b__21_4();
                        /*0x3f9b830*/ void <CheckCreditState>b__21_5();
                        /*0x3f9b83c*/ void <CheckCreditState>b__21_6();
                        /*0x3f9b974*/ void <CheckCreditState>b__21_9();
                        /*0x3f9b9d0*/ void <CheckCreditState>b__21_10();
                        /*0x3f9b9ec*/ void <CheckCreditState>b__21_7();
                        /*0x3f9ba48*/ void <CheckCreditState>b__21_8();
                        /*0x3f9ba54*/ void <CheckCreditState>b__21_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f9ba68*/ void <CheckCreditState>b__21_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f9bb28*/ void <CheckCreditState>b__21_11();
                        /*0x3f9bb34*/ void <CheckCreditState>b__21_12();
                        /*0x3f9bb40*/ void <CheckPointBalanceState>b__22_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Model.PointBalanceModel response);
                        /*0x3f9bf40*/ void <CheckPointBalanceState>b__22_3();
                        /*0x3f9bf5c*/ void <CheckPointBalanceState>b__22_5();
                        /*0x3f9bf78*/ void <CheckPointBalanceState>b__22_6();
                        /*0x3f9bf84*/ void <CheckPointBalanceState>b__22_7();
                        /*0x3f9bfa0*/ void <CheckPointBalanceState>b__22_9();
                        /*0x3f9c0d8*/ void <CheckPointBalanceState>b__22_11();
                        /*0x3f9c0e4*/ void <CheckPointBalanceState>b__22_12();
                        /*0x3f9c0f0*/ void <CheckPointBalanceState>b__22_10();
                        /*0x3f9c0fc*/ void <CheckPointBalanceState>b__22_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f9c110*/ void <CheckPointBalanceState>b__22_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f9c1d4*/ void <CheckPointBalanceState>b__22_13();
                        /*0x3f9c1e0*/ void <CheckPointBalanceState>b__22_14();
                        /*0x3f9c1ec*/ void <PurchasingState>b__23_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Receipt.Model.CreateReceiptResponseModel response);
                        /*0x3f9c388*/ void <PurchasingState>b__23_3();
                        /*0x3f9c394*/ void <PurchasingState>b__23_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f9c3a8*/ void <PurchasingState>b__23_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f9c46c*/ void <PurchasingState>b__23_4();
                        /*0x3f9c478*/ void <PurchasingState>b__23_5();
                        /*0x3f9c484*/ void <CancelState>b__24_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.BaseResultModel response);
                        /*0x3f9c4ac*/ void <CancelState>b__24_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f9c4d4*/ void <CancelState>b__24_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f9c4fc*/ void <ChangePaymentMethodState>b__27_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.BaseResultModel response);
                        /*0x3f9c524*/ void <ChangePaymentMethodState>b__27_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f9c54c*/ void <ChangePaymentMethodState>b__27_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);

                        class SubscriptionItemInfo
                        {
                            /*0x10*/ bool hasFreeTime;
                            /*0x18*/ string freeTime;
                            /*0x20*/ int price;
                            /*0x28*/ string displayPrice;
                            /*0x30*/ string nextBillingDay;

                            /*0x3f9c574*/ SubscriptionItemInfo();
                        }

                        class <>c
                        {
                            static /*0x0*/ DMM.Games.Recibo.Ui.Subscription.SubscriptionProcess.<> <>9;
                            static /*0x8*/ UnityEngine.Events.UnityAction <>9__20_1;
                            static /*0x10*/ UnityEngine.Events.UnityAction <>9__20_8;
                            static /*0x18*/ UnityEngine.Events.UnityAction <>9__22_4;
                            static /*0x20*/ UnityEngine.Events.UnityAction <>9__22_8;

                            static /*0x3f9c57c*/ <>c();
                            /*0x3f9c5e4*/ <>c();
                            /*0x3f9c5ec*/ void <ReCheckCreditState>b__20_1();
                            /*0x3f9c5f0*/ void <ReCheckCreditState>b__20_8();
                            /*0x3f9c5f4*/ void <CheckPointBalanceState>b__22_4();
                            /*0x3f9c5f8*/ void <CheckPointBalanceState>b__22_8();
                        }

                        class <>c__DisplayClass20_0
                        {
                            /*0x10*/ DMM.Games.Recibo.Ui.Subscription.SubscriptionProcess <>4__this;
                            /*0x18*/ DMM.Games.Recibo.Ui.Subscription.SubscriptionProcess.SubscriptionItemInfo item;
                            /*0x20*/ UnityEngine.Events.UnityAction <>9__7;
                            /*0x28*/ UnityEngine.Events.UnityAction <>9__11;
                            /*0x30*/ UnityEngine.Events.UnityAction <>9__12;
                            /*0x38*/ UnityEngine.Events.UnityAction <>9__9;
                            /*0x40*/ UnityEngine.Events.UnityAction <>9__10;
                            /*0x48*/ UnityEngine.Events.UnityAction <>9__13;
                            /*0x50*/ UnityEngine.Events.UnityAction <>9__14;

                            /*0x3f9c5fc*/ <>c__DisplayClass20_0();
                            /*0x3f9c604*/ void <ReCheckCreditState>b__0();
                            /*0x3f9c630*/ void <ReCheckCreditState>b__2();
                            /*0x3f9c65c*/ void <ReCheckCreditState>b__3();
                            /*0x3f9c680*/ void <ReCheckCreditState>b__4(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Credit.Model.CheckCreditAvaliaResponseModel response);
                            /*0x3f9c964*/ void <ReCheckCreditState>b__7();
                            /*0x3f9c990*/ void <ReCheckCreditState>b__9();
                            /*0x3f9cb40*/ void <ReCheckCreditState>b__11();
                            /*0x3f9cb64*/ void <ReCheckCreditState>b__12();
                            /*0x3f9cb88*/ void <ReCheckCreditState>b__10();
                            /*0x3f9cbac*/ void <ReCheckCreditState>b__5(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                            /*0x3f9cbd8*/ void <ReCheckCreditState>b__6(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                            /*0x3f9ccf0*/ void <ReCheckCreditState>b__13();
                            /*0x3f9cd10*/ void <ReCheckCreditState>b__14();
                        }

                        class <>c__DisplayClass30_0
                        {
                            /*0x10*/ DMM.Games.Recibo.Ui.Subscription.SubscriptionProcess <>4__this;
                            /*0x18*/ DMM.Games.Recibo.Ui.ErrorObject e;
                            /*0x20*/ int localCode;
                            /*0x28*/ string body;

                            /*0x3f9cd34*/ <>c__DisplayClass30_0();
                            /*0x3f9cd3c*/ void <ShowErrorResponse>b__0();
                            /*0x3f9cd5c*/ void <ShowErrorResponse>b__1();
                            /*0x3f9ce60*/ void <ShowErrorResponse>b__9();
                            /*0x3f9ceb4*/ void <ShowErrorResponse>b__10();
                            /*0x3f9cf08*/ void <ShowErrorResponse>b__2();
                            /*0x3f9cf34*/ void <ShowErrorResponse>b__3();
                            /*0x3f9cf60*/ void <ShowErrorResponse>b__4();
                            /*0x3f9cf8c*/ void <ShowErrorResponse>b__5();
                            /*0x3f9cfb8*/ void <ShowErrorResponse>b__6();
                            /*0x3f9cfe4*/ void <ShowErrorResponse>b__7();
                            /*0x3f9d010*/ void <ShowErrorResponse>b__8();
                        }
                    }

                    enum SubscriptionState
                    {
                        None = 0,
                        InitSdk = 1,
                        ShowLoading = 2,
                        CheckCredit = 3,
                        ReCheckCredit = 4,
                        SetCreditContinue = 5,
                        ChargePointContinue = 6,
                        CreditRegister = 7,
                        ShowSelectMethod = 8,
                        ChangePayMethod = 9,
                        CheckError = 10,
                        ShowErrorDialog = 11,
                        ShowRetryDialog = 12,
                        CheckOderPurchased = 13,
                        CreateOrder = 14,
                        GetBalance = 15,
                        CheckPointBalance = 16,
                        ShowConfirmDialog = 17,
                        LessBlance = 18,
                        Cancel = 19,
                        Purchasing = 20,
                        Complete = 21,
                        Finish = 22,
                    }
                }
            }

            namespace Api
            {
                class ReciboApi<T>
                {
                    static /*0x0*/ string BS_DOMAIN;
                    static /*0x0*/ string BS_SBX_DOMAIN;
                    static /*0x0*/ string AE_DOMAIN;
                    static /*0x0*/ string AE_SBX_DOMAIN;
                    static /*0x0*/ string HEADER_KEY_OPEN_ID;
                    static /*0x0*/ string HEADER_KEY_ACCESS_TOKEN;
                    static /*0x0*/ string HEADER_KEY_API_KEY;
                    /*0x0*/ string _openId;
                    /*0x0*/ string _accessToken;
                    /*0x0*/ string _apiToken;
                    /*0x0*/ bool _isSandbox;
                    /*0x0*/ DMM.Games.Net.IHttpClient _client;

                    static /*0x383e7a0*/ ReciboApi();
                    ReciboApi(string apiToken, string openId, string accessToken, bool isSandbox);
                    /*0x38148bc*/ string GetEndpoint();
                    /*0x38148bc*/ DMM.Games.Net.Method GetMethod();
                    /*0x3910ae8*/ T ParseResponse(string responseBody);
                    /*0x38148bc*/ string GetAdditionalQuery();
                    /*0x38148bc*/ string GetRequestBody();
                    /*0x38148bc*/ string GetDomain();
                    /*0x38148bc*/ string GetAEDomain();
                    /*0x38148bc*/ string GetBSDomain();
                    /*0x38148bc*/ string GetScheme();
                    /*0x3816958*/ void Request(DMM.Games.Recibo.Api.ReciboApi.OnSuccessCallback<T> onSuccess, DMM.Games.Recibo.Api.ReciboApi.OnFalureCallback<T> onFailure, DMM.Games.Recibo.Api.ReciboApi.OnNetworkErrorCallback<T> onNetworkError, object tag);
                    /*0x38148bc*/ string BuildUrl();
                    /*0x38148bc*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> BuildRequestHeaders();

                    class OnSuccessCallback<T> : System.MulticastDelegate
                    {
                        OnSuccessCallback(object object, nint method);
                        /*0x3910ae8*/ void Invoke(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, T responseData);
                        /*0x3910ae8*/ System.IAsyncResult BeginInvoke(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, T responseData, System.AsyncCallback callback, object object);
                        /*0x3816710*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class OnFalureCallback<T> : System.MulticastDelegate
                    {
                        OnFalureCallback(object object, nint method);
                        void Invoke(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string responseBody);
                        /*0x3910ae8*/ System.IAsyncResult BeginInvoke(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string responseBody, System.AsyncCallback callback, object object);
                        /*0x3816710*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class OnNetworkErrorCallback<T> : System.MulticastDelegate
                    {
                        OnNetworkErrorCallback(object object, nint method);
                        void Invoke(object tag, DMM.Games.Net.NetworkErrorKind kind, System.Exception exception);
                        System.IAsyncResult BeginInvoke(object tag, DMM.Games.Net.NetworkErrorKind kind, System.Exception exception, System.AsyncCallback callback, object object);
                        /*0x3816710*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class <>c__DisplayClass25_0<T>
                    {
                        /*0x0*/ DMM.Games.Recibo.Api.ReciboApi.OnSuccessCallback<T> onSuccess;
                        /*0x0*/ DMM.Games.Recibo.Api.ReciboApi<T> <>4__this;
                        /*0x0*/ DMM.Games.Recibo.Api.ReciboApi.OnFalureCallback<T> onFailure;
                        /*0x0*/ DMM.Games.Recibo.Api.ReciboApi.OnNetworkErrorCallback<T> onNetworkError;

                        /*0x38159dc*/ <>c__DisplayClass25_0();
                        void <Request>b__0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string body);
                        void <Request>b__1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string body);
                        void <Request>b__2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }
                }

                namespace Version2
                {
                    class BaseResultModel
                    {
                        /*0x10*/ int <Status>k__BackingField;
                        /*0x18*/ string <Message>k__BackingField;
                        /*0x20*/ DMM.Games.Recibo.Api.Version2.ErrorModel <Error>k__BackingField;

                        static /*0x3f9d09c*/ DMM.Games.Recibo.Api.Version2.BaseResultModel CreateInstance(string response);
                        /*0x3f9d160*/ BaseResultModel();
                        /*0x3f9d03c*/ int get_Status();
                        /*0x3f9d044*/ void set_Status(int value);
                        /*0x3f9d04c*/ string get_Message();
                        /*0x3f9d054*/ void set_Message(string value);
                        /*0x3f9d05c*/ DMM.Games.Recibo.Api.Version2.ErrorModel get_Error();
                        /*0x3f9d064*/ void set_Error(DMM.Games.Recibo.Api.Version2.ErrorModel value);
                        /*0x3f9d06c*/ bool get_IsErrorOccurred();
                    }

                    class ErrorModel
                    {
                        /*0x10*/ string <ErrorCode>k__BackingField;
                        /*0x18*/ string <ErrorMessage>k__BackingField;
                        /*0x20*/ DMM.Games.Recibo.Api.Version2.ValidationErrorModel[] <ValidationErrors>k__BackingField;

                        /*0x3f9d198*/ ErrorModel();
                        /*0x3f9d168*/ string get_ErrorCode();
                        /*0x3f9d170*/ void set_ErrorCode(string value);
                        /*0x3f9d178*/ string get_ErrorMessage();
                        /*0x3f9d180*/ void set_ErrorMessage(string value);
                        /*0x3f9d188*/ DMM.Games.Recibo.Api.Version2.ValidationErrorModel[] get_ValidationErrors();
                        /*0x3f9d190*/ void set_ValidationErrors(DMM.Games.Recibo.Api.Version2.ValidationErrorModel[] value);
                        /*0x3f9d08c*/ bool get_IsErrorOccurred();
                    }

                    class ValidationErrorModel
                    {
                        /*0x10*/ string <FieldName>k__BackingField;
                        /*0x18*/ string <ValidationCode>k__BackingField;

                        /*0x3f9d1c0*/ ValidationErrorModel();
                        /*0x3f9d1a0*/ string get_FieldName();
                        /*0x3f9d1a8*/ void set_FieldName(string value);
                        /*0x3f9d1b0*/ string get_ValidationCode();
                        /*0x3f9d1b8*/ void set_ValidationCode(string value);
                    }

                    namespace Sdk
                    {
                        class InitializeSdk : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Sdk.Model.InitializeSdkResponseModel>
                        {
                            /*0x3f9d1c8*/ InitializeSdk(string apiToken, string openId, string accessToken, bool isSandbox);
                            /*0x3f9d264*/ string GetEndpoint();
                            /*0x3f9d2a4*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f9d2fc*/ DMM.Games.Recibo.Api.Version2.Sdk.Model.InitializeSdkResponseModel ParseResponse(string responseBody);
                        }

                        namespace Model
                        {
                            class InitializeSdkResponseModel
                            {
                                /*0x10*/ int <ApplicationId>k__BackingField;
                                /*0x14*/ int <GamesId>k__BackingField;
                                /*0x18*/ string <GamesIdSignature>k__BackingField;
                                /*0x20*/ int <ViewerId>k__BackingField;
                                /*0x28*/ string <ViewerIdSignature>k__BackingField;
                                /*0x30*/ string <PointChargeUrl>k__BackingField;
                                /*0x38*/ string <CreditChangeUrl>k__BackingField;
                                /*0x40*/ bool <IsAdult>k__BackingField;
                                /*0x48*/ string <UserType>k__BackingField;

                                /*0x3f9d6c0*/ InitializeSdkResponseModel();
                                /*0x3f9d344*/ int get_ApplicationId();
                                /*0x3f9d34c*/ void set_ApplicationId(int value);
                                /*0x3f9d354*/ int get_GamesId();
                                /*0x3f9d35c*/ void set_GamesId(int value);
                                /*0x3f9d364*/ string get_GamesIdSignature();
                                /*0x3f9d36c*/ void set_GamesIdSignature(string value);
                                /*0x3f9d374*/ int get_ViewerId();
                                /*0x3f9d37c*/ void set_ViewerId(int value);
                                /*0x3f9d384*/ string get_ViewerIdSignature();
                                /*0x3f9d38c*/ void set_ViewerIdSignature(string value);
                                /*0x3f9d394*/ string get_PointChargeUrl();
                                /*0x3f9d39c*/ void set_PointChargeUrl(string value);
                                /*0x3f9d3a4*/ string get_CreditChangeUrl();
                                /*0x3f9d3ac*/ void set_CreditChangeUrl(string value);
                                /*0x3f9d3b4*/ bool get_IsAdult();
                                /*0x3f9d3bc*/ void set_IsAdult(bool value);
                                /*0x3f9d3c8*/ string get_UserType();
                                /*0x3f9d3d0*/ void set_UserType(string value);
                                /*0x3f9d3d8*/ string ToString();
                            }
                        }
                    }

                    namespace Receipt
                    {
                        class CreateReceipt : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Receipt.Model.CreateReceiptResponseModel>
                        {
                            /*0x38*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.CreateReceiptRequestModel requestModel;

                            /*0x3f9d6c8*/ CreateReceipt(string apiToken, string openId, string accessToken, string orderId, bool isSandbox, string locale);
                            /*0x3f9d7f4*/ string GetEndpoint();
                            /*0x3f9d834*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f9d88c*/ string GetRequestBody();
                            /*0x3f9dae4*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.CreateReceiptResponseModel ParseResponse(string responseBody);
                        }

                        class GetReceipt : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Receipt.Model.GetReceiptResponseModel>
                        {
                            /*0x38*/ string <Locale>k__BackingField;

                            /*0x3f9db3c*/ GetReceipt(string apiToken, string openId, string accessToken, bool isSandbox, string locale);
                            /*0x3f9db2c*/ string get_Locale();
                            /*0x3f9db34*/ void set_Locale(string value);
                            /*0x3f9dbf4*/ string GetEndpoint();
                            /*0x3f9dc34*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f9dc8c*/ string GetAdditionalQuery();
                            /*0x3f9dcd8*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.GetReceiptResponseModel ParseResponse(string responseBody);
                        }

                        namespace Model
                        {
                            class CreateReceiptRequestModel
                            {
                                /*0x10*/ string <OrderId>k__BackingField;
                                /*0x18*/ string <Locale>k__BackingField;

                                /*0x3f9d7b0*/ CreateReceiptRequestModel(string orderId, string locale);
                                /*0x3f9dd20*/ string get_OrderId();
                                /*0x3f9dd28*/ void set_OrderId(string value);
                                /*0x3f9dd30*/ string get_Locale();
                                /*0x3f9dd38*/ void set_Locale(string value);
                            }

                            class CreateReceiptResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel <Body>k__BackingField;

                                /*0x3f9dd50*/ CreateReceiptResponseModel();
                                /*0x3f9dd40*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel get_Body();
                                /*0x3f9dd48*/ void set_Body(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel value);
                            }

                            class GetReceiptResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList <Body>k__BackingField;

                                /*0x3f9dd68*/ GetReceiptResponseModel();
                                /*0x3f9dd58*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList get_Body();
                                /*0x3f9dd60*/ void set_Body(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList value);
                            }

                            class ProductId
                            {
                                /*0x10*/ string <Id>k__BackingField;

                                /*0x3f9dd80*/ ProductId();
                                /*0x3f9dd70*/ string get_Id();
                                /*0x3f9dd78*/ void set_Id(string value);
                            }

                            class ReceiptList
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel[] <Receipts>k__BackingField;

                                /*0x3f9de64*/ ReceiptList();
                                /*0x3f9dd88*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel[] get_Receipts();
                                /*0x3f9dd90*/ void set_Receipts(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel[] value);
                                /*0x3f9dd98*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel FindReceiptFromProductId(string productId);
                            }

                            class ReceiptModel
                            {
                                /*0x10*/ int <PurchaseTime>k__BackingField;
                                /*0x14*/ int <PurchaseState>k__BackingField;
                                /*0x18*/ string <DeveloperPayload>k__BackingField;
                                /*0x20*/ string <OrderId>k__BackingField;
                                /*0x28*/ string <OriginalJson>k__BackingField;
                                /*0x30*/ string <PurchaseToken>k__BackingField;
                                /*0x38*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ProductId[] <Products>k__BackingField;
                                /*0x40*/ int <Quantity>k__BackingField;
                                /*0x48*/ string <Signature>k__BackingField;
                                /*0x50*/ bool <IsAcknowledged>k__BackingField;
                                /*0x51*/ bool <IsAutoRenewing>k__BackingField;
                                /*0x58*/ long <NextBillingTime>k__BackingField;
                                /*0x60*/ bool <WithoutFirstPayment>k__BackingField;

                                /*0x3f9df48*/ ReceiptModel();
                                /*0x3f9de6c*/ int get_PurchaseTime();
                                /*0x3f9de74*/ void set_PurchaseTime(int value);
                                /*0x3f9de7c*/ int get_PurchaseState();
                                /*0x3f9de84*/ void set_PurchaseState(int value);
                                /*0x3f9de8c*/ string get_DeveloperPayload();
                                /*0x3f9de94*/ void set_DeveloperPayload(string value);
                                /*0x3f9de9c*/ string get_OrderId();
                                /*0x3f9dea4*/ void set_OrderId(string value);
                                /*0x3f9deac*/ string get_OriginalJson();
                                /*0x3f9deb4*/ void set_OriginalJson(string value);
                                /*0x3f9debc*/ string get_PurchaseToken();
                                /*0x3f9dec4*/ void set_PurchaseToken(string value);
                                /*0x3f9decc*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ProductId[] get_Products();
                                /*0x3f9ded4*/ void set_Products(DMM.Games.Recibo.Api.Version2.Receipt.Model.ProductId[] value);
                                /*0x3f9dedc*/ int get_Quantity();
                                /*0x3f9dee4*/ void set_Quantity(int value);
                                /*0x3f9deec*/ string get_Signature();
                                /*0x3f9def4*/ void set_Signature(string value);
                                /*0x3f9defc*/ bool get_IsAcknowledged();
                                /*0x3f9df04*/ void set_IsAcknowledged(bool value);
                                /*0x3f9df10*/ bool get_IsAutoRenewing();
                                /*0x3f9df18*/ void set_IsAutoRenewing(bool value);
                                /*0x3f9df24*/ long get_NextBillingTime();
                                /*0x3f9df2c*/ void set_NextBillingTime(long value);
                                /*0x3f9df34*/ bool get_WithoutFirstPayment();
                                /*0x3f9df3c*/ void set_WithoutFirstPayment(bool value);
                                /*0x3f9de28*/ string get_ProductId();
                            }
                        }
                    }

                    namespace Product
                    {
                        class SearchProduct : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductResponseModel>
                        {
                            /*0x38*/ DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductRequestModel <RequestModel>k__BackingField;

                            /*0x3f9df60*/ SearchProduct(string apiToken, string openId, string accessToken, string locale, DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] products, bool isSandbox);
                            /*0x3f9df50*/ DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductRequestModel get_RequestModel();
                            /*0x3f9df58*/ void set_RequestModel(DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductRequestModel value);
                            /*0x3f9e08c*/ string GetRequestBody();
                            /*0x3f9e094*/ string GetEndpoint();
                            /*0x3f9e0d4*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f9e12c*/ DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductResponseModel ParseResponse(string responseBody);
                        }

                        namespace Model
                        {
                            class OneTimePurchaseOffer
                            {
                                /*0x10*/ string <FormattedPrice>k__BackingField;
                                /*0x18*/ long <PriceAmountMicros>k__BackingField;
                                /*0x20*/ string <PriceCurrencyCode>k__BackingField;

                                /*0x3f9e1a4*/ OneTimePurchaseOffer();
                                /*0x3f9e174*/ string get_FormattedPrice();
                                /*0x3f9e17c*/ void set_FormattedPrice(string value);
                                /*0x3f9e184*/ long get_PriceAmountMicros();
                                /*0x3f9e18c*/ void set_PriceAmountMicros(long value);
                                /*0x3f9e194*/ string get_PriceCurrencyCode();
                                /*0x3f9e19c*/ void set_PriceCurrencyCode(string value);
                            }

                            class PricingPhases
                            {
                                /*0x10*/ int <BillingCycleCount>k__BackingField;
                                /*0x18*/ string <BillingPeriod>k__BackingField;
                                /*0x20*/ string <FormattedPrice>k__BackingField;
                                /*0x28*/ long <PriceAmountMicros>k__BackingField;
                                /*0x30*/ string <PriceCurrencyCode>k__BackingField;
                                /*0x38*/ int <RecurrenceMode>k__BackingField;

                                /*0x3f9e230*/ PricingPhases();
                                /*0x3f9e1ac*/ int get_BillingCycleCount();
                                /*0x3f9e1b4*/ void set_BillingCycleCount(int value);
                                /*0x3f9e1bc*/ string get_BillingPeriod();
                                /*0x3f9e1c4*/ void set_BillingPeriod(string value);
                                /*0x3f9e1cc*/ string get_FormattedPrice();
                                /*0x3f9e1d4*/ void set_FormattedPrice(string value);
                                /*0x3f9e1dc*/ long get_PriceAmountMicros();
                                /*0x3f9e1e4*/ void set_PriceAmountMicros(long value);
                                /*0x3f9e1ec*/ string get_PriceCurrencyCode();
                                /*0x3f9e1f4*/ void set_PriceCurrencyCode(string value);
                                /*0x3f9e1fc*/ int get_RecurrenceMode();
                                /*0x3f9e204*/ void set_RecurrenceMode(int value);
                                /*0x3f9e20c*/ bool get_IsFirstTimeOffer();

                                enum Recurrence
                                {
                                    UNDEFINED = 0,
                                    INFINITE_RECURRING = 1,
                                    FINITE_RECURRING = 2,
                                    NON_RECURRING = 3,
                                }
                            }

                            class Product
                            {
                                /*0x10*/ string <Name>k__BackingField;
                                /*0x18*/ string <ProductId>k__BackingField;
                                /*0x20*/ string <ProductType>k__BackingField;
                                /*0x28*/ string <Title>k__BackingField;
                                /*0x30*/ string <Description>k__BackingField;
                                /*0x38*/ DMM.Games.Recibo.Api.Version2.Product.Model.OneTimePurchaseOffer <OneTimePurchaseOffer>k__BackingField;
                                /*0x40*/ DMM.Games.Recibo.Api.Version2.Product.Model.SubscriptionsOffer[] <SubscriptionsOffers>k__BackingField;

                                /*0x3f9e430*/ Product();
                                /*0x3f9e238*/ string get_Name();
                                /*0x3f9e240*/ void set_Name(string value);
                                /*0x3f9e248*/ string get_ProductId();
                                /*0x3f9e250*/ void set_ProductId(string value);
                                /*0x3f9e258*/ string get_ProductType();
                                /*0x3f9e260*/ void set_ProductType(string value);
                                /*0x3f9e268*/ string get_Title();
                                /*0x3f9e270*/ void set_Title(string value);
                                /*0x3f9e278*/ string get_Description();
                                /*0x3f9e280*/ void set_Description(string value);
                                /*0x3f9e288*/ DMM.Games.Recibo.Api.Version2.Product.Model.OneTimePurchaseOffer get_OneTimePurchaseOffer();
                                /*0x3f9e290*/ void set_OneTimePurchaseOffer(DMM.Games.Recibo.Api.Version2.Product.Model.OneTimePurchaseOffer value);
                                /*0x3f9e298*/ DMM.Games.Recibo.Api.Version2.Product.Model.SubscriptionsOffer[] get_SubscriptionsOffers();
                                /*0x3f9e2a0*/ void set_SubscriptionsOffers(DMM.Games.Recibo.Api.Version2.Product.Model.SubscriptionsOffer[] value);
                                /*0x3f9e2a8*/ DMM.Games.Recibo.Api.Version2.Product.Model.SubscriptionsOffer get_PrimarySubscriptionOffer();
                            }

                            class ProductList
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product[] <Products>k__BackingField;

                                /*0x3f9e4cc*/ ProductList();
                                /*0x3f9e438*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product[] get_Products();
                                /*0x3f9e440*/ void set_Products(DMM.Games.Recibo.Api.Version2.Product.Model.Product[] value);
                                /*0x3f9e448*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product FindProduct(string productId);
                            }

                            class ProductQuery
                            {
                                /*0x10*/ string <ProductId>k__BackingField;
                                /*0x18*/ string <ProductType>k__BackingField;

                                /*0x3f9e4f4*/ ProductQuery(string productId, string productType);
                                /*0x3f9e4d4*/ string get_ProductId();
                                /*0x3f9e4dc*/ void set_ProductId(string value);
                                /*0x3f9e4e4*/ string get_ProductType();
                                /*0x3f9e4ec*/ void set_ProductType(string value);
                            }

                            class SearchProductRequestModel
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] <Products>k__BackingField;
                                /*0x18*/ string <Locale>k__BackingField;

                                /*0x3f9e048*/ SearchProductRequestModel(DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] products, string locale);
                                /*0x3f9e538*/ DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] get_Products();
                                /*0x3f9e540*/ void set_Products(DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] value);
                                /*0x3f9e548*/ string get_Locale();
                                /*0x3f9e550*/ void set_Locale(string value);
                            }

                            class SearchProductResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Product.Model.ProductList <Body>k__BackingField;

                                /*0x3f9e568*/ SearchProductResponseModel();
                                /*0x3f9e558*/ DMM.Games.Recibo.Api.Version2.Product.Model.ProductList get_Body();
                                /*0x3f9e560*/ void set_Body(DMM.Games.Recibo.Api.Version2.Product.Model.ProductList value);
                            }

                            class SubscriptionsOffer
                            {
                                static /*0x0*/ string OFFER_TAG_FREE_TRIAL;
                                static /*0x8*/ string OFFER_TAG_SINGLE_PAYMENT;
                                /*0x10*/ string <BasePlanId>k__BackingField;
                                /*0x18*/ string <OfferId>k__BackingField;
                                /*0x20*/ string[] <OfferTags>k__BackingField;
                                /*0x28*/ string <OfferToken>k__BackingField;
                                /*0x30*/ DMM.Games.Recibo.Api.Version2.Product.Model.PricingPhases[] <PricingPhases>k__BackingField;

                                static /*0x3f9e77c*/ SubscriptionsOffer();
                                /*0x3f9e774*/ SubscriptionsOffer();
                                /*0x3f9e570*/ string get_BasePlanId();
                                /*0x3f9e578*/ void set_BasePlanId(string value);
                                /*0x3f9e580*/ string get_OfferId();
                                /*0x3f9e588*/ void set_OfferId(string value);
                                /*0x3f9e590*/ string[] get_OfferTags();
                                /*0x3f9e598*/ void set_OfferTags(string[] value);
                                /*0x3f9e5a0*/ string get_OfferToken();
                                /*0x3f9e5a8*/ void set_OfferToken(string value);
                                /*0x3f9e5b0*/ DMM.Games.Recibo.Api.Version2.Product.Model.PricingPhases[] get_PricingPhases();
                                /*0x3f9e5b8*/ void set_PricingPhases(DMM.Games.Recibo.Api.Version2.Product.Model.PricingPhases[] value);
                                /*0x3f9e344*/ bool get_IsFirstTimeOfferExists();
                                /*0x3f9e5c0*/ bool get_IsFreeTrialOfferExists();
                                /*0x3f9e690*/ DMM.Games.Recibo.Api.Version2.Product.Model.PricingPhases get_FirstTimeOfferPricingPhase();
                                /*0x3f9e708*/ DMM.Games.Recibo.Api.Version2.Product.Model.PricingPhases get_GeneralPricingPhases();
                            }
                        }
                    }

                    namespace Order
                    {
                        class CreateOrder : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderResponseModel>
                        {
                            /*0x38*/ DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderRequestModel <RequestModel>k__BackingField;

                            /*0x3f9e828*/ CreateOrder(string apiToken, string openId, string accessToken, DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderRequestModel requestModel, bool isSandbox);
                            /*0x3f9e818*/ DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderRequestModel get_RequestModel();
                            /*0x3f9e820*/ void set_RequestModel(DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderRequestModel value);
                            /*0x3f9e8e0*/ string GetRequestBody();
                            /*0x3f9e8e8*/ string GetEndpoint();
                            /*0x3f9e928*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f9e980*/ DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderResponseModel ParseResponse(string responseBody);
                        }

                        class DeleteOrder : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.BaseResultModel>
                        {
                            /*0x38*/ string <OrderId>k__BackingField;
                            /*0x40*/ string <Locale>k__BackingField;

                            /*0x3f9e9e8*/ DeleteOrder(string apiToken, string locale, string openId, string accessToken, string orderId, bool isSandbox);
                            /*0x3f9e9c8*/ string get_OrderId();
                            /*0x3f9e9d0*/ void set_OrderId(string value);
                            /*0x3f9e9d8*/ string get_Locale();
                            /*0x3f9e9e0*/ void set_Locale(string value);
                            /*0x3f9eab4*/ string GetEndpoint();
                            /*0x3f9eb34*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f9eb8c*/ DMM.Games.Recibo.Api.Version2.BaseResultModel ParseResponse(string responseBody);
                        }

                        namespace Model
                        {
                            class CreateOrderRequestModel
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] <Products>k__BackingField;

                                /*0x3f9ec04*/ CreateOrderRequestModel(DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] products);
                                /*0x3f9ebf4*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] get_Products();
                                /*0x3f9ebfc*/ void set_Products(DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] value);
                            }

                            class CreateOrderResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderModel <Body>k__BackingField;

                                /*0x3f9ec44*/ CreateOrderResponseModel();
                                /*0x3f9ec34*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderModel get_Body();
                                /*0x3f9ec3c*/ void set_Body(DMM.Games.Recibo.Api.Version2.Order.Model.OrderModel value);
                            }

                            class OrderModel
                            {
                                /*0x10*/ string <OrderId>k__BackingField;
                                /*0x18*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] <Products>k__BackingField;

                                /*0x3f9ec6c*/ OrderModel();
                                /*0x3f9ec4c*/ string get_OrderId();
                                /*0x3f9ec54*/ void set_OrderId(string value);
                                /*0x3f9ec5c*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] get_Products();
                                /*0x3f9ec64*/ void set_Products(DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] value);
                            }

                            class OrderProduct
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product <Product>k__BackingField;
                                /*0x18*/ string <OfferToken>k__BackingField;
                                /*0x20*/ string <PayType>k__BackingField;
                                /*0x28*/ string <DeveloperPayload>k__BackingField;
                                /*0x30*/ string <Locale>k__BackingField;
                                /*0x38*/ long <NextBillingTime>k__BackingField;

                                /*0x3f9ecd4*/ OrderProduct(DMM.Games.Recibo.Api.Version2.Product.Model.Product product, string offerToken, string payType, string developerPayload, string locale);
                                /*0x3f9ec74*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product get_Product();
                                /*0x3f9ec7c*/ void set_Product(DMM.Games.Recibo.Api.Version2.Product.Model.Product value);
                                /*0x3f9ec84*/ string get_OfferToken();
                                /*0x3f9ec8c*/ void set_OfferToken(string value);
                                /*0x3f9ec94*/ string get_PayType();
                                /*0x3f9ec9c*/ void set_PayType(string value);
                                /*0x3f9eca4*/ string get_DeveloperPayload();
                                /*0x3f9ecac*/ void set_DeveloperPayload(string value);
                                /*0x3f9ecb4*/ string get_Locale();
                                /*0x3f9ecbc*/ void set_Locale(string value);
                                /*0x3f9ecc4*/ long get_NextBillingTime();
                                /*0x3f9eccc*/ void set_NextBillingTime(long value);
                            }
                        }
                    }

                    namespace Credit
                    {
                        class CheckCreditAvailability : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Credit.Model.CheckCreditAvaliaResponseModel>
                        {
                            /*0x3f9ed64*/ CheckCreditAvailability(string apiToken, string openId, string accessToken, bool isSandbox);
                            /*0x3f9ee00*/ string GetEndpoint();
                            /*0x3f9ee40*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f9ee98*/ DMM.Games.Recibo.Api.Version2.Credit.Model.CheckCreditAvaliaResponseModel ParseResponse(string responseBody);
                        }

                        namespace Model
                        {
                            class CheckCreditAvaliaResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Credit.Model.HasCreditModel <Body>k__BackingField;

                                /*0x3f9eef0*/ CheckCreditAvaliaResponseModel();
                                /*0x3f9eee0*/ DMM.Games.Recibo.Api.Version2.Credit.Model.HasCreditModel get_Body();
                                /*0x3f9eee8*/ void set_Body(DMM.Games.Recibo.Api.Version2.Credit.Model.HasCreditModel value);
                            }

                            class HasCreditModel
                            {
                                /*0x10*/ bool <HasCredit>k__BackingField;

                                /*0x3f9ef0c*/ HasCreditModel();
                                /*0x3f9eef8*/ bool get_HasCredit();
                                /*0x3f9ef00*/ void set_HasCredit(bool value);
                            }
                        }
                    }
                }

                namespace UserInfo
                {
                    class GetUserInfo : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.UserInfo.UserInfoModel>
                    {
                        /*0x38*/ string <OnetimeToken>k__BackingField;

                        /*0x3f9ef24*/ GetUserInfo(bool isSandbox, string onetimeToken);
                        /*0x3f9ef14*/ string get_OnetimeToken();
                        /*0x3f9ef1c*/ void set_OnetimeToken(string value);
                        /*0x3f9efd4*/ string GetAdditionalQuery();
                        /*0x3f9f020*/ string GetEndpoint();
                        /*0x3f9f060*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f9f0b8*/ DMM.Games.Recibo.Api.UserInfo.UserInfoModel ParseResponse(string responseBody);
                    }

                    struct UserInfoModel
                    {
                        /*0x10*/ string <AccessToken>k__BackingField;
                        /*0x18*/ string <OpenId>k__BackingField;
                        /*0x20*/ string <SessionId>k__BackingField;
                        /*0x28*/ string <SecureId>k__BackingField;

                        /*0x3f9f124*/ string get_AccessToken();
                        /*0x3f9f12c*/ void set_AccessToken(string value);
                        /*0x3f9f134*/ string get_OpenId();
                        /*0x3f9f13c*/ void set_OpenId(string value);
                        /*0x3f9f144*/ string get_SessionId();
                        /*0x3f9f14c*/ void set_SessionId(string value);
                        /*0x3f9f154*/ string get_SecureId();
                        /*0x3f9f15c*/ void set_SecureId(string value);
                    }
                }

                namespace Model
                {
                    struct PointBalanceModel
                    {
                        /*0x10*/ long <PointBalance>k__BackingField;

                        /*0x3f9f164*/ long get_PointBalance();
                        /*0x3f9f16c*/ void set_PointBalance(long value);
                        /*0x3f9f174*/ string ToString();
                    }
                }

                namespace User
                {
                    class GetPointBalance : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Model.PointBalanceModel>
                    {
                        /*0x3f9f1ec*/ GetPointBalance(string apiToken, string openId, string accessToken, bool isSandbox);
                        /*0x3f9f288*/ string GetEndpoint();
                        /*0x3f9f2c8*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f9f320*/ DMM.Games.Recibo.Api.Model.PointBalanceModel ParseResponse(string responseBody);
                    }
                }

                namespace Receipt
                {
                    class CreateReceipt : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel>
                    {
                        /*0x38*/ DMM.Games.Recibo.Api.Receipt.Model.CreateRequestModel _requestModel;

                        /*0x3f9f368*/ CreateReceipt(string apiToken, string openId, string accessToken, string orderId, string couponId, string userDevice, bool isSandbox);
                        /*0x3f9f4a8*/ string GetRequestBody();
                        /*0x3f9f510*/ string GetEndpoint();
                        /*0x3f9f550*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f9f5a8*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel ParseResponse(string responseBody);
                    }

                    class DeleteReceipt : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel>
                    {
                        /*0x38*/ string _purchaseToken;

                        /*0x3f9f740*/ DeleteReceipt(string apiToken, string openId, string accessToken, string purchaseToken, bool isSandbox);
                        /*0x3f9f7f8*/ string GetAdditionalQuery();
                        /*0x3f9f844*/ string GetEndpoint();
                        /*0x3f9f884*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f9f8dc*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel ParseResponse(string responseBody);
                    }

                    class GetReceiptList : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Receipt.Model.ReceiptList>
                    {
                        /*0x3f9f97c*/ GetReceiptList(string apiToken, string openId, string accessToken, bool isSandbox);
                        /*0x3f9fa18*/ string GetEndpoint();
                        /*0x3f9fa58*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f9fab0*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptList ParseResponse(string responseBody);
                    }

                    namespace Model
                    {
                        struct PurchaseEventModel
                        {
                            /*0x10*/ string <Store>k__BackingField;
                            /*0x18*/ string <TransactionId>k__BackingField;
                            /*0x20*/ string <Payload>k__BackingField;

                            /*0x3f9fdf4*/ string get_Store();
                            /*0x3f9fdfc*/ void set_Store(string value);
                            /*0x3f9fe04*/ string get_TransactionId();
                            /*0x3f9fe0c*/ void set_TransactionId(string value);
                            /*0x3f9fe14*/ string get_Payload();
                            /*0x3f9fe1c*/ void set_Payload(string value);
                        }

                        struct CreateRequestModel
                        {
                            /*0x10*/ string <OrderId>k__BackingField;
                            /*0x18*/ string <CouponId>k__BackingField;
                            /*0x20*/ string <UserDevice>k__BackingField;

                            /*0x3f9f464*/ CreateRequestModel(string orderId, string couponId, string userDevice);
                            /*0x3f9fe24*/ string get_OrderId();
                            /*0x3f9fe2c*/ void set_OrderId(string value);
                            /*0x3f9fe34*/ string get_CouponId();
                            /*0x3f9fe3c*/ void set_CouponId(string value);
                            /*0x3f9fe44*/ string get_UserDevice();
                            /*0x3f9fe4c*/ void set_UserDevice(string value);
                        }

                        struct ReceiptInfo
                        {
                            /*0x10*/ string <PurchaseToken>k__BackingField;
                            /*0x18*/ string <OrderId>k__BackingField;
                            /*0x20*/ string <ProductId>k__BackingField;
                            /*0x28*/ string <Price>k__BackingField;
                            /*0x30*/ long <PriceAmountMicros>k__BackingField;
                            /*0x38*/ string <PriceCurrencyCode>k__BackingField;
                            /*0x40*/ int <Quantity>k__BackingField;
                            /*0x48*/ long <PurchaseTime>k__BackingField;
                            /*0x50*/ string <DeveloperPayload>k__BackingField;
                            /*0x58*/ string <CouponId>k__BackingField;
                            /*0x60*/ string <UserDevice>k__BackingField;
                            /*0x68*/ int <OrderPrice>k__BackingField;
                            /*0x6c*/ int <CouponDiscountAmount>k__BackingField;
                            /*0x70*/ int <BillingAmount>k__BackingField;

                            /*0x3f9fe54*/ string get_PurchaseToken();
                            /*0x3f9fe5c*/ void set_PurchaseToken(string value);
                            /*0x3f9fe64*/ string get_OrderId();
                            /*0x3f9fe6c*/ void set_OrderId(string value);
                            /*0x3f9fe74*/ string get_ProductId();
                            /*0x3f9fe7c*/ void set_ProductId(string value);
                            /*0x3f9fe84*/ string get_Price();
                            /*0x3f9fe8c*/ void set_Price(string value);
                            /*0x3f9fe94*/ long get_PriceAmountMicros();
                            /*0x3f9fe9c*/ void set_PriceAmountMicros(long value);
                            /*0x3f9fea4*/ string get_PriceCurrencyCode();
                            /*0x3f9feac*/ void set_PriceCurrencyCode(string value);
                            /*0x3f9feb4*/ int get_Quantity();
                            /*0x3f9febc*/ void set_Quantity(int value);
                            /*0x3f9fec4*/ long get_PurchaseTime();
                            /*0x3f9fecc*/ void set_PurchaseTime(long value);
                            /*0x3f9fed4*/ string get_DeveloperPayload();
                            /*0x3f9fedc*/ void set_DeveloperPayload(string value);
                            /*0x3f9fee4*/ string get_CouponId();
                            /*0x3f9feec*/ void set_CouponId(string value);
                            /*0x3f9fef4*/ string get_UserDevice();
                            /*0x3f9fefc*/ void set_UserDevice(string value);
                            /*0x3f9ff04*/ int get_OrderPrice();
                            /*0x3f9ff0c*/ void set_OrderPrice(int value);
                            /*0x3f9ff14*/ int get_CouponDiscountAmount();
                            /*0x3f9ff1c*/ void set_CouponDiscountAmount(int value);
                            /*0x3f9ff24*/ int get_BillingAmount();
                            /*0x3f9ff2c*/ void set_BillingAmount(int value);
                        }

                        struct ReceiptModel
                        {
                            /*0x10*/ string <InappPurchaseData>k__BackingField;
                            /*0x18*/ System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> <ReceiptInfo>k__BackingField;
                            /*0x88*/ string <InappDataSignature>k__BackingField;

                            /*0x3f9ff88*/ ReceiptModel(string inappPurchaseData, string inappDataSignature);
                            /*0x3f9ff34*/ string get_InappPurchaseData();
                            /*0x3f9ff3c*/ void set_InappPurchaseData(string value);
                            /*0x3f9ff44*/ System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> get_ReceiptInfo();
                            /*0x3f9ff54*/ void set_ReceiptInfo(System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> value);
                            /*0x3f9ff78*/ string get_InappDataSignature();
                            /*0x3f9ff80*/ void set_InappDataSignature(string value);
                            /*0x3f9f648*/ void ConstractReceiptInfo();
                        }

                        struct ReceiptList
                        {
                            /*0x10*/ System.Collections.Generic.List<string> <InappPurchaseDataList>k__BackingField;
                            /*0x18*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> <ReceiptInfoList>k__BackingField;
                            /*0x20*/ System.Collections.Generic.List<string> <InappDataSignatureList>k__BackingField;

                            /*0x3fa009c*/ System.Collections.Generic.List<string> get_InappPurchaseDataList();
                            /*0x3fa00a4*/ void set_InappPurchaseDataList(System.Collections.Generic.List<string> value);
                            /*0x3fa00ac*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> get_ReceiptInfoList();
                            /*0x3fa00b4*/ void set_ReceiptInfoList(System.Collections.Generic.List<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> value);
                            /*0x3fa00bc*/ System.Collections.Generic.List<string> get_InappDataSignatureList();
                            /*0x3fa00c4*/ void set_InappDataSignatureList(System.Collections.Generic.List<string> value);
                            /*0x3f9fb44*/ void ConstractReceiptInfoList();
                            /*0x3fa00cc*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel[] ConvertToReceiptModelArray();
                        }
                    }
                }

                namespace Orders
                {
                    class RankPointConfirm : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Orders.Model.OrdersModel>
                    {
                        /*0x38*/ DMM.Games.Recibo.Api.Orders.Model.RequestModel requestModel;

                        /*0x3fa022c*/ RankPointConfirm(string apiToken, string openId, string accessToken, long amount, bool isSandbox);
                        /*0x3fa02e4*/ string GetDomain();
                        /*0x3fa032c*/ string GetEndpoint();
                        /*0x3fa036c*/ DMM.Games.Net.Method GetMethod();
                        /*0x3fa03c4*/ string GetRequestBody();
                        /*0x3fa0424*/ DMM.Games.Recibo.Api.Orders.Model.OrdersModel ParseResponse(string responseBody);
                    }

                    namespace Model
                    {
                        struct RequestModel
                        {
                            /*0x10*/ long <Amount>k__BackingField;

                            /*0x3fa02dc*/ RequestModel(long amount);
                            /*0x3fa046c*/ long get_Amount();
                            /*0x3fa0474*/ void set_Amount(long value);
                        }

                        struct OrdersModel
                        {
                            /*0x10*/ DMM.Games.Recibo.Api.Orders.Model.GamesRank GamesRank;
                        }

                        class GamesRank
                        {
                            /*0x10*/ string CurrentRankName;
                            /*0x18*/ int GrantPoint;

                            /*0x3fa04fc*/ GamesRank();
                            /*0x3fa047c*/ string ToString();
                        }
                    }
                }

                namespace Product
                {
                    class GetProduct : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnitListModel>
                    {
                        /*0x38*/ DMM.Games.Recibo.Api.Product.Model.RequestModel _requestModel;

                        /*0x3fa0504*/ GetProduct(string apiToken, string locale, string[] productIds, bool isSandbox);
                        /*0x3fa0618*/ string GetRequestBody();
                        /*0x3fa0678*/ string GetEndpoint();
                        /*0x3fa06b8*/ DMM.Games.Net.Method GetMethod();
                        /*0x3fa0710*/ DMM.Games.Recibo.Api.Product.Model.StockKeepingUnitListModel ParseResponse(string responseBody);
                    }

                    namespace Model
                    {
                        struct RequestModel
                        {
                            /*0x10*/ string <Locale>k__BackingField;
                            /*0x18*/ string[] <ProductIds>k__BackingField;

                            /*0x3fa05e8*/ RequestModel(string locale, string[] productIds);
                            /*0x3fa0758*/ string get_Locale();
                            /*0x3fa0760*/ void set_Locale(string value);
                            /*0x3fa0768*/ string[] get_ProductIds();
                            /*0x3fa0770*/ void set_ProductIds(string[] value);
                        }

                        struct StockKeepingUnit
                        {
                            /*0x10*/ string <ProductId>k__BackingField;
                            /*0x18*/ string <Type>k__BackingField;
                            /*0x20*/ string <Title>k__BackingField;
                            /*0x28*/ string <Description>k__BackingField;
                            /*0x30*/ string <Price>k__BackingField;
                            /*0x38*/ long <PriceAmountMicros>k__BackingField;
                            /*0x40*/ string <PriceCurrencyCode>k__BackingField;

                            /*0x3fa0778*/ string get_ProductId();
                            /*0x3fa0780*/ void set_ProductId(string value);
                            /*0x3fa0788*/ string get_Type();
                            /*0x3fa0790*/ void set_Type(string value);
                            /*0x3fa0798*/ string get_Title();
                            /*0x3fa07a0*/ void set_Title(string value);
                            /*0x3fa07a8*/ string get_Description();
                            /*0x3fa07b0*/ void set_Description(string value);
                            /*0x3fa07b8*/ string get_Price();
                            /*0x3fa07c0*/ void set_Price(string value);
                            /*0x3fa07c8*/ long get_PriceAmountMicros();
                            /*0x3fa07d0*/ void set_PriceAmountMicros(long value);
                            /*0x3fa07d8*/ string get_PriceCurrencyCode();
                            /*0x3fa07e0*/ void set_PriceCurrencyCode(string value);
                            /*0x3fa07e8*/ string ToString();
                        }

                        struct StockKeepingUnitListModel
                        {
                            /*0x10*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> <Skus>k__BackingField;

                            /*0x3fa0a1c*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> get_Skus();
                            /*0x3fa0a24*/ void set_Skus(System.Collections.Generic.List<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> value);
                            /*0x3fa0a2c*/ string ToString();
                            /*0x3fa0bf0*/ System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> FindSku(string productId);
                        }
                    }
                }

                namespace Order
                {
                    class CancelOrder : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Order.Model.OrderModel>
                    {
                        /*0x38*/ string _orderId;

                        /*0x3fa0e2c*/ CancelOrder(string apiToken, string openId, string accessToken, string orderId, bool isSandbox);
                        /*0x3fa0ee4*/ string GetAdditionalQuery();
                        /*0x3fa0f30*/ string GetEndpoint();
                        /*0x3fa0f70*/ DMM.Games.Net.Method GetMethod();
                        /*0x3fa0fc8*/ DMM.Games.Recibo.Api.Order.Model.OrderModel ParseResponse(string responseBody);
                    }

                    class CreateOrder : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Order.Model.OrderModel>
                    {
                        /*0x38*/ DMM.Games.Recibo.Api.Order.Model.RequestModel requestModel;

                        /*0x3fa103c*/ CreateOrder(string apiToken, string openId, string accessToken, string locale, string productId, int quantity, string developerPayload, bool isSandbox);
                        /*0x3fa1190*/ string GetEndpoint();
                        /*0x3fa11d0*/ DMM.Games.Net.Method GetMethod();
                        /*0x3fa1228*/ DMM.Games.Recibo.Api.Order.Model.OrderModel ParseResponse(string responseBody);
                        /*0x3fa129c*/ string GetRequestBody();
                    }

                    namespace Model
                    {
                        struct RequestModel
                        {
                            /*0x10*/ string <Locale>k__BackingField;
                            /*0x18*/ string <ProductId>k__BackingField;
                            /*0x20*/ int <Quantity>k__BackingField;
                            /*0x28*/ string <DeveloperPayload>k__BackingField;

                            /*0x3fa113c*/ RequestModel(string locale, string productId, int quantity, string developerPayload);
                            /*0x3fa1300*/ string get_Locale();
                            /*0x3fa1308*/ void set_Locale(string value);
                            /*0x3fa1310*/ string get_ProductId();
                            /*0x3fa1318*/ void set_ProductId(string value);
                            /*0x3fa1320*/ int get_Quantity();
                            /*0x3fa1328*/ void set_Quantity(int value);
                            /*0x3fa1330*/ string get_DeveloperPayload();
                            /*0x3fa1338*/ void set_DeveloperPayload(string value);
                        }

                        struct OrderModel
                        {
                            /*0x10*/ string <OrderId>k__BackingField;
                            /*0x18*/ string <PurchaseId>k__BackingField;
                            /*0x20*/ string <Sku>k__BackingField;
                            /*0x28*/ string <Locale>k__BackingField;
                            /*0x30*/ string <Type>k__BackingField;
                            /*0x38*/ string <Title>k__BackingField;
                            /*0x40*/ string <Price>k__BackingField;
                            /*0x48*/ long <PriceAmountMicros>k__BackingField;
                            /*0x50*/ string <PriceCurrencyCode>k__BackingField;
                            /*0x58*/ int <Quantity>k__BackingField;
                            /*0x60*/ string <CreatedAt>k__BackingField;
                            /*0x68*/ string <UpdatedAt>k__BackingField;
                            /*0x70*/ string <DeveloperPayload>k__BackingField;
                            /*0x78*/ int <CouponCounts>k__BackingField;

                            /*0x3fa1340*/ string get_OrderId();
                            /*0x3fa1348*/ void set_OrderId(string value);
                            /*0x3fa1350*/ string get_PurchaseId();
                            /*0x3fa1358*/ void set_PurchaseId(string value);
                            /*0x3fa1360*/ string get_Sku();
                            /*0x3fa1368*/ void set_Sku(string value);
                            /*0x3fa1370*/ string get_Locale();
                            /*0x3fa1378*/ void set_Locale(string value);
                            /*0x3fa1380*/ string get_Type();
                            /*0x3fa1388*/ void set_Type(string value);
                            /*0x3fa1390*/ string get_Title();
                            /*0x3fa1398*/ void set_Title(string value);
                            /*0x3fa13a0*/ string get_Price();
                            /*0x3fa13a8*/ void set_Price(string value);
                            /*0x3fa13b0*/ long get_PriceAmountMicros();
                            /*0x3fa13b8*/ void set_PriceAmountMicros(long value);
                            /*0x3fa13c0*/ string get_PriceCurrencyCode();
                            /*0x3fa13c8*/ void set_PriceCurrencyCode(string value);
                            /*0x3fa13d0*/ int get_Quantity();
                            /*0x3fa13d8*/ void set_Quantity(int value);
                            /*0x3fa13e0*/ string get_CreatedAt();
                            /*0x3fa13e8*/ void set_CreatedAt(string value);
                            /*0x3fa13f0*/ string get_UpdatedAt();
                            /*0x3fa13f8*/ void set_UpdatedAt(string value);
                            /*0x3fa1400*/ string get_DeveloperPayload();
                            /*0x3fa1408*/ void set_DeveloperPayload(string value);
                            /*0x3fa1410*/ int get_CouponCounts();
                            /*0x3fa1418*/ void set_CouponCounts(int value);
                            /*0x3fa1420*/ string ToString();
                        }
                    }
                }

                namespace Error
                {
                    namespace Model
                    {
                        class ErrorModel
                        {
                            /*0x10*/ DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain <Error>k__BackingField;

                            /*0x3fa181c*/ ErrorModel();
                            /*0x3fa180c*/ DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain get_Error();
                            /*0x3fa1814*/ void set_Error(DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain value);

                            class ErrorMain
                            {
                                /*0x10*/ int <Code>k__BackingField;
                                /*0x18*/ string <Message>k__BackingField;
                                /*0x20*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain.ErrorDetail> <Details>k__BackingField;

                                /*0x3fa1854*/ ErrorMain();
                                /*0x3fa1824*/ int get_Code();
                                /*0x3fa182c*/ void set_Code(int value);
                                /*0x3fa1834*/ string get_Message();
                                /*0x3fa183c*/ void set_Message(string value);
                                /*0x3fa1844*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain.ErrorDetail> get_Details();
                                /*0x3fa184c*/ void set_Details(System.Collections.Generic.List<DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain.ErrorDetail> value);

                                class ErrorDetail
                                {
                                    /*0x10*/ string <Domain>k__BackingField;
                                    /*0x18*/ string <Reason>k__BackingField;
                                    /*0x20*/ string <Message>k__BackingField;
                                    /*0x28*/ string <GwCode>k__BackingField;
                                    /*0x30*/ string <GwMessage>k__BackingField;

                                    /*0x3fa18ac*/ ErrorDetail();
                                    /*0x3fa185c*/ string get_Domain();
                                    /*0x3fa1864*/ void set_Domain(string value);
                                    /*0x3fa186c*/ string get_Reason();
                                    /*0x3fa1874*/ void set_Reason(string value);
                                    /*0x3fa187c*/ string get_Message();
                                    /*0x3fa1884*/ void set_Message(string value);
                                    /*0x3fa188c*/ string get_GwCode();
                                    /*0x3fa1894*/ void set_GwCode(string value);
                                    /*0x3fa189c*/ string get_GwMessage();
                                    /*0x3fa18a4*/ void set_GwMessage(string value);
                                }
                            }
                        }
                    }
                }

                namespace Coupon
                {
                    class GetAvailableCoupons : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel>
                    {
                        /*0x38*/ string <OrderId>k__BackingField;

                        /*0x3fa18c4*/ GetAvailableCoupons(string apiToken, string openId, string accessToken, string orderId, bool isSandbox);
                        /*0x3fa18b4*/ string get_OrderId();
                        /*0x3fa18bc*/ void set_OrderId(string value);
                        /*0x3fa197c*/ string GetAdditionalQuery();
                        /*0x3fa19e8*/ string GetEndpoint();
                        /*0x3fa1a28*/ DMM.Games.Net.Method GetMethod();
                        /*0x3fa1a80*/ DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel ParseResponse(string responseBody);
                    }

                    namespace Model
                    {
                        class CouponModel
                        {
                            /*0x10*/ string <AcquiredAt>k__BackingField;
                            /*0x18*/ string <BannerUrl>k__BackingField;
                            /*0x20*/ DMM.Games.Recibo.Api.Coupon.Model.DiscountProduct <Discount>k__BackingField;
                            /*0x28*/ int <DiscountAmount>k__BackingField;
                            /*0x2c*/ int <DiscountRate>k__BackingField;
                            /*0x30*/ string <DisplayType>k__BackingField;
                            /*0x38*/ string <Explanation>k__BackingField;
                            /*0x40*/ string <GuidanceUrl>k__BackingField;
                            /*0x48*/ string <Id>k__BackingField;
                            /*0x50*/ bool <IsAvailable>k__BackingField;
                            /*0x51*/ bool <IsForSegmentDistribution>k__BackingField;
                            /*0x52*/ bool <IsPremium>k__BackingField;
                            /*0x53*/ bool <IsPublished>k__BackingField;
                            /*0x54*/ int <MaxDiscountAmount>k__BackingField;
                            /*0x58*/ int <MinPayment>k__BackingField;
                            /*0x60*/ string <PublicEndAt>k__BackingField;
                            /*0x68*/ string <PublicStartAt>k__BackingField;
                            /*0x70*/ int <RemainedCount>k__BackingField;
                            /*0x74*/ int <RemainedCountPerUser>k__BackingField;
                            /*0x78*/ string <Title>k__BackingField;
                            /*0x80*/ DMM.Games.Recibo.Api.Coupon.Model.CouponTagLabel[] <Labels>k__BackingField;
                            /*0x88*/ string <UseCondition>k__BackingField;
                            /*0x90*/ string <UseEndAt>k__BackingField;
                            /*0x98*/ int <UseLimit>k__BackingField;
                            /*0x9c*/ int <UseLimitPerUser>k__BackingField;
                            /*0xa0*/ string <UseStartAt>k__BackingField;

                            /*0x3fa1c78*/ CouponModel();
                            /*0x3fa1ac8*/ string get_AcquiredAt();
                            /*0x3fa1ad0*/ void set_AcquiredAt(string value);
                            /*0x3fa1ad8*/ string get_BannerUrl();
                            /*0x3fa1ae0*/ void set_BannerUrl(string value);
                            /*0x3fa1ae8*/ DMM.Games.Recibo.Api.Coupon.Model.DiscountProduct get_Discount();
                            /*0x3fa1af0*/ void set_Discount(DMM.Games.Recibo.Api.Coupon.Model.DiscountProduct value);
                            /*0x3fa1af8*/ int get_DiscountAmount();
                            /*0x3fa1b00*/ void set_DiscountAmount(int value);
                            /*0x3fa1b08*/ int get_DiscountRate();
                            /*0x3fa1b10*/ void set_DiscountRate(int value);
                            /*0x3fa1b18*/ string get_DisplayType();
                            /*0x3fa1b20*/ void set_DisplayType(string value);
                            /*0x3fa1b28*/ string get_Explanation();
                            /*0x3fa1b30*/ void set_Explanation(string value);
                            /*0x3fa1b38*/ string get_GuidanceUrl();
                            /*0x3fa1b40*/ void set_GuidanceUrl(string value);
                            /*0x3fa1b48*/ string get_Id();
                            /*0x3fa1b50*/ void set_Id(string value);
                            /*0x3fa1b58*/ bool get_IsAvailable();
                            /*0x3fa1b60*/ void set_IsAvailable(bool value);
                            /*0x3fa1b6c*/ bool get_IsForSegmentDistribution();
                            /*0x3fa1b74*/ void set_IsForSegmentDistribution(bool value);
                            /*0x3fa1b80*/ bool get_IsPremium();
                            /*0x3fa1b88*/ void set_IsPremium(bool value);
                            /*0x3fa1b94*/ bool get_IsPublished();
                            /*0x3fa1b9c*/ void set_IsPublished(bool value);
                            /*0x3fa1ba8*/ int get_MaxDiscountAmount();
                            /*0x3fa1bb0*/ void set_MaxDiscountAmount(int value);
                            /*0x3fa1bb8*/ int get_MinPayment();
                            /*0x3fa1bc0*/ void set_MinPayment(int value);
                            /*0x3fa1bc8*/ string get_PublicEndAt();
                            /*0x3fa1bd0*/ void set_PublicEndAt(string value);
                            /*0x3fa1bd8*/ string get_PublicStartAt();
                            /*0x3fa1be0*/ void set_PublicStartAt(string value);
                            /*0x3fa1be8*/ int get_RemainedCount();
                            /*0x3fa1bf0*/ void set_RemainedCount(int value);
                            /*0x3fa1bf8*/ int get_RemainedCountPerUser();
                            /*0x3fa1c00*/ void set_RemainedCountPerUser(int value);
                            /*0x3fa1c08*/ string get_Title();
                            /*0x3fa1c10*/ void set_Title(string value);
                            /*0x3fa1c18*/ DMM.Games.Recibo.Api.Coupon.Model.CouponTagLabel[] get_Labels();
                            /*0x3fa1c20*/ void set_Labels(DMM.Games.Recibo.Api.Coupon.Model.CouponTagLabel[] value);
                            /*0x3fa1c28*/ string get_UseCondition();
                            /*0x3fa1c30*/ void set_UseCondition(string value);
                            /*0x3fa1c38*/ string get_UseEndAt();
                            /*0x3fa1c40*/ void set_UseEndAt(string value);
                            /*0x3fa1c48*/ int get_UseLimit();
                            /*0x3fa1c50*/ void set_UseLimit(int value);
                            /*0x3fa1c58*/ int get_UseLimitPerUser();
                            /*0x3fa1c60*/ void set_UseLimitPerUser(int value);
                            /*0x3fa1c68*/ string get_UseStartAt();
                            /*0x3fa1c70*/ void set_UseStartAt(string value);
                        }

                        class CouponNotice
                        {
                            /*0x10*/ string <Message>k__BackingField;

                            /*0x3fa1c90*/ CouponNotice();
                            /*0x3fa1c80*/ string get_Message();
                            /*0x3fa1c88*/ void set_Message(string value);
                        }

                        class CouponTagLabel
                        {
                            /*0x10*/ string <LabelId>k__BackingField;
                            /*0x18*/ string <Description>k__BackingField;
                            /*0x20*/ string <FontColor>k__BackingField;
                            /*0x28*/ string <BorderColor>k__BackingField;

                            /*0x3fa1cd8*/ CouponTagLabel();
                            /*0x3fa1c98*/ string get_LabelId();
                            /*0x3fa1ca0*/ void set_LabelId(string value);
                            /*0x3fa1ca8*/ string get_Description();
                            /*0x3fa1cb0*/ void set_Description(string value);
                            /*0x3fa1cb8*/ string get_FontColor();
                            /*0x3fa1cc0*/ void set_FontColor(string value);
                            /*0x3fa1cc8*/ string get_BorderColor();
                            /*0x3fa1cd0*/ void set_BorderColor(string value);
                        }

                        class DiscountProduct
                        {
                            /*0x10*/ int <DiscountAmount>k__BackingField;
                            /*0x14*/ int <DiscountedAmount>k__BackingField;
                            /*0x18*/ bool <IsDiscountable>k__BackingField;

                            /*0x3fa1d14*/ DiscountProduct();
                            /*0x3fa1ce0*/ int get_DiscountAmount();
                            /*0x3fa1ce8*/ void set_DiscountAmount(int value);
                            /*0x3fa1cf0*/ int get_DiscountedAmount();
                            /*0x3fa1cf8*/ void set_DiscountedAmount(int value);
                            /*0x3fa1d00*/ bool get_IsDiscountable();
                            /*0x3fa1d08*/ void set_IsDiscountable(bool value);
                        }

                        class GetAvailableCouponsModel
                        {
                            /*0x10*/ DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] <Coupons>k__BackingField;
                            /*0x18*/ int <Total>k__BackingField;
                            /*0x20*/ DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] <Notice>k__BackingField;

                            /*0x3fa1d4c*/ GetAvailableCouponsModel();
                            /*0x3fa1d1c*/ DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] get_Coupons();
                            /*0x3fa1d24*/ void set_Coupons(DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] value);
                            /*0x3fa1d2c*/ int get_Total();
                            /*0x3fa1d34*/ void set_Total(int value);
                            /*0x3fa1d3c*/ DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] get_Notice();
                            /*0x3fa1d44*/ void set_Notice(DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] value);
                        }
                    }
                }

                namespace Sdk
                {
                    class ClientAccess : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Sdk.Model.ClientAccessModel>
                    {
                        /*0x38*/ int appId;
                        /*0x3c*/ int userId;

                        /*0x3fa1d54*/ ClientAccess(int appId, int userId, bool isSandbox);
                        /*0x3fa1df4*/ string GetDomain();
                        /*0x3fa1e34*/ string GetAdditionalQuery();
                        /*0x3fa1ec8*/ string GetEndpoint();
                        /*0x3fa1f08*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> BuildRequestHeaders();
                        /*0x3fa1f10*/ DMM.Games.Net.Method GetMethod();
                        /*0x3fa1f68*/ DMM.Games.Recibo.Api.Sdk.Model.ClientAccessModel ParseResponse(string responseBody);
                    }

                    namespace Model
                    {
                        struct ClientAccessModel
                        {
                            /*0x3fa1f70*/ string ToString();
                        }
                    }
                }
            }
        }

        namespace Net
        {
            class HttpClientFactory
            {
                static /*0x3fa1f88*/ DMM.Games.Net.IHttpClient NewHttpClient();
            }

            enum NetworkErrorKind
            {
                Connection = 0,
                NotResolveHost = 1,
                ConnectionTimeout = 2,
                ReadTimeout = 3,
                Timeout = 4,
                TooManyRedirects = 5,
                Unknown = 6,
            }

            class Method
            {
                static /*0x0*/ DMM.Games.Net.Method GET;
                static /*0x8*/ DMM.Games.Net.Method POST;
                static /*0x10*/ DMM.Games.Net.Method DELETE;
                static /*0x18*/ DMM.Games.Net.Method PUT;
                /*0x10*/ bool <ExistsRequestBody>k__BackingField;
                /*0x11*/ bool <ExistsResponseBody>k__BackingField;
                /*0x18*/ string <Name>k__BackingField;

                static /*0x3fa208c*/ Method();
                /*0x3fa203c*/ Method(bool existsRequestBody, bool existsResponseBody, string name);
                /*0x3fa2004*/ bool get_ExistsRequestBody();
                /*0x3fa200c*/ void set_ExistsRequestBody(bool value);
                /*0x3fa2018*/ bool get_ExistsResponseBody();
                /*0x3fa2020*/ void set_ExistsResponseBody(bool value);
                /*0x3fa202c*/ string get_Name();
                /*0x3fa2034*/ void set_Name(string value);
            }

            class OnResponseCallback : System.MulticastDelegate
            {
                /*0x3fa2234*/ OnResponseCallback(object object, nint method);
                /*0x3fa2340*/ void Invoke(object tag, long httpStatusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string body);
                /*0x3fa2354*/ System.IAsyncResult BeginInvoke(object tag, long httpStatusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string body, System.AsyncCallback callback, object object);
                /*0x3fa23d0*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnNetworkErrorCallback : System.MulticastDelegate
            {
                /*0x3fa23dc*/ OnNetworkErrorCallback(object object, nint method);
                /*0x3fa24e8*/ void Invoke(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                /*0x3fa24fc*/ System.IAsyncResult BeginInvoke(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception, System.AsyncCallback callback, object object);
                /*0x3fa2598*/ void EndInvoke(System.IAsyncResult result);
            }

            interface IHttpClient
            {
                bool Request(string url, DMM.Games.Net.Method method, object tag, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> requestHeaders, DMM.Games.Net.OnResponseCallback successCallback, DMM.Games.Net.OnResponseCallback failureCallback, DMM.Games.Net.OnNetworkErrorCallback networkErrorCallback, string requestBody);
            }

            namespace Unity
            {
                class UnityWebRequestAsyncOperationAwaiter : System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ UnityEngine.Networking.UnityWebRequestAsyncOperation _asyncOperation;

                    /*0x3fa25c0*/ UnityWebRequestAsyncOperationAwaiter(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                    /*0x3fa25a4*/ bool get_IsCompleted();
                    /*0x3fa25f0*/ void GetResult();
                    /*0x3fa25f4*/ void OnCompleted(System.Action continuation);
                    /*0x3fa26cc*/ DMM.Games.Net.Unity.UnityWebRequestAsyncOperationAwaiter GetAwaiter();

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ System.Action continuation;

                        /*0x3fa26c4*/ <>c__DisplayClass5_0();
                        /*0x3fa26d0*/ void <OnCompleted>b__0(UnityEngine.AsyncOperation _);
                    }
                }

                class UnityWebRequestAsyncOperationExtension
                {
                    static /*0x3fa26f4*/ DMM.Games.Net.Unity.UnityWebRequestAsyncOperationAwaiter GetAwaiter(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                    static /*0x3fa275c*/ DMM.Games.Net.Unity.UnityWebRequestAsyncOperationAwaiter ConfigureAwait(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                }

                class RequestTask
                {
                    static /*0x0*/ string _userAgent;
                    /*0x10*/ System.Threading.SynchronizationContext context;
                    /*0x18*/ object <tag>k__BackingField;
                    /*0x20*/ string <url>k__BackingField;
                    /*0x28*/ DMM.Games.Net.Method <method>k__BackingField;
                    /*0x30*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> <requestHeaders>k__BackingField;
                    /*0x38*/ string <body>k__BackingField;
                    /*0x40*/ DMM.Games.Net.OnResponseCallback successCallback;
                    /*0x48*/ DMM.Games.Net.OnResponseCallback failureCallback;
                    /*0x50*/ DMM.Games.Net.OnNetworkErrorCallback networkErrorCallback;

                    static /*0x3fa2998*/ void SetUserAgent(string userAgent);
                    static /*0x3fa2bd8*/ string BuildHeaderValue(System.Collections.Generic.List<string> values);
                    /*0x3fa2814*/ RequestTask(System.Threading.SynchronizationContext context, object tag, string url, DMM.Games.Net.Method method, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> requestHeaders, string body, DMM.Games.Net.OnResponseCallback successCallback, DMM.Games.Net.OnResponseCallback failureCallback, DMM.Games.Net.OnNetworkErrorCallback networkErrorCallback);
                    /*0x3fa27c4*/ object get_tag();
                    /*0x3fa27cc*/ void set_tag(object value);
                    /*0x3fa27d4*/ string get_url();
                    /*0x3fa27dc*/ void set_url(string value);
                    /*0x3fa27e4*/ DMM.Games.Net.Method get_method();
                    /*0x3fa27ec*/ void set_method(DMM.Games.Net.Method value);
                    /*0x3fa27f4*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> get_requestHeaders();
                    /*0x3fa27fc*/ void set_requestHeaders(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> value);
                    /*0x3fa2804*/ string get_body();
                    /*0x3fa280c*/ void set_body(string value);
                    /*0x3fa2900*/ void Request();
                    /*0x3fa29f0*/ void SetRequestHeaders(UnityEngine.Networking.UnityWebRequest request);
                    /*0x3fa2db8*/ void <Request>b__26_0(object state);

                    struct <<Request>b__26_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ DMM.Games.Net.Unity.RequestTask <>4__this;
                        /*0x40*/ UnityEngine.Networking.UnityWebRequest <req>5__2;
                        /*0x48*/ object <>u__1;

                        /*0x3fa2e68*/ void MoveNext();
                        /*0x3fa351c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class HttpClientUnityImpl : DMM.Games.Net.IHttpClient
                {
                    /*0x10*/ System.Threading.SynchronizationContext context;

                    /*0x3fa1fd8*/ HttpClientUnityImpl();
                    /*0x3fa3528*/ bool Request(string url, DMM.Games.Net.Method method, object tag, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> requestHeaders, DMM.Games.Net.OnResponseCallback successCallback, DMM.Games.Net.OnResponseCallback failureCallback, DMM.Games.Net.OnNetworkErrorCallback networkErrorCallback, string requestBody);
                }
            }
        }

        namespace Util
        {
            class BridgeJsonUtility
            {
                static /*0x3838ba0*/ string List2Json<T>(System.Collections.Generic.List<T> list, bool isString);
                static /*0x3fa35f8*/ string EscapeJsonStringValue(string value);
                static /*0x3fa3604*/ string EscapeSpecialCharactersForJson(string value);
                static /*0x3fa381c*/ string GenerateOpenTransactionRequestJson(Dmm.Games.Store.OsapiPaymentResult paymentResult, string gameEngineName);
                static /*0x3fa3ca4*/ string ConvertToJson(Dmm.Games.Store.Menu menu, string gameEngineName);
                static /*0x3fa3fd8*/ string GenerateReceiptAuthDataRequestJson(string gameEngineName);
                static /*0x3fa4138*/ string GenerateSendSpendEventRequestJson(double amount, string gameEngineName);
                static /*0x3fa4308*/ string ConvertToJson(Dmm.Games.Store.DmmGamesStoreSdkSettings settings, string version, string cloudLoginToken, string gameEngineName);
            }

            class InstanceUtility
            {
                static /*0x3fa4e58*/ UnityEngine.GameObject Instance(string path);
                /*0x3fa4f24*/ InstanceUtility();
            }

            class BackGroundController : UnityEngine.MonoBehaviour
            {
                static int MIN_HIGHT = 718;
                static int PORTRAIT_MAX_HIGHT = 1600;
                static int LANDSCAPE_MAX_HIGHT = 880;
                /*0x20*/ UnityEngine.RectTransform _backgroundObject;
                /*0x28*/ UnityEngine.RectTransform _contentSizeFitterObject;
                /*0x30*/ int _landscapeMinHeight;
                /*0x34*/ int _landscapeMaxHeight;
                /*0x38*/ int _portraitMinHeight;
                /*0x3c*/ int _portraitMaxHeight;
                /*0x40*/ int _offset;
                /*0x44*/ int _totalHeight;
                /*0x48*/ bool _isPortrait;

                /*0x3fa5068*/ BackGroundController();
                /*0x3fa4f2c*/ void Start();
                /*0x3fa4f70*/ void Update();
                /*0x3fa4ff8*/ void AdjustBackgroundSize();
                /*0x3fa4f58*/ void SetTotalHight();
                /*0x3fa4fb4*/ int GetTotalHight();
            }

            class ClickDetector : UnityEngine.UI.Graphic
            {
                /*0x3fa509c*/ ClickDetector();
                /*0x3fa5084*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            }

            class DateUtility
            {
                static /*0x0*/ string REGEX_DURATION_STRING;
                static /*0x8*/ int NUM_OF_MATCHES_WHEN_FOUND;
                static /*0xc*/ int NUM_OF_GROUPS_WHEN_FOUND;
                static /*0x10*/ int DURATION_UNIT_GROUP_INDEX;
                static /*0x14*/ int DURATION_COUNT_GROUP_INDEX;
                static /*0x18*/ System.Collections.ObjectModel.ReadOnlyDictionary<string, string> DURATION_STRING_POSTFIX_FOR_USER_DICTIONARY;

                static /*0x3fa5a30*/ DateUtility();
                static /*0x3fa50f4*/ string ConvertDateTimeOffsetToString(System.DateTimeOffset dateTime);
                static /*0x3fa51c8*/ string ConvertUnixTimeToDateTimeString(long unixTime);
                static /*0x3fa5258*/ string ConvertW3CXmlSchemaTimeDurationStringToDateTimeString(string duration);
                static /*0x3fa53fc*/ string ConvertDurationUnitStringToUserDisplayPostfix(string durationUnitString);
                static /*0x3fa56fc*/ string ConvertW3CXmlSchemaTimeDurationStringToUserDisplayString(string duration);
                static /*0x3fa58e4*/ long GetStringToUnixTimestamp(string time);
                /*0x3fa5a28*/ DateUtility();
            }

            class DialogCanvasController : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.CanvasScaler _canvasScaler;
                /*0x28*/ UnityEngine.Canvas _canvas;

                /*0x3fa5d34*/ DialogCanvasController();
                /*0x3fa5c6c*/ void Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
            }

            class JsonUtility
            {
                static /*0x3910ae8*/ T Deserialize<T>(string data);
                static /*0x3f9d894*/ string Serialize(object data);
            }
        }
    }
}

namespace Dmm
{
    namespace Games
    {
        namespace Util
        {
            class AndroidIntent
            {
                static /*0x3fa5d3c*/ UnityEngine.AndroidJavaObject GetIntent();
                static /*0x3fa6100*/ bool HasExtra(UnityEngine.AndroidJavaObject intent, string target);
                static /*0x3fa61e0*/ UnityEngine.AndroidJavaObject GetExtras(UnityEngine.AndroidJavaObject intent);
                static /*0x3910ae8*/ T GetExtra<T>(string target);
            }
        }

        namespace Unity
        {
            namespace Purchasing
            {
                class MarketingEventIds
                {
                    /*0x10*/ System.Collections.Generic.List<long> FirstBoot;
                    /*0x18*/ System.Collections.Generic.List<long> Boot;
                    /*0x20*/ System.Collections.Generic.List<long> Signup;
                    /*0x28*/ System.Collections.Generic.List<long> Spend;
                    /*0x30*/ System.Collections.Generic.List<long> Login;

                    /*0x3fa62ac*/ MarketingEventIds();
                }

                class ResultLoginData
                {
                    /*0x10*/ string ErrorMessage;
                    /*0x18*/ string AccessToken;
                    /*0x20*/ string OpenId;

                    /*0x3fa63c4*/ ResultLoginData();
                }

                class SendSpendEventData
                {
                    /*0x10*/ bool IsSuccess;
                    /*0x18*/ string Error;

                    /*0x3fa63cc*/ SendSpendEventData();
                }

                class DmmGamesLoginHelper<T> : UnityEngine.MonoBehaviour
                {
                    static /*0x0*/ T _g;
                    static /*0x0*/ Dmm.Games.Store.DmmGamesStoreSdk _sdk;
                    static /*0x0*/ Dmm.Games.Unity.Purchasing.ResultLoginData _resultLoginData;
                    static /*0x0*/ System.Action<Dmm.Games.Unity.Purchasing.ResultLoginData> _resultAction;
                    static /*0x0*/ bool _isInit;

                    static /*0x3836db8*/ string get_Version();
                    static /*0x3840c74*/ void Instance(string objectName);
                    static /*0x3836db8*/ Dmm.Games.Store.DmmGamesStoreSdk GetDmmGamesStoreSdk();
                    static /*0x3840c74*/ void ResultError(string message);
                    /*0x38159dc*/ DmmGamesLoginHelper();

                    class Environment<T>
                    {
                        static string Production = "prod";
                        static string Staging = "Staging";

                        /*0x38159dc*/ Environment();
                    }

                    class DevelopmentMode<T>
                    {
                        static string Release = "Service";
                        static string Sandbox = "sandbox";

                        /*0x38159dc*/ DevelopmentMode();
                    }
                }

                class DmmGamesStore : Dmm.Games.Unity.Purchasing.DmmGamesLoginHelper<Dmm.Games.Unity.Purchasing.DmmGamesStore>
                {
                    static string OBJECT_NAME = "DmmGamesBrowserHelperObject";

                    static /*0x3fa63d4*/ void Login(Dmm.Games.Unity.Purchasing.DmmGamesStoreSettings settings, System.Action<Dmm.Games.Unity.Purchasing.ResultLoginData> action);
                    static /*0x3fa6488*/ void LoginWithGetReceiptAuthData(Dmm.Games.Store.DmmGamesStoreSdkSettings settings, System.Action<Dmm.Games.Unity.Purchasing.ResultLoginData> action);
                    static /*0x3fa6a50*/ void SendSpendEvent(double amount, System.Action<Dmm.Games.Unity.Purchasing.SendSpendEventData> action);
                    static /*0x3fa6cc4*/ void OpenMenu(Dmm.Games.Unity.Purchasing.Menu menu, System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> action);
                    static /*0x3fa6e8c*/ Dmm.Games.Store.Menu ConvertMenu(Dmm.Games.Unity.Purchasing.Menu menu);
                    /*0x3fa6fa8*/ DmmGamesStore();
                    /*0x3fa67c8*/ void OnInit(string result);
                    /*0x3fa6988*/ void OnGetReceiptAuthData(Dmm.Games.Store.ReceiptAuthDataResult result);

                    class <>c
                    {
                        static /*0x0*/ Dmm.Games.Unity.Purchasing.DmmGamesStore.<> <>9;
                        static /*0x8*/ System.Action<Dmm.Games.Store.SdkResult> <>9__2_0;

                        static /*0x3fa6ff0*/ <>c();
                        /*0x3fa7058*/ <>c();
                        /*0x3fa7060*/ void <LoginWithGetReceiptAuthData>b__2_0(Dmm.Games.Store.SdkResult result);
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ System.Action<Dmm.Games.Unity.Purchasing.SendSpendEventData> action;
                        /*0x18*/ Dmm.Games.Unity.Purchasing.SendSpendEventData data;

                        /*0x3fa6c00*/ <>c__DisplayClass5_0();
                        /*0x3fa719c*/ void <SendSpendEvent>b__0(Dmm.Games.Store.SendSpendEventResult result);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> action;
                        /*0x18*/ Dmm.Games.Unity.Purchasing.MenuEventData data;

                        /*0x3fa6e7c*/ <>c__DisplayClass6_0();
                        /*0x3fa721c*/ void <OpenMenu>b__0(Dmm.Games.Store.SdkResult result);
                    }
                }

                class DmmGamesStoreSettings : Dmm.Games.Store.DmmGamesStoreSdkSettings
                {
                    /*0x3fa72a0*/ DmmGamesStoreSettings();
                }

                class HttpException : System.Exception
                {
                    /*0x8c*/ bool <IsNetworkError>k__BackingField;
                    /*0x90*/ int <StatusCode>k__BackingField;
                    /*0x98*/ Dmm.Games.Unity.Purchasing.RawResult <result>k__BackingField;

                    /*0x3fa7390*/ HttpException(string message);
                    /*0x3fa7404*/ HttpException(string message, int statusCode);
                    /*0x3fa7480*/ HttpException(int statusCode, byte[] body, string message);
                    /*0x3fa753c*/ bool get_IsNetworkError();
                    /*0x3fa7544*/ void set_IsNetworkError(bool value);
                    /*0x3fa7550*/ int get_StatusCode();
                    /*0x3fa7558*/ void set_StatusCode(int value);
                    /*0x3fa7560*/ Dmm.Games.Unity.Purchasing.RawResult get_result();
                    /*0x3fa756c*/ void set_result(Dmm.Games.Unity.Purchasing.RawResult value);
                }

                struct RawResult
                {
                    /*0x10*/ int statusCode;
                    /*0x18*/ byte[] body;
                }

                enum Menu
                {
                    DmmGamesStore = 0,
                    PointCharge = 1,
                    Settings = 2,
                    MyGame = 3,
                    Community = 4,
                    Terms = 5,
                    Inquiry = 6,
                    Annonucement = 7,
                    DmmAccountPage = 8,
                    ApplicationUpdate = 9,
                    SubscriptionContractPage = 10,
                    GamesRankPage = 11,
                }

                class MenuEventData
                {
                    /*0x10*/ bool IsSuccess;
                    /*0x18*/ string Error;

                    /*0x3fa6e84*/ MenuEventData();
                }

                class DeveloperPayload
                {
                    /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesTerms DmmGamesTerms;

                    /*0x3fa757c*/ DeveloperPayload();
                }

                class DmmGamesTerms
                {
                    /*0x10*/ string PeriodTimeDescription;
                    /*0x18*/ string TermOfDelivery;
                    /*0x20*/ string TermOfPayment;
                    /*0x28*/ string ReturnPolicy;

                    /*0x3fa75e8*/ DmmGamesTerms();
                }

                class DmmGamesApiResult
                {
                    static /*0x3fa75f0*/ string GetMaintenanceUrl(bool isAdult);
                    static /*0x3fa7658*/ void DisassemblyForBrowser(long statusCode, string body, ref int code, ref string message, bool isAdult);
                    static /*0x3fa7860*/ DMM.Games.Recibo.Api.Error.Model.ErrorModel GetErrorModel(string message);
                    static /*0x3fa7938*/ bool IsErrorModel(DMM.Games.Recibo.Api.Error.Model.ErrorModel model);
                    static /*0x3fa792c*/ bool IsMaintenance(long status);
                    /*0x3fa794c*/ DmmGamesApiResult();
                }

                struct UserKey
                {
                    /*0x10*/ string <OpenId>k__BackingField;
                    /*0x18*/ string <AccessToken>k__BackingField;

                    /*0x3fa7954*/ string get_OpenId();
                    /*0x3fa795c*/ void set_OpenId(string value);
                    /*0x3fa7964*/ string get_AccessToken();
                    /*0x3fa796c*/ void set_AccessToken(string value);
                }

                class DmmGamesIapStore : UnityEngine.Purchasing.Extension.IStore
                {
                    static /*0x0*/ string URL_SUBSCRIPTION_CONTRACT_GENERAL;
                    static /*0x8*/ string URL_SUBSCRIPTION_CONTRACT_ADULT;
                    static /*0x10*/ string URL_GAMES_RANK_GENERAL;
                    static /*0x18*/ string URL_GAMES_RANK_ADULT;
                    static /*0x20*/ int MAX_API_RETRY_COUNT;
                    static /*0x28*/ Dmm.Games.Unity.Purchasing.Error.DmmGamesIapStoreError _dmmGamesIapError;
                    static /*0x30*/ bool IsAdult;
                    /*0x10*/ UnityEngine.Purchasing.Extension.IStoreCallback _callback;
                    /*0x18*/ DMM.Games.Recibo.Api.Version2.Sdk.Model.InitializeSdkResponseModel _initModel;
                    /*0x20*/ string _apiToken;
                    /*0x28*/ bool _isSandbox;
                    /*0x30*/ Dmm.Games.Unity.Purchasing.UserKey _userKey;
                    /*0x40*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventory _inventory;
                    /*0x48*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreSubscriptionInventory _subscriptionInventory;
                    /*0x50*/ UnityEngine.Texture2D _productIcon;
                    /*0x58*/ System.Collections.Generic.Dictionary<string, UnityEngine.Texture2D> _productIcons;
                    /*0x60*/ int <SortOrderOffset>k__BackingField;

                    static /*0x3fab18c*/ DmmGamesIapStore();
                    static /*0x3fa7c74*/ Dmm.Games.Unity.Purchasing.Error.DmmGamesIapStoreError get_Error();
                    static /*0x3fa7ccc*/ void set_Error(Dmm.Games.Unity.Purchasing.Error.DmmGamesIapStoreError value);
                    static /*0x3faa470*/ void ClearError();
                    static /*0x3fab0b8*/ string GetSubscriptionContractPageUrl(bool isAdult);
                    static /*0x3fab120*/ string GetGamesRankPageUrl(bool isAdult);
                    /*0x3fa7e04*/ DmmGamesIapStore(Dmm.Games.Unity.Purchasing.DmmGamesIapStoreConfiguration storeConfiguration);
                    /*0x3fa7974*/ string get_Version();
                    /*0x3fa79b4*/ string GetVersion();
                    /*0x3fa79f4*/ bool get_IsSdkReady();
                    /*0x3fa7a04*/ string get_GamesId();
                    /*0x3fa7a38*/ string get_GamesIdSignature();
                    /*0x3fa7a50*/ string get_ViewerId();
                    /*0x3fa7a84*/ string get_ViewerIdSignature();
                    /*0x3fa7a9c*/ string get_PointChargeUrl();
                    /*0x3fa7ab4*/ Dmm.Games.Unity.Purchasing.UserType get_UserType();
                    /*0x3f9cb28*/ string get_CreditChangeUrl();
                    /*0x3f9cdd4*/ string get_MaintenanceUrl();
                    /*0x3fa7d2c*/ string get_ApiToken();
                    /*0x3fa7d34*/ Dmm.Games.Unity.Purchasing.UserKey get_UserKey();
                    /*0x3fa7d40*/ bool get_IsSandbox();
                    /*0x3fa7d48*/ int get_SortOrderOffset();
                    /*0x3fa7d50*/ void set_SortOrderOffset(int value);
                    /*0x3fa7d58*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventory get_Inventory();
                    /*0x3fa7d60*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreSubscriptionInventory get_SubscriptionInventory();
                    /*0x3fa7d68*/ UnityEngine.Texture2D get_ProductIcon();
                    /*0x3fa7d70*/ UnityEngine.Texture2D ProductIcons(string id);
                    /*0x3fa805c*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
                    /*0x3fa8064*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                    /*0x3fa848c*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
                    /*0x3fa8a5c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
                    /*0x3fa8a64*/ void FinishTransactionInternal(UnityEngine.Purchasing.ProductDefinition product, string transactionId, int count);
                    /*0x3fa8284*/ void QueryNonSubscriptionPurchase(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, int count);
                    /*0x3fa8ffc*/ void QueryNonSubscriptionSkuDetails(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Receipt.Model.ReceiptList purchasedList, int count);
                    /*0x3fa96a4*/ void QuerySubscriptionPurchase(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, int count);
                    /*0x3fa98cc*/ void QuerySubscriptionSkuDetails(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList purchasedList, int count);
                    /*0x3fa9320*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> GetNonSubscriptionProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                    /*0x3fa9d1c*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> GetSubscriptionProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                    /*0x3fa807c*/ void InitializeSdk(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, int count);
                    /*0x3faa4fc*/ void SetProductIcon(UnityEngine.Texture2D icon);
                    /*0x3faa504*/ void SetProductIcon(string productId, UnityEngine.Texture2D icon);
                    /*0x3faa5d0*/ void ClearProductIcon();
                    /*0x3faa630*/ string GetInAppPurchaseData(UnityEngine.Purchasing.Product product);
                    /*0x3faa79c*/ string GetInAppDataSignature(UnityEngine.Purchasing.Product product);
                    /*0x3faa7f0*/ void OpenSubscriptionContractPage();
                    /*0x3faa8c0*/ void OpenGamesRankPage();
                    /*0x3faa684*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel GetReceiptModel(UnityEngine.Purchasing.Product product);
                    /*0x3faa71c*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel GetSubscriptionReceiptModel(UnityEngine.Purchasing.Product product);
                    /*0x3faa990*/ void ClientAccess(System.Nullable<int> appid, System.Nullable<int> viewerid, UnityEngine.Events.UnityAction action);
                    /*0x3faaba0*/ void Disassembly(long statusCode, string body, ref int code, ref string message);
                    /*0x3faada8*/ DMM.Games.Recibo.Api.Error.Model.ErrorModel GetErrorModel(string message);
                    /*0x3faae80*/ bool IsErrorModel(DMM.Games.Recibo.Api.Error.Model.ErrorModel model);
                    /*0x3faae9c*/ void DisassemblyForSubscription(long statusCode, string body, ref int code, ref string codeString, ref string message);
                    /*0x3faafe0*/ DMM.Games.Recibo.Api.Version2.BaseResultModel GetErrorModelForSubscription(string message);
                    /*0x3faae74*/ bool IsMaintenance(long status);
                    /*0x3faa868*/ string GetSubscriptionContractPageUrl();
                    /*0x3faa938*/ string GetGamesRankPageUrl();
                    /*0x3fab294*/ void <Purchase>b__60_0(System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> receipt);
                    /*0x3fab4d8*/ void <Purchase>b__60_1(DMM.Games.Recibo.Ui.ErrorObject error);
                    /*0x3fab69c*/ void <Purchase>b__60_2(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel receipt);
                    /*0x3fab7d4*/ void <Purchase>b__60_3(DMM.Games.Recibo.Ui.ErrorObject error);

                    class <>c__DisplayClass62_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem item;
                        /*0x18*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x20*/ UnityEngine.Purchasing.ProductDefinition product;
                        /*0x28*/ string transactionId;

                        /*0x3fa8da4*/ <>c__DisplayClass62_0();
                        /*0x3faba00*/ void <FinishTransactionInternal>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel response);
                        /*0x3faba58*/ void <FinishTransactionInternal>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fabb88*/ void <FinishTransactionInternal>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass63_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                        /*0x3fa8ff4*/ <>c__DisplayClass63_0();
                        /*0x3fabd8c*/ void <QueryNonSubscriptionPurchase>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Receipt.Model.ReceiptList response);
                        /*0x3fabde0*/ void <QueryNonSubscriptionPurchase>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fabf9c*/ void <QueryNonSubscriptionPurchase>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass64_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                        /*0x20*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptList purchasedList;

                        /*0x3fa9318*/ <>c__DisplayClass64_0();
                        /*0x3fac2fc*/ void <QueryNonSubscriptionSkuDetails>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Product.Model.StockKeepingUnitListModel response);
                        /*0x3fac890*/ void <QueryNonSubscriptionSkuDetails>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3faca4c*/ void <QueryNonSubscriptionSkuDetails>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass65_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                        /*0x3fa98c4*/ <>c__DisplayClass65_0();
                        /*0x3facdb8*/ void <QuerySubscriptionPurchase>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Receipt.Model.GetReceiptResponseModel response);
                        /*0x3facde4*/ void <QuerySubscriptionPurchase>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3facfac*/ void <QuerySubscriptionPurchase>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass66_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                        /*0x20*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList purchasedList;

                        /*0x3fa9d14*/ <>c__DisplayClass66_0();
                        /*0x3fad30c*/ void <QuerySubscriptionSkuDetails>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductResponseModel response);
                        /*0x3fadbc0*/ void <QuerySubscriptionSkuDetails>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fadd88*/ void <QuerySubscriptionSkuDetails>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass69_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                        /*0x3faa468*/ <>c__DisplayClass69_0();
                        /*0x3fae0e8*/ void <InitializeSdk>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Sdk.Model.InitializeSdkResponseModel response);
                        /*0x3fae190*/ void <InitializeSdk>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fae350*/ void <InitializeSdk>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass80_0
                    {
                        /*0x10*/ UnityEngine.Events.UnityAction action;

                        /*0x3faab98*/ <>c__DisplayClass80_0();
                        /*0x3fae6b0*/ void <ClientAccess>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Sdk.Model.ClientAccessModel response);
                        /*0x3fae6d4*/ void <ClientAccess>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fae6f8*/ void <ClientAccess>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }
                }

                class DmmGamesIapStoreConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
                {
                    /*0x10*/ string ApiToken;
                    /*0x18*/ string OpenId;
                    /*0x20*/ string AccessToken;
                    /*0x28*/ bool IsSandbox;

                    /*0x3fae71c*/ DmmGamesIapStoreConfiguration(string apiToken, string openId, string accessToken, bool isSandbox);
                }

                class DmmGamesIapStoreErrorCode
                {
                    static int GwCodeError = -1;
                    static int ApiFailed = 100;
                    static int ConnectionError = 200;
                    static int ConnectionMaxRetry = 300;
                    static int TransactionIdMismatch = 400;
                    static int DeleteReceiptNotAllowedInSubscriptionItem = 401;
                    static int Maintenance = 503;
                    static int GetPurchasedReceiptListFailure = 800;
                    static int GetPurchasedReceiptListError = 801;
                    static int CheckOrderPurchased = 802;
                    static int CreateOrderFailure = 803;
                    static int CreateOrderError = 804;
                    static int GetBlanceFailure = 805;
                    static int GetBalanceFailure = 805;
                    static int GetBlanceError = 806;
                    static int GetBalanceError = 806;
                    static int PurchasingFailure = 807;
                    static int PurchasingError = 808;
                    static int UserCancel = 809;
                    static int Uninitialized = 810;
                    static int ProductNotFound = 811;
                    static int SubscriptionProductOfferNotAvailable = 812;
                    static int GetAvailableCouponsFailure = 900;
                    static int GetAvailableCouponsError = 901;
                    static int UnableToGetUserId = 300001;
                    static int AccessTokenUnspecified = 300002;
                    static int InvalidApiAccessKeyFile = 300003;
                    static int FailedToRetrieveInformation = 500115;
                    static int FailedToRetrieveUserInformation = 500301;
                    static int AccessTokenInvalid = 500303;
                    static int AccessTokenExpired = 500304;
                    static int AccessTokenNotSet = 500309;
                    static int CombinationError = 500310;
                    static int UnableToGetSKU = 500435;
                    static int PurchaseNotExist = 500441;
                    static int UnknownError = 999999;
                    static string ExpireLoginErrorNo1 = "000001";
                    static string ExpireLoginErrorNo2 = "300002";
                    static string ExpireLoginErrorNo5 = "300005";

                    /*0x3fae788*/ DmmGamesIapStoreErrorCode();
                }

                class DmmGamesIapStoreErrorKind
                {
                    static string Init = "Init";
                    static string GetPurchasedItems = "GetPurchasedItems";
                    static string GetDetailItems = "GetDetailItems";
                    static string GetPurchasedSubscriptionItems = "GetPurchasedSubscriptionItems";
                    static string GetDetailSubscriptionItems = "GetDetailSubscriptionItems";
                    static string DeletePurchasedItem = "DeletePurchasedItem";
                    static string PurchasedProcess = "PurchasedProcess";
                    static string PurchaseItemNotFound = "PurchaseItemNotFound";

                    /*0x3fae790*/ DmmGamesIapStoreErrorKind();
                }

                class DmmGamesIapStoreExtension : UnityEngine.Purchasing.IStoreExtension
                {
                    /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore _store;

                    /*0x3fae798*/ DmmGamesIapStoreExtension(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                    /*0x3fae7c8*/ string get_GamesId();
                    /*0x3fae808*/ string get_GamesIdSignature();
                    /*0x3fae834*/ string get_ViewerId();
                    /*0x3fae874*/ string get_ViewerIdSignature();
                    /*0x3fae8a0*/ string get_PointChargeUrl();
                    /*0x3fae8cc*/ Dmm.Games.Unity.Purchasing.Error.IDmmGamesIapStoreError get_Error();
                    /*0x3fae954*/ void ClearError();
                    /*0x3fae9a0*/ string GetVersion();
                    /*0x3fae9ec*/ void SetProductIcon(UnityEngine.Texture2D icon);
                    /*0x3faea08*/ void SetProductIcon(string productId, UnityEngine.Texture2D icon);
                    /*0x3faea20*/ string GetInAppPurchaseData(UnityEngine.Purchasing.Product product);
                    /*0x3faea38*/ string GetInAppDataSignature(UnityEngine.Purchasing.Product product);
                    /*0x3faea50*/ void SetPurchaseDialogSortOrderOffset(int offset);
                    /*0x3faea60*/ void OpenSubscriptionContractPage();
                    /*0x3faea70*/ void OpenGamesRankPage();
                }

                class DmmGamesIapStoreInventory
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<string, Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem> items;

                    static /*0x3faefd4*/ UnityEngine.Purchasing.ProductDefinition FindProduct(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> receiptModel);
                    /*0x3fa7f4c*/ DmmGamesIapStoreInventory();
                    /*0x3faea80*/ System.Collections.Generic.IEnumerable<string> get_KeySet();
                    /*0x3faead0*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem get_Item(string key);
                    /*0x3faead4*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem Get(string key);
                    /*0x3fa89bc*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem FindItem(UnityEngine.Purchasing.ProductDefinition product);
                    /*0x3faebd8*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem FindItem(string storeSpecificId);
                    /*0x3fac3e8*/ void GenerateInventory(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnitListModel> skus, System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptList> receiptList);
                    /*0x3faedcc*/ void BindReceiptToInventory(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptList> receiptList);
                    /*0x3faa0a0*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertToProductDescriptionList();
                    /*0x3fab430*/ void UpdateReceipt(System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> receiptModel);
                }

                class DmmGamesIapStoreInventoryItem
                {
                    /*0x10*/ System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> <Sku>k__BackingField;
                    /*0x50*/ System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> <ReceiptModel>k__BackingField;

                    static /*0x3faf57c*/ UnityEngine.Purchasing.ProductMetadata ConvertToMetadata(System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> sku);
                    /*0x3faed90*/ DmmGamesIapStoreInventoryItem(System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> sku);
                    /*0x3faf514*/ System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> get_Sku();
                    /*0x3faf528*/ void set_Sku(System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> value);
                    /*0x3faf548*/ System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> get_ReceiptModel();
                    /*0x3faf558*/ void set_ReceiptModel(System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> value);
                    /*0x3faba30*/ void EraseReceipt();
                    /*0x3faf318*/ UnityEngine.Purchasing.Extension.ProductDescription ConvertProductDescription();
                    /*0x3faeb68*/ bool ValidateProductId(UnityEngine.Purchasing.ProductDefinition product);
                    /*0x3fa8dac*/ bool ValidateTransactionId(string transactionId);
                }

                class DmmGames
                {
                    static /*0x0*/ string Name;

                    static /*0x3faf6a8*/ DmmGames();
                    /*0x3faf6a0*/ DmmGames();
                }

                class DmmGamesIapModule : UnityEngine.Purchasing.Extension.AbstractPurchasingModule
                {
                    /*0x18*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreConfiguration <Configuration>k__BackingField;

                    /*0x3faf724*/ DmmGamesIapModule(string apiToken, string openId, string accessToken, bool isSandbox);
                    /*0x3faf714*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreConfiguration get_Configuration();
                    /*0x3faf71c*/ void set_Configuration(Dmm.Games.Unity.Purchasing.DmmGamesIapStoreConfiguration value);
                    /*0x3faf7bc*/ void Configure();
                }

                class UserType
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<string, Dmm.Games.Unity.Purchasing.UserType> _types;
                    static /*0x8*/ Dmm.Games.Unity.Purchasing.UserType None;
                    static /*0x10*/ Dmm.Games.Unity.Purchasing.UserType Normal;
                    static /*0x18*/ Dmm.Games.Unity.Purchasing.UserType Developer;
                    static /*0x20*/ Dmm.Games.Unity.Purchasing.UserType Staff;
                    static /*0x28*/ Dmm.Games.Unity.Purchasing.UserType Official;
                    /*0x10*/ string <Name>k__BackingField;
                    /*0x18*/ string <DisplayName>k__BackingField;

                    static /*0x3fafb8c*/ UserType();
                    static /*0x3fa7b3c*/ Dmm.Games.Unity.Purchasing.UserType FromString(string name);
                    static /*0x3faf9cc*/ bool op_Equality(Dmm.Games.Unity.Purchasing.UserType u1, Dmm.Games.Unity.Purchasing.UserType u2);
                    static /*0x3faf9f8*/ bool op_Inequality(Dmm.Games.Unity.Purchasing.UserType u1, Dmm.Games.Unity.Purchasing.UserType u2);
                    /*0x3faf900*/ UserType(string name, string displayName);
                    /*0x3faf8e0*/ string get_Name();
                    /*0x3faf8e8*/ void set_Name(string value);
                    /*0x3faf8f0*/ string get_DisplayName();
                    /*0x3faf8f8*/ void set_DisplayName(string value);
                    /*0x3faf9c4*/ string ToString();
                    /*0x3fafa80*/ bool Equals(object obj);
                    /*0x3fafb1c*/ int GetHashCode();
                }

                namespace Version2
                {
                    class DmmGamesIapStoreSubscriptionInventory
                    {
                        /*0x10*/ System.Collections.Generic.Dictionary<string, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem> subscriptionItems;

                        static /*0x3fb0390*/ UnityEngine.Purchasing.ProductDefinition FindProduct(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel receiptModel);
                        /*0x3fa7fd4*/ DmmGamesIapStoreSubscriptionInventory();
                        /*0x3fafd90*/ System.Collections.Generic.IEnumerable<string> get_KeySet();
                        /*0x3fafde0*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem get_Item(string key);
                        /*0x3fafde4*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem Get(string key);
                        /*0x3fa89fc*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem FindItem(UnityEngine.Purchasing.ProductDefinition product);
                        /*0x3fafe9c*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem FindItem(string storeSpecificId);
                        /*0x3fad434*/ void GenerateInventory(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Version2.Product.Model.ProductList productList, DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList receiptList);
                        /*0x3fb0068*/ void BindReceiptToInventory(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList receiptList);
                        /*0x3fad804*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertToProductDescriptionList();
                        /*0x3fab788*/ void UpdateReceipt(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel receiptModel);
                    }

                    class DmmGamesIapStoreInventorySubscriptionItem
                    {
                        /*0x10*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product <Sku>k__BackingField;
                        /*0x18*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel <Receipt>k__BackingField;

                        static /*0x3fb0780*/ UnityEngine.Purchasing.ProductMetadata ConvertToMetadata(DMM.Games.Recibo.Api.Version2.Product.Model.Product sku);
                        /*0x3fb0038*/ DmmGamesIapStoreInventorySubscriptionItem(DMM.Games.Recibo.Api.Version2.Product.Model.Product sku);
                        /*0x3fb0760*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product get_Sku();
                        /*0x3fb0768*/ void set_Sku(DMM.Games.Recibo.Api.Version2.Product.Model.Product value);
                        /*0x3fb0770*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel get_Receipt();
                        /*0x3fb0778*/ void set_Receipt(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel value);
                        /*0x3fafe78*/ bool ValidateProductId(UnityEngine.Purchasing.ProductDefinition product);
                        /*0x3fb06a4*/ UnityEngine.Purchasing.Extension.ProductDescription ConvertProductDescription();
                    }
                }

                namespace Error
                {
                    interface IDmmGamesIapStoreError
                    {
                        /*0x38148bc*/ string GetErrorKind();
                        /*0x3814574*/ int GetErrorCode();
                        /*0x38148bc*/ string GetErrorMessage();
                        /*0x38148bc*/ System.Exception GetException();
                        /*0x38148bc*/ string GetStringErrorCode();
                        /*0x38148bc*/ string GetSubscriptionExtendErrorCode();
                    }

                    class DmmGamesIapStoreError : Dmm.Games.Unity.Purchasing.Error.IDmmGamesIapStoreError
                    {
                        static /*0x0*/ int UNDEFINED_ERROR_CODE;
                        /*0x10*/ string _kind;
                        /*0x18*/ int _errorCode;
                        /*0x20*/ string _errorCodeString;
                        /*0x28*/ string _errorMessage;
                        /*0x30*/ System.Exception _exception;
                        /*0x38*/ string _subscriptionExtendErrorCode;

                        static /*0x3fb09e8*/ DmmGamesIapStoreError();
                        /*0x3fa8a4c*/ DmmGamesIapStoreError(string kind, int errorCode, string errorMessage, System.Exception exception);
                        /*0x3fb0914*/ DmmGamesIapStoreError(string kind, string errorCode, string errorMessage, System.Exception exception);
                        /*0x3fb0890*/ DmmGamesIapStoreError(string kind, int errorCode, string errorCodeString, string errorMessage, System.Exception exception);
                        /*0x3fab998*/ DmmGamesIapStoreError(string kind, bool isSubscription, int errorCode, string subscriptionErrorCode, string errorMessage);
                        /*0x3fb09a4*/ string GetErrorKind();
                        /*0x3fb09ac*/ int GetErrorCode();
                        /*0x3fb09b4*/ string GetErrorMessage();
                        /*0x3fb09bc*/ System.Exception GetException();
                        /*0x3fb09c4*/ string GetStringErrorCode();
                        /*0x3fb09e0*/ string GetSubscriptionExtendErrorCode();
                    }
                }
            }
        }

        namespace Store
        {
            class AuthParams
            {
                /*0x10*/ string ClientId;
                /*0x18*/ string ClientSecret;
                /*0x20*/ string SecretKey;
                /*0x28*/ string RedirectUri;
                /*0x30*/ int ConnectionTimeoutMillis;
                /*0x34*/ int ReadTimeoutMillis;

                /*0x3fb0a34*/ AuthParams();
            }

            class DmmGamesStoreSdk
            {
                static string GameEngineName = "Unity";
                static /*0x0*/ bool isStandaloneAuthEnable;
                static /*0x8*/ UnityEngine.GameObject _receiveGo;
                static /*0x10*/ Dmm.Games.Store.DmmSdkReceiveObject _receiveCode;
                /*0x10*/ Dmm.Games.Store.DmmGamesStoreSdkSettings settings;
                /*0x18*/ bool isEditorInit;

                static /*0x3fb0a48*/ string get_Version();
                /*0x3fa66a8*/ DmmGamesStoreSdk();
                /*0x3fb0a88*/ Dmm.Games.Store.GameEngine GetGameEngine(Dmm.Games.Store.GameEngineParameter parameter);
                /*0x3814a3c*/ string Execute<T>(Dmm.Games.Store.RootParameter<T> parameter);
                /*0x3fb0b24*/ string Execute(string json);
                /*0x3814a74*/ string List2Json<T>(System.Collections.Generic.List<T> list, bool isString);
                /*0x3814a3c*/ string ToJson<T>(Dmm.Games.Store.RootParameter<T> parameter);
                /*0x3910ae8*/ T ToObject<T>(string json);
                /*0x3fb0d7c*/ void Initialize(Dmm.Games.Store.DmmGamesStoreSdkSettings settings, System.Action<Dmm.Games.Store.InitializeData> callback);
                /*0x3fa66b0*/ void InternalInitialize(Dmm.Games.Store.DmmGamesStoreSdkSettings settings, System.Action<Dmm.Games.Store.SdkResult> action);
                /*0x3fb1174*/ void IsInitialized(System.Action<Dmm.Games.Store.SdkResult> action);
                /*0x3fa6e9c*/ void OpenMenu(Dmm.Games.Store.Menu kind, System.Action<Dmm.Games.Store.SdkResult> action);
                /*0x3fb127c*/ void MakeRequest(Dmm.Games.Store.MakeRequestParameter request, System.Action<Dmm.Games.Store.OsapiMakeRequestResult> action);
                /*0x3fb1ee4*/ void Thumbnail(Dmm.Games.Store.ThumbnailParameter request, System.Action<Dmm.Games.Store.OsapiThumbnailResult> response);
                /*0x3fb1fbc*/ void Message(Dmm.Games.Store.MessageParameter request, System.Action<Dmm.Games.Store.OsapiMessageResult> response);
                /*0x3fb2094*/ void Inspection(Dmm.Games.Store.InspectionParameter request, System.Action<Dmm.Games.Store.OsapiInspectionResult> response);
                /*0x3fb216c*/ void Activity(Dmm.Games.Store.ActivityParameter request, System.Action<Dmm.Games.Store.OsapiActivityResult> response);
                /*0x3fb2244*/ void IgnoreList(Dmm.Games.Store.IgnoreListParameter request, System.Action<Dmm.Games.Store.OsapiIgnoreListResult> response);
                /*0x3fb237c*/ void People(Dmm.Games.Store.PeopleParameter request, System.Action<Dmm.Games.Store.OsapiPeopleResult> response);
                /*0x3fb2454*/ void Payment(Dmm.Games.Store.PaymentParameter request, System.Action<Dmm.Games.Store.OsapiPaymentResult> response);
                /*0x3fb252c*/ void OpenTransactionDialog(Dmm.Games.Store.OsapiPaymentResult item, System.Action<Dmm.Games.Store.OpenTransactionDialogData> callback);
                /*0x3fa68d8*/ void GetReceiptAuthData(System.Action<Dmm.Games.Store.ReceiptAuthDataResult> action);
                /*0x3fa6c08*/ void SendSpendEvent(double amount, System.Action<Dmm.Games.Store.SendSpendEventResult> action);
                /*0x3fb1084*/ bool IsAndroid();
                /*0x3fb1094*/ Dmm.Games.Store.Error GetUnsupportedError();
                /*0x3fb1944*/ void CheckHttpStatus(int httpStatus, ref Dmm.Games.Store.Error error, string message);
                /*0x3fb2654*/ string GetCloudLoginToken4Json();
                /*0x3fb2708*/ string GetGamesId();
                /*0x3fb28a8*/ string GetDmmGamesId();
                /*0x3fb28ac*/ bool LogoutForStandaloneAuth();

                class PaymentStatus
                {
                    static int IdIssuance = 1;
                    static int PaymentCompleted = 2;
                    static int Cancel = 3;
                    static int Expired = 4;

                    /*0x3fb29b8*/ PaymentStatus();
                }

                class OpenSocialSelector
                {
                    static string Self = "@self";
                    static string Friends = "@friends";
                    static string All = "@all";

                    /*0x3fb29c0*/ OpenSocialSelector();
                }

                class HttpMethod
                {
                    static string Get = "GET";
                    static string Put = "PUT";
                    static string Post = "POST";
                    static string Delete = "DELETE";

                    /*0x3fb29c8*/ HttpMethod();
                }

                class Environment
                {
                    static string Production = "prod";
                    static string Staging = "Staging";
                    static string Staging2 = "staging2";

                    /*0x3fb29d0*/ Environment();
                }

                class DevelopmentMode
                {
                    static string Release = "Service";
                    static string Sandbox = "sandbox";

                    /*0x3fb29d8*/ DevelopmentMode();
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ System.Action<Dmm.Games.Store.InitializeData> callback;

                    /*0x3fb107c*/ <>c__DisplayClass19_0();
                    /*0x3fb29e0*/ void <Initialize>b__0(Dmm.Games.Store.SdkResult result);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ Dmm.Games.Store.DmmGamesStoreSdk <>4__this;
                    /*0x18*/ System.Action<Dmm.Games.Store.SdkResult> action;
                    /*0x20*/ Dmm.Games.Store.ApiCoroutine ac;
                    /*0x28*/ Dmm.Games.Store.DmmGamesStoreSdkSettings settings;

                    /*0x3fb116c*/ <>c__DisplayClass20_0();
                    /*0x3fb2b10*/ void <InternalInitialize>b__0();
                }

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ Dmm.Games.Store.DmmGamesStoreSdk <>4__this;
                    /*0x18*/ System.Action<Dmm.Games.Store.SdkResult> action;
                    /*0x20*/ Dmm.Games.Store.ApiCoroutine ac;
                    /*0x28*/ Dmm.Games.Store.Menu kind;

                    /*0x3fb1274*/ <>c__DisplayClass22_0();
                    /*0x3fb2c2c*/ void <OpenMenu>b__0();
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ System.Action<Dmm.Games.Store.OpenTransactionDialogData> callback;
                    /*0x18*/ Dmm.Games.Store.ApiCoroutine ac;
                    /*0x20*/ Dmm.Games.Store.DmmGamesStoreSdk <>4__this;
                    /*0x28*/ Dmm.Games.Store.OsapiPaymentResult item;

                    /*0x3fb2644*/ <>c__DisplayClass31_0();
                    /*0x3fb2ce4*/ void <OpenTransactionDialog>b__0();
                }
            }

            class DmmGamesStoreSdkSettings
            {
                /*0x10*/ string AppId;
                /*0x18*/ string ConsumerKey;
                /*0x20*/ string ConsumerSecret;
                /*0x28*/ string Environment;
                /*0x30*/ string DevelopmentMode;
                /*0x38*/ string GameName;
                /*0x40*/ string OauthSignaturePublicKey;
                /*0x48*/ int WebViewTimeoutMillis;
                /*0x50*/ Dmm.Games.Store.MarketingEventIds MarketingEventIds;
                /*0x58*/ Dmm.Games.Store.Callback Callback;
                /*0x60*/ bool IsStandaloneAuthEnable;
                /*0x68*/ Dmm.Games.Store.AuthParams AuthParams;
                /*0x70*/ bool IsProfileRegisterSkipEnable;

                /*0x3fa72a4*/ DmmGamesStoreSdkSettings();
            }

            class MarketingEventIds
            {
                /*0x10*/ System.Collections.Generic.List<long> FirstBoot;
                /*0x18*/ System.Collections.Generic.List<long> Boot;
                /*0x20*/ System.Collections.Generic.List<long> Signup;
                /*0x28*/ System.Collections.Generic.List<long> Spend;
                /*0x30*/ System.Collections.Generic.List<long> Login;

                /*0x3fb313c*/ MarketingEventIds();
            }

            class DmmJsonUtil
            {
                static /*0x3fb1a3c*/ string GetHeadersJson(string key, string json);
                static /*0x3fb1cf0*/ System.Collections.Generic.Dictionary<string, string> GetHeadersDictionary(string json);
                static /*0x3fb325c*/ string RemoveEmpty(string json);
                /*0x3fb36a4*/ DmmJsonUtil();
            }

            class Error
            {
                /*0x10*/ string Message;
                /*0x18*/ string Class;
                /*0x20*/ System.Collections.Generic.List<Dmm.Games.Store.StackTraceElement> StackTraces;
                /*0x28*/ Dmm.Games.Store.Error Cause;

                /*0x3fb264c*/ Error();
            }

            class StackTraceElement
            {
                /*0x10*/ string Class;
                /*0x18*/ string File;
                /*0x20*/ string Method;
                /*0x28*/ int Line;

                /*0x3fb36ac*/ StackTraceElement();
            }

            class FunctionKind
            {
                static string Sdk = "sdk";
                static string Osapi = "Osapi";

                /*0x3fb36b4*/ FunctionKind();
            }

            class Function<T>
            {
                /*0x0*/ string Kind;
                /*0x0*/ T Parameters;

                /*0x38159dc*/ Function();
            }

            class GameEngine
            {
                /*0x10*/ string GameEngineName;
                /*0x18*/ Dmm.Games.Store.GameEngineParameter GameEngineParameter;

                /*0x3fb0b1c*/ GameEngine();
            }

            class GameEngineParameter
            {
                /*0x10*/ Dmm.Games.Store.Callback Callback;

                /*0x3fb36bc*/ GameEngineParameter();
            }

            class Callback
            {
                /*0x10*/ string GameObject;
                /*0x18*/ string MethodName;

                /*0x3fb3254*/ Callback();
            }

            enum Menu
            {
                DmmGamesStore = 0,
                PointCharge = 1,
                Settings = 2,
                MyGame = 3,
                Community = 4,
                Terms = 5,
                Inquiry = 6,
                Annonucement = 7,
                DmmAccountPage = 8,
                ApplicationUpdate = 9,
                SubscriptionContractPage = 10,
                GamesRankPage = 11,
            }

            class MenuExtention
            {
                static /*0x3fa3e6c*/ string GetName(Dmm.Games.Store.Menu menu);
            }

            class MenuParameter
            {
                /*0x10*/ string MenuKind;

                /*0x3fb36c4*/ MenuParameter();
            }

            class OAuthModel
            {
                /*0x10*/ string UserId;
                /*0x18*/ string ConsumerKey;
                /*0x20*/ string ConsumerSecret;
                /*0x28*/ string Token;
                /*0x30*/ string TokenSecret;

                /*0x3fb36cc*/ OAuthModel();
                /*0x3fb36d4*/ OAuthModel(Dmm.Games.Store.OAuthModel authModel);
            }

            class OsapiParameter
            {
                /*0x10*/ Dmm.Games.Store.OAuthModel Oauth;
                /*0x18*/ bool IsTwoLeggedOAuth;
                /*0x20*/ string Endpoint;

                /*0x3fb3754*/ OsapiParameter();
                /*0x3fb375c*/ OsapiParameter(Dmm.Games.Store.OsapiParameter osapiParameter);
                /*0x38148bc*/ string ConvertToJsonParameter();
                /*0x38148bc*/ string GetApiName();
                /*0x3fb1698*/ string ConvertToJson(string gameEngineName);
            }

            class RootParameter<T>
            {
                static string AndroidStoreSdk = "AndroidStoreSdk";
                /*0x0*/ string SdkType;
                /*0x0*/ Dmm.Games.Store.GameEngine GameEngine;
                /*0x0*/ Dmm.Games.Store.Function<T> Function;

                /*0x38159dc*/ RootParameter();
            }

            class SdkCommand
            {
                static string Init = "init";
                static string IsInit = "isInit";
                static string Menu = "menu";
                static string OpenPayment = "openPayment";
                static string ReceiptAuthData = "ReceiptAuthData";
                static string SendSpendEvent = "sendSpendEvent";

                /*0x3fb3804*/ SdkCommand();
            }

            class SdkParameter<T>
            {
                /*0x0*/ string SdkCommand;
                /*0x0*/ Dmm.Games.Store.DmmGamesStoreSdkSettings Setting;
                /*0x0*/ T Parameter;

                /*0x38159dc*/ SdkParameter();
            }

            class SdkParameter
            {
                /*0x10*/ string SdkCommand;
                /*0x18*/ Dmm.Games.Store.DmmGamesStoreSdkSettings Setting;

                /*0x3fb380c*/ SdkParameter();
            }

            class DmmSdkReceiveObject : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ System.Action<Dmm.Games.Store.InitializeData> _callbackInitialize;
                static /*0x8*/ System.Action<Dmm.Games.Store.OpenTransactionDialogData> _callbackPayment;
                static /*0x10*/ string _paymentId;

                /*0x3fb3bbc*/ DmmSdkReceiveObject();
                /*0x3fb1114*/ void SetInitializeCallback(System.Action<Dmm.Games.Store.InitializeData> callback);
                /*0x3fb3814*/ System.Action<Dmm.Games.Store.InitializeData> GetInitializeCallback();
                /*0x3fb385c*/ void OnInitializeCallback(string result);
                /*0x3fb309c*/ void SetPaymentCallback(System.Action<Dmm.Games.Store.OpenTransactionDialogData> callback);
                /*0x3fb39a8*/ System.Action<Dmm.Games.Store.OpenTransactionDialogData> GetPaymentCallback();
                /*0x3fb30ec*/ void SetPaymentId(string paymentId);
                /*0x3fb39f0*/ void OnPaymentCallback(string result);
                /*0x3910ae8*/ T ToObject<T>(string json);
            }

            class InitializeData
            {
                /*0x10*/ Dmm.Games.Store.InitializeResult Status;
                /*0x18*/ Dmm.Games.Store.Error Error;

                /*0x3fb108c*/ InitializeData();
            }

            enum InitializeResult
            {
                None = 0,
                Success = 1,
                Error = 2,
                IsAlreadyInitialized = 3,
            }

            class OpenTransactionDialogData
            {
                /*0x10*/ Dmm.Games.Store.OpenTransactionDialogResult Status;
                /*0x18*/ string PaymentId;
                /*0x20*/ Dmm.Games.Store.Error Error;

                /*0x3fb3094*/ OpenTransactionDialogData();
            }

            class OpenTransactionDialogModel
            {
                /*0x10*/ string ResponseCode;
                /*0x18*/ string PaymentId;
                /*0x20*/ bool Cancel;

                /*0x3fb3bc4*/ OpenTransactionDialogModel();
            }

            enum OpenTransactionDialogResult
            {
                None = 0,
                Success = 1,
                Cancel = 2,
                Error = 3,
            }

            class ActivityParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Guid;
                /*0x30*/ string Selector;
                /*0x38*/ string AppId;
                /*0x40*/ string Title;
                /*0x48*/ string Url;
                /*0x50*/ string MobileUrl;
                /*0x58*/ string TouchUrl;

                /*0x3fb3f58*/ ActivityParameter();
                /*0x3fb3bcc*/ string ConvertToJsonParameter();
                /*0x3fb3f18*/ string GetApiName();
            }

            class IgnoreListParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Guid;
                /*0x30*/ string Selector;
                /*0x38*/ string Pid;
                /*0x40*/ int Count;
                /*0x44*/ int StartIndex;

                /*0x3fb421c*/ IgnoreListParameter();
                /*0x3fb3f60*/ string ConvertToJsonParameter();
                /*0x3fb41dc*/ string GetApiName();
            }

            class InspectionParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string AppId;
                /*0x30*/ string Method;
                /*0x38*/ string TextId;
                /*0x40*/ string Text;

                /*0x3fb4484*/ InspectionParameter();
                /*0x3fb4224*/ string ConvertToJsonParameter();
                /*0x3fb4444*/ string GetApiName();
            }

            class MakeRequestParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Url;
                /*0x30*/ System.Collections.Generic.List<Dmm.Games.Store.PostData> Parameters;
                /*0x38*/ string SignaturePublicKey;

                /*0x3fb448c*/ MakeRequestParameter();
                /*0x3fb1420*/ MakeRequestParameter(Dmm.Games.Store.MakeRequestParameter makeRequestParameter);
                /*0x3fb455c*/ string PostDataToJson();
                /*0x3fb4818*/ string ConvertToJsonParameter();
                /*0x3fb49e8*/ string GetApiName();
            }

            class PostData
            {
                /*0x10*/ string Key;
                /*0x18*/ string Value;

                /*0x3fb4a28*/ PostData();
                /*0x3fb4514*/ PostData(Dmm.Games.Store.PostData postData);
            }

            class MessageParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Guid;
                /*0x30*/ string MsgCollId;
                /*0x38*/ System.Collections.Generic.List<string> Recipients;
                /*0x40*/ string Title;
                /*0x48*/ string Message;
                /*0x50*/ System.Collections.Generic.List<Dmm.Games.Store.Url> Urls;

                /*0x3fb4a30*/ MessageParameter();
                /*0x3fb4b0c*/ string UrlListToJson();
                /*0x3fb4db0*/ string RecipientsToJson();
                /*0x3fb4e58*/ string ConvertToJsonParameter();
                /*0x3fb50fc*/ string GetApiName();
            }

            class Url
            {
                /*0x10*/ string Value;
                /*0x18*/ string Type;

                /*0x3fb513c*/ Url();
                /*0x3fb4c58*/ string ConvertToJson();

                class Types
                {
                    static /*0x0*/ string Mobile;
                    static /*0x8*/ string Touch;
                    static /*0x10*/ string Canvas;

                    static /*0x3fb5144*/ Types();
                }
            }

            class PaymentParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Method;
                /*0x30*/ string Guid;
                /*0x38*/ string AppId;
                /*0x40*/ string PaymentId;
                /*0x48*/ string Selector;
                /*0x50*/ string Message;
                /*0x58*/ string CallbackUrl;
                /*0x60*/ System.Collections.Generic.List<Dmm.Games.Store.PaymentItem> Items;

                /*0x3fb5208*/ PaymentParameter();
                /*0x3fb5290*/ string get_ItemsJson();
                /*0x3fb56b0*/ string ConvertToJsonParameter();
                /*0x3fb5a58*/ string GetApiName();
            }

            class PaymentItem
            {
                /*0x10*/ string ItemId;
                /*0x18*/ string ItemName;
                /*0x20*/ int UnitPrice;
                /*0x24*/ int Quantity;
                /*0x28*/ string ImageUrl;
                /*0x30*/ string Description;

                /*0x3fb5a98*/ PaymentItem();
                /*0x3fb53d0*/ string ConvertToJson();
            }

            class PeopleParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Guid;
                /*0x30*/ string Selector;
                /*0x38*/ System.Collections.Generic.List<string> Fields;
                /*0x40*/ int Count;
                /*0x44*/ int StartIndex;
                /*0x48*/ Dmm.Games.Store.Filter Filter;

                /*0x3fb5aa0*/ PeopleParameter();
                /*0x3fb5b28*/ string FieldsToJson();
                /*0x3fb5bf0*/ string ConvertToJsonParameter();
                /*0x3fb5e64*/ string GetApiName();
            }

            class Filter
            {
                /*0x10*/ string Field;
                /*0x18*/ string Operand;
                /*0x20*/ string Value;

                /*0x3fb5ea4*/ Filter();
            }

            class ReceiptAuthDataParameter
            {
                /*0x10*/ string SdkCommand;

                /*0x3fb5eac*/ ReceiptAuthDataParameter();
            }

            class SendSpendEventParameter
            {
                /*0x10*/ string SdkCommand;
                /*0x18*/ Dmm.Games.Store.SendSpendEventParameter.AmountParameter Parameter;

                /*0x3fb5eb4*/ SendSpendEventParameter();

                class AmountParameter
                {
                    /*0x10*/ double Amount;

                    /*0x3fb5f20*/ AmountParameter();
                }
            }

            class ThumbnailParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string AppId;
                /*0x30*/ string Size;
                /*0x38*/ System.Collections.Generic.List<string> Pids;
                /*0x40*/ string AdjustVga;

                /*0x3fb5f28*/ ThumbnailParameter();
                /*0x3fb5fb0*/ string PidListToJson();
                /*0x3fb6058*/ string ConvertToJsonParameter();
                /*0x3fb6240*/ string GetApiName();
            }

            class Thumbnail
            {
                class Size
                {
                    static /*0x0*/ string Small;
                    static /*0x8*/ string Normal;
                    static /*0x10*/ string Large;
                    static /*0x18*/ string Huge;

                    static /*0x3fb6280*/ Size();
                }
            }

            class OsapiActivityResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.ActivityResult Response;

                /*0x3fb6374*/ OsapiActivityResult();
            }

            class ActivityResult
            {
                /*0x3fb6400*/ ActivityResult();
            }

            class OsapiIgnoreListResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.IgnoreListResult Response;

                /*0x3fb6408*/ OsapiIgnoreListResult();
            }

            class IgnoreListResult
            {
                /*0x10*/ int TotalResults;
                /*0x14*/ int ItemsPerPage;
                /*0x18*/ int StartIndex;
                /*0x20*/ System.Collections.Generic.List<Dmm.Games.Store.Entry> Items;

                /*0x3fb640c*/ IgnoreListResult();
            }

            class Entry
            {
                /*0x10*/ int Id;
                /*0x14*/ int IgnorelistId;

                /*0x3fb6494*/ Entry();
            }

            class OsapiInspectionResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.InspectionResult Response;

                /*0x3fb649c*/ OsapiInspectionResult();
            }

            class InspectionResult
            {
                /*0x10*/ System.Collections.Generic.List<Dmm.Games.Store.InspectionEntry> Entry;
                /*0x18*/ string Data;

                /*0x3fb64a0*/ InspectionResult();
            }

            class InspectionEntry
            {
                /*0x10*/ string TextId;
                /*0x18*/ string AppId;
                /*0x20*/ string AuthorId;
                /*0x28*/ string OwnerId;
                /*0x30*/ string Data;
                /*0x38*/ int Status;
                /*0x40*/ string Ctime;
                /*0x48*/ string Mtime;

                /*0x3fb6528*/ InspectionEntry();
            }

            class OsapiMakeRequestResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.MakeRequestResult Response;

                /*0x3fb6530*/ OsapiMakeRequestResult();
            }

            class MakeRequestResult
            {
                /*0x10*/ int Rc;
                /*0x18*/ string Body;
                /*0x20*/ System.Collections.Generic.Dictionary<string, string> Headers;

                /*0x3fb6534*/ MakeRequestResult();
            }

            class OsapiMessageResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.MessageResult Response;

                /*0x3fb65bc*/ OsapiMessageResult();
            }

            class MessageResult
            {
                /*0x3fb65c0*/ MessageResult();
            }

            class OsapiResult
            {
                /*0x10*/ bool HasBody;
                /*0x18*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> ResponseHeaders;
                /*0x20*/ bool IsNetworkErrorOccurred;
                /*0x28*/ string RawBody;
                /*0x30*/ int HttpStatus;
                /*0x38*/ Dmm.Games.Store.Error Error;

                /*0x3fb6378*/ OsapiResult();
            }

            class OsapiPaymentResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.PaymentResult Response;
                /*0x48*/ Dmm.Games.Store.Callback callback;
                /*0x50*/ int RequestCode;

                /*0x3fb66b4*/ OsapiPaymentResult();
                /*0x3fb65c8*/ Dmm.Games.Store.Callback get_Callback();
                /*0x3fb6638*/ void set_Callback(Dmm.Games.Store.Callback value);
            }

            class PaymentResult
            {
                /*0x10*/ string PaymentId;
                /*0x18*/ string AppId;
                /*0x20*/ string UserId;
                /*0x28*/ int Status;
                /*0x30*/ string TransactionUrl;
                /*0x38*/ string Message;
                /*0x40*/ System.Collections.Generic.List<Dmm.Games.Store.PaymentItem> PaymentItems;
                /*0x48*/ string OrderedTime;
                /*0x50*/ string ExecutedTime;

                /*0x3fb66c0*/ PaymentResult();
            }

            class OsapiPeopleResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.PeopleResult Response;

                /*0x3fb6748*/ OsapiPeopleResult();
            }

            class PeopleResult
            {
                /*0x10*/ System.Collections.Generic.List<Dmm.Games.Store.PeopleItem> Items;
                /*0x18*/ int TotalResults;
                /*0x1c*/ int ItemsPerPage;
                /*0x20*/ int StartIndex;

                /*0x3fb674c*/ PeopleResult();
            }

            class PeopleItem
            {
                /*0x10*/ string Id;
                /*0x18*/ string NickName;
                /*0x20*/ string DisplayName;
                /*0x28*/ string Grade;
                /*0x30*/ string Age;
                /*0x38*/ string AboutMe;
                /*0x40*/ string Birthday;
                /*0x48*/ string BloodType;
                /*0x50*/ string ChannelUserId;
                /*0x58*/ string ClientUserId;
                /*0x60*/ string Gender;
                /*0x68*/ bool HasApp;
                /*0x70*/ string ProfileUrl;
                /*0x78*/ string ThumbnailUrl;
                /*0x80*/ string ThumbnailUrlSmall;
                /*0x88*/ string ThumbnailUrlLarge;
                /*0x90*/ string ThumbnailUrlHuge;
                /*0x98*/ string UserType;
                /*0xa0*/ Dmm.Games.Store.Address Addresses;

                /*0x3fb67d4*/ PeopleItem();
            }

            class Address
            {
                /*0x10*/ string Formatted;

                /*0x3fb67dc*/ Address();
            }

            class ReceiptAuthDataResult
            {
                /*0x10*/ string DmmAccessToken;
                /*0x18*/ string DmmOpenId;
                /*0x20*/ Dmm.Games.Store.Error Error;

                /*0x3fb67e4*/ ReceiptAuthDataResult();
            }

            class SdkResult
            {
                /*0x10*/ bool IsAlreadyInitialized;
                /*0x11*/ bool IsInitializeStarted;
                /*0x12*/ bool IsInitialized;
                /*0x13*/ bool IsStartedPaymentView;
                /*0x18*/ string GamesId;
                /*0x20*/ bool IsSuccess;
                /*0x21*/ bool Success;
                /*0x28*/ Dmm.Games.Store.Error Error;

                /*0x3fb67f8*/ SdkResult();
                /*0x3fb67ec*/ string get_DmmGamesId();
                /*0x3fb67f4*/ void set_DmmGamesId(string value);
            }

            class SendSpendEventResult
            {
                /*0x10*/ bool Success;
                /*0x18*/ Dmm.Games.Store.Error Error;

                /*0x3fb6800*/ SendSpendEventResult();
            }

            class OsapiThumbnailResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.ThumbnailResult Response;

                /*0x3fb6808*/ OsapiThumbnailResult();
            }

            class ThumbnailResult
            {
                /*0x10*/ System.Collections.Generic.List<Dmm.Games.Store.ThumbnailEntry> Entry;

                /*0x3fb680c*/ ThumbnailResult();
            }

            class ThumbnailEntry
            {
                /*0x10*/ string Id;
                /*0x18*/ string Url;

                /*0x3fb6894*/ ThumbnailEntry();
            }

            class ApiCoroutine : UnityEngine.MonoBehaviour
            {
                static /*0x3fb689c*/ Dmm.Games.Store.ApiCoroutine Initialize();
                /*0x3fb6a48*/ ApiCoroutine();
                /*0x3fb6928*/ void Execution(System.Action action);
                /*0x3fb6948*/ System.Collections.IEnumerator Coroutine(System.Action action);
                /*0x3fb69dc*/ void Release();

                class <Coroutine>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ System.Action action;

                    /*0x3fb69b4*/ <Coroutine>d__2(int <>1__state);
                    /*0x3fb6a50*/ void System.IDisposable.Dispose();
                    /*0x3fb6a54*/ bool MoveNext();
                    /*0x3fb6ac0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fb6ac8*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fb6b00*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class FontApplier : UnityEngine.MonoBehaviour
            {
                static float TextScaleMag = 4;
                /*0x20*/ UnityEngine.Font targetFont;
                /*0x28*/ bool initialized;

                /*0x3fb6c70*/ FontApplier();
                /*0x3fb6b08*/ void Awake();
                /*0x3fb6b0c*/ void ApplyFontToAllTexts();
            }

            class FontGetter : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Font font;

                /*0x3fb6c80*/ FontGetter();
                /*0x3fb6c78*/ UnityEngine.Font get_Font();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 3F1B5F4364C9E778A7004662616A3FDF7CE00922EFE4E8A86B9A1C95C6C7CCD8;
    static /*0x3e55*/ <PrivateImplementationDetails> FDE0EF5EFF4E963945794FE121EE6076F578BBBFB0EB39298B8EE189708ED9E9;

    static /*0x3fb6c88*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=10290
    {
    }

    struct __StaticArrayInitTypeSize=15957
    {
    }
}
