class <Module>
{
}

class AuthSdkInfo
{
    static string Version = "6.2.2";
    static string Production = "AuthSDK-6.2.2-prod.aar";
    static string Staging = "AuthSDK-6.2.2-stg.aar";

    /*0x3f7b0e8*/ AuthSdkInfo();
}

class DmmGamesIapStoreSubscriptionExtendErrorCode
{
    static string PurchaseCreditError = "E-041-422-010";
    static string PurchaseCreditAltError = "E-041-422-011";
    static string AlreadyPurchasedError = "E-042-422-004";
    static string AlreadyPurchasedAltError = "E-041-422-013";
    static string AlreadyCanceledError = "E-042-422-005";
    static string AlreadyCanceledAltError = "E-041-422-014";

    /*0x3f7b0f0*/ DmmGamesIapStoreSubscriptionExtendErrorCode();
}

class ScreenUtility : UnityEngine.MonoBehaviour
{
    static /*0x3f7b0f8*/ UnityEngine.DeviceOrientation GetOrientation();
    /*0x3f7b124*/ ScreenUtility();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3f7b12c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3f7b220*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

                    static /*0x3f7b228*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                    static /*0x3f7b6c4*/ void Begin(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, System.Action finish);
                    static /*0x3f7b75c*/ void Finish();
                    /*0x3f7b964*/ Complete();
                    /*0x3f7b630*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f7b8ac*/ void LogoDestroy();

                    class <>c
                    {
                        static /*0x0*/ DMM.Games.Recibo.Ui.Complete.<> <>9;
                        static /*0x8*/ UnityEngine.Events.UnityAction <>9__10_0;
                        static /*0x10*/ UnityEngine.Events.UnityAction <>9__10_1;

