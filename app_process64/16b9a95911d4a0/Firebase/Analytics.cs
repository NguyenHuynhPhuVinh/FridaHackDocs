class <Module>
{
}

namespace Firebase
{
    namespace Analytics
    {
        class FirebaseAnalytics
        {
            static /*0x0*/ string EventAdImpression;
            static /*0x8*/ string EventAddPaymentInfo;
            static /*0x10*/ string EventAddShippingInfo;
            static /*0x18*/ string EventAddToCart;
            static /*0x20*/ string EventAddToWishlist;
            static /*0x28*/ string EventAppOpen;
            static /*0x30*/ string EventBeginCheckout;
            static /*0x38*/ string EventCampaignDetails;
            static /*0x40*/ string EventEarnVirtualCurrency;
            static /*0x48*/ string EventGenerateLead;
            static /*0x50*/ string EventJoinGroup;
            static /*0x58*/ string EventLevelEnd;
            static /*0x60*/ string EventLevelStart;
            static /*0x68*/ string EventLevelUp;
            static /*0x70*/ string EventLogin;
            static /*0x78*/ string EventPostScore;
            static /*0x80*/ string EventPurchase;
            static /*0x88*/ string EventRefund;
            static /*0x90*/ string EventRemoveFromCart;
            static /*0x98*/ string EventScreenView;
            static /*0xa0*/ string EventSearch;
            static /*0xa8*/ string EventSelectContent;
            static /*0xb0*/ string EventSelectItem;
            static /*0xb8*/ string EventSelectPromotion;
            static /*0xc0*/ string EventShare;
            static /*0xc8*/ string EventSignUp;
            static /*0xd0*/ string EventSpendVirtualCurrency;
            static /*0xd8*/ string EventTutorialBegin;
            static /*0xe0*/ string EventTutorialComplete;
            static /*0xe8*/ string EventUnlockAchievement;
            static /*0xf0*/ string EventViewCart;
            static /*0xf8*/ string EventViewItem;
            static /*0x100*/ string EventViewItemList;
            static /*0x108*/ string EventViewPromotion;
            static /*0x110*/ string EventViewSearchResults;
            static /*0x118*/ string ParameterAchievementID;
            static /*0x120*/ string ParameterAdFormat;
            static /*0x128*/ string ParameterAdNetworkClickID;
            static /*0x130*/ string ParameterAdPlatform;
            static /*0x138*/ string ParameterAdSource;
            static /*0x140*/ string ParameterAdUnitName;
            static /*0x148*/ string ParameterAffiliation;
            static /*0x150*/ string ParameterCP1;
            static /*0x158*/ string ParameterCampaign;
            static /*0x160*/ string ParameterCampaignID;
            static /*0x168*/ string ParameterCharacter;
            static /*0x170*/ string ParameterContent;
            static /*0x178*/ string ParameterContentType;
            static /*0x180*/ string ParameterCoupon;
            static /*0x188*/ string ParameterCreativeFormat;
            static /*0x190*/ string ParameterCreativeName;
            static /*0x198*/ string ParameterCreativeSlot;
            static /*0x1a0*/ string ParameterCurrency;
            static /*0x1a8*/ string ParameterDestination;
            static /*0x1b0*/ string ParameterDiscount;
            static /*0x1b8*/ string ParameterEndDate;
            static /*0x1c0*/ string ParameterExtendSession;
            static /*0x1c8*/ string ParameterFlightNumber;
            static /*0x1d0*/ string ParameterGroupID;
            static /*0x1d8*/ string ParameterIndex;
            static /*0x1e0*/ string ParameterItemBrand;
            static /*0x1e8*/ string ParameterItemCategory;
            static /*0x1f0*/ string ParameterItemCategory2;
            static /*0x1f8*/ string ParameterItemCategory3;
            static /*0x200*/ string ParameterItemCategory4;
            static /*0x208*/ string ParameterItemCategory5;
            static /*0x210*/ string ParameterItemID;
            static /*0x218*/ string ParameterItemListID;
            static /*0x220*/ string ParameterItemListName;
            static /*0x228*/ string ParameterItemName;
            static /*0x230*/ string ParameterItemVariant;
            static /*0x238*/ string ParameterItems;
            static /*0x240*/ string ParameterLevel;
            static /*0x248*/ string ParameterLevelName;
            static /*0x250*/ string ParameterLocation;
            static /*0x258*/ string ParameterLocationID;
            static /*0x260*/ string ParameterMarketingTactic;
            static /*0x268*/ string ParameterMedium;
            static /*0x270*/ string ParameterMethod;
            static /*0x278*/ string ParameterNumberOfNights;
            static /*0x280*/ string ParameterNumberOfPassengers;
            static /*0x288*/ string ParameterNumberOfRooms;
            static /*0x290*/ string ParameterOrigin;
            static /*0x298*/ string ParameterPaymentType;
            static /*0x2a0*/ string ParameterPrice;
            static /*0x2a8*/ string ParameterPromotionID;
            static /*0x2b0*/ string ParameterPromotionName;
            static /*0x2b8*/ string ParameterQuantity;
            static /*0x2c0*/ string ParameterScore;
            static /*0x2c8*/ string ParameterScreenClass;
            static /*0x2d0*/ string ParameterScreenName;
            static /*0x2d8*/ string ParameterSearchTerm;
            static /*0x2e0*/ string ParameterShipping;
            static /*0x2e8*/ string ParameterShippingTier;
            static /*0x2f0*/ string ParameterSource;
            static /*0x2f8*/ string ParameterSourcePlatform;
            static /*0x300*/ string ParameterStartDate;
            static /*0x308*/ string ParameterSuccess;
            static /*0x310*/ string ParameterTax;
            static /*0x318*/ string ParameterTerm;
            static /*0x320*/ string ParameterTransactionID;
            static /*0x328*/ string ParameterTravelClass;
            static /*0x330*/ string ParameterValue;
            static /*0x338*/ string ParameterVirtualCurrencyName;
            static /*0x340*/ string UserPropertyAllowAdPersonalizationSignals;
            static /*0x348*/ string UserPropertySignUpMethod;

            static /*0x2d21cdc*/ FirebaseAnalytics();
            static /*0x2d2163c*/ void LogEvent(string name);
            static /*0x2d2174c*/ void LogEvent(string name, Firebase.Analytics.Parameter[] parameters);
            static /*0x2d2198c*/ void SetAnalyticsCollectionEnabled(bool enabled);
            static /*0x2d21a9c*/ void SetUserId(string userId);
            static /*0x2d21bac*/ void SetUserProperty(string name, string property);
        }

        class Parameter : System.IDisposable
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ object <Value>k__BackingField;

            /*0x2d22f14*/ Parameter(string parameterName, string parameterValue);
            /*0x2d22f58*/ Parameter(string parameterName, long parameterValue);
            /*0x2d22fc0*/ Parameter(string parameterName, double parameterValue);
            /*0x2d22ef4*/ string get_Name();
            /*0x2d22efc*/ void set_Name(string value);
            /*0x2d22f04*/ object get_Value();
            /*0x2d22f0c*/ void set_Value(object value);
            /*0x2d23030*/ void Dispose();
        }

        class FirebaseAnalyticsInternalPINVOKE
        {
            static /*0x0*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper swigExceptionHelper;
            static /*0x8*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper swigStringHelper;

            static /*0x2d23034*/ FirebaseAnalyticsInternalPINVOKE();
            static /*0x2d23104*/ void SetAnalyticsCollectionEnabled(bool jarg1);
            static /*0x2d23180*/ void LogEvent__SWIG_4(string jarg1);
            static /*0x2d2320c*/ void SetUserProperty(string jarg1, string jarg2);
            static /*0x2d232b8*/ void SetUserId(string jarg1);
            static /*0x2d23344*/ void LogEvent__SWIG_5(string jarg1, System.Runtime.InteropServices.HandleRef jarg2, System.Runtime.InteropServices.HandleRef jarg3);