                        static /*0x3f7b96c*/ <>c();
                        /*0x3f7b9d4*/ <>c();
                        /*0x3f7b9dc*/ void <Init>b__10_0();
                        /*0x3f7ba38*/ void <Init>b__10_1();
                    }
                }

                class CouponListSingleton : DMM.Games.Recibo.Ui.SingletonComponent<DMM.Games.Recibo.Ui.CouponListSingleton>
                {
                    /*0x20*/ string _couponId;
                    /*0x28*/ bool _isSelectCoupon;
                    /*0x2c*/ int _toggleSelectIndex;
                    /*0x30*/ System.Collections.Generic.Dictionary<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> _couponList;

                    /*0x3f7c3b0*/ CouponListSingleton();
                    /*0x3f7ba94*/ System.Collections.Generic.Dictionary<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> get_GetCouponList();
                    /*0x3f7ba9c*/ void SetCouponListData(DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] coupons);
                    /*0x3f7baa0*/ void CreateCouponListData(DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] coupons);
                    /*0x3f7bd00*/ void UpdateCouponListData(string couponId, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData data);
                    /*0x3f7bdcc*/ DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData FindCouponListData(string couponId);
                    /*0x3f7bf84*/ DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData FindCouponListData(int index);
                    /*0x3f7c0f0*/ int GetSelectCouponIndex();
                    /*0x3f7c24c*/ void SetBannerCache(string couponId, UnityEngine.Sprite bannerCache);
                    /*0x3f7c2b0*/ void SetCouponValue(string couponId, int billingAmount, int couponDiscountAmount);
                    /*0x3f7c30c*/ void UpdateDropDownSortValue(string couponId, int index, bool isSelectCoupon);
                    /*0x3f7c37c*/ string GetSelectCouponId();
                    /*0x3f7c384*/ void SetSelectCouponId(string couponId);
                    /*0x3f7c38c*/ bool GetIsSelectCoupon();
                    /*0x3f7c394*/ void SetIsSelectCoupon(bool isSelectCoupon);
                    /*0x3f7c3a0*/ int GetSelectToggleIndex();
                    /*0x3f7c3a8*/ void SetSelectToggleIndex(int toggleSelectIndex);

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

                        /*0x3f7c544*/ CouponListData();
                        /*0x3f7bc30*/ CouponListData(string couponId, string couponName, int billingAmount, int couponDiscountAmount, int orderPrice, int index, int discountedAmount, long acquiredAtValue, long useEndAtValue, UnityEngine.Sprite bannerCache, bool isSelectCoupon, DMM.Games.Recibo.Api.Coupon.Model.CouponModel couponModel);
                        /*0x3f7c480*/ string get_CouponId();
                        /*0x3f7c488*/ void set_CouponId(string value);
                        /*0x3f7c490*/ string get_CouponName();
                        /*0x3f7c498*/ void set_CouponName(string value);
                        /*0x3f7c4a0*/ int get_BillingAmount();
                        /*0x3f7c4a8*/ void set_BillingAmount(int value);
                        /*0x3f7c4b0*/ int get_CouponDiscountAmount();
                        /*0x3f7c4b8*/ void set_CouponDiscountAmount(int value);
                        /*0x3f7c4c0*/ int get_OrderPrice();
                        /*0x3f7c4c8*/ void set_OrderPrice(int value);
                        /*0x3f7c4d0*/ int get_Index();
                        /*0x3f7c4d8*/ void set_Index(int value);
                        /*0x3f7c4e0*/ int get_DiscountedAmount();
                        /*0x3f7c4e8*/ void set_DiscountedAmount(int value);
                        /*0x3f7c4f0*/ long get_AcquiredAtValue();
                        /*0x3f7c4f8*/ void set_AcquiredAtValue(long value);
                        /*0x3f7c500*/ long get_UseEndAtValue();
                        /*0x3f7c508*/ void set_UseEndAtValue(long value);
                        /*0x3f7c510*/ UnityEngine.Sprite get_BannerCache();
                        /*0x3f7c518*/ void set_BannerCache(UnityEngine.Sprite value);
                        /*0x3f7c520*/ bool get_IsSelectCoupon();
                        /*0x3f7c528*/ void set_IsSelectCoupon(bool value);
                        /*0x3f7c534*/ DMM.Games.Recibo.Api.Coupon.Model.CouponModel get_CouponModel();
                        /*0x3f7c53c*/ void set_CouponModel(DMM.Games.Recibo.Api.Coupon.Model.CouponModel value);
                        /*0x3f7c2a8*/ void SetBannerCache(UnityEngine.Sprite bannerCache);
                        /*0x3f7c304*/ void SetCouponValue(int billingAmount, int couponDiscountAmount);
                        /*0x3f7c368*/ void SetDropDownSortValue(int index);
                        /*0x3f7c370*/ void SetIsSelectCoupon(bool isSelectCoupon);
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

                    static /*0x3f7c54c*/ bool Init();
                    static /*0x3f7c8b0*/ void Show();
                    static /*0x3f7c910*/ void Hide();
                    /*0x3f7cb18*/ Loading();
                    /*0x3f7c7a0*/ void Update();
                    /*0x3f7c70c*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f7ca60*/ void LogoDestroy();
                }

                class LogoManager
                {
                    static /*0x0*/ string SubscriptionDmmGamesLogo;
                    static /*0x8*/ string SubscriptionFanzaGamesLogo;
                    static /*0x10*/ UnityEngine.Sprite _logo;

                    static /*0x3f7cd40*/ LogoManager();
                    static /*0x3f7cb2c*/ void Init(bool isAdult);
                    static /*0x3f7cc60*/ UnityEngine.Sprite Load(bool isAdult);
                    static /*0x3f7cce0*/ UnityEngine.Sprite Get();
                    static /*0x3f7cc04*/ void Release();
                    /*0x3f7cd38*/ LogoManager();
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

                    static /*0x3f7ce78*/ ErrorObject();
                    /*0x3f7ce70*/ ErrorObject();
                    /*0x3f7cddc*/ UnityEngine.Purchasing.PurchaseFailureReason get_Reason();
                    /*0x3f7cde4*/ void SetReason(int code);
                    /*0x3f7ce20*/ UnityEngine.Purchasing.ProductDefinition get_Product();
                    /*0x3f7ce28*/ void SetProductDefinition(UnityEngine.Purchasing.ProductDefinition product);
                    /*0x3f7ce30*/ string get_Kind();
                    /*0x3f7ce38*/ int get_Code();
                    /*0x3f7ce40*/ string get_SubscriptionCode();
                    /*0x3f7ce48*/ string get_Message();
                    /*0x3f7ce50*/ void SetKind(string kind);
                    /*0x3f7ce58*/ void SetCode(int code);
                    /*0x3f7ce60*/ void SetSubscriptionCode(string code);
                    /*0x3f7ce68*/ void SetMessage(string message);
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

                    /*0x3f7f710*/ PurchaseProcess();
                    /*0x3f7d19c*/ void Execution(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Purchasing.ProductDefinition product, string developerPayload, System.Action<System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel>> successAction, System.Action<DMM.Games.Recibo.Ui.ErrorObject> errorAction);
                    /*0x3f7d228*/ void Update();
                    /*0x3f7d36c*/ void InitSDKState();
                    /*0x3f7d458*/ void CheckErrorState();
                    /*0x3f7d488*/ void ShowErrorDialogState();
                    /*0x3f7d910*/ void ShowRetryDialogState();
                    /*0x3f7d9cc*/ void CheckOrderPurchasedState();
                    /*0x3f7da6c*/ void CreateOrderState();
                    /*0x3f7dd0c*/ void GetBalanceState();
                    /*0x3f7dea8*/ void GetGrantUserRankPoints();
                    /*0x3f7e198*/ void ShowOrderDialogState();
                    /*0x3f7e50c*/ void GetAvailableCouponsState();
                    /*0x3f7e6e0*/ void ShowCouponListDialogState();
                    /*0x3f7e868*/ void CancelState();
                    /*0x3f7e8a4*/ void PurchasingState();
                    /*0x3f7eac4*/ void CompleteState();
                    /*0x3f7eb4c*/ void FinishState();
                    /*0x3f7f4f8*/ void SetState(DMM.Games.Recibo.Ui.PurchaseState state);
                    /*0x3f7ee24*/ void ErrorTransition(DMM.Games.Recibo.Ui.ErrorObject error, DMM.Games.Recibo.Ui.PurchaseState retryState);
                    /*0x3f7ed00*/ DMM.Games.Recibo.Ui.ErrorObject GetErrorObject(int code, string message);
                    /*0x3f7f1f4*/ long GetAvailablePoint();
                    /*0x3f7f288*/ long GetProductPoint();
                    /*0x3f7f038*/ long CheckProductPoint();
                    /*0x3f7f328*/ UnityEngine.Texture2D GetProductIcon();
                    /*0x3f7f500*/ void CancelOrder(System.Action action);
                    /*0x3f7f1b0*/ bool IsAvailablePurchase();
                    /*0x3f7f758*/ void <ShowRetryDialogState>b__23_0();
                    /*0x3f7f8c4*/ void <ShowRetryDialogState>b__23_1();
                    /*0x3f7f8d0*/ void <CreateOrderState>b__25_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Order.Model.OrderModel response);
                    /*0x3f7f994*/ void <CreateOrderState>b__25_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f7fa04*/ void <CreateOrderState>b__25_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f7fa48*/ void <GetBalanceState>b__26_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Model.PointBalanceModel response);
                    /*0x3f7fae8*/ void <GetBalanceState>b__26_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f7fb58*/ void <GetBalanceState>b__26_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f7fb9c*/ void <GetGrantUserRankPoints>b__27_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Orders.Model.OrdersModel response);
                    /*0x3f7fc20*/ void <GetGrantUserRankPoints>b__27_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f7fc30*/ void <GetGrantUserRankPoints>b__27_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f7fc40*/ void <GetAvailableCouponsState>b__29_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel response);
                    /*0x3f7fc78*/ void <GetAvailableCouponsState>b__29_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f7fce8*/ void <GetAvailableCouponsState>b__29_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f7fd2c*/ void <ShowCouponListDialogState>b__30_0();
                    /*0x3f7fe88*/ void <ShowCouponListDialogState>b__30_1();
                    /*0x3f7fe94*/ void <PurchasingState>b__32_0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel response);
                    /*0x3f7ff54*/ void <PurchasingState>b__32_1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                    /*0x3f7ffc4*/ void <PurchasingState>b__32_2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    /*0x3f80008*/ void <CompleteState>b__33_0();

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ DMM.Games.Recibo.Ui.PurchaseProcess <>4__this;
                        /*0x18*/ string url;

                        /*0x3f7ee64*/ <>c__DisplayClass22_0();
                        /*0x3f80014*/ void <ShowErrorDialogState>b__0();
                        /*0x3f80184*/ void <ShowErrorDialogState>b__1();
                        /*0x3f801e0*/ void <ShowErrorDialogState>b__2();
                    }

                    class <>c__DisplayClass28_0
                    {
                        /*0x10*/ DMM.Games.Recibo.Ui.PurchaseProcess <>4__this;
                        /*0x18*/ bool isAvailablePurchase;
                        /*0x20*/ System.Action <>9__3;
                        /*0x28*/ UnityEngine.Events.UnityAction <>9__4;
                        /*0x30*/ System.Action <>9__6;
                        /*0x38*/ UnityEngine.Events.UnityAction <>9__5;

                        /*0x3f7f1a8*/ <>c__DisplayClass28_0();
                        /*0x3f8033c*/ void <ShowOrderDialogState>b__0();
                        /*0x3f80548*/ void <ShowOrderDialogState>b__3();
                        /*0x3f80570*/ void <ShowOrderDialogState>b__1();
                        /*0x3f8084c*/ void <ShowOrderDialogState>b__4();
                        /*0x3f809ac*/ void <ShowOrderDialogState>b__5();
                        /*0x3f80a68*/ void <ShowOrderDialogState>b__6();
                        /*0x3f80a90*/ void <ShowOrderDialogState>b__2();
                    }

                    class <>c__DisplayClass42_0
                    {
                        /*0x10*/ System.Action action;

                        /*0x3f7f708*/ <>c__DisplayClass42_0();
                        /*0x3f80ab0*/ void <CancelOrder>b__0(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Order.Model.OrderModel response);
                        /*0x3f80ad4*/ void <CancelOrder>b__1(object _tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f80af8*/ void <CancelOrder>b__2(object _tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
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

                    static /*0x3f80b1c*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string productTitle, UnityEngine.Texture2D productIcon, string developerPayload, UnityEngine.Events.UnityAction onCLickContinueButton, UnityEngine.Events.UnityAction onClickCancelButton);
                    static /*0x3f80798*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string productTitle, UnityEngine.Texture2D productIcon, string developerPayload, UnityEngine.Events.UnityAction onClickContinueButton, UnityEngine.Events.UnityAction onClickCancelButton);
                    static /*0x3f80870*/ void Hide();
                    /*0x3f8112c*/ ShowChargeContinueDialog();
                    /*0x3f80fbc*/ void SetProductTitle(string title);
                    /*0x3f81108*/ void SetProductSubTitle(string subTitle);
                    /*0x3f80fe0*/ void SetProductIcon(UnityEngine.Texture2D icon);
                    /*0x3f81074*/ void SetLogo(UnityEngine.Sprite logo);
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

                    /*0x3f824b0*/ ShowCouponData();
                    /*0x3f81134*/ void Init(DMM.Games.Recibo.Ui.ShowCouponDetailData couponDetailData, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon);
                    /*0x3f81230*/ void UpdateData(DMM.Games.Recibo.Ui.ShowCouponDetailData couponDetailData, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon);
                    /*0x3f81170*/ void SetData(DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon);
                    /*0x3f81314*/ void UpdateCloseFrame(bool isActive);
                    /*0x3f81368*/ void SetToggleSprite(bool isAvailable);
                    /*0x3f81480*/ System.Threading.Tasks.Task LoadBannerImageAsync(string bannerUrl);
                    /*0x3f81bc0*/ System.Threading.Tasks.Task LoadImage(string url);
                    /*0x3f81cb8*/ void SetBannerImage(UnityEngine.UI.RawImage image, UnityEngine.Sprite sprite);
                    /*0x3f81aa0*/ void UpdateTag(DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon);
                    /*0x3f81cec*/ void SetTagAreaActive(int index, bool isActive);
                    /*0x3f81d28*/ void SetTagInfo(int id, UnityEngine.RectTransform[] tagGameObjects, UnityEngine.UI.Text[] tagTexts, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData data);
                    /*0x3f82280*/ void SetTagText(UnityEngine.UI.Text tagText, string colorCode, string text);
                    /*0x3f82300*/ void SetTagFrame(UnityEngine.UI.Image img, string colorCode);
                    /*0x3f820b8*/ float GetLabelLength(string text);
                    /*0x3f82350*/ bool IsOnlyAlphanumeric(string text);
                    /*0x3f8157c*/ void SetDiscountAmount(bool isAvailable, int discountAmount);
                    /*0x3f81718*/ void SetCouponName(string couponName);
                    /*0x3f81818*/ void SetNumberOfTimesOfUse(int remainedCount);
                    /*0x3f819fc*/ void SetExpiryDate(string useEndAt);
                    /*0x3f8126c*/ void SetButtonAction();
                    /*0x3f824a8*/ void OnCloseFrameButton();
                    /*0x3f823c0*/ string CommaFormat(long number);

                    class <>c
                    {
                        static /*0x0*/ DMM.Games.Recibo.Ui.ShowCouponData.<> <>9;
                        static /*0x8*/ System.Func<char, string> <>9__46_0;

                        static /*0x3f824b8*/ <>c();
                        /*0x3f82520*/ <>c();
                        /*0x3f82528*/ string <GetLabelLength>b__46_0(char x);
                    }

                    struct <LoadBannerImageAsync>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ DMM.Games.Recibo.Ui.ShowCouponData <>4__this;
                        /*0x38*/ string bannerUrl;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x3f8255c*/ void MoveNext();
                        /*0x3f8287c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <LoadImage>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ string url;
                        /*0x38*/ DMM.Games.Recibo.Ui.ShowCouponData <>4__this;
                        /*0x40*/ UnityEngine.Networking.UnityWebRequest <www>5__2;
                        /*0x48*/ object <>u__1;

                        /*0x3f828e4*/ void MoveNext();
                        /*0x3f82ea0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3f83924*/ ShowCouponDetailData();
                    /*0x3f82f08*/ void Init(DMM.Games.Recibo.Ui.ShowCouponData couponData, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon, DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] notice);
                    /*0x3f82f74*/ void UpdateData(DMM.Games.Recibo.Ui.ShowCouponData couponData, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon, DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] notice);
                    /*0x3f82f44*/ void SetData(DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon, DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] notice);
                    /*0x3f82fb0*/ void SetButtonAction();
                    /*0x3f833f4*/ void OnOpenFrameButton();
                    /*0x3f83410*/ string SetDiscountText(int discountAmount, int discountRate, int maxDiscountAmount);
                    /*0x3f836f0*/ string SetUseConditionDetail(int minPayment, int useLimit, int useLimitPerUser);
                    /*0x3f83058*/ void SetDetailDescription(DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData coupon, DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] notice);
                    /*0x3f83608*/ string CommaFormat(long number);
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

                    static /*0x3f8392c*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, DMM.Games.Recibo.Ui.ShowCouponListDialogModel data);
                    static /*0x3f7f450*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, DMM.Games.Recibo.Ui.ShowCouponListDialogModel data);
                    static /*0x3f7fd38*/ void Hide();
                    /*0x3f863e0*/ ShowCouponListDialog();
                    /*0x3f83bf4*/ void Initialized();
                    /*0x3f83cfc*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowCouponListDialogModel data);
                    /*0x3f83eb4*/ void SetCoupon(int totalCount, bool isInit);
                    /*0x3f84b98*/ void UpdateCoupon();
                    /*0x3f84830*/ void UpdateCouponData(bool isInit);
                    /*0x3f84c4c*/ int SetSortList(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData>> sortedList, int index, bool isAvailable);
                    /*0x3f84530*/ void SortDropDownValue();
                    /*0x3f84fe4*/ void OnDropDownValueChanged(int value);
                    /*0x3f84494*/ void SetCouponCount(int totalCount);
                    /*0x3f8406c*/ void SetToggleGroupButton();
                    /*0x3f84ff0*/ void OnToggleValueChanged(bool state);
                    /*0x3f852c8*/ void UpdateToggleData();
                    /*0x3f85488*/ void SetToggleList(int index, int count);
                    /*0x3f85164*/ int GetToggleValue(int key);
                    /*0x3f84adc*/ void UpdatePaging(int pageCount);
                    /*0x3f854f0*/ DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState GetPageState(int currentPage, int pageMax);
                    /*0x3f84294*/ void SetPageButton();
                    /*0x3f85a30*/ System.Collections.Generic.List<int> GetPageIndexList(DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState pageState);
                    /*0x3f85534*/ void UpdatePageValue(DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState pageState, int currentPage);
                    /*0x3f85680*/ void UpdatePageObject(DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState pageState, int currentPage);
                    /*0x3f858d4*/ void UpdatePageText(DMM.Games.Recibo.Ui.ShowCouponListDialog.PageState pageState, int currentPage);
                    /*0x3f85f6c*/ void SetPageList(int index, int page);
                    /*0x3f85fd4*/ int GetPageValue(int key);
                    /*0x3f86130*/ void OnPageButton(int index);
                    /*0x3f8614c*/ void OnPageNextButton(int index);
                    /*0x3f86178*/ void OnPageBackButton(int index);
                    /*0x3f86198*/ void OnCancelButton();
                    /*0x3f862a0*/ void OnDecideButton();
                    /*0x3f83f20*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f83fb4*/ void LogoDestroy();

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

                        static /*0x3f864e0*/ <>c();
                        /*0x3f86548*/ <>c();
                        /*0x3f86550*/ int <SortDropDownValue>b__46_0(System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> x);
                        /*0x3f86594*/ long <SortDropDownValue>b__46_1(System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> x);
                        /*0x3f865d8*/ long <SortDropDownValue>b__46_2(System.Collections.Generic.KeyValuePair<string, DMM.Games.Recibo.Ui.CouponListSingleton.CouponListData> x);
                    }

                    class <>c__DisplayClass56_0
                    {
                        /*0x10*/ int index;
                        /*0x18*/ DMM.Games.Recibo.Ui.ShowCouponListDialog <>4__this;

                        /*0x3f85a28*/ <>c__DisplayClass56_0();
                        /*0x3f8661c*/ void <SetPageButton>b__0();
                        /*0x3f86658*/ void <SetPageButton>b__1();
                        /*0x3f86684*/ void <SetPageButton>b__2();
                    }
                }

                class ShowCouponListDialogModel
                {
                    /*0x10*/ DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel <AvailableCoupons>k__BackingField;
                    /*0x18*/ UnityEngine.Events.UnityAction <OnClickPositiveButton>k__BackingField;
                    /*0x20*/ UnityEngine.Events.UnityAction <OnClickNegativeButton>k__BackingField;
                    /*0x28*/ int <SortingOrder>k__BackingField;
                    /*0x30*/ UnityEngine.Sprite <LogoImage>k__BackingField;

                    /*0x3f7f440*/ ShowCouponListDialogModel();
                    /*0x3f866cc*/ DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel get_AvailableCoupons();
                    /*0x3f866d4*/ void set_AvailableCoupons(DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel value);
                    /*0x3f866dc*/ UnityEngine.Events.UnityAction get_OnClickPositiveButton();
                    /*0x3f866e4*/ void set_OnClickPositiveButton(UnityEngine.Events.UnityAction value);
                    /*0x3f866ec*/ UnityEngine.Events.UnityAction get_OnClickNegativeButton();
                    /*0x3f866f4*/ void set_OnClickNegativeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f866fc*/ int get_SortingOrder();
                    /*0x3f86704*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f8670c*/ void set_LogoImage(UnityEngine.Sprite value);
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

                    static /*0x3f86714*/ bool Init(DMM.Games.Recibo.Ui.ShowErrorDialogModel data);
                    static /*0x3f86a3c*/ void Show(DMM.Games.Recibo.Ui.ShowErrorDialogModel data);
                    static /*0x3f86ab0*/ void Hide();
                    /*0x3f86cb8*/ ShowErrorDialog();
                    /*0x3f86920*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowErrorDialogModel data);
                    /*0x3f868fc*/ void SetMessage(string message);
                    /*0x3f869a8*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f86c00*/ void LogoDestroy();
                }

                class ShowErrorDialogModel
                {
                    /*0x10*/ string <Message>k__BackingField;
                    /*0x18*/ UnityEngine.Events.UnityAction <OnClickCloseButton>k__BackingField;
                    /*0x20*/ UnityEngine.Events.UnityAction <OnClickInquiryButton>k__BackingField;
                    /*0x28*/ int <SortingOrder>k__BackingField;
                    /*0x30*/ UnityEngine.Sprite <LogoImage>k__BackingField;

                    /*0x3f86d08*/ ShowErrorDialogModel();
                    /*0x3f86cc0*/ string get_Message();
                    /*0x3f86cc8*/ void set_Message(string value);
                    /*0x3f86cd0*/ UnityEngine.Events.UnityAction get_OnClickCloseButton();
                    /*0x3f86cd8*/ void set_OnClickCloseButton(UnityEngine.Events.UnityAction value);
                    /*0x3f86ce0*/ UnityEngine.Events.UnityAction get_OnClickInquiryButton();
                    /*0x3f86ce8*/ void set_OnClickInquiryButton(UnityEngine.Events.UnityAction value);
                    /*0x3f86cf0*/ int get_SortingOrder();
                    /*0x3f86cf8*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f86d00*/ void set_LogoImage(UnityEngine.Sprite value);
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

                    static /*0x3f86d18*/ bool Init(DMM.Games.Recibo.Ui.ShowMaintenanceDialogModel data);
                    static /*0x3f870b0*/ void Show(DMM.Games.Recibo.Ui.ShowMaintenanceDialogModel data);
                    static /*0x3f80034*/ void Hide();
                    /*0x3f871dc*/ ShowMaintenanceDialog();
                    /*0x3f86f94*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowMaintenanceDialogModel data);
                    /*0x3f86f3c*/ void SetButtonText(DMM.Games.Recibo.Ui.ShowMaintenanceDialogModel data);
                    /*0x3f86f18*/ void SetMessage(string message);
                    /*0x3f8701c*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f87124*/ void LogoDestroy();
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

                    /*0x3f8724c*/ ShowMaintenanceDialogModel();
                    /*0x3f871e4*/ string get_Message();
                    /*0x3f871ec*/ void set_Message(string value);
                    /*0x3f871f4*/ UnityEngine.Events.UnityAction get_OnClickPositiveButton();
                    /*0x3f871fc*/ void set_OnClickPositiveButton(UnityEngine.Events.UnityAction value);
                    /*0x3f87204*/ UnityEngine.Events.UnityAction get_OnClickNegativeButton();
                    /*0x3f8720c*/ void set_OnClickNegativeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f87214*/ string get_PositiveButtonText();
                    /*0x3f8721c*/ void set_PositiveButtonText(string value);
                    /*0x3f87224*/ string get_NegativeButtonText();
                    /*0x3f8722c*/ void set_NegativeButtonText(string value);
                    /*0x3f87234*/ int get_SortingOrder();
                    /*0x3f8723c*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f87244*/ void set_LogoImage(UnityEngine.Sprite value);
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

                    static /*0x3f8725c*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, DMM.Games.Recibo.Ui.ShowOrderDialogModel data);
                    static /*0x3f7f3c4*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, DMM.Games.Recibo.Ui.ShowOrderDialogModel data);
                    static /*0x3f803f8*/ void Hide();
                    static /*0x3f8834c*/ void UpdatePositiveButtonText(string text);
                    /*0x3f889c8*/ ShowOrderDialog();
                    /*0x3f8833c*/ void SetStore(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                    /*0x3f877e4*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowOrderDialogModel data);
                    /*0x3f87e1c*/ void SetPositiveButtonText(string text);
                    /*0x3f87e40*/ void SetAvailablePurchase(bool isAvailablePurchase);
                    /*0x3f87ea0*/ void SetUserRankInfo(System.Nullable<DMM.Games.Recibo.Api.Orders.Model.OrdersModel> grantUserRankPointModel);
                    /*0x3f878d4*/ void SetDeveloperPayloadAction(string json);
                    /*0x3f8762c*/ void SetProductTitle(string title);
                    /*0x3f87650*/ void SetProductPoint(long point);
                    /*0x3f876d0*/ void SetAvailablePoint(long point);
                    /*0x3f883d8*/ string CommaFormat(long number);
                    /*0x3f87750*/ void SetProductIcon(UnityEngine.Texture2D icon);
                    /*0x3f8802c*/ void SetIsUseCoupon(int couponCount, bool isSelectCoupon);
                    /*0x3f88090*/ void SetCouponInfo(DMM.Games.Recibo.Ui.ShowOrderDialogModel data, int couponCount, bool isUseCoupon);
                    /*0x3f888a4*/ void SetAdvantageousCouponBadge();
                    /*0x3f884c0*/ void SetInfoActive(bool isTotalInfoActive, bool isCouponTotalInfoActive, bool isCouponInfoActive, bool isCouponUseInfoActive);
                    /*0x3f88948*/ void SetTotalInfoActive(bool isActive);
                    /*0x3f88968*/ void SetCouponTotalInfoActive(bool isActive);
                    /*0x3f885ac*/ void SetCouponTotal(long subTotalPoint, long couponPoint, long totalPoint);
                    /*0x3f88988*/ void SetCouponInfoActive(bool isActive);
                    /*0x3f88808*/ void SetCouponCount(int count);
                    /*0x3f889a8*/ void SetCouponUseInfoActive(bool isActive);
                    /*0x3f8870c*/ void SetCouponName(string couponName);
                    /*0x3f881ec*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f88280*/ void LogoDestroy();
                    /*0x3f889d0*/ void <SetDeveloperPayloadAction>b__49_0();
                    /*0x3f88a40*/ void <SetDeveloperPayloadAction>b__49_1();
                    /*0x3f88ab0*/ void <SetDeveloperPayloadAction>b__49_2();
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

                    /*0x3f7f1e4*/ ShowOrderDialogModel();
                    /*0x3f88b20*/ string get_ProductTitle();
                    /*0x3f88b28*/ void set_ProductTitle(string value);
                    /*0x3f88b30*/ long get_ProductPoint();
                    /*0x3f88b38*/ void set_ProductPoint(long value);
                    /*0x3f88b40*/ long get_AvailablePoint();
                    /*0x3f88b48*/ void set_AvailablePoint(long value);
                    /*0x3f88b50*/ string get_DeveloperPayload();
                    /*0x3f88b58*/ void set_DeveloperPayload(string value);
                    /*0x3f88b60*/ bool get_IsAvailablePurchase();
                    /*0x3f88b68*/ void set_IsAvailablePurchase(bool value);
                    /*0x3f88b74*/ UnityEngine.Texture2D get_ProductIcon();
                    /*0x3f88b7c*/ void set_ProductIcon(UnityEngine.Texture2D value);
                    /*0x3f88b84*/ UnityEngine.Events.UnityAction get_OnClickPositiveButton();
                    /*0x3f88b8c*/ void set_OnClickPositiveButton(UnityEngine.Events.UnityAction value);
                    /*0x3f88b94*/ UnityEngine.Events.UnityAction get_OnClickNegativeButton();
                    /*0x3f88b9c*/ void set_OnClickNegativeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f88ba4*/ UnityEngine.Events.UnityAction get_OnClickCupoonChangeButton();
                    /*0x3f88bac*/ void set_OnClickCupoonChangeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f88bb4*/ int get_CouponCounts();
                    /*0x3f88bbc*/ void set_CouponCounts(int value);
                    /*0x3f88bc4*/ string get_CouponId();
                    /*0x3f88bcc*/ void set_CouponId(string value);
                    /*0x3f88bd4*/ bool get_IsSelectCoupon();
                    /*0x3f88bdc*/ void set_IsSelectCoupon(bool value);
                    /*0x3f88be8*/ int get_SortingOrder();
                    /*0x3f88bf0*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f88bf8*/ void set_LogoImage(UnityEngine.Sprite value);
                    /*0x3f88c00*/ System.Nullable<DMM.Games.Recibo.Api.Orders.Model.OrdersModel> get_GrantUserRankPointModel();
                    /*0x3f88c0c*/ void set_GrantUserRankPointModel(System.Nullable<DMM.Games.Recibo.Api.Orders.Model.OrdersModel> value);
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

                    static /*0x3f88c1c*/ bool Init(DMM.Games.Recibo.Ui.ShowRetryDialogModel data);
                    static /*0x3f88fb4*/ void Show(DMM.Games.Recibo.Ui.ShowRetryDialogModel data);
                    static /*0x3f89028*/ void Hide();
                    /*0x3f89230*/ ShowRetryDialog();
                    /*0x3f88e98*/ void SetButtonAction(DMM.Games.Recibo.Ui.ShowRetryDialogModel data);
                    /*0x3f88e40*/ void SetButtonText(DMM.Games.Recibo.Ui.ShowRetryDialogModel data);
                    /*0x3f88e1c*/ void SetMessage(string message);
                    /*0x3f88f20*/ void SetLogo(UnityEngine.Sprite logo);
                    /*0x3f89178*/ void LogoDestroy();
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

                    /*0x3f89280*/ ShowRetryDialogModel();
                    /*0x3f89238*/ string get_Message();
                    /*0x3f89240*/ void set_Message(string value);
                    /*0x3f89248*/ UnityEngine.Events.UnityAction get_OnClickPositiveButton();
                    /*0x3f89250*/ void set_OnClickPositiveButton(UnityEngine.Events.UnityAction value);
                    /*0x3f89258*/ UnityEngine.Events.UnityAction get_OnClickNegativeButton();
                    /*0x3f89260*/ void set_OnClickNegativeButton(UnityEngine.Events.UnityAction value);
                    /*0x3f89268*/ int get_SortingOrder();
                    /*0x3f89270*/ UnityEngine.Sprite get_LogoImage();
                    /*0x3f89278*/ void set_LogoImage(UnityEngine.Sprite value);
                }

                class SingletonComponent<T> : UnityEngine.MonoBehaviour
                {
                    static /*0x0*/ T _instance;

                    static /*0x3907c14*/ T get_Instance();
                    static /*0x3818690*/ bool get_HasInstance();
                    /*0x380cb08*/ SingletonComponent();
                    /*0x380cb08*/ void Awake();
                    /*0x380cb08*/ void OnAwake();
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

                        static /*0x3f8930c*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, string payType, UnityEngine.Events.UnityAction onCLickContinueButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f89844*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, string payType, UnityEngine.Events.UnityAction onClickContinueButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f898f0*/ void Hide();
                        /*0x3f89a2c*/ ShowContinueDialog();
                        /*0x3f896f8*/ void SetProductTitle(string title);
                        /*0x3f8971c*/ void SetProductIcon(UnityEngine.Texture2D icon);
                        /*0x3f897b0*/ void SetLogo(UnityEngine.Sprite logo);
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

                        static /*0x3f89a34*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string errorCode, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f89f0c*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string errorCode, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f89f9c*/ void Hide();
                        /*0x3f8a0d8*/ ShowCreditErrorDialog();
                        /*0x3f89e90*/ void SetErrorCode(string errorCode);
                        /*0x3f89dfc*/ void SetLogo(UnityEngine.Sprite logo);

                        class <>c
                        {
                            static /*0x0*/ DMM.Games.Recibo.Ui.Subscription.ShowCreditErrorDialog.<> <>9;
                            static /*0x8*/ UnityEngine.Events.UnityAction <>9__11_0;

                            static /*0x3f8a0e0*/ <>c();
                            /*0x3f8a148*/ <>c();
                            /*0x3f8a150*/ void <Init>b__11_0();
                        }

                        class <>c__DisplayClass11_0
                        {
                            /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore store;

                            /*0x3f89df4*/ <>c__DisplayClass11_0();
                            /*0x3f8a1b8*/ void <Init>b__1();
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

                        static /*0x3f8a22c*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                        static /*0x3f7ec8c*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                        static /*0x3f7e05c*/ void Hide();
                        /*0x3f8a464*/ ShowLoading();
                        /*0x3f8a39c*/ void Update();
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

                        static /*0x3f8a478*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Events.UnityAction onClickReturnButton, UnityEngine.Events.UnityAction OnClickInfomationButton);
                        static /*0x3f7ee6c*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Events.UnityAction onClickReturnButton, UnityEngine.Events.UnityAction OnClickInfomationButton);
                        static /*0x3f8a88c*/ void Hide();
                        /*0x3f8a998*/ ShowMaintenanceDialog();
                        /*0x3f8a7f8*/ void SetLogo(UnityEngine.Sprite logo);

                        class <>c__DisplayClass9_0
                        {
                            /*0x10*/ UnityEngine.Events.UnityAction onClickReturnButton;
                            /*0x18*/ UnityEngine.Events.UnityAction OnClickInfomationButton;

                            /*0x3f8a7f0*/ <>c__DisplayClass9_0();
                            /*0x3f8a9a0*/ void <Init>b__0();
                            /*0x3f8a9c4*/ void <Init>b__1();
                            /*0x3f8a9e8*/ void <Init>b__2();
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

                        static /*0x3f8aa04*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, bool isAdult, string nextDay, UnityEngine.Events.UnityAction onClickReturnButton);
                        static /*0x3f8add8*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string nextDay, UnityEngine.Events.UnityAction onClickReturnButton);
                        static /*0x3f8ae90*/ void Hide();
                        /*0x3f8b068*/ ShowOrderCompleteDialog();
                        /*0x3f8afcc*/ void SetNextPayDay(string day);
                        /*0x3f8ad44*/ void SetLogo(UnityEngine.Sprite logo);

                        class <>c__DisplayClass9_0
                        {
                            /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore store;

                            /*0x3f8ad3c*/ <>c__DisplayClass9_0();
                            /*0x3f8b070*/ void <Init>b__0();
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

                        static /*0x3f8b08c*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, string payload, string payMethod, long availablePoint, bool hasFreeTime, string freeTime, DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog.ShowOrderConfirmDialogState state, string displayPrice, string nextBillingDay, UnityEngine.Events.UnityAction onClickChangeMethodText, UnityEngine.Events.UnityAction onClickMiddleButton, UnityEngine.Events.UnityAction onClickBottomButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f8bfb0*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, string payload, string payMethod, long availablePoint, bool hasFreeTime, string freeTime, DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog.ShowOrderConfirmDialogState state, string displayPrice, string nextBillingDay, UnityEngine.Events.UnityAction onClickChangeMethodText, UnityEngine.Events.UnityAction onClickMiddleButton, UnityEngine.Events.UnityAction onClickBottomButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f8c0b8*/ void Hide();
                        /*0x3f8c40c*/ ShowOrderConfirmDialog();
                        /*0x3f8b78c*/ void SetButtonAction(UnityEngine.Events.UnityAction onClickChangeMethodText, UnityEngine.Events.UnityAction onClickMiddleButton, UnityEngine.Events.UnityAction onClickBottomButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        /*0x3f8c2c0*/ void SetBottomButtonText(string text);
                        /*0x3f8b88c*/ void SetShortageActive(DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog.ShowOrderConfirmDialogState state);
                        /*0x3f8ba70*/ void SetDeveloperPayloadAction(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string json);
                        /*0x3f8b640*/ void SetProductTitle(string title);
                        /*0x3f8c2ec*/ void SetProductPoint(long point);
                        /*0x3f8b9f0*/ void SetAvailablePoint(long point);
                        /*0x3f8c31c*/ string CommaFormat(long number);
                        /*0x3f8b664*/ void SetProductIcon(UnityEngine.Texture2D icon);
                        /*0x3f8c404*/ void SetState(DMM.Games.Recibo.Ui.Subscription.ShowOrderConfirmDialog.ShowOrderConfirmDialogState state);
                        /*0x3f8b6f8*/ void SetLogo(UnityEngine.Sprite logo);
                        /*0x3f8c208*/ void LogoDestroy();

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

                            /*0x3f8c2e4*/ <>c__DisplayClass38_0();
                            /*0x3f8c414*/ void <SetDeveloperPayloadAction>b__0();
                            /*0x3f8c48c*/ void <SetDeveloperPayloadAction>b__1();
                            /*0x3f8c504*/ void <SetDeveloperPayloadAction>b__2();
                            /*0x3f8c57c*/ void <SetDeveloperPayloadAction>b__3();
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

                        static /*0x3f8c598*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Events.UnityAction onClickRetryButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f7efa8*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Events.UnityAction onClickRetryButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f7f788*/ void Hide();
                        /*0x3f8c884*/ ShowRetryDialog();
                        /*0x3f8c7f0*/ void SetLogo(UnityEngine.Sprite logo);
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

                        static /*0x3f8c88c*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, bool isCardRegistered, UnityEngine.Events.UnityAction onClickCardButton, UnityEngine.Events.UnityAction onClickPointButton, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f8ce08*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem item, bool isCardRegistered, UnityEngine.Events.UnityAction onClickCardButton, UnityEngine.Events.UnityAction onClickPointButto, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f8cebc*/ void Hide();
                        /*0x3f8cff8*/ ShowSelectOrderMethodDialog();
                        /*0x3f8ccbc*/ void SetProductTitle(string title);
                        /*0x3f8cce0*/ void SetProductIcon(UnityEngine.Texture2D icon);
                        /*0x3f8cc3c*/ void SetCardButtonTitle();
                        /*0x3f8cd74*/ void SetLogo(UnityEngine.Sprite logo);
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

                        static /*0x3f8d000*/ bool Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string errorText, bool isCommercial, string errorCode, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f7eefc*/ void Show(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, string errorText, bool isCommercial, string errorCode, UnityEngine.Events.UnityAction onClickCancelButton);
                        static /*0x3f80200*/ void Hide();
                        /*0x3f8d5e0*/ ShowTypicalErrorDialog();
                        /*0x3f8d5bc*/ void SetErrorText(string errorText);
                        /*0x3f8d540*/ void SetErrorCode(string errorCode);
                        /*0x3f8d4ac*/ void SetLogo(UnityEngine.Sprite logo);

                        class <>c
                        {
                            static /*0x0*/ DMM.Games.Recibo.Ui.Subscription.ShowTypicalErrorDialog.<> <>9;
                            static /*0x8*/ UnityEngine.Events.UnityAction <>9__12_0;

                            static /*0x3f8d5e8*/ <>c();
                            /*0x3f8d650*/ <>c();
                            /*0x3f8d658*/ void <Init>b__12_0();
                        }

                        class <>c__DisplayClass12_0
                        {
                            /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore store;

                            /*0x3f8d4a4*/ <>c__DisplayClass12_0();
                            /*0x3f8d6c0*/ void <Init>b__1();
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

                        /*0x3f8f6d0*/ SubscriptionProcess();
                        /*0x3f8d6dc*/ void Execution(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store, UnityEngine.Purchasing.ProductDefinition product, string developerPayload, System.Action<DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel> successAction, System.Action<DMM.Games.Recibo.Ui.ErrorObject> errorAction);
                        /*0x3f8d7f8*/ void Update();
                        /*0x3f8d8ac*/ void InitSdkState();
                        /*0x3f8d998*/ void CreateOrderState();
                        /*0x3f8dca0*/ void ReCheckCreditState();
                        /*0x3f8e0e0*/ void CheckCreditState();
                        /*0x3f8e288*/ void CheckPointBalanceState();
                        /*0x3f8e430*/ void PurchasingState();
                        /*0x3f8e600*/ void CancelState();
                        /*0x3f8ef7c*/ void ErrorTransition(DMM.Games.Recibo.Ui.ErrorObject error);
                        /*0x3f8ea1c*/ void FinishState();
                        /*0x3f8e820*/ void ChangePaymentMethodState();
                        /*0x3f8ec34*/ DMM.Games.Recibo.Ui.Subscription.SubscriptionProcess.SubscriptionItemInfo GetSubscriptionItemInfo(DMM.Games.Recibo.Api.Version2.Product.Model.SubscriptionsOffer offer, DMM.Games.Recibo.Api.Version2.Order.Model.OrderModel orderModel);
                        /*0x3f8eb10*/ DMM.Games.Recibo.Ui.ErrorObject GetErrorObject(int code, string message);
                        /*0x3f8ef84*/ void ShowErrorResponse(string body, int localCode, long statusCode, string message);
                        /*0x3f8f670*/ long GetAvailablePoint();
                        /*0x3f8f6c8*/ void SetState(DMM.Games.Recibo.Ui.Subscription.SubscriptionState state);
                        /*0x3f8f718*/ void <CreateOrderState>b__19_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderResponseModel response);
                        /*0x3f8f79c*/ void <CreateOrderState>b__19_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f8f7f4*/ void <CreateOrderState>b__19_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f8f8b8*/ void <CreateOrderState>b__19_3();
                        /*0x3f8f8c4*/ void <CreateOrderState>b__19_4();
                        /*0x3f8f8d0*/ void <CheckCreditState>b__21_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Credit.Model.CheckCreditAvaliaResponseModel response);
                        /*0x3f8faa4*/ void <CheckCreditState>b__21_3();
                        /*0x3f8fb00*/ void <CheckCreditState>b__21_4();
                        /*0x3f8fb5c*/ void <CheckCreditState>b__21_5();
                        /*0x3f8fb68*/ void <CheckCreditState>b__21_6();
                        /*0x3f8fca0*/ void <CheckCreditState>b__21_9();
                        /*0x3f8fcfc*/ void <CheckCreditState>b__21_10();
                        /*0x3f8fd18*/ void <CheckCreditState>b__21_7();
                        /*0x3f8fd74*/ void <CheckCreditState>b__21_8();
                        /*0x3f8fd80*/ void <CheckCreditState>b__21_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f8fd94*/ void <CheckCreditState>b__21_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f8fe54*/ void <CheckCreditState>b__21_11();
                        /*0x3f8fe60*/ void <CheckCreditState>b__21_12();
                        /*0x3f8fe6c*/ void <CheckPointBalanceState>b__22_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Model.PointBalanceModel response);
                        /*0x3f9026c*/ void <CheckPointBalanceState>b__22_3();
                        /*0x3f90288*/ void <CheckPointBalanceState>b__22_5();
                        /*0x3f902a4*/ void <CheckPointBalanceState>b__22_6();
                        /*0x3f902b0*/ void <CheckPointBalanceState>b__22_7();
                        /*0x3f902cc*/ void <CheckPointBalanceState>b__22_9();
                        /*0x3f90404*/ void <CheckPointBalanceState>b__22_11();
                        /*0x3f90410*/ void <CheckPointBalanceState>b__22_12();
                        /*0x3f9041c*/ void <CheckPointBalanceState>b__22_10();
                        /*0x3f90428*/ void <CheckPointBalanceState>b__22_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f9043c*/ void <CheckPointBalanceState>b__22_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f90500*/ void <CheckPointBalanceState>b__22_13();
                        /*0x3f9050c*/ void <CheckPointBalanceState>b__22_14();
                        /*0x3f90518*/ void <PurchasingState>b__23_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Receipt.Model.CreateReceiptResponseModel response);
                        /*0x3f906b4*/ void <PurchasingState>b__23_3();
                        /*0x3f906c0*/ void <PurchasingState>b__23_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f906d4*/ void <PurchasingState>b__23_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f90798*/ void <PurchasingState>b__23_4();
                        /*0x3f907a4*/ void <PurchasingState>b__23_5();
                        /*0x3f907b0*/ void <CancelState>b__24_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.BaseResultModel response);
                        /*0x3f907d8*/ void <CancelState>b__24_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f90800*/ void <CancelState>b__24_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                        /*0x3f90828*/ void <ChangePaymentMethodState>b__27_0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.BaseResultModel response);
                        /*0x3f90850*/ void <ChangePaymentMethodState>b__27_1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f90878*/ void <ChangePaymentMethodState>b__27_2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);

                        class SubscriptionItemInfo
                        {
                            /*0x10*/ bool hasFreeTime;
                            /*0x18*/ string freeTime;
                            /*0x20*/ int price;
                            /*0x28*/ string displayPrice;
                            /*0x30*/ string nextBillingDay;

                            /*0x3f908a0*/ SubscriptionItemInfo();
                        }

                        class <>c
                        {
                            static /*0x0*/ DMM.Games.Recibo.Ui.Subscription.SubscriptionProcess.<> <>9;
                            static /*0x8*/ UnityEngine.Events.UnityAction <>9__20_1;
                            static /*0x10*/ UnityEngine.Events.UnityAction <>9__20_8;
                            static /*0x18*/ UnityEngine.Events.UnityAction <>9__22_4;
                            static /*0x20*/ UnityEngine.Events.UnityAction <>9__22_8;

                            static /*0x3f908a8*/ <>c();
                            /*0x3f90910*/ <>c();
                            /*0x3f90918*/ void <ReCheckCreditState>b__20_1();
                            /*0x3f9091c*/ void <ReCheckCreditState>b__20_8();
                            /*0x3f90920*/ void <CheckPointBalanceState>b__22_4();
                            /*0x3f90924*/ void <CheckPointBalanceState>b__22_8();
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

                            /*0x3f90928*/ <>c__DisplayClass20_0();
                            /*0x3f90930*/ void <ReCheckCreditState>b__0();
                            /*0x3f9095c*/ void <ReCheckCreditState>b__2();
                            /*0x3f90988*/ void <ReCheckCreditState>b__3();
                            /*0x3f909ac*/ void <ReCheckCreditState>b__4(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Credit.Model.CheckCreditAvaliaResponseModel response);
                            /*0x3f90c90*/ void <ReCheckCreditState>b__7();
                            /*0x3f90cbc*/ void <ReCheckCreditState>b__9();
                            /*0x3f90e6c*/ void <ReCheckCreditState>b__11();
                            /*0x3f90e90*/ void <ReCheckCreditState>b__12();
                            /*0x3f90eb4*/ void <ReCheckCreditState>b__10();
                            /*0x3f90ed8*/ void <ReCheckCreditState>b__5(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                            /*0x3f90f04*/ void <ReCheckCreditState>b__6(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                            /*0x3f9101c*/ void <ReCheckCreditState>b__13();
                            /*0x3f9103c*/ void <ReCheckCreditState>b__14();
                        }

                        class <>c__DisplayClass30_0
                        {
                            /*0x10*/ DMM.Games.Recibo.Ui.Subscription.SubscriptionProcess <>4__this;
                            /*0x18*/ DMM.Games.Recibo.Ui.ErrorObject e;
                            /*0x20*/ int localCode;
                            /*0x28*/ string body;

                            /*0x3f91060*/ <>c__DisplayClass30_0();
                            /*0x3f91068*/ void <ShowErrorResponse>b__0();
                            /*0x3f91088*/ void <ShowErrorResponse>b__1();
                            /*0x3f9118c*/ void <ShowErrorResponse>b__9();
                            /*0x3f911e0*/ void <ShowErrorResponse>b__10();
                            /*0x3f91234*/ void <ShowErrorResponse>b__2();
                            /*0x3f91260*/ void <ShowErrorResponse>b__3();
                            /*0x3f9128c*/ void <ShowErrorResponse>b__4();
                            /*0x3f912b8*/ void <ShowErrorResponse>b__5();
                            /*0x3f912e4*/ void <ShowErrorResponse>b__6();
                            /*0x3f91310*/ void <ShowErrorResponse>b__7();
                            /*0x3f9133c*/ void <ShowErrorResponse>b__8();
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

                    static /*0x38358cc*/ ReciboApi();
                    ReciboApi(string apiToken, string openId, string accessToken, bool isSandbox);
                    /*0x380b9e8*/ string GetEndpoint();
                    /*0x380b9e8*/ DMM.Games.Net.Method GetMethod();
                    /*0x3907c14*/ T ParseResponse(string responseBody);
                    /*0x380b9e8*/ string GetAdditionalQuery();
                    /*0x380b9e8*/ string GetRequestBody();
                    /*0x380b9e8*/ string GetDomain();
                    /*0x380b9e8*/ string GetAEDomain();
                    /*0x380b9e8*/ string GetBSDomain();
                    /*0x380b9e8*/ string GetScheme();
                    /*0x380da84*/ void Request(DMM.Games.Recibo.Api.ReciboApi.OnSuccessCallback<T> onSuccess, DMM.Games.Recibo.Api.ReciboApi.OnFalureCallback<T> onFailure, DMM.Games.Recibo.Api.ReciboApi.OnNetworkErrorCallback<T> onNetworkError, object tag);
                    /*0x380b9e8*/ string BuildUrl();
                    /*0x380b9e8*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> BuildRequestHeaders();

                    class OnSuccessCallback<T> : System.MulticastDelegate
                    {
                        OnSuccessCallback(object object, nint method);
                        /*0x3907c14*/ void Invoke(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, T responseData);
                        /*0x3907c14*/ System.IAsyncResult BeginInvoke(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, T responseData, System.AsyncCallback callback, object object);
                        /*0x380d83c*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class OnFalureCallback<T> : System.MulticastDelegate
                    {
                        OnFalureCallback(object object, nint method);
                        void Invoke(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string responseBody);
                        /*0x3907c14*/ System.IAsyncResult BeginInvoke(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string responseBody, System.AsyncCallback callback, object object);
                        /*0x380d83c*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class OnNetworkErrorCallback<T> : System.MulticastDelegate
                    {
                        OnNetworkErrorCallback(object object, nint method);
                        void Invoke(object tag, DMM.Games.Net.NetworkErrorKind kind, System.Exception exception);
                        System.IAsyncResult BeginInvoke(object tag, DMM.Games.Net.NetworkErrorKind kind, System.Exception exception, System.AsyncCallback callback, object object);
                        /*0x380d83c*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class <>c__DisplayClass25_0<T>
                    {
                        /*0x0*/ DMM.Games.Recibo.Api.ReciboApi.OnSuccessCallback<T> onSuccess;
                        /*0x0*/ DMM.Games.Recibo.Api.ReciboApi<T> <>4__this;
                        /*0x0*/ DMM.Games.Recibo.Api.ReciboApi.OnFalureCallback<T> onFailure;
                        /*0x0*/ DMM.Games.Recibo.Api.ReciboApi.OnNetworkErrorCallback<T> onNetworkError;

                        /*0x380cb08*/ <>c__DisplayClass25_0();
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

                        static /*0x3f913c8*/ DMM.Games.Recibo.Api.Version2.BaseResultModel CreateInstance(string response);
                        /*0x3f9148c*/ BaseResultModel();
                        /*0x3f91368*/ int get_Status();
                        /*0x3f91370*/ void set_Status(int value);
                        /*0x3f91378*/ string get_Message();
                        /*0x3f91380*/ void set_Message(string value);
                        /*0x3f91388*/ DMM.Games.Recibo.Api.Version2.ErrorModel get_Error();
                        /*0x3f91390*/ void set_Error(DMM.Games.Recibo.Api.Version2.ErrorModel value);
                        /*0x3f91398*/ bool get_IsErrorOccurred();
                    }

                    class ErrorModel
                    {
                        /*0x10*/ string <ErrorCode>k__BackingField;
                        /*0x18*/ string <ErrorMessage>k__BackingField;
                        /*0x20*/ DMM.Games.Recibo.Api.Version2.ValidationErrorModel[] <ValidationErrors>k__BackingField;

                        /*0x3f914c4*/ ErrorModel();
                        /*0x3f91494*/ string get_ErrorCode();
                        /*0x3f9149c*/ void set_ErrorCode(string value);
                        /*0x3f914a4*/ string get_ErrorMessage();
                        /*0x3f914ac*/ void set_ErrorMessage(string value);
                        /*0x3f914b4*/ DMM.Games.Recibo.Api.Version2.ValidationErrorModel[] get_ValidationErrors();
                        /*0x3f914bc*/ void set_ValidationErrors(DMM.Games.Recibo.Api.Version2.ValidationErrorModel[] value);
                        /*0x3f913b8*/ bool get_IsErrorOccurred();
                    }

                    class ValidationErrorModel
                    {
                        /*0x10*/ string <FieldName>k__BackingField;
                        /*0x18*/ string <ValidationCode>k__BackingField;

                        /*0x3f914ec*/ ValidationErrorModel();
                        /*0x3f914cc*/ string get_FieldName();
                        /*0x3f914d4*/ void set_FieldName(string value);
                        /*0x3f914dc*/ string get_ValidationCode();
                        /*0x3f914e4*/ void set_ValidationCode(string value);
                    }

                    namespace Sdk
                    {
                        class InitializeSdk : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Sdk.Model.InitializeSdkResponseModel>
                        {
                            /*0x3f914f4*/ InitializeSdk(string apiToken, string openId, string accessToken, bool isSandbox);
                            /*0x3f91590*/ string GetEndpoint();
                            /*0x3f915d0*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f91628*/ DMM.Games.Recibo.Api.Version2.Sdk.Model.InitializeSdkResponseModel ParseResponse(string responseBody);
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

                                /*0x3f919ec*/ InitializeSdkResponseModel();
                                /*0x3f91670*/ int get_ApplicationId();
                                /*0x3f91678*/ void set_ApplicationId(int value);
                                /*0x3f91680*/ int get_GamesId();
                                /*0x3f91688*/ void set_GamesId(int value);
                                /*0x3f91690*/ string get_GamesIdSignature();
                                /*0x3f91698*/ void set_GamesIdSignature(string value);
                                /*0x3f916a0*/ int get_ViewerId();
                                /*0x3f916a8*/ void set_ViewerId(int value);
                                /*0x3f916b0*/ string get_ViewerIdSignature();
                                /*0x3f916b8*/ void set_ViewerIdSignature(string value);
                                /*0x3f916c0*/ string get_PointChargeUrl();
                                /*0x3f916c8*/ void set_PointChargeUrl(string value);
                                /*0x3f916d0*/ string get_CreditChangeUrl();
                                /*0x3f916d8*/ void set_CreditChangeUrl(string value);
                                /*0x3f916e0*/ bool get_IsAdult();
                                /*0x3f916e8*/ void set_IsAdult(bool value);
                                /*0x3f916f4*/ string get_UserType();
                                /*0x3f916fc*/ void set_UserType(string value);
                                /*0x3f91704*/ string ToString();
                            }
                        }
                    }

                    namespace Receipt
                    {
                        class CreateReceipt : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Receipt.Model.CreateReceiptResponseModel>
                        {
                            /*0x38*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.CreateReceiptRequestModel requestModel;

                            /*0x3f919f4*/ CreateReceipt(string apiToken, string openId, string accessToken, string orderId, bool isSandbox, string locale);
                            /*0x3f91b20*/ string GetEndpoint();
                            /*0x3f91b60*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f91bb8*/ string GetRequestBody();
                            /*0x3f91e10*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.CreateReceiptResponseModel ParseResponse(string responseBody);
                        }

                        class GetReceipt : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Receipt.Model.GetReceiptResponseModel>
                        {
                            /*0x38*/ string <Locale>k__BackingField;

                            /*0x3f91e68*/ GetReceipt(string apiToken, string openId, string accessToken, bool isSandbox, string locale);
                            /*0x3f91e58*/ string get_Locale();
                            /*0x3f91e60*/ void set_Locale(string value);
                            /*0x3f91f20*/ string GetEndpoint();
                            /*0x3f91f60*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f91fb8*/ string GetAdditionalQuery();
                            /*0x3f92004*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.GetReceiptResponseModel ParseResponse(string responseBody);
                        }

                        namespace Model
                        {
                            class CreateReceiptRequestModel
                            {
                                /*0x10*/ string <OrderId>k__BackingField;
                                /*0x18*/ string <Locale>k__BackingField;

                                /*0x3f91adc*/ CreateReceiptRequestModel(string orderId, string locale);
                                /*0x3f9204c*/ string get_OrderId();
                                /*0x3f92054*/ void set_OrderId(string value);
                                /*0x3f9205c*/ string get_Locale();
                                /*0x3f92064*/ void set_Locale(string value);
                            }

                            class CreateReceiptResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel <Body>k__BackingField;

                                /*0x3f9207c*/ CreateReceiptResponseModel();
                                /*0x3f9206c*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel get_Body();
                                /*0x3f92074*/ void set_Body(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel value);
                            }

                            class GetReceiptResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList <Body>k__BackingField;

                                /*0x3f92094*/ GetReceiptResponseModel();
                                /*0x3f92084*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList get_Body();
                                /*0x3f9208c*/ void set_Body(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList value);
                            }

                            class ProductId
                            {
                                /*0x10*/ string <Id>k__BackingField;

                                /*0x3f920ac*/ ProductId();
                                /*0x3f9209c*/ string get_Id();
                                /*0x3f920a4*/ void set_Id(string value);
                            }

                            class ReceiptList
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel[] <Receipts>k__BackingField;

                                /*0x3f92190*/ ReceiptList();
                                /*0x3f920b4*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel[] get_Receipts();
                                /*0x3f920bc*/ void set_Receipts(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel[] value);
                                /*0x3f920c4*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel FindReceiptFromProductId(string productId);
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

                                /*0x3f92274*/ ReceiptModel();
                                /*0x3f92198*/ int get_PurchaseTime();
                                /*0x3f921a0*/ void set_PurchaseTime(int value);
                                /*0x3f921a8*/ int get_PurchaseState();
                                /*0x3f921b0*/ void set_PurchaseState(int value);
                                /*0x3f921b8*/ string get_DeveloperPayload();
                                /*0x3f921c0*/ void set_DeveloperPayload(string value);
                                /*0x3f921c8*/ string get_OrderId();
                                /*0x3f921d0*/ void set_OrderId(string value);
                                /*0x3f921d8*/ string get_OriginalJson();
                                /*0x3f921e0*/ void set_OriginalJson(string value);
                                /*0x3f921e8*/ string get_PurchaseToken();
                                /*0x3f921f0*/ void set_PurchaseToken(string value);
                                /*0x3f921f8*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ProductId[] get_Products();
                                /*0x3f92200*/ void set_Products(DMM.Games.Recibo.Api.Version2.Receipt.Model.ProductId[] value);
                                /*0x3f92208*/ int get_Quantity();
                                /*0x3f92210*/ void set_Quantity(int value);
                                /*0x3f92218*/ string get_Signature();
                                /*0x3f92220*/ void set_Signature(string value);
                                /*0x3f92228*/ bool get_IsAcknowledged();
                                /*0x3f92230*/ void set_IsAcknowledged(bool value);
                                /*0x3f9223c*/ bool get_IsAutoRenewing();
                                /*0x3f92244*/ void set_IsAutoRenewing(bool value);
                                /*0x3f92250*/ long get_NextBillingTime();
                                /*0x3f92258*/ void set_NextBillingTime(long value);
                                /*0x3f92260*/ bool get_WithoutFirstPayment();
                                /*0x3f92268*/ void set_WithoutFirstPayment(bool value);
                                /*0x3f92154*/ string get_ProductId();
                            }
                        }
                    }

                    namespace Product
                    {
                        class SearchProduct : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductResponseModel>
                        {
                            /*0x38*/ DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductRequestModel <RequestModel>k__BackingField;

                            /*0x3f9228c*/ SearchProduct(string apiToken, string openId, string accessToken, string locale, DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] products, bool isSandbox);
                            /*0x3f9227c*/ DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductRequestModel get_RequestModel();
                            /*0x3f92284*/ void set_RequestModel(DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductRequestModel value);
                            /*0x3f923b8*/ string GetRequestBody();
                            /*0x3f923c0*/ string GetEndpoint();
                            /*0x3f92400*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f92458*/ DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductResponseModel ParseResponse(string responseBody);
                        }

                        namespace Model
                        {
                            class OneTimePurchaseOffer
                            {
                                /*0x10*/ string <FormattedPrice>k__BackingField;
                                /*0x18*/ long <PriceAmountMicros>k__BackingField;
                                /*0x20*/ string <PriceCurrencyCode>k__BackingField;

                                /*0x3f924d0*/ OneTimePurchaseOffer();
                                /*0x3f924a0*/ string get_FormattedPrice();
                                /*0x3f924a8*/ void set_FormattedPrice(string value);
                                /*0x3f924b0*/ long get_PriceAmountMicros();
                                /*0x3f924b8*/ void set_PriceAmountMicros(long value);
                                /*0x3f924c0*/ string get_PriceCurrencyCode();
                                /*0x3f924c8*/ void set_PriceCurrencyCode(string value);
                            }

                            class PricingPhases
                            {
                                /*0x10*/ int <BillingCycleCount>k__BackingField;
                                /*0x18*/ string <BillingPeriod>k__BackingField;
                                /*0x20*/ string <FormattedPrice>k__BackingField;
                                /*0x28*/ long <PriceAmountMicros>k__BackingField;
                                /*0x30*/ string <PriceCurrencyCode>k__BackingField;
                                /*0x38*/ int <RecurrenceMode>k__BackingField;

                                /*0x3f9255c*/ PricingPhases();
                                /*0x3f924d8*/ int get_BillingCycleCount();
                                /*0x3f924e0*/ void set_BillingCycleCount(int value);
                                /*0x3f924e8*/ string get_BillingPeriod();
                                /*0x3f924f0*/ void set_BillingPeriod(string value);
                                /*0x3f924f8*/ string get_FormattedPrice();
                                /*0x3f92500*/ void set_FormattedPrice(string value);
                                /*0x3f92508*/ long get_PriceAmountMicros();
                                /*0x3f92510*/ void set_PriceAmountMicros(long value);
                                /*0x3f92518*/ string get_PriceCurrencyCode();
                                /*0x3f92520*/ void set_PriceCurrencyCode(string value);
                                /*0x3f92528*/ int get_RecurrenceMode();
                                /*0x3f92530*/ void set_RecurrenceMode(int value);
                                /*0x3f92538*/ bool get_IsFirstTimeOffer();

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

                                /*0x3f9275c*/ Product();
                                /*0x3f92564*/ string get_Name();
                                /*0x3f9256c*/ void set_Name(string value);
                                /*0x3f92574*/ string get_ProductId();
                                /*0x3f9257c*/ void set_ProductId(string value);
                                /*0x3f92584*/ string get_ProductType();
                                /*0x3f9258c*/ void set_ProductType(string value);
                                /*0x3f92594*/ string get_Title();
                                /*0x3f9259c*/ void set_Title(string value);
                                /*0x3f925a4*/ string get_Description();
                                /*0x3f925ac*/ void set_Description(string value);
                                /*0x3f925b4*/ DMM.Games.Recibo.Api.Version2.Product.Model.OneTimePurchaseOffer get_OneTimePurchaseOffer();
                                /*0x3f925bc*/ void set_OneTimePurchaseOffer(DMM.Games.Recibo.Api.Version2.Product.Model.OneTimePurchaseOffer value);
                                /*0x3f925c4*/ DMM.Games.Recibo.Api.Version2.Product.Model.SubscriptionsOffer[] get_SubscriptionsOffers();
                                /*0x3f925cc*/ void set_SubscriptionsOffers(DMM.Games.Recibo.Api.Version2.Product.Model.SubscriptionsOffer[] value);
                                /*0x3f925d4*/ DMM.Games.Recibo.Api.Version2.Product.Model.SubscriptionsOffer get_PrimarySubscriptionOffer();
                            }

                            class ProductList
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product[] <Products>k__BackingField;

                                /*0x3f927f8*/ ProductList();
                                /*0x3f92764*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product[] get_Products();
                                /*0x3f9276c*/ void set_Products(DMM.Games.Recibo.Api.Version2.Product.Model.Product[] value);
                                /*0x3f92774*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product FindProduct(string productId);
                            }

                            class ProductQuery
                            {
                                /*0x10*/ string <ProductId>k__BackingField;
                                /*0x18*/ string <ProductType>k__BackingField;

                                /*0x3f92820*/ ProductQuery(string productId, string productType);
                                /*0x3f92800*/ string get_ProductId();
                                /*0x3f92808*/ void set_ProductId(string value);
                                /*0x3f92810*/ string get_ProductType();
                                /*0x3f92818*/ void set_ProductType(string value);
                            }

                            class SearchProductRequestModel
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] <Products>k__BackingField;
                                /*0x18*/ string <Locale>k__BackingField;

                                /*0x3f92374*/ SearchProductRequestModel(DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] products, string locale);
                                /*0x3f92864*/ DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] get_Products();
                                /*0x3f9286c*/ void set_Products(DMM.Games.Recibo.Api.Version2.Product.Model.ProductQuery[] value);
                                /*0x3f92874*/ string get_Locale();
                                /*0x3f9287c*/ void set_Locale(string value);
                            }

                            class SearchProductResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Product.Model.ProductList <Body>k__BackingField;

                                /*0x3f92894*/ SearchProductResponseModel();
                                /*0x3f92884*/ DMM.Games.Recibo.Api.Version2.Product.Model.ProductList get_Body();
                                /*0x3f9288c*/ void set_Body(DMM.Games.Recibo.Api.Version2.Product.Model.ProductList value);
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

                                static /*0x3f92aa8*/ SubscriptionsOffer();
                                /*0x3f92aa0*/ SubscriptionsOffer();
                                /*0x3f9289c*/ string get_BasePlanId();
                                /*0x3f928a4*/ void set_BasePlanId(string value);
                                /*0x3f928ac*/ string get_OfferId();
                                /*0x3f928b4*/ void set_OfferId(string value);
                                /*0x3f928bc*/ string[] get_OfferTags();
                                /*0x3f928c4*/ void set_OfferTags(string[] value);
                                /*0x3f928cc*/ string get_OfferToken();
                                /*0x3f928d4*/ void set_OfferToken(string value);
                                /*0x3f928dc*/ DMM.Games.Recibo.Api.Version2.Product.Model.PricingPhases[] get_PricingPhases();
                                /*0x3f928e4*/ void set_PricingPhases(DMM.Games.Recibo.Api.Version2.Product.Model.PricingPhases[] value);
                                /*0x3f92670*/ bool get_IsFirstTimeOfferExists();
                                /*0x3f928ec*/ bool get_IsFreeTrialOfferExists();
                                /*0x3f929bc*/ DMM.Games.Recibo.Api.Version2.Product.Model.PricingPhases get_FirstTimeOfferPricingPhase();
                                /*0x3f92a34*/ DMM.Games.Recibo.Api.Version2.Product.Model.PricingPhases get_GeneralPricingPhases();
                            }
                        }
                    }

                    namespace Order
                    {
                        class CreateOrder : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderResponseModel>
                        {
                            /*0x38*/ DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderRequestModel <RequestModel>k__BackingField;

                            /*0x3f92b54*/ CreateOrder(string apiToken, string openId, string accessToken, DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderRequestModel requestModel, bool isSandbox);
                            /*0x3f92b44*/ DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderRequestModel get_RequestModel();
                            /*0x3f92b4c*/ void set_RequestModel(DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderRequestModel value);
                            /*0x3f92c0c*/ string GetRequestBody();
                            /*0x3f92c14*/ string GetEndpoint();
                            /*0x3f92c54*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f92cac*/ DMM.Games.Recibo.Api.Version2.Order.Model.CreateOrderResponseModel ParseResponse(string responseBody);
                        }

                        class DeleteOrder : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.BaseResultModel>
                        {
                            /*0x38*/ string <OrderId>k__BackingField;
                            /*0x40*/ string <Locale>k__BackingField;

                            /*0x3f92d14*/ DeleteOrder(string apiToken, string locale, string openId, string accessToken, string orderId, bool isSandbox);
                            /*0x3f92cf4*/ string get_OrderId();
                            /*0x3f92cfc*/ void set_OrderId(string value);
                            /*0x3f92d04*/ string get_Locale();
                            /*0x3f92d0c*/ void set_Locale(string value);
                            /*0x3f92de0*/ string GetEndpoint();
                            /*0x3f92e60*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f92eb8*/ DMM.Games.Recibo.Api.Version2.BaseResultModel ParseResponse(string responseBody);
                        }

                        namespace Model
                        {
                            class CreateOrderRequestModel
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] <Products>k__BackingField;

                                /*0x3f92f30*/ CreateOrderRequestModel(DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] products);
                                /*0x3f92f20*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] get_Products();
                                /*0x3f92f28*/ void set_Products(DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] value);
                            }

                            class CreateOrderResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderModel <Body>k__BackingField;

                                /*0x3f92f70*/ CreateOrderResponseModel();
                                /*0x3f92f60*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderModel get_Body();
                                /*0x3f92f68*/ void set_Body(DMM.Games.Recibo.Api.Version2.Order.Model.OrderModel value);
                            }

                            class OrderModel
                            {
                                /*0x10*/ string <OrderId>k__BackingField;
                                /*0x18*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] <Products>k__BackingField;

                                /*0x3f92f98*/ OrderModel();
                                /*0x3f92f78*/ string get_OrderId();
                                /*0x3f92f80*/ void set_OrderId(string value);
                                /*0x3f92f88*/ DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] get_Products();
                                /*0x3f92f90*/ void set_Products(DMM.Games.Recibo.Api.Version2.Order.Model.OrderProduct[] value);
                            }

                            class OrderProduct
                            {
                                /*0x10*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product <Product>k__BackingField;
                                /*0x18*/ string <OfferToken>k__BackingField;
                                /*0x20*/ string <PayType>k__BackingField;
                                /*0x28*/ string <DeveloperPayload>k__BackingField;
                                /*0x30*/ string <Locale>k__BackingField;
                                /*0x38*/ long <NextBillingTime>k__BackingField;

                                /*0x3f93000*/ OrderProduct(DMM.Games.Recibo.Api.Version2.Product.Model.Product product, string offerToken, string payType, string developerPayload, string locale);
                                /*0x3f92fa0*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product get_Product();
                                /*0x3f92fa8*/ void set_Product(DMM.Games.Recibo.Api.Version2.Product.Model.Product value);
                                /*0x3f92fb0*/ string get_OfferToken();
                                /*0x3f92fb8*/ void set_OfferToken(string value);
                                /*0x3f92fc0*/ string get_PayType();
                                /*0x3f92fc8*/ void set_PayType(string value);
                                /*0x3f92fd0*/ string get_DeveloperPayload();
                                /*0x3f92fd8*/ void set_DeveloperPayload(string value);
                                /*0x3f92fe0*/ string get_Locale();
                                /*0x3f92fe8*/ void set_Locale(string value);
                                /*0x3f92ff0*/ long get_NextBillingTime();
                                /*0x3f92ff8*/ void set_NextBillingTime(long value);
                            }
                        }
                    }

                    namespace Credit
                    {
                        class CheckCreditAvailability : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Version2.Credit.Model.CheckCreditAvaliaResponseModel>
                        {
                            /*0x3f93090*/ CheckCreditAvailability(string apiToken, string openId, string accessToken, bool isSandbox);
                            /*0x3f9312c*/ string GetEndpoint();
                            /*0x3f9316c*/ DMM.Games.Net.Method GetMethod();
                            /*0x3f931c4*/ DMM.Games.Recibo.Api.Version2.Credit.Model.CheckCreditAvaliaResponseModel ParseResponse(string responseBody);
                        }

                        namespace Model
                        {
                            class CheckCreditAvaliaResponseModel : DMM.Games.Recibo.Api.Version2.BaseResultModel
                            {
                                /*0x28*/ DMM.Games.Recibo.Api.Version2.Credit.Model.HasCreditModel <Body>k__BackingField;

                                /*0x3f9321c*/ CheckCreditAvaliaResponseModel();
                                /*0x3f9320c*/ DMM.Games.Recibo.Api.Version2.Credit.Model.HasCreditModel get_Body();
                                /*0x3f93214*/ void set_Body(DMM.Games.Recibo.Api.Version2.Credit.Model.HasCreditModel value);
                            }

                            class HasCreditModel
                            {
                                /*0x10*/ bool <HasCredit>k__BackingField;

                                /*0x3f93238*/ HasCreditModel();
                                /*0x3f93224*/ bool get_HasCredit();
                                /*0x3f9322c*/ void set_HasCredit(bool value);
                            }
                        }
                    }
                }

                namespace UserInfo
                {
                    class GetUserInfo : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.UserInfo.UserInfoModel>
                    {
                        /*0x38*/ string <OnetimeToken>k__BackingField;

                        /*0x3f93250*/ GetUserInfo(bool isSandbox, string onetimeToken);
                        /*0x3f93240*/ string get_OnetimeToken();
                        /*0x3f93248*/ void set_OnetimeToken(string value);
                        /*0x3f93300*/ string GetAdditionalQuery();
                        /*0x3f9334c*/ string GetEndpoint();
                        /*0x3f9338c*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f933e4*/ DMM.Games.Recibo.Api.UserInfo.UserInfoModel ParseResponse(string responseBody);
                    }

                    struct UserInfoModel
                    {
                        /*0x10*/ string <AccessToken>k__BackingField;
                        /*0x18*/ string <OpenId>k__BackingField;
                        /*0x20*/ string <SessionId>k__BackingField;
                        /*0x28*/ string <SecureId>k__BackingField;

                        /*0x3f93450*/ string get_AccessToken();
                        /*0x3f93458*/ void set_AccessToken(string value);
                        /*0x3f93460*/ string get_OpenId();
                        /*0x3f93468*/ void set_OpenId(string value);
                        /*0x3f93470*/ string get_SessionId();
                        /*0x3f93478*/ void set_SessionId(string value);
                        /*0x3f93480*/ string get_SecureId();
                        /*0x3f93488*/ void set_SecureId(string value);
                    }
                }

                namespace Model
                {
                    struct PointBalanceModel
                    {
                        /*0x10*/ long <PointBalance>k__BackingField;

                        /*0x3f93490*/ long get_PointBalance();
                        /*0x3f93498*/ void set_PointBalance(long value);
                        /*0x3f934a0*/ string ToString();
                    }
                }

                namespace User
                {
                    class GetPointBalance : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Model.PointBalanceModel>
                    {
                        /*0x3f93518*/ GetPointBalance(string apiToken, string openId, string accessToken, bool isSandbox);
                        /*0x3f935b4*/ string GetEndpoint();
                        /*0x3f935f4*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f9364c*/ DMM.Games.Recibo.Api.Model.PointBalanceModel ParseResponse(string responseBody);
                    }
                }

                namespace Receipt
                {
                    class CreateReceipt : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel>
                    {
                        /*0x38*/ DMM.Games.Recibo.Api.Receipt.Model.CreateRequestModel _requestModel;

                        /*0x3f93694*/ CreateReceipt(string apiToken, string openId, string accessToken, string orderId, string couponId, string userDevice, bool isSandbox);
                        /*0x3f937d4*/ string GetRequestBody();
                        /*0x3f9383c*/ string GetEndpoint();
                        /*0x3f9387c*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f938d4*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel ParseResponse(string responseBody);
                    }

                    class DeleteReceipt : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel>
                    {
                        /*0x38*/ string _purchaseToken;

                        /*0x3f93a6c*/ DeleteReceipt(string apiToken, string openId, string accessToken, string purchaseToken, bool isSandbox);
                        /*0x3f93b24*/ string GetAdditionalQuery();
                        /*0x3f93b70*/ string GetEndpoint();
                        /*0x3f93bb0*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f93c08*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel ParseResponse(string responseBody);
                    }

                    class GetReceiptList : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Receipt.Model.ReceiptList>
                    {
                        /*0x3f93ca8*/ GetReceiptList(string apiToken, string openId, string accessToken, bool isSandbox);
                        /*0x3f93d44*/ string GetEndpoint();
                        /*0x3f93d84*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f93ddc*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptList ParseResponse(string responseBody);
                    }

                    namespace Model
                    {
                        struct PurchaseEventModel
                        {
                            /*0x10*/ string <Store>k__BackingField;
                            /*0x18*/ string <TransactionId>k__BackingField;
                            /*0x20*/ string <Payload>k__BackingField;

                            /*0x3f94120*/ string get_Store();
                            /*0x3f94128*/ void set_Store(string value);
                            /*0x3f94130*/ string get_TransactionId();
                            /*0x3f94138*/ void set_TransactionId(string value);
                            /*0x3f94140*/ string get_Payload();
                            /*0x3f94148*/ void set_Payload(string value);
                        }

                        struct CreateRequestModel
                        {
                            /*0x10*/ string <OrderId>k__BackingField;
                            /*0x18*/ string <CouponId>k__BackingField;
                            /*0x20*/ string <UserDevice>k__BackingField;

                            /*0x3f93790*/ CreateRequestModel(string orderId, string couponId, string userDevice);
                            /*0x3f94150*/ string get_OrderId();
                            /*0x3f94158*/ void set_OrderId(string value);
                            /*0x3f94160*/ string get_CouponId();
                            /*0x3f94168*/ void set_CouponId(string value);
                            /*0x3f94170*/ string get_UserDevice();
                            /*0x3f94178*/ void set_UserDevice(string value);
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

                            /*0x3f94180*/ string get_PurchaseToken();
                            /*0x3f94188*/ void set_PurchaseToken(string value);
                            /*0x3f94190*/ string get_OrderId();
                            /*0x3f94198*/ void set_OrderId(string value);
                            /*0x3f941a0*/ string get_ProductId();
                            /*0x3f941a8*/ void set_ProductId(string value);
                            /*0x3f941b0*/ string get_Price();
                            /*0x3f941b8*/ void set_Price(string value);
                            /*0x3f941c0*/ long get_PriceAmountMicros();
                            /*0x3f941c8*/ void set_PriceAmountMicros(long value);
                            /*0x3f941d0*/ string get_PriceCurrencyCode();
                            /*0x3f941d8*/ void set_PriceCurrencyCode(string value);
                            /*0x3f941e0*/ int get_Quantity();
                            /*0x3f941e8*/ void set_Quantity(int value);
                            /*0x3f941f0*/ long get_PurchaseTime();
                            /*0x3f941f8*/ void set_PurchaseTime(long value);
                            /*0x3f94200*/ string get_DeveloperPayload();
                            /*0x3f94208*/ void set_DeveloperPayload(string value);
                            /*0x3f94210*/ string get_CouponId();
                            /*0x3f94218*/ void set_CouponId(string value);
                            /*0x3f94220*/ string get_UserDevice();
                            /*0x3f94228*/ void set_UserDevice(string value);
                            /*0x3f94230*/ int get_OrderPrice();
                            /*0x3f94238*/ void set_OrderPrice(int value);
                            /*0x3f94240*/ int get_CouponDiscountAmount();
                            /*0x3f94248*/ void set_CouponDiscountAmount(int value);
                            /*0x3f94250*/ int get_BillingAmount();
                            /*0x3f94258*/ void set_BillingAmount(int value);
                        }

                        struct ReceiptModel
                        {
                            /*0x10*/ string <InappPurchaseData>k__BackingField;
                            /*0x18*/ System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> <ReceiptInfo>k__BackingField;
                            /*0x88*/ string <InappDataSignature>k__BackingField;

                            /*0x3f942b4*/ ReceiptModel(string inappPurchaseData, string inappDataSignature);
                            /*0x3f94260*/ string get_InappPurchaseData();
                            /*0x3f94268*/ void set_InappPurchaseData(string value);
                            /*0x3f94270*/ System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> get_ReceiptInfo();
                            /*0x3f94280*/ void set_ReceiptInfo(System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> value);
                            /*0x3f942a4*/ string get_InappDataSignature();
                            /*0x3f942ac*/ void set_InappDataSignature(string value);
                            /*0x3f93974*/ void ConstractReceiptInfo();
                        }

                        struct ReceiptList
                        {
                            /*0x10*/ System.Collections.Generic.List<string> <InappPurchaseDataList>k__BackingField;
                            /*0x18*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> <ReceiptInfoList>k__BackingField;
                            /*0x20*/ System.Collections.Generic.List<string> <InappDataSignatureList>k__BackingField;

                            /*0x3f943c8*/ System.Collections.Generic.List<string> get_InappPurchaseDataList();
                            /*0x3f943d0*/ void set_InappPurchaseDataList(System.Collections.Generic.List<string> value);
                            /*0x3f943d8*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> get_ReceiptInfoList();
                            /*0x3f943e0*/ void set_ReceiptInfoList(System.Collections.Generic.List<DMM.Games.Recibo.Api.Receipt.Model.ReceiptInfo> value);
                            /*0x3f943e8*/ System.Collections.Generic.List<string> get_InappDataSignatureList();
                            /*0x3f943f0*/ void set_InappDataSignatureList(System.Collections.Generic.List<string> value);
                            /*0x3f93e70*/ void ConstractReceiptInfoList();
                            /*0x3f943f8*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel[] ConvertToReceiptModelArray();
                        }
                    }
                }

                namespace Orders
                {
                    class RankPointConfirm : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Orders.Model.OrdersModel>
                    {
                        /*0x38*/ DMM.Games.Recibo.Api.Orders.Model.RequestModel requestModel;

                        /*0x3f94558*/ RankPointConfirm(string apiToken, string openId, string accessToken, long amount, bool isSandbox);
                        /*0x3f94610*/ string GetDomain();
                        /*0x3f94658*/ string GetEndpoint();
                        /*0x3f94698*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f946f0*/ string GetRequestBody();
                        /*0x3f94750*/ DMM.Games.Recibo.Api.Orders.Model.OrdersModel ParseResponse(string responseBody);
                    }

                    namespace Model
                    {
                        struct RequestModel
                        {
                            /*0x10*/ long <Amount>k__BackingField;

                            /*0x3f94608*/ RequestModel(long amount);
                            /*0x3f94798*/ long get_Amount();
                            /*0x3f947a0*/ void set_Amount(long value);
                        }

                        struct OrdersModel
                        {
                            /*0x10*/ DMM.Games.Recibo.Api.Orders.Model.GamesRank GamesRank;
                        }

                        class GamesRank
                        {
                            /*0x10*/ string CurrentRankName;
                            /*0x18*/ int GrantPoint;

                            /*0x3f94828*/ GamesRank();
                            /*0x3f947a8*/ string ToString();
                        }
                    }
                }

                namespace Product
                {
                    class GetProduct : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnitListModel>
                    {
                        /*0x38*/ DMM.Games.Recibo.Api.Product.Model.RequestModel _requestModel;

                        /*0x3f94830*/ GetProduct(string apiToken, string locale, string[] productIds, bool isSandbox);
                        /*0x3f94944*/ string GetRequestBody();
                        /*0x3f949a4*/ string GetEndpoint();
                        /*0x3f949e4*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f94a3c*/ DMM.Games.Recibo.Api.Product.Model.StockKeepingUnitListModel ParseResponse(string responseBody);
                    }

                    namespace Model
                    {
                        struct RequestModel
                        {
                            /*0x10*/ string <Locale>k__BackingField;
                            /*0x18*/ string[] <ProductIds>k__BackingField;

                            /*0x3f94914*/ RequestModel(string locale, string[] productIds);
                            /*0x3f94a84*/ string get_Locale();
                            /*0x3f94a8c*/ void set_Locale(string value);
                            /*0x3f94a94*/ string[] get_ProductIds();
                            /*0x3f94a9c*/ void set_ProductIds(string[] value);
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

                            /*0x3f94aa4*/ string get_ProductId();
                            /*0x3f94aac*/ void set_ProductId(string value);
                            /*0x3f94ab4*/ string get_Type();
                            /*0x3f94abc*/ void set_Type(string value);
                            /*0x3f94ac4*/ string get_Title();
                            /*0x3f94acc*/ void set_Title(string value);
                            /*0x3f94ad4*/ string get_Description();
                            /*0x3f94adc*/ void set_Description(string value);
                            /*0x3f94ae4*/ string get_Price();
                            /*0x3f94aec*/ void set_Price(string value);
                            /*0x3f94af4*/ long get_PriceAmountMicros();
                            /*0x3f94afc*/ void set_PriceAmountMicros(long value);
                            /*0x3f94b04*/ string get_PriceCurrencyCode();
                            /*0x3f94b0c*/ void set_PriceCurrencyCode(string value);
                            /*0x3f94b14*/ string ToString();
                        }

                        struct StockKeepingUnitListModel
                        {
                            /*0x10*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> <Skus>k__BackingField;

                            /*0x3f94d48*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> get_Skus();
                            /*0x3f94d50*/ void set_Skus(System.Collections.Generic.List<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> value);
                            /*0x3f94d58*/ string ToString();
                            /*0x3f94f1c*/ System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> FindSku(string productId);
                        }
                    }
                }

                namespace Order
                {
                    class CancelOrder : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Order.Model.OrderModel>
                    {
                        /*0x38*/ string _orderId;

                        /*0x3f95158*/ CancelOrder(string apiToken, string openId, string accessToken, string orderId, bool isSandbox);
                        /*0x3f95210*/ string GetAdditionalQuery();
                        /*0x3f9525c*/ string GetEndpoint();
                        /*0x3f9529c*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f952f4*/ DMM.Games.Recibo.Api.Order.Model.OrderModel ParseResponse(string responseBody);
                    }

                    class CreateOrder : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Order.Model.OrderModel>
                    {
                        /*0x38*/ DMM.Games.Recibo.Api.Order.Model.RequestModel requestModel;

                        /*0x3f95368*/ CreateOrder(string apiToken, string openId, string accessToken, string locale, string productId, int quantity, string developerPayload, bool isSandbox);
                        /*0x3f954bc*/ string GetEndpoint();
                        /*0x3f954fc*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f95554*/ DMM.Games.Recibo.Api.Order.Model.OrderModel ParseResponse(string responseBody);
                        /*0x3f955c8*/ string GetRequestBody();
                    }

                    namespace Model
                    {
                        struct RequestModel
                        {
                            /*0x10*/ string <Locale>k__BackingField;
                            /*0x18*/ string <ProductId>k__BackingField;
                            /*0x20*/ int <Quantity>k__BackingField;
                            /*0x28*/ string <DeveloperPayload>k__BackingField;

                            /*0x3f95468*/ RequestModel(string locale, string productId, int quantity, string developerPayload);
                            /*0x3f9562c*/ string get_Locale();
                            /*0x3f95634*/ void set_Locale(string value);
                            /*0x3f9563c*/ string get_ProductId();
                            /*0x3f95644*/ void set_ProductId(string value);
                            /*0x3f9564c*/ int get_Quantity();
                            /*0x3f95654*/ void set_Quantity(int value);
                            /*0x3f9565c*/ string get_DeveloperPayload();
                            /*0x3f95664*/ void set_DeveloperPayload(string value);
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

                            /*0x3f9566c*/ string get_OrderId();
                            /*0x3f95674*/ void set_OrderId(string value);
                            /*0x3f9567c*/ string get_PurchaseId();
                            /*0x3f95684*/ void set_PurchaseId(string value);
                            /*0x3f9568c*/ string get_Sku();
                            /*0x3f95694*/ void set_Sku(string value);
                            /*0x3f9569c*/ string get_Locale();
                            /*0x3f956a4*/ void set_Locale(string value);
                            /*0x3f956ac*/ string get_Type();
                            /*0x3f956b4*/ void set_Type(string value);
                            /*0x3f956bc*/ string get_Title();
                            /*0x3f956c4*/ void set_Title(string value);
                            /*0x3f956cc*/ string get_Price();
                            /*0x3f956d4*/ void set_Price(string value);
                            /*0x3f956dc*/ long get_PriceAmountMicros();
                            /*0x3f956e4*/ void set_PriceAmountMicros(long value);
                            /*0x3f956ec*/ string get_PriceCurrencyCode();
                            /*0x3f956f4*/ void set_PriceCurrencyCode(string value);
                            /*0x3f956fc*/ int get_Quantity();
                            /*0x3f95704*/ void set_Quantity(int value);
                            /*0x3f9570c*/ string get_CreatedAt();
                            /*0x3f95714*/ void set_CreatedAt(string value);
                            /*0x3f9571c*/ string get_UpdatedAt();
                            /*0x3f95724*/ void set_UpdatedAt(string value);
                            /*0x3f9572c*/ string get_DeveloperPayload();
                            /*0x3f95734*/ void set_DeveloperPayload(string value);
                            /*0x3f9573c*/ int get_CouponCounts();
                            /*0x3f95744*/ void set_CouponCounts(int value);
                            /*0x3f9574c*/ string ToString();
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

                            /*0x3f95b48*/ ErrorModel();
                            /*0x3f95b38*/ DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain get_Error();
                            /*0x3f95b40*/ void set_Error(DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain value);

                            class ErrorMain
                            {
                                /*0x10*/ int <Code>k__BackingField;
                                /*0x18*/ string <Message>k__BackingField;
                                /*0x20*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain.ErrorDetail> <Details>k__BackingField;

                                /*0x3f95b80*/ ErrorMain();
                                /*0x3f95b50*/ int get_Code();
                                /*0x3f95b58*/ void set_Code(int value);
                                /*0x3f95b60*/ string get_Message();
                                /*0x3f95b68*/ void set_Message(string value);
                                /*0x3f95b70*/ System.Collections.Generic.List<DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain.ErrorDetail> get_Details();
                                /*0x3f95b78*/ void set_Details(System.Collections.Generic.List<DMM.Games.Recibo.Api.Error.Model.ErrorModel.ErrorMain.ErrorDetail> value);

                                class ErrorDetail
                                {
                                    /*0x10*/ string <Domain>k__BackingField;
                                    /*0x18*/ string <Reason>k__BackingField;
                                    /*0x20*/ string <Message>k__BackingField;
                                    /*0x28*/ string <GwCode>k__BackingField;
                                    /*0x30*/ string <GwMessage>k__BackingField;

                                    /*0x3f95bd8*/ ErrorDetail();
                                    /*0x3f95b88*/ string get_Domain();
                                    /*0x3f95b90*/ void set_Domain(string value);
                                    /*0x3f95b98*/ string get_Reason();
                                    /*0x3f95ba0*/ void set_Reason(string value);
                                    /*0x3f95ba8*/ string get_Message();
                                    /*0x3f95bb0*/ void set_Message(string value);
                                    /*0x3f95bb8*/ string get_GwCode();
                                    /*0x3f95bc0*/ void set_GwCode(string value);
                                    /*0x3f95bc8*/ string get_GwMessage();
                                    /*0x3f95bd0*/ void set_GwMessage(string value);
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

                        /*0x3f95bf0*/ GetAvailableCoupons(string apiToken, string openId, string accessToken, string orderId, bool isSandbox);
                        /*0x3f95be0*/ string get_OrderId();
                        /*0x3f95be8*/ void set_OrderId(string value);
                        /*0x3f95ca8*/ string GetAdditionalQuery();
                        /*0x3f95d14*/ string GetEndpoint();
                        /*0x3f95d54*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f95dac*/ DMM.Games.Recibo.Api.Coupon.Model.GetAvailableCouponsModel ParseResponse(string responseBody);
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

                            /*0x3f95fa4*/ CouponModel();
                            /*0x3f95df4*/ string get_AcquiredAt();
                            /*0x3f95dfc*/ void set_AcquiredAt(string value);
                            /*0x3f95e04*/ string get_BannerUrl();
                            /*0x3f95e0c*/ void set_BannerUrl(string value);
                            /*0x3f95e14*/ DMM.Games.Recibo.Api.Coupon.Model.DiscountProduct get_Discount();
                            /*0x3f95e1c*/ void set_Discount(DMM.Games.Recibo.Api.Coupon.Model.DiscountProduct value);
                            /*0x3f95e24*/ int get_DiscountAmount();
                            /*0x3f95e2c*/ void set_DiscountAmount(int value);
                            /*0x3f95e34*/ int get_DiscountRate();
                            /*0x3f95e3c*/ void set_DiscountRate(int value);
                            /*0x3f95e44*/ string get_DisplayType();
                            /*0x3f95e4c*/ void set_DisplayType(string value);
                            /*0x3f95e54*/ string get_Explanation();
                            /*0x3f95e5c*/ void set_Explanation(string value);
                            /*0x3f95e64*/ string get_GuidanceUrl();
                            /*0x3f95e6c*/ void set_GuidanceUrl(string value);
                            /*0x3f95e74*/ string get_Id();
                            /*0x3f95e7c*/ void set_Id(string value);
                            /*0x3f95e84*/ bool get_IsAvailable();
                            /*0x3f95e8c*/ void set_IsAvailable(bool value);
                            /*0x3f95e98*/ bool get_IsForSegmentDistribution();
                            /*0x3f95ea0*/ void set_IsForSegmentDistribution(bool value);
                            /*0x3f95eac*/ bool get_IsPremium();
                            /*0x3f95eb4*/ void set_IsPremium(bool value);
                            /*0x3f95ec0*/ bool get_IsPublished();
                            /*0x3f95ec8*/ void set_IsPublished(bool value);
                            /*0x3f95ed4*/ int get_MaxDiscountAmount();
                            /*0x3f95edc*/ void set_MaxDiscountAmount(int value);
                            /*0x3f95ee4*/ int get_MinPayment();
                            /*0x3f95eec*/ void set_MinPayment(int value);
                            /*0x3f95ef4*/ string get_PublicEndAt();
                            /*0x3f95efc*/ void set_PublicEndAt(string value);
                            /*0x3f95f04*/ string get_PublicStartAt();
                            /*0x3f95f0c*/ void set_PublicStartAt(string value);
                            /*0x3f95f14*/ int get_RemainedCount();
                            /*0x3f95f1c*/ void set_RemainedCount(int value);
                            /*0x3f95f24*/ int get_RemainedCountPerUser();
                            /*0x3f95f2c*/ void set_RemainedCountPerUser(int value);
                            /*0x3f95f34*/ string get_Title();
                            /*0x3f95f3c*/ void set_Title(string value);
                            /*0x3f95f44*/ DMM.Games.Recibo.Api.Coupon.Model.CouponTagLabel[] get_Labels();
                            /*0x3f95f4c*/ void set_Labels(DMM.Games.Recibo.Api.Coupon.Model.CouponTagLabel[] value);
                            /*0x3f95f54*/ string get_UseCondition();
                            /*0x3f95f5c*/ void set_UseCondition(string value);
                            /*0x3f95f64*/ string get_UseEndAt();
                            /*0x3f95f6c*/ void set_UseEndAt(string value);
                            /*0x3f95f74*/ int get_UseLimit();
                            /*0x3f95f7c*/ void set_UseLimit(int value);
                            /*0x3f95f84*/ int get_UseLimitPerUser();
                            /*0x3f95f8c*/ void set_UseLimitPerUser(int value);
                            /*0x3f95f94*/ string get_UseStartAt();
                            /*0x3f95f9c*/ void set_UseStartAt(string value);
                        }

                        class CouponNotice
                        {
                            /*0x10*/ string <Message>k__BackingField;

                            /*0x3f95fbc*/ CouponNotice();
                            /*0x3f95fac*/ string get_Message();
                            /*0x3f95fb4*/ void set_Message(string value);
                        }

                        class CouponTagLabel
                        {
                            /*0x10*/ string <LabelId>k__BackingField;
                            /*0x18*/ string <Description>k__BackingField;
                            /*0x20*/ string <FontColor>k__BackingField;
                            /*0x28*/ string <BorderColor>k__BackingField;

                            /*0x3f96004*/ CouponTagLabel();
                            /*0x3f95fc4*/ string get_LabelId();
                            /*0x3f95fcc*/ void set_LabelId(string value);
                            /*0x3f95fd4*/ string get_Description();
                            /*0x3f95fdc*/ void set_Description(string value);
                            /*0x3f95fe4*/ string get_FontColor();
                            /*0x3f95fec*/ void set_FontColor(string value);
                            /*0x3f95ff4*/ string get_BorderColor();
                            /*0x3f95ffc*/ void set_BorderColor(string value);
                        }

                        class DiscountProduct
                        {
                            /*0x10*/ int <DiscountAmount>k__BackingField;
                            /*0x14*/ int <DiscountedAmount>k__BackingField;
                            /*0x18*/ bool <IsDiscountable>k__BackingField;

                            /*0x3f96040*/ DiscountProduct();
                            /*0x3f9600c*/ int get_DiscountAmount();
                            /*0x3f96014*/ void set_DiscountAmount(int value);
                            /*0x3f9601c*/ int get_DiscountedAmount();
                            /*0x3f96024*/ void set_DiscountedAmount(int value);
                            /*0x3f9602c*/ bool get_IsDiscountable();
                            /*0x3f96034*/ void set_IsDiscountable(bool value);
                        }

                        class GetAvailableCouponsModel
                        {
                            /*0x10*/ DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] <Coupons>k__BackingField;
                            /*0x18*/ int <Total>k__BackingField;
                            /*0x20*/ DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] <Notice>k__BackingField;

                            /*0x3f96078*/ GetAvailableCouponsModel();
                            /*0x3f96048*/ DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] get_Coupons();
                            /*0x3f96050*/ void set_Coupons(DMM.Games.Recibo.Api.Coupon.Model.CouponModel[] value);
                            /*0x3f96058*/ int get_Total();
                            /*0x3f96060*/ void set_Total(int value);
                            /*0x3f96068*/ DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] get_Notice();
                            /*0x3f96070*/ void set_Notice(DMM.Games.Recibo.Api.Coupon.Model.CouponNotice[] value);
                        }
                    }
                }

                namespace Sdk
                {
                    class ClientAccess : DMM.Games.Recibo.Api.ReciboApi<DMM.Games.Recibo.Api.Sdk.Model.ClientAccessModel>
                    {
                        /*0x38*/ int appId;
                        /*0x3c*/ int userId;

                        /*0x3f96080*/ ClientAccess(int appId, int userId, bool isSandbox);
                        /*0x3f96120*/ string GetDomain();
                        /*0x3f96160*/ string GetAdditionalQuery();
                        /*0x3f961f4*/ string GetEndpoint();
                        /*0x3f96234*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> BuildRequestHeaders();
                        /*0x3f9623c*/ DMM.Games.Net.Method GetMethod();
                        /*0x3f96294*/ DMM.Games.Recibo.Api.Sdk.Model.ClientAccessModel ParseResponse(string responseBody);
                    }

                    namespace Model
                    {
                        struct ClientAccessModel
                        {
                            /*0x3f9629c*/ string ToString();
                        }
                    }
                }
            }
        }

        namespace Net
        {
            class HttpClientFactory
            {
                static /*0x3f962b4*/ DMM.Games.Net.IHttpClient NewHttpClient();
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

                static /*0x3f963b8*/ Method();
                /*0x3f96368*/ Method(bool existsRequestBody, bool existsResponseBody, string name);
                /*0x3f96330*/ bool get_ExistsRequestBody();
                /*0x3f96338*/ void set_ExistsRequestBody(bool value);
                /*0x3f96344*/ bool get_ExistsResponseBody();
                /*0x3f9634c*/ void set_ExistsResponseBody(bool value);
                /*0x3f96358*/ string get_Name();
                /*0x3f96360*/ void set_Name(string value);
            }

            class OnResponseCallback : System.MulticastDelegate
            {
                /*0x3f96560*/ OnResponseCallback(object object, nint method);
                /*0x3f9666c*/ void Invoke(object tag, long httpStatusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string body);
                /*0x3f96680*/ System.IAsyncResult BeginInvoke(object tag, long httpStatusCode, System.Collections.Generic.Dictionary<string, string> responseHeaders, string body, System.AsyncCallback callback, object object);
                /*0x3f966fc*/ void EndInvoke(System.IAsyncResult result);
            }

            class OnNetworkErrorCallback : System.MulticastDelegate
            {
                /*0x3f96708*/ OnNetworkErrorCallback(object object, nint method);
                /*0x3f96814*/ void Invoke(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                /*0x3f96828*/ System.IAsyncResult BeginInvoke(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception, System.AsyncCallback callback, object object);
                /*0x3f968c4*/ void EndInvoke(System.IAsyncResult result);
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

                    /*0x3f968ec*/ UnityWebRequestAsyncOperationAwaiter(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                    /*0x3f968d0*/ bool get_IsCompleted();
                    /*0x3f9691c*/ void GetResult();
                    /*0x3f96920*/ void OnCompleted(System.Action continuation);
                    /*0x3f969f8*/ DMM.Games.Net.Unity.UnityWebRequestAsyncOperationAwaiter GetAwaiter();

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ System.Action continuation;

                        /*0x3f969f0*/ <>c__DisplayClass5_0();
                        /*0x3f969fc*/ void <OnCompleted>b__0(UnityEngine.AsyncOperation _);
                    }
                }

                class UnityWebRequestAsyncOperationExtension
                {
                    static /*0x3f96a20*/ DMM.Games.Net.Unity.UnityWebRequestAsyncOperationAwaiter GetAwaiter(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                    static /*0x3f96a88*/ DMM.Games.Net.Unity.UnityWebRequestAsyncOperationAwaiter ConfigureAwait(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
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

                    static /*0x3f96cc4*/ void SetUserAgent(string userAgent);
                    static /*0x3f96f04*/ string BuildHeaderValue(System.Collections.Generic.List<string> values);
                    /*0x3f96b40*/ RequestTask(System.Threading.SynchronizationContext context, object tag, string url, DMM.Games.Net.Method method, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> requestHeaders, string body, DMM.Games.Net.OnResponseCallback successCallback, DMM.Games.Net.OnResponseCallback failureCallback, DMM.Games.Net.OnNetworkErrorCallback networkErrorCallback);
                    /*0x3f96af0*/ object get_tag();
                    /*0x3f96af8*/ void set_tag(object value);
                    /*0x3f96b00*/ string get_url();
                    /*0x3f96b08*/ void set_url(string value);
                    /*0x3f96b10*/ DMM.Games.Net.Method get_method();
                    /*0x3f96b18*/ void set_method(DMM.Games.Net.Method value);
                    /*0x3f96b20*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> get_requestHeaders();
                    /*0x3f96b28*/ void set_requestHeaders(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> value);
                    /*0x3f96b30*/ string get_body();
                    /*0x3f96b38*/ void set_body(string value);
                    /*0x3f96c2c*/ void Request();
                    /*0x3f96d1c*/ void SetRequestHeaders(UnityEngine.Networking.UnityWebRequest request);
                    /*0x3f970e4*/ void <Request>b__26_0(object state);

                    struct <<Request>b__26_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ DMM.Games.Net.Unity.RequestTask <>4__this;
                        /*0x40*/ UnityEngine.Networking.UnityWebRequest <req>5__2;
                        /*0x48*/ object <>u__1;

                        /*0x3f97194*/ void MoveNext();
                        /*0x3f97848*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class HttpClientUnityImpl : DMM.Games.Net.IHttpClient
                {
                    /*0x10*/ System.Threading.SynchronizationContext context;

                    /*0x3f96304*/ HttpClientUnityImpl();
                    /*0x3f97854*/ bool Request(string url, DMM.Games.Net.Method method, object tag, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> requestHeaders, DMM.Games.Net.OnResponseCallback successCallback, DMM.Games.Net.OnResponseCallback failureCallback, DMM.Games.Net.OnNetworkErrorCallback networkErrorCallback, string requestBody);
                }
            }
        }

        namespace Util
        {
            class BridgeJsonUtility
            {
                static /*0x382fccc*/ string List2Json<T>(System.Collections.Generic.List<T> list, bool isString);
                static /*0x3f97924*/ string EscapeJsonStringValue(string value);
                static /*0x3f97930*/ string EscapeSpecialCharactersForJson(string value);
                static /*0x3f97b48*/ string GenerateOpenTransactionRequestJson(Dmm.Games.Store.OsapiPaymentResult paymentResult, string gameEngineName);
                static /*0x3f97fd0*/ string ConvertToJson(Dmm.Games.Store.Menu menu, string gameEngineName);
                static /*0x3f98304*/ string GenerateReceiptAuthDataRequestJson(string gameEngineName);
                static /*0x3f98464*/ string GenerateSendSpendEventRequestJson(double amount, string gameEngineName);
                static /*0x3f98634*/ string ConvertToJson(Dmm.Games.Store.DmmGamesStoreSdkSettings settings, string version, string cloudLoginToken, string gameEngineName);
            }

            class InstanceUtility
            {
                static /*0x3f99184*/ UnityEngine.GameObject Instance(string path);
                /*0x3f99250*/ InstanceUtility();
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

                /*0x3f99394*/ BackGroundController();
                /*0x3f99258*/ void Start();
                /*0x3f9929c*/ void Update();
                /*0x3f99324*/ void AdjustBackgroundSize();
                /*0x3f99284*/ void SetTotalHight();
                /*0x3f992e0*/ int GetTotalHight();
            }

            class ClickDetector : UnityEngine.UI.Graphic
            {
                /*0x3f993c8*/ ClickDetector();
                /*0x3f993b0*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            }

            class DateUtility
            {
                static /*0x0*/ string REGEX_DURATION_STRING;
                static /*0x8*/ int NUM_OF_MATCHES_WHEN_FOUND;
                static /*0xc*/ int NUM_OF_GROUPS_WHEN_FOUND;
                static /*0x10*/ int DURATION_UNIT_GROUP_INDEX;
                static /*0x14*/ int DURATION_COUNT_GROUP_INDEX;
                static /*0x18*/ System.Collections.ObjectModel.ReadOnlyDictionary<string, string> DURATION_STRING_POSTFIX_FOR_USER_DICTIONARY;

                static /*0x3f99d5c*/ DateUtility();
                static /*0x3f99420*/ string ConvertDateTimeOffsetToString(System.DateTimeOffset dateTime);
                static /*0x3f994f4*/ string ConvertUnixTimeToDateTimeString(long unixTime);
                static /*0x3f99584*/ string ConvertW3CXmlSchemaTimeDurationStringToDateTimeString(string duration);
                static /*0x3f99728*/ string ConvertDurationUnitStringToUserDisplayPostfix(string durationUnitString);
                static /*0x3f99a28*/ string ConvertW3CXmlSchemaTimeDurationStringToUserDisplayString(string duration);
                static /*0x3f99c10*/ long GetStringToUnixTimestamp(string time);
                /*0x3f99d54*/ DateUtility();
            }

            class DialogCanvasController : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.CanvasScaler _canvasScaler;
                /*0x28*/ UnityEngine.Canvas _canvas;

                /*0x3f9a060*/ DialogCanvasController();
                /*0x3f99f98*/ void Init(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
            }

            class JsonUtility
            {
                static /*0x3907c14*/ T Deserialize<T>(string data);
                static /*0x3f91bc0*/ string Serialize(object data);
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
                static /*0x3f9a068*/ UnityEngine.AndroidJavaObject GetIntent();
                static /*0x3f9a42c*/ bool HasExtra(UnityEngine.AndroidJavaObject intent, string target);
                static /*0x3f9a50c*/ UnityEngine.AndroidJavaObject GetExtras(UnityEngine.AndroidJavaObject intent);
                static /*0x3907c14*/ T GetExtra<T>(string target);
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

                    /*0x3f9a5d8*/ MarketingEventIds();
                }

                class ResultLoginData
                {
                    /*0x10*/ string ErrorMessage;
                    /*0x18*/ string AccessToken;
                    /*0x20*/ string OpenId;

                    /*0x3f9a6f0*/ ResultLoginData();
                }

                class SendSpendEventData
                {
                    /*0x10*/ bool IsSuccess;
                    /*0x18*/ string Error;

                    /*0x3f9a6f8*/ SendSpendEventData();
                }

                class DmmGamesLoginHelper<T> : UnityEngine.MonoBehaviour
                {
                    static /*0x0*/ T _g;
                    static /*0x0*/ Dmm.Games.Store.DmmGamesStoreSdk _sdk;
                    static /*0x0*/ Dmm.Games.Unity.Purchasing.ResultLoginData _resultLoginData;
                    static /*0x0*/ System.Action<Dmm.Games.Unity.Purchasing.ResultLoginData> _resultAction;
                    static /*0x0*/ bool _isInit;

                    static /*0x382dee4*/ string get_Version();
                    static /*0x3837da0*/ void Instance(string objectName);
                    static /*0x382dee4*/ Dmm.Games.Store.DmmGamesStoreSdk GetDmmGamesStoreSdk();
                    static /*0x3837da0*/ void ResultError(string message);
                    /*0x380cb08*/ DmmGamesLoginHelper();

                    class Environment<T>
                    {
                        static string Production = "prod";
                        static string Staging = "Staging";

                        /*0x380cb08*/ Environment();
                    }

                    class DevelopmentMode<T>
                    {
                        static string Release = "Service";
                        static string Sandbox = "sandbox";

                        /*0x380cb08*/ DevelopmentMode();
                    }
                }

                class DmmGamesStore : Dmm.Games.Unity.Purchasing.DmmGamesLoginHelper<Dmm.Games.Unity.Purchasing.DmmGamesStore>
                {
                    static string OBJECT_NAME = "DmmGamesBrowserHelperObject";

                    static /*0x3f9a700*/ void Login(Dmm.Games.Unity.Purchasing.DmmGamesStoreSettings settings, System.Action<Dmm.Games.Unity.Purchasing.ResultLoginData> action);
                    static /*0x3f9a7b4*/ void LoginWithGetReceiptAuthData(Dmm.Games.Store.DmmGamesStoreSdkSettings settings, System.Action<Dmm.Games.Unity.Purchasing.ResultLoginData> action);
                    static /*0x3f9ad7c*/ void SendSpendEvent(double amount, System.Action<Dmm.Games.Unity.Purchasing.SendSpendEventData> action);
                    static /*0x3f9aff0*/ void OpenMenu(Dmm.Games.Unity.Purchasing.Menu menu, System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> action);
                    static /*0x3f9b1b8*/ Dmm.Games.Store.Menu ConvertMenu(Dmm.Games.Unity.Purchasing.Menu menu);
                    /*0x3f9b2d4*/ DmmGamesStore();
                    /*0x3f9aaf4*/ void OnInit(string result);
                    /*0x3f9acb4*/ void OnGetReceiptAuthData(Dmm.Games.Store.ReceiptAuthDataResult result);

                    class <>c
                    {
                        static /*0x0*/ Dmm.Games.Unity.Purchasing.DmmGamesStore.<> <>9;
                        static /*0x8*/ System.Action<Dmm.Games.Store.SdkResult> <>9__2_0;

                        static /*0x3f9b31c*/ <>c();
                        /*0x3f9b384*/ <>c();
                        /*0x3f9b38c*/ void <LoginWithGetReceiptAuthData>b__2_0(Dmm.Games.Store.SdkResult result);
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ System.Action<Dmm.Games.Unity.Purchasing.SendSpendEventData> action;
                        /*0x18*/ Dmm.Games.Unity.Purchasing.SendSpendEventData data;

                        /*0x3f9af2c*/ <>c__DisplayClass5_0();
                        /*0x3f9b4c8*/ void <SendSpendEvent>b__0(Dmm.Games.Store.SendSpendEventResult result);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> action;
                        /*0x18*/ Dmm.Games.Unity.Purchasing.MenuEventData data;

                        /*0x3f9b1a8*/ <>c__DisplayClass6_0();
                        /*0x3f9b548*/ void <OpenMenu>b__0(Dmm.Games.Store.SdkResult result);
                    }
                }

                class DmmGamesStoreSettings : Dmm.Games.Store.DmmGamesStoreSdkSettings
                {
                    /*0x3f9b5cc*/ DmmGamesStoreSettings();
                }

                class HttpException : System.Exception
                {
                    /*0x8c*/ bool <IsNetworkError>k__BackingField;
                    /*0x90*/ int <StatusCode>k__BackingField;
                    /*0x98*/ Dmm.Games.Unity.Purchasing.RawResult <result>k__BackingField;

                    /*0x3f9b6bc*/ HttpException(string message);
                    /*0x3f9b730*/ HttpException(string message, int statusCode);
                    /*0x3f9b7ac*/ HttpException(int statusCode, byte[] body, string message);
                    /*0x3f9b868*/ bool get_IsNetworkError();
                    /*0x3f9b870*/ void set_IsNetworkError(bool value);
                    /*0x3f9b87c*/ int get_StatusCode();
                    /*0x3f9b884*/ void set_StatusCode(int value);
                    /*0x3f9b88c*/ Dmm.Games.Unity.Purchasing.RawResult get_result();
                    /*0x3f9b898*/ void set_result(Dmm.Games.Unity.Purchasing.RawResult value);
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

                    /*0x3f9b1b0*/ MenuEventData();
                }

                class DeveloperPayload
                {
                    /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesTerms DmmGamesTerms;

                    /*0x3f9b8a8*/ DeveloperPayload();
                }

                class DmmGamesTerms
                {
                    /*0x10*/ string PeriodTimeDescription;
                    /*0x18*/ string TermOfDelivery;
                    /*0x20*/ string TermOfPayment;
                    /*0x28*/ string ReturnPolicy;

                    /*0x3f9b914*/ DmmGamesTerms();
                }

                class DmmGamesApiResult
                {
                    static /*0x3f9b91c*/ string GetMaintenanceUrl(bool isAdult);
                    static /*0x3f9b984*/ void DisassemblyForBrowser(long statusCode, string body, ref int code, ref string message, bool isAdult);
                    static /*0x3f9bb8c*/ DMM.Games.Recibo.Api.Error.Model.ErrorModel GetErrorModel(string message);
                    static /*0x3f9bc64*/ bool IsErrorModel(DMM.Games.Recibo.Api.Error.Model.ErrorModel model);
                    static /*0x3f9bc58*/ bool IsMaintenance(long status);
                    /*0x3f9bc78*/ DmmGamesApiResult();
                }

                struct UserKey
                {
                    /*0x10*/ string <OpenId>k__BackingField;
                    /*0x18*/ string <AccessToken>k__BackingField;

                    /*0x3f9bc80*/ string get_OpenId();
                    /*0x3f9bc88*/ void set_OpenId(string value);
                    /*0x3f9bc90*/ string get_AccessToken();
                    /*0x3f9bc98*/ void set_AccessToken(string value);
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

                    static /*0x3f9f4b8*/ DmmGamesIapStore();
                    static /*0x3f9bfa0*/ Dmm.Games.Unity.Purchasing.Error.DmmGamesIapStoreError get_Error();
                    static /*0x3f9bff8*/ void set_Error(Dmm.Games.Unity.Purchasing.Error.DmmGamesIapStoreError value);
                    static /*0x3f9e79c*/ void ClearError();
                    static /*0x3f9f3e4*/ string GetSubscriptionContractPageUrl(bool isAdult);
                    static /*0x3f9f44c*/ string GetGamesRankPageUrl(bool isAdult);
                    /*0x3f9c130*/ DmmGamesIapStore(Dmm.Games.Unity.Purchasing.DmmGamesIapStoreConfiguration storeConfiguration);
                    /*0x3f9bca0*/ string get_Version();
                    /*0x3f9bce0*/ string GetVersion();
                    /*0x3f9bd20*/ bool get_IsSdkReady();
                    /*0x3f9bd30*/ string get_GamesId();
                    /*0x3f9bd64*/ string get_GamesIdSignature();
                    /*0x3f9bd7c*/ string get_ViewerId();
                    /*0x3f9bdb0*/ string get_ViewerIdSignature();
                    /*0x3f9bdc8*/ string get_PointChargeUrl();
                    /*0x3f9bde0*/ Dmm.Games.Unity.Purchasing.UserType get_UserType();
                    /*0x3f90e54*/ string get_CreditChangeUrl();
                    /*0x3f91100*/ string get_MaintenanceUrl();
                    /*0x3f9c058*/ string get_ApiToken();
                    /*0x3f9c060*/ Dmm.Games.Unity.Purchasing.UserKey get_UserKey();
                    /*0x3f9c06c*/ bool get_IsSandbox();
                    /*0x3f9c074*/ int get_SortOrderOffset();
                    /*0x3f9c07c*/ void set_SortOrderOffset(int value);
                    /*0x3f9c084*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventory get_Inventory();
                    /*0x3f9c08c*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreSubscriptionInventory get_SubscriptionInventory();
                    /*0x3f9c094*/ UnityEngine.Texture2D get_ProductIcon();
                    /*0x3f9c09c*/ UnityEngine.Texture2D ProductIcons(string id);
                    /*0x3f9c388*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
                    /*0x3f9c390*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                    /*0x3f9c7b8*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
                    /*0x3f9cd88*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
                    /*0x3f9cd90*/ void FinishTransactionInternal(UnityEngine.Purchasing.ProductDefinition product, string transactionId, int count);
                    /*0x3f9c5b0*/ void QueryNonSubscriptionPurchase(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, int count);
                    /*0x3f9d328*/ void QueryNonSubscriptionSkuDetails(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Receipt.Model.ReceiptList purchasedList, int count);
                    /*0x3f9d9d0*/ void QuerySubscriptionPurchase(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, int count);
                    /*0x3f9dbf8*/ void QuerySubscriptionSkuDetails(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList purchasedList, int count);
                    /*0x3f9d64c*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> GetNonSubscriptionProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                    /*0x3f9e048*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> GetSubscriptionProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                    /*0x3f9c3a8*/ void InitializeSdk(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, int count);
                    /*0x3f9e828*/ void SetProductIcon(UnityEngine.Texture2D icon);
                    /*0x3f9e830*/ void SetProductIcon(string productId, UnityEngine.Texture2D icon);
                    /*0x3f9e8fc*/ void ClearProductIcon();
                    /*0x3f9e95c*/ string GetInAppPurchaseData(UnityEngine.Purchasing.Product product);
                    /*0x3f9eac8*/ string GetInAppDataSignature(UnityEngine.Purchasing.Product product);
                    /*0x3f9eb1c*/ void OpenSubscriptionContractPage();
                    /*0x3f9ebec*/ void OpenGamesRankPage();
                    /*0x3f9e9b0*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel GetReceiptModel(UnityEngine.Purchasing.Product product);
                    /*0x3f9ea48*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel GetSubscriptionReceiptModel(UnityEngine.Purchasing.Product product);
                    /*0x3f9ecbc*/ void ClientAccess(System.Nullable<int> appid, System.Nullable<int> viewerid, UnityEngine.Events.UnityAction action);
                    /*0x3f9eecc*/ void Disassembly(long statusCode, string body, ref int code, ref string message);
                    /*0x3f9f0d4*/ DMM.Games.Recibo.Api.Error.Model.ErrorModel GetErrorModel(string message);
                    /*0x3f9f1ac*/ bool IsErrorModel(DMM.Games.Recibo.Api.Error.Model.ErrorModel model);
                    /*0x3f9f1c8*/ void DisassemblyForSubscription(long statusCode, string body, ref int code, ref string codeString, ref string message);
                    /*0x3f9f30c*/ DMM.Games.Recibo.Api.Version2.BaseResultModel GetErrorModelForSubscription(string message);
                    /*0x3f9f1a0*/ bool IsMaintenance(long status);
                    /*0x3f9eb94*/ string GetSubscriptionContractPageUrl();
                    /*0x3f9ec64*/ string GetGamesRankPageUrl();
                    /*0x3f9f5c0*/ void <Purchase>b__60_0(System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> receipt);
                    /*0x3f9f804*/ void <Purchase>b__60_1(DMM.Games.Recibo.Ui.ErrorObject error);
                    /*0x3f9f9c8*/ void <Purchase>b__60_2(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel receipt);
                    /*0x3f9fb00*/ void <Purchase>b__60_3(DMM.Games.Recibo.Ui.ErrorObject error);

                    class <>c__DisplayClass62_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem item;
                        /*0x18*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x20*/ UnityEngine.Purchasing.ProductDefinition product;
                        /*0x28*/ string transactionId;

                        /*0x3f9d0d0*/ <>c__DisplayClass62_0();
                        /*0x3f9fd2c*/ void <FinishTransactionInternal>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel response);
                        /*0x3f9fd84*/ void <FinishTransactionInternal>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3f9feb4*/ void <FinishTransactionInternal>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass63_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                        /*0x3f9d320*/ <>c__DisplayClass63_0();
                        /*0x3fa00b8*/ void <QueryNonSubscriptionPurchase>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Receipt.Model.ReceiptList response);
                        /*0x3fa010c*/ void <QueryNonSubscriptionPurchase>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fa02c8*/ void <QueryNonSubscriptionPurchase>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass64_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                        /*0x20*/ DMM.Games.Recibo.Api.Receipt.Model.ReceiptList purchasedList;

                        /*0x3f9d644*/ <>c__DisplayClass64_0();
                        /*0x3fa0628*/ void <QueryNonSubscriptionSkuDetails>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Product.Model.StockKeepingUnitListModel response);
                        /*0x3fa0bbc*/ void <QueryNonSubscriptionSkuDetails>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fa0d78*/ void <QueryNonSubscriptionSkuDetails>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass65_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                        /*0x3f9dbf0*/ <>c__DisplayClass65_0();
                        /*0x3fa10e4*/ void <QuerySubscriptionPurchase>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Receipt.Model.GetReceiptResponseModel response);
                        /*0x3fa1110*/ void <QuerySubscriptionPurchase>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fa12d8*/ void <QuerySubscriptionPurchase>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass66_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                        /*0x20*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList purchasedList;

                        /*0x3f9e040*/ <>c__DisplayClass66_0();
                        /*0x3fa1638*/ void <QuerySubscriptionSkuDetails>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Product.Model.SearchProductResponseModel response);
                        /*0x3fa1eec*/ void <QuerySubscriptionSkuDetails>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fa20b4*/ void <QuerySubscriptionSkuDetails>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass69_0
                    {
                        /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore <>4__this;
                        /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                        /*0x3f9e794*/ <>c__DisplayClass69_0();
                        /*0x3fa2414*/ void <InitializeSdk>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Version2.Sdk.Model.InitializeSdkResponseModel response);
                        /*0x3fa24bc*/ void <InitializeSdk>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fa267c*/ void <InitializeSdk>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }

                    class <>c__DisplayClass80_0
                    {
                        /*0x10*/ UnityEngine.Events.UnityAction action;

                        /*0x3f9eec4*/ <>c__DisplayClass80_0();
                        /*0x3fa29dc*/ void <ClientAccess>b__0(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, DMM.Games.Recibo.Api.Sdk.Model.ClientAccessModel response);
                        /*0x3fa2a00*/ void <ClientAccess>b__1(object tag, long statusCode, System.Collections.Generic.Dictionary<string, string> headers, string body);
                        /*0x3fa2a24*/ void <ClientAccess>b__2(object tag, DMM.Games.Net.NetworkErrorKind error, System.Exception exception);
                    }
                }

                class DmmGamesIapStoreConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
                {
                    /*0x10*/ string ApiToken;
                    /*0x18*/ string OpenId;
                    /*0x20*/ string AccessToken;
                    /*0x28*/ bool IsSandbox;

                    /*0x3fa2a48*/ DmmGamesIapStoreConfiguration(string apiToken, string openId, string accessToken, bool isSandbox);
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

                    /*0x3fa2ab4*/ DmmGamesIapStoreErrorCode();
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

                    /*0x3fa2abc*/ DmmGamesIapStoreErrorKind();
                }

                class DmmGamesIapStoreExtension : UnityEngine.Purchasing.IStoreExtension
                {
                    /*0x10*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStore _store;

                    /*0x3fa2ac4*/ DmmGamesIapStoreExtension(Dmm.Games.Unity.Purchasing.DmmGamesIapStore store);
                    /*0x3fa2af4*/ string get_GamesId();
                    /*0x3fa2b34*/ string get_GamesIdSignature();
                    /*0x3fa2b60*/ string get_ViewerId();
                    /*0x3fa2ba0*/ string get_ViewerIdSignature();
                    /*0x3fa2bcc*/ string get_PointChargeUrl();
                    /*0x3fa2bf8*/ Dmm.Games.Unity.Purchasing.Error.IDmmGamesIapStoreError get_Error();
                    /*0x3fa2c80*/ void ClearError();
                    /*0x3fa2ccc*/ string GetVersion();
                    /*0x3fa2d18*/ void SetProductIcon(UnityEngine.Texture2D icon);
                    /*0x3fa2d34*/ void SetProductIcon(string productId, UnityEngine.Texture2D icon);
                    /*0x3fa2d4c*/ string GetInAppPurchaseData(UnityEngine.Purchasing.Product product);
                    /*0x3fa2d64*/ string GetInAppDataSignature(UnityEngine.Purchasing.Product product);
                    /*0x3fa2d7c*/ void SetPurchaseDialogSortOrderOffset(int offset);
                    /*0x3fa2d8c*/ void OpenSubscriptionContractPage();
                    /*0x3fa2d9c*/ void OpenGamesRankPage();
                }

                class DmmGamesIapStoreInventory
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<string, Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem> items;

                    static /*0x3fa3300*/ UnityEngine.Purchasing.ProductDefinition FindProduct(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> receiptModel);
                    /*0x3f9c278*/ DmmGamesIapStoreInventory();
                    /*0x3fa2dac*/ System.Collections.Generic.IEnumerable<string> get_KeySet();
                    /*0x3fa2dfc*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem get_Item(string key);
                    /*0x3fa2e00*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem Get(string key);
                    /*0x3f9cce8*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem FindItem(UnityEngine.Purchasing.ProductDefinition product);
                    /*0x3fa2f04*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreInventoryItem FindItem(string storeSpecificId);
                    /*0x3fa0714*/ void GenerateInventory(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnitListModel> skus, System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptList> receiptList);
                    /*0x3fa30f8*/ void BindReceiptToInventory(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptList> receiptList);
                    /*0x3f9e3cc*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertToProductDescriptionList();
                    /*0x3f9f75c*/ void UpdateReceipt(System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> receiptModel);
                }

                class DmmGamesIapStoreInventoryItem
                {
                    /*0x10*/ System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> <Sku>k__BackingField;
                    /*0x50*/ System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> <ReceiptModel>k__BackingField;

                    static /*0x3fa38a8*/ UnityEngine.Purchasing.ProductMetadata ConvertToMetadata(System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> sku);
                    /*0x3fa30bc*/ DmmGamesIapStoreInventoryItem(System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> sku);
                    /*0x3fa3840*/ System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> get_Sku();
                    /*0x3fa3854*/ void set_Sku(System.Nullable<DMM.Games.Recibo.Api.Product.Model.StockKeepingUnit> value);
                    /*0x3fa3874*/ System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> get_ReceiptModel();
                    /*0x3fa3884*/ void set_ReceiptModel(System.Nullable<DMM.Games.Recibo.Api.Receipt.Model.ReceiptModel> value);
                    /*0x3f9fd5c*/ void EraseReceipt();
                    /*0x3fa3644*/ UnityEngine.Purchasing.Extension.ProductDescription ConvertProductDescription();
                    /*0x3fa2e94*/ bool ValidateProductId(UnityEngine.Purchasing.ProductDefinition product);
                    /*0x3f9d0d8*/ bool ValidateTransactionId(string transactionId);
                }

                class DmmGames
                {
                    static /*0x0*/ string Name;

                    static /*0x3fa39d4*/ DmmGames();
                    /*0x3fa39cc*/ DmmGames();
                }

                class DmmGamesIapModule : UnityEngine.Purchasing.Extension.AbstractPurchasingModule
                {
                    /*0x18*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreConfiguration <Configuration>k__BackingField;

                    /*0x3fa3a50*/ DmmGamesIapModule(string apiToken, string openId, string accessToken, bool isSandbox);
                    /*0x3fa3a40*/ Dmm.Games.Unity.Purchasing.DmmGamesIapStoreConfiguration get_Configuration();
                    /*0x3fa3a48*/ void set_Configuration(Dmm.Games.Unity.Purchasing.DmmGamesIapStoreConfiguration value);
                    /*0x3fa3ae8*/ void Configure();
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

                    static /*0x3fa3eb8*/ UserType();
                    static /*0x3f9be68*/ Dmm.Games.Unity.Purchasing.UserType FromString(string name);
                    static /*0x3fa3cf8*/ bool op_Equality(Dmm.Games.Unity.Purchasing.UserType u1, Dmm.Games.Unity.Purchasing.UserType u2);
                    static /*0x3fa3d24*/ bool op_Inequality(Dmm.Games.Unity.Purchasing.UserType u1, Dmm.Games.Unity.Purchasing.UserType u2);
                    /*0x3fa3c2c*/ UserType(string name, string displayName);
                    /*0x3fa3c0c*/ string get_Name();
                    /*0x3fa3c14*/ void set_Name(string value);
                    /*0x3fa3c1c*/ string get_DisplayName();
                    /*0x3fa3c24*/ void set_DisplayName(string value);
                    /*0x3fa3cf0*/ string ToString();
                    /*0x3fa3dac*/ bool Equals(object obj);
                    /*0x3fa3e48*/ int GetHashCode();
                }

                namespace Version2
                {
                    class DmmGamesIapStoreSubscriptionInventory
                    {
                        /*0x10*/ System.Collections.Generic.Dictionary<string, Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem> subscriptionItems;

                        static /*0x3fa46bc*/ UnityEngine.Purchasing.ProductDefinition FindProduct(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel receiptModel);
                        /*0x3f9c300*/ DmmGamesIapStoreSubscriptionInventory();
                        /*0x3fa40bc*/ System.Collections.Generic.IEnumerable<string> get_KeySet();
                        /*0x3fa410c*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem get_Item(string key);
                        /*0x3fa4110*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem Get(string key);
                        /*0x3f9cd28*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem FindItem(UnityEngine.Purchasing.ProductDefinition product);
                        /*0x3fa41c8*/ Dmm.Games.Unity.Purchasing.Version2.DmmGamesIapStoreInventorySubscriptionItem FindItem(string storeSpecificId);
                        /*0x3fa1760*/ void GenerateInventory(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Version2.Product.Model.ProductList productList, DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList receiptList);
                        /*0x3fa4394*/ void BindReceiptToInventory(System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductDefinition> products, DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptList receiptList);
                        /*0x3fa1b30*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertToProductDescriptionList();
                        /*0x3f9fab4*/ void UpdateReceipt(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel receiptModel);
                    }

                    class DmmGamesIapStoreInventorySubscriptionItem
                    {
                        /*0x10*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product <Sku>k__BackingField;
                        /*0x18*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel <Receipt>k__BackingField;

                        static /*0x3fa4aac*/ UnityEngine.Purchasing.ProductMetadata ConvertToMetadata(DMM.Games.Recibo.Api.Version2.Product.Model.Product sku);
                        /*0x3fa4364*/ DmmGamesIapStoreInventorySubscriptionItem(DMM.Games.Recibo.Api.Version2.Product.Model.Product sku);
                        /*0x3fa4a8c*/ DMM.Games.Recibo.Api.Version2.Product.Model.Product get_Sku();
                        /*0x3fa4a94*/ void set_Sku(DMM.Games.Recibo.Api.Version2.Product.Model.Product value);
                        /*0x3fa4a9c*/ DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel get_Receipt();
                        /*0x3fa4aa4*/ void set_Receipt(DMM.Games.Recibo.Api.Version2.Receipt.Model.ReceiptModel value);
                        /*0x3fa41a4*/ bool ValidateProductId(UnityEngine.Purchasing.ProductDefinition product);
                        /*0x3fa49d0*/ UnityEngine.Purchasing.Extension.ProductDescription ConvertProductDescription();
                    }
                }

                namespace Error
                {
                    interface IDmmGamesIapStoreError
                    {
                        /*0x380b9e8*/ string GetErrorKind();
                        /*0x380b6a0*/ int GetErrorCode();
                        /*0x380b9e8*/ string GetErrorMessage();
                        /*0x380b9e8*/ System.Exception GetException();
                        /*0x380b9e8*/ string GetStringErrorCode();
                        /*0x380b9e8*/ string GetSubscriptionExtendErrorCode();
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

                        static /*0x3fa4d14*/ DmmGamesIapStoreError();
                        /*0x3f9cd78*/ DmmGamesIapStoreError(string kind, int errorCode, string errorMessage, System.Exception exception);
                        /*0x3fa4c40*/ DmmGamesIapStoreError(string kind, string errorCode, string errorMessage, System.Exception exception);
                        /*0x3fa4bbc*/ DmmGamesIapStoreError(string kind, int errorCode, string errorCodeString, string errorMessage, System.Exception exception);
                        /*0x3f9fcc4*/ DmmGamesIapStoreError(string kind, bool isSubscription, int errorCode, string subscriptionErrorCode, string errorMessage);
                        /*0x3fa4cd0*/ string GetErrorKind();
                        /*0x3fa4cd8*/ int GetErrorCode();
                        /*0x3fa4ce0*/ string GetErrorMessage();
                        /*0x3fa4ce8*/ System.Exception GetException();
                        /*0x3fa4cf0*/ string GetStringErrorCode();
                        /*0x3fa4d0c*/ string GetSubscriptionExtendErrorCode();
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

                /*0x3fa4d60*/ AuthParams();
            }

            class DmmGamesStoreSdk
            {
                static string GameEngineName = "Unity";
                static /*0x0*/ bool isStandaloneAuthEnable;
                static /*0x8*/ UnityEngine.GameObject _receiveGo;
                static /*0x10*/ Dmm.Games.Store.DmmSdkReceiveObject _receiveCode;
                /*0x10*/ Dmm.Games.Store.DmmGamesStoreSdkSettings settings;
                /*0x18*/ bool isEditorInit;

                static /*0x3fa4d74*/ string get_Version();
                /*0x3f9a9d4*/ DmmGamesStoreSdk();
                /*0x3fa4db4*/ Dmm.Games.Store.GameEngine GetGameEngine(Dmm.Games.Store.GameEngineParameter parameter);
                /*0x380bb68*/ string Execute<T>(Dmm.Games.Store.RootParameter<T> parameter);
                /*0x3fa4e50*/ string Execute(string json);
                /*0x380bba0*/ string List2Json<T>(System.Collections.Generic.List<T> list, bool isString);
                /*0x380bb68*/ string ToJson<T>(Dmm.Games.Store.RootParameter<T> parameter);
                /*0x3907c14*/ T ToObject<T>(string json);
                /*0x3fa50a8*/ void Initialize(Dmm.Games.Store.DmmGamesStoreSdkSettings settings, System.Action<Dmm.Games.Store.InitializeData> callback);
                /*0x3f9a9dc*/ void InternalInitialize(Dmm.Games.Store.DmmGamesStoreSdkSettings settings, System.Action<Dmm.Games.Store.SdkResult> action);
                /*0x3fa54a0*/ void IsInitialized(System.Action<Dmm.Games.Store.SdkResult> action);
                /*0x3f9b1c8*/ void OpenMenu(Dmm.Games.Store.Menu kind, System.Action<Dmm.Games.Store.SdkResult> action);
                /*0x3fa55a8*/ void MakeRequest(Dmm.Games.Store.MakeRequestParameter request, System.Action<Dmm.Games.Store.OsapiMakeRequestResult> action);
                /*0x3fa6210*/ void Thumbnail(Dmm.Games.Store.ThumbnailParameter request, System.Action<Dmm.Games.Store.OsapiThumbnailResult> response);
                /*0x3fa62e8*/ void Message(Dmm.Games.Store.MessageParameter request, System.Action<Dmm.Games.Store.OsapiMessageResult> response);
                /*0x3fa63c0*/ void Inspection(Dmm.Games.Store.InspectionParameter request, System.Action<Dmm.Games.Store.OsapiInspectionResult> response);
                /*0x3fa6498*/ void Activity(Dmm.Games.Store.ActivityParameter request, System.Action<Dmm.Games.Store.OsapiActivityResult> response);
                /*0x3fa6570*/ void IgnoreList(Dmm.Games.Store.IgnoreListParameter request, System.Action<Dmm.Games.Store.OsapiIgnoreListResult> response);
                /*0x3fa66a8*/ void People(Dmm.Games.Store.PeopleParameter request, System.Action<Dmm.Games.Store.OsapiPeopleResult> response);
                /*0x3fa6780*/ void Payment(Dmm.Games.Store.PaymentParameter request, System.Action<Dmm.Games.Store.OsapiPaymentResult> response);
                /*0x3fa6858*/ void OpenTransactionDialog(Dmm.Games.Store.OsapiPaymentResult item, System.Action<Dmm.Games.Store.OpenTransactionDialogData> callback);
                /*0x3f9ac04*/ void GetReceiptAuthData(System.Action<Dmm.Games.Store.ReceiptAuthDataResult> action);
                /*0x3f9af34*/ void SendSpendEvent(double amount, System.Action<Dmm.Games.Store.SendSpendEventResult> action);
                /*0x3fa53b0*/ bool IsAndroid();
                /*0x3fa53c0*/ Dmm.Games.Store.Error GetUnsupportedError();
                /*0x3fa5c70*/ void CheckHttpStatus(int httpStatus, ref Dmm.Games.Store.Error error, string message);
                /*0x3fa6980*/ string GetCloudLoginToken4Json();
                /*0x3fa6a34*/ string GetGamesId();
                /*0x3fa6bd4*/ string GetDmmGamesId();
                /*0x3fa6bd8*/ bool LogoutForStandaloneAuth();

                class PaymentStatus
                {
                    static int IdIssuance = 1;
                    static int PaymentCompleted = 2;
                    static int Cancel = 3;
                    static int Expired = 4;

                    /*0x3fa6ce4*/ PaymentStatus();
                }

                class OpenSocialSelector
                {
                    static string Self = "@self";
                    static string Friends = "@friends";
                    static string All = "@all";

                    /*0x3fa6cec*/ OpenSocialSelector();
                }

                class HttpMethod
                {
                    static string Get = "GET";
                    static string Put = "PUT";
                    static string Post = "POST";
                    static string Delete = "DELETE";

                    /*0x3fa6cf4*/ HttpMethod();
                }

                class Environment
                {
                    static string Production = "prod";
                    static string Staging = "Staging";
                    static string Staging2 = "staging2";

                    /*0x3fa6cfc*/ Environment();
                }

                class DevelopmentMode
                {
                    static string Release = "Service";
                    static string Sandbox = "sandbox";

                    /*0x3fa6d04*/ DevelopmentMode();
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ System.Action<Dmm.Games.Store.InitializeData> callback;

                    /*0x3fa53a8*/ <>c__DisplayClass19_0();
                    /*0x3fa6d0c*/ void <Initialize>b__0(Dmm.Games.Store.SdkResult result);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ Dmm.Games.Store.DmmGamesStoreSdk <>4__this;
                    /*0x18*/ System.Action<Dmm.Games.Store.SdkResult> action;
                    /*0x20*/ Dmm.Games.Store.ApiCoroutine ac;
                    /*0x28*/ Dmm.Games.Store.DmmGamesStoreSdkSettings settings;

                    /*0x3fa5498*/ <>c__DisplayClass20_0();
                    /*0x3fa6e3c*/ void <InternalInitialize>b__0();
                }

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ Dmm.Games.Store.DmmGamesStoreSdk <>4__this;
                    /*0x18*/ System.Action<Dmm.Games.Store.SdkResult> action;
                    /*0x20*/ Dmm.Games.Store.ApiCoroutine ac;
                    /*0x28*/ Dmm.Games.Store.Menu kind;

                    /*0x3fa55a0*/ <>c__DisplayClass22_0();
                    /*0x3fa6f58*/ void <OpenMenu>b__0();
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ System.Action<Dmm.Games.Store.OpenTransactionDialogData> callback;
                    /*0x18*/ Dmm.Games.Store.ApiCoroutine ac;
                    /*0x20*/ Dmm.Games.Store.DmmGamesStoreSdk <>4__this;
                    /*0x28*/ Dmm.Games.Store.OsapiPaymentResult item;

                    /*0x3fa6970*/ <>c__DisplayClass31_0();
                    /*0x3fa7010*/ void <OpenTransactionDialog>b__0();
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

                /*0x3f9b5d0*/ DmmGamesStoreSdkSettings();
            }

            class MarketingEventIds
            {
                /*0x10*/ System.Collections.Generic.List<long> FirstBoot;
                /*0x18*/ System.Collections.Generic.List<long> Boot;
                /*0x20*/ System.Collections.Generic.List<long> Signup;
                /*0x28*/ System.Collections.Generic.List<long> Spend;
                /*0x30*/ System.Collections.Generic.List<long> Login;

                /*0x3fa7468*/ MarketingEventIds();
            }

            class DmmJsonUtil
            {
                static /*0x3fa5d68*/ string GetHeadersJson(string key, string json);
                static /*0x3fa601c*/ System.Collections.Generic.Dictionary<string, string> GetHeadersDictionary(string json);
                static /*0x3fa7588*/ string RemoveEmpty(string json);
                /*0x3fa79d0*/ DmmJsonUtil();
            }

            class Error
            {
                /*0x10*/ string Message;
                /*0x18*/ string Class;
                /*0x20*/ System.Collections.Generic.List<Dmm.Games.Store.StackTraceElement> StackTraces;
                /*0x28*/ Dmm.Games.Store.Error Cause;

                /*0x3fa6978*/ Error();
            }

            class StackTraceElement
            {
                /*0x10*/ string Class;
                /*0x18*/ string File;
                /*0x20*/ string Method;
                /*0x28*/ int Line;

                /*0x3fa79d8*/ StackTraceElement();
            }

            class FunctionKind
            {
                static string Sdk = "sdk";
                static string Osapi = "Osapi";

                /*0x3fa79e0*/ FunctionKind();
            }

            class Function<T>
            {
                /*0x0*/ string Kind;
                /*0x0*/ T Parameters;

                /*0x380cb08*/ Function();
            }

            class GameEngine
            {
                /*0x10*/ string GameEngineName;
                /*0x18*/ Dmm.Games.Store.GameEngineParameter GameEngineParameter;

                /*0x3fa4e48*/ GameEngine();
            }

            class GameEngineParameter
            {
                /*0x10*/ Dmm.Games.Store.Callback Callback;

                /*0x3fa79e8*/ GameEngineParameter();
            }

            class Callback
            {
                /*0x10*/ string GameObject;
                /*0x18*/ string MethodName;

                /*0x3fa7580*/ Callback();
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
                static /*0x3f98198*/ string GetName(Dmm.Games.Store.Menu menu);
            }

            class MenuParameter
            {
                /*0x10*/ string MenuKind;

                /*0x3fa79f0*/ MenuParameter();
            }

            class OAuthModel
            {
                /*0x10*/ string UserId;
                /*0x18*/ string ConsumerKey;
                /*0x20*/ string ConsumerSecret;
                /*0x28*/ string Token;
                /*0x30*/ string TokenSecret;

                /*0x3fa79f8*/ OAuthModel();
                /*0x3fa7a00*/ OAuthModel(Dmm.Games.Store.OAuthModel authModel);
            }

            class OsapiParameter
            {
                /*0x10*/ Dmm.Games.Store.OAuthModel Oauth;
                /*0x18*/ bool IsTwoLeggedOAuth;
                /*0x20*/ string Endpoint;

                /*0x3fa7a80*/ OsapiParameter();
                /*0x3fa7a88*/ OsapiParameter(Dmm.Games.Store.OsapiParameter osapiParameter);
                /*0x380b9e8*/ string ConvertToJsonParameter();
                /*0x380b9e8*/ string GetApiName();
                /*0x3fa59c4*/ string ConvertToJson(string gameEngineName);
            }

            class RootParameter<T>
            {
                static string AndroidStoreSdk = "AndroidStoreSdk";
                /*0x0*/ string SdkType;
                /*0x0*/ Dmm.Games.Store.GameEngine GameEngine;
                /*0x0*/ Dmm.Games.Store.Function<T> Function;

                /*0x380cb08*/ RootParameter();
            }

            class SdkCommand
            {
                static string Init = "init";
                static string IsInit = "isInit";
                static string Menu = "menu";
                static string OpenPayment = "openPayment";
                static string ReceiptAuthData = "ReceiptAuthData";
                static string SendSpendEvent = "sendSpendEvent";

                /*0x3fa7b30*/ SdkCommand();
            }

            class SdkParameter<T>
            {
                /*0x0*/ string SdkCommand;
                /*0x0*/ Dmm.Games.Store.DmmGamesStoreSdkSettings Setting;
                /*0x0*/ T Parameter;

                /*0x380cb08*/ SdkParameter();
            }

            class SdkParameter
            {
                /*0x10*/ string SdkCommand;
                /*0x18*/ Dmm.Games.Store.DmmGamesStoreSdkSettings Setting;

                /*0x3fa7b38*/ SdkParameter();
            }

            class DmmSdkReceiveObject : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ System.Action<Dmm.Games.Store.InitializeData> _callbackInitialize;
                static /*0x8*/ System.Action<Dmm.Games.Store.OpenTransactionDialogData> _callbackPayment;
                static /*0x10*/ string _paymentId;

                /*0x3fa7ee8*/ DmmSdkReceiveObject();
                /*0x3fa5440*/ void SetInitializeCallback(System.Action<Dmm.Games.Store.InitializeData> callback);
                /*0x3fa7b40*/ System.Action<Dmm.Games.Store.InitializeData> GetInitializeCallback();
                /*0x3fa7b88*/ void OnInitializeCallback(string result);
                /*0x3fa73c8*/ void SetPaymentCallback(System.Action<Dmm.Games.Store.OpenTransactionDialogData> callback);
                /*0x3fa7cd4*/ System.Action<Dmm.Games.Store.OpenTransactionDialogData> GetPaymentCallback();
                /*0x3fa7418*/ void SetPaymentId(string paymentId);
                /*0x3fa7d1c*/ void OnPaymentCallback(string result);
                /*0x3907c14*/ T ToObject<T>(string json);
            }

            class InitializeData
            {
                /*0x10*/ Dmm.Games.Store.InitializeResult Status;
                /*0x18*/ Dmm.Games.Store.Error Error;

                /*0x3fa53b8*/ InitializeData();
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

                /*0x3fa73c0*/ OpenTransactionDialogData();
            }

            class OpenTransactionDialogModel
            {
                /*0x10*/ string ResponseCode;
                /*0x18*/ string PaymentId;
                /*0x20*/ bool Cancel;

                /*0x3fa7ef0*/ OpenTransactionDialogModel();
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

                /*0x3fa8284*/ ActivityParameter();
                /*0x3fa7ef8*/ string ConvertToJsonParameter();
                /*0x3fa8244*/ string GetApiName();
            }

            class IgnoreListParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Guid;
                /*0x30*/ string Selector;
                /*0x38*/ string Pid;
                /*0x40*/ int Count;
                /*0x44*/ int StartIndex;

                /*0x3fa8548*/ IgnoreListParameter();
                /*0x3fa828c*/ string ConvertToJsonParameter();
                /*0x3fa8508*/ string GetApiName();
            }

            class InspectionParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string AppId;
                /*0x30*/ string Method;
                /*0x38*/ string TextId;
                /*0x40*/ string Text;

                /*0x3fa87b0*/ InspectionParameter();
                /*0x3fa8550*/ string ConvertToJsonParameter();
                /*0x3fa8770*/ string GetApiName();
            }

            class MakeRequestParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Url;
                /*0x30*/ System.Collections.Generic.List<Dmm.Games.Store.PostData> Parameters;
                /*0x38*/ string SignaturePublicKey;

                /*0x3fa87b8*/ MakeRequestParameter();
                /*0x3fa574c*/ MakeRequestParameter(Dmm.Games.Store.MakeRequestParameter makeRequestParameter);
                /*0x3fa8888*/ string PostDataToJson();
                /*0x3fa8b44*/ string ConvertToJsonParameter();
                /*0x3fa8d14*/ string GetApiName();
            }

            class PostData
            {
                /*0x10*/ string Key;
                /*0x18*/ string Value;

                /*0x3fa8d54*/ PostData();
                /*0x3fa8840*/ PostData(Dmm.Games.Store.PostData postData);
            }

            class MessageParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Guid;
                /*0x30*/ string MsgCollId;
                /*0x38*/ System.Collections.Generic.List<string> Recipients;
                /*0x40*/ string Title;
                /*0x48*/ string Message;
                /*0x50*/ System.Collections.Generic.List<Dmm.Games.Store.Url> Urls;

                /*0x3fa8d5c*/ MessageParameter();
                /*0x3fa8e38*/ string UrlListToJson();
                /*0x3fa90dc*/ string RecipientsToJson();
                /*0x3fa9184*/ string ConvertToJsonParameter();
                /*0x3fa9428*/ string GetApiName();
            }

            class Url
            {
                /*0x10*/ string Value;
                /*0x18*/ string Type;

                /*0x3fa9468*/ Url();
                /*0x3fa8f84*/ string ConvertToJson();

                class Types
                {
                    static /*0x0*/ string Mobile;
                    static /*0x8*/ string Touch;
                    static /*0x10*/ string Canvas;

                    static /*0x3fa9470*/ Types();
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

                /*0x3fa9534*/ PaymentParameter();
                /*0x3fa95bc*/ string get_ItemsJson();
                /*0x3fa99dc*/ string ConvertToJsonParameter();
                /*0x3fa9d84*/ string GetApiName();
            }

            class PaymentItem
            {
                /*0x10*/ string ItemId;
                /*0x18*/ string ItemName;
                /*0x20*/ int UnitPrice;
                /*0x24*/ int Quantity;
                /*0x28*/ string ImageUrl;
                /*0x30*/ string Description;

                /*0x3fa9dc4*/ PaymentItem();
                /*0x3fa96fc*/ string ConvertToJson();
            }

            class PeopleParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string Guid;
                /*0x30*/ string Selector;
                /*0x38*/ System.Collections.Generic.List<string> Fields;
                /*0x40*/ int Count;
                /*0x44*/ int StartIndex;
                /*0x48*/ Dmm.Games.Store.Filter Filter;

                /*0x3fa9dcc*/ PeopleParameter();
                /*0x3fa9e54*/ string FieldsToJson();
                /*0x3fa9f1c*/ string ConvertToJsonParameter();
                /*0x3faa190*/ string GetApiName();
            }

            class Filter
            {
                /*0x10*/ string Field;
                /*0x18*/ string Operand;
                /*0x20*/ string Value;

                /*0x3faa1d0*/ Filter();
            }

            class ReceiptAuthDataParameter
            {
                /*0x10*/ string SdkCommand;

                /*0x3faa1d8*/ ReceiptAuthDataParameter();
            }

            class SendSpendEventParameter
            {
                /*0x10*/ string SdkCommand;
                /*0x18*/ Dmm.Games.Store.SendSpendEventParameter.AmountParameter Parameter;

                /*0x3faa1e0*/ SendSpendEventParameter();

                class AmountParameter
                {
                    /*0x10*/ double Amount;

                    /*0x3faa24c*/ AmountParameter();
                }
            }

            class ThumbnailParameter : Dmm.Games.Store.OsapiParameter
            {
                /*0x28*/ string AppId;
                /*0x30*/ string Size;
                /*0x38*/ System.Collections.Generic.List<string> Pids;
                /*0x40*/ string AdjustVga;

                /*0x3faa254*/ ThumbnailParameter();
                /*0x3faa2dc*/ string PidListToJson();
                /*0x3faa384*/ string ConvertToJsonParameter();
                /*0x3faa56c*/ string GetApiName();
            }

            class Thumbnail
            {
                class Size
                {
                    static /*0x0*/ string Small;
                    static /*0x8*/ string Normal;
                    static /*0x10*/ string Large;
                    static /*0x18*/ string Huge;

                    static /*0x3faa5ac*/ Size();
                }
            }

            class OsapiActivityResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.ActivityResult Response;

                /*0x3faa6a0*/ OsapiActivityResult();
            }

            class ActivityResult
            {
                /*0x3faa72c*/ ActivityResult();
            }

            class OsapiIgnoreListResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.IgnoreListResult Response;

                /*0x3faa734*/ OsapiIgnoreListResult();
            }

            class IgnoreListResult
            {
                /*0x10*/ int TotalResults;
                /*0x14*/ int ItemsPerPage;
                /*0x18*/ int StartIndex;
                /*0x20*/ System.Collections.Generic.List<Dmm.Games.Store.Entry> Items;

                /*0x3faa738*/ IgnoreListResult();
            }

            class Entry
            {
                /*0x10*/ int Id;
                /*0x14*/ int IgnorelistId;

                /*0x3faa7c0*/ Entry();
            }

            class OsapiInspectionResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.InspectionResult Response;

                /*0x3faa7c8*/ OsapiInspectionResult();
            }

            class InspectionResult
            {
                /*0x10*/ System.Collections.Generic.List<Dmm.Games.Store.InspectionEntry> Entry;
                /*0x18*/ string Data;

                /*0x3faa7cc*/ InspectionResult();
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

                /*0x3faa854*/ InspectionEntry();
            }

            class OsapiMakeRequestResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.MakeRequestResult Response;

                /*0x3faa85c*/ OsapiMakeRequestResult();
            }

            class MakeRequestResult
            {
                /*0x10*/ int Rc;
                /*0x18*/ string Body;
                /*0x20*/ System.Collections.Generic.Dictionary<string, string> Headers;

                /*0x3faa860*/ MakeRequestResult();
            }

            class OsapiMessageResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.MessageResult Response;

                /*0x3faa8e8*/ OsapiMessageResult();
            }

            class MessageResult
            {
                /*0x3faa8ec*/ MessageResult();
            }

            class OsapiResult
            {
                /*0x10*/ bool HasBody;
                /*0x18*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> ResponseHeaders;
                /*0x20*/ bool IsNetworkErrorOccurred;
                /*0x28*/ string RawBody;
                /*0x30*/ int HttpStatus;
                /*0x38*/ Dmm.Games.Store.Error Error;

                /*0x3faa6a4*/ OsapiResult();
            }

            class OsapiPaymentResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.PaymentResult Response;
                /*0x48*/ Dmm.Games.Store.Callback callback;
                /*0x50*/ int RequestCode;

                /*0x3faa9e0*/ OsapiPaymentResult();
                /*0x3faa8f4*/ Dmm.Games.Store.Callback get_Callback();
                /*0x3faa964*/ void set_Callback(Dmm.Games.Store.Callback value);
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

                /*0x3faa9ec*/ PaymentResult();
            }

            class OsapiPeopleResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.PeopleResult Response;

                /*0x3faaa74*/ OsapiPeopleResult();
            }

            class PeopleResult
            {
                /*0x10*/ System.Collections.Generic.List<Dmm.Games.Store.PeopleItem> Items;
                /*0x18*/ int TotalResults;
                /*0x1c*/ int ItemsPerPage;
                /*0x20*/ int StartIndex;

                /*0x3faaa78*/ PeopleResult();
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

                /*0x3faab00*/ PeopleItem();
            }

            class Address
            {
                /*0x10*/ string Formatted;

                /*0x3faab08*/ Address();
            }

            class ReceiptAuthDataResult
            {
                /*0x10*/ string DmmAccessToken;
                /*0x18*/ string DmmOpenId;
                /*0x20*/ Dmm.Games.Store.Error Error;

                /*0x3faab10*/ ReceiptAuthDataResult();
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

                /*0x3faab24*/ SdkResult();
                /*0x3faab18*/ string get_DmmGamesId();
                /*0x3faab20*/ void set_DmmGamesId(string value);
            }

            class SendSpendEventResult
            {
                /*0x10*/ bool Success;
                /*0x18*/ Dmm.Games.Store.Error Error;

                /*0x3faab2c*/ SendSpendEventResult();
            }

            class OsapiThumbnailResult : Dmm.Games.Store.OsapiResult
            {
                /*0x40*/ Dmm.Games.Store.ThumbnailResult Response;

                /*0x3faab34*/ OsapiThumbnailResult();
            }

            class ThumbnailResult
            {
                /*0x10*/ System.Collections.Generic.List<Dmm.Games.Store.ThumbnailEntry> Entry;

                /*0x3faab38*/ ThumbnailResult();
            }

            class ThumbnailEntry
            {
                /*0x10*/ string Id;
                /*0x18*/ string Url;

                /*0x3faabc0*/ ThumbnailEntry();
            }

            class ApiCoroutine : UnityEngine.MonoBehaviour
            {
                static /*0x3faabc8*/ Dmm.Games.Store.ApiCoroutine Initialize();
                /*0x3faad74*/ ApiCoroutine();
                /*0x3faac54*/ void Execution(System.Action action);
                /*0x3faac74*/ System.Collections.IEnumerator Coroutine(System.Action action);
                /*0x3faad08*/ void Release();

                class <Coroutine>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ System.Action action;

                    /*0x3faace0*/ <Coroutine>d__2(int <>1__state);
                    /*0x3faad7c*/ void System.IDisposable.Dispose();
                    /*0x3faad80*/ bool MoveNext();
                    /*0x3faadec*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3faadf4*/ void System.Collections.IEnumerator.Reset();
                    /*0x3faae2c*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class FontApplier : UnityEngine.MonoBehaviour
            {
                static float TextScaleMag = 4;
                /*0x20*/ UnityEngine.Font targetFont;
                /*0x28*/ bool initialized;

                /*0x3faaf9c*/ FontApplier();
                /*0x3faae34*/ void Awake();
                /*0x3faae38*/ void ApplyFontToAllTexts();
            }

            class FontGetter : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Font font;

                /*0x3faafac*/ FontGetter();
                /*0x3faafa4*/ UnityEngine.Font get_Font();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 3F1B5F4364C9E778A7004662616A3FDF7CE00922EFE4E8A86B9A1C95C6C7CCD8;
    static /*0x3e55*/ <PrivateImplementationDetails> FDE0EF5EFF4E963945794FE121EE6076F578BBBFB0EB39298B8EE189708ED9E9;

    static /*0x3faafb4*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=10290
    {
    }

    struct __StaticArrayInitTypeSize=15957
    {
    }
}