            class SWIGExceptionHelper
            {
                static /*0x0*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
                static /*0x8*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
                static /*0x10*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
                static /*0x18*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
                static /*0x20*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
                static /*0x28*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
                static /*0x30*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
                static /*0x38*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
                static /*0x40*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
                static /*0x48*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
                static /*0x50*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
                static /*0x58*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
                static /*0x60*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
                static /*0x68*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;

                static /*0x2d24234*/ SWIGExceptionHelper();
                static /*0x2d23c78*/ void SWIGRegisterExceptionCallbacks_FirebaseAnalyticsInternal(Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
                static /*0x2d23de4*/ void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalyticsInternal(Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
                static /*0x2d233e8*/ void SetPendingApplicationException(string message);
                static /*0x2d23478*/ void SetPendingArithmeticException(string message);
                static /*0x2d23508*/ void SetPendingDivideByZeroException(string message);
                static /*0x2d23598*/ void SetPendingIndexOutOfRangeException(string message);
                static /*0x2d23628*/ void SetPendingInvalidCastException(string message);
                static /*0x2d236b8*/ void SetPendingInvalidOperationException(string message);
                static /*0x2d23748*/ void SetPendingIOException(string message);
                static /*0x2d237d8*/ void SetPendingNullReferenceException(string message);
                static /*0x2d23868*/ void SetPendingOutOfMemoryException(string message);
                static /*0x2d238f8*/ void SetPendingOverflowException(string message);
                static /*0x2d23988*/ void SetPendingSystemException(string message);
                static /*0x2d23a18*/ void SetPendingArgumentException(string message, string paramName);
                static /*0x2d23ab8*/ void SetPendingArgumentNullException(string message, string paramName);
                static /*0x2d23b98*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
                /*0x2d230f4*/ SWIGExceptionHelper();

                class ExceptionDelegate : System.MulticastDelegate
                {
                    /*0x2d24684*/ ExceptionDelegate(object object, nint method);
                    /*0x2d247e8*/ void Invoke(string message);
                }

                class ExceptionArgumentDelegate : System.MulticastDelegate
                {
                    /*0x2d24734*/ ExceptionArgumentDelegate(object object, nint method);
                    /*0x2d247fc*/ void Invoke(string message, string paramName);
                }
            }

            class SWIGPendingException
            {
                static /*0x0*/ int numExceptionsPending;
                static /*0x8*/ object exceptionsLock;
                [ThreadStatic] static System.Exception pendingException;

                static /*0x2d24810*/ SWIGPendingException();
                static /*0x2d24028*/ void Set(System.Exception e);
                static /*0x2d23e98*/ System.Exception Retrieve();
            }

            class SWIGStringHelper
            {
                static /*0x0*/ Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

                static /*0x2d2493c*/ SWIGStringHelper();
                static /*0x2d248bc*/ void SWIGRegisterStringCallback_FirebaseAnalyticsInternal(Firebase.Analytics.FirebaseAnalyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
                static /*0x2d248b8*/ string CreateString(string cString);
                /*0x2d230fc*/ SWIGStringHelper();

                class SWIGStringDelegate : System.MulticastDelegate
                {
                    /*0x2d249e8*/ SWIGStringDelegate(object object, nint method);
                    /*0x2d24a98*/ string Invoke(string message);
                }
            }
        }

        class FirebaseAnalyticsInternal
        {
            static /*0x0*/ Firebase.FirebaseApp app;

            static /*0x2d24aac*/ FirebaseAnalyticsInternal();
            static /*0x2d219e0*/ void SetAnalyticsCollectionEnabled(bool enabled);
            static /*0x2d21690*/ void LogEvent(string name);
            static /*0x2d21c10*/ void SetUserProperty(string name, string property);
            static /*0x2d21af0*/ void SetUserId(string userId);
            static /*0x2d21880*/ void LogEvent(string name, Firebase.StringList parameterNames, Firebase.VariantList parameterValues);
        }
    }
}
