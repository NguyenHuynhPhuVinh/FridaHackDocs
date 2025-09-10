class <Module>
{
}

namespace Firebase
{
    namespace Analytics
    {
        class Parameter : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x12ebe20*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Analytics.Parameter obj);
            /*0x12ebdcc*/ Parameter(nint cPtr, bool cMemoryOwn);
            /*0x12ec1d0*/ Parameter(string parameterName, string parameterValue);
            /*0x12ec394*/ Parameter(string parameterName, long parameterValue);
            /*0x12ec540*/ Parameter(string parameterName, double parameterValue);
            /*0x12ebe98*/ void Finalize();
            /*0x12ec0f0*/ void Dispose();
            /*0x12ebf30*/ void Dispose(bool disposing);
        }

        class FirebaseAnalyticsPINVOKE
        {
            static /*0x0*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper swigExceptionHelper;
            static /*0x8*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGStringHelper swigStringHelper;

            static /*0x12ec6fc*/ FirebaseAnalyticsPINVOKE();
            static /*0x12ec7bc*/ void ExportFix();
            static /*0x12ec820*/ string kEventAdImpression_get();
            static /*0x12ec8a8*/ string kEventAddPaymentInfo_get();
            static /*0x12ec930*/ string kEventAddShippingInfo_get();
            static /*0x12ec9b8*/ string kEventAddToCart_get();
            static /*0x12eca40*/ string kEventAddToWishlist_get();
            static /*0x12ecac8*/ string kEventAppOpen_get();
            static /*0x12ecb50*/ string kEventBeginCheckout_get();
            static /*0x12ecbd8*/ string kEventCampaignDetails_get();
            static /*0x12ecc60*/ string kEventEarnVirtualCurrency_get();
            static /*0x12ecce8*/ string kEventGenerateLead_get();
            static /*0x12ecd70*/ string kEventJoinGroup_get();
            static /*0x12ecdf8*/ string kEventLevelEnd_get();
            static /*0x12ece80*/ string kEventLevelStart_get();
            static /*0x12ecf08*/ string kEventLevelUp_get();
            static /*0x12ecf90*/ string kEventLogin_get();
            static /*0x12ed018*/ string kEventPostScore_get();
            static /*0x12ed0a0*/ string kEventPurchase_get();
            static /*0x12ed128*/ string kEventRefund_get();
            static /*0x12ed1b0*/ string kEventRemoveFromCart_get();
            static /*0x12ed238*/ string kEventScreenView_get();
            static /*0x12ed2c0*/ string kEventSearch_get();
            static /*0x12ed348*/ string kEventSelectContent_get();
            static /*0x12ed3d0*/ string kEventSelectItem_get();
            static /*0x12ed458*/ string kEventSelectPromotion_get();
            static /*0x12ed4e0*/ string kEventShare_get();
            static /*0x12ed568*/ string kEventSignUp_get();
            static /*0x12ed5f0*/ string kEventSpendVirtualCurrency_get();
            static /*0x12ed678*/ string kEventTutorialBegin_get();
            static /*0x12ed700*/ string kEventTutorialComplete_get();
            static /*0x12ed788*/ string kEventUnlockAchievement_get();
            static /*0x12ed810*/ string kEventViewCart_get();
            static /*0x12ed898*/ string kEventViewItem_get();
            static /*0x12ed920*/ string kEventViewItemList_get();
            static /*0x12ed9a8*/ string kEventViewPromotion_get();
            static /*0x12eda30*/ string kEventViewSearchResults_get();
            static /*0x12edab8*/ string kParameterAchievementId_get();
            static /*0x12edb40*/ string kParameterAdFormat_get();
            static /*0x12edbc8*/ string kParameterAdNetworkClickID_get();
            static /*0x12edc50*/ string kParameterAdPlatform_get();
            static /*0x12edcd8*/ string kParameterAdSource_get();
            static /*0x12edd60*/ string kParameterAdUnitName_get();
            static /*0x12edde8*/ string kParameterAffiliation_get();
            static /*0x12ede70*/ string kParameterCP1_get();
            static /*0x12edef8*/ string kParameterCampaign_get();
            static /*0x12edf80*/ string kParameterCampaignID_get();
            static /*0x12ee008*/ string kParameterCharacter_get();
            static /*0x12ee090*/ string kParameterContent_get();
            static /*0x12ee118*/ string kParameterContentType_get();
            static /*0x12ee1a0*/ string kParameterCoupon_get();
            static /*0x12ee228*/ string kParameterCreativeFormat_get();
            static /*0x12ee2b0*/ string kParameterCreativeName_get();
            static /*0x12ee338*/ string kParameterCreativeSlot_get();
            static /*0x12ee3c0*/ string kParameterCurrency_get();
            static /*0x12ee448*/ string kParameterDestination_get();
            static /*0x12ee4d0*/ string kParameterDiscount_get();
            static /*0x12ee558*/ string kParameterEndDate_get();
            static /*0x12ee5e0*/ string kParameterExtendSession_get();
            static /*0x12ee668*/ string kParameterFlightNumber_get();
            static /*0x12ee6f0*/ string kParameterGroupId_get();
            static /*0x12ee778*/ string kParameterIndex_get();
            static /*0x12ee800*/ string kParameterItemBrand_get();
            static /*0x12ee888*/ string kParameterItemCategory_get();
            static /*0x12ee910*/ string kParameterItemCategory2_get();
            static /*0x12ee998*/ string kParameterItemCategory3_get();
            static /*0x12eea20*/ string kParameterItemCategory4_get();
            static /*0x12eeaa8*/ string kParameterItemCategory5_get();
            static /*0x12eeb30*/ string kParameterItemId_get();
            static /*0x12eebb8*/ string kParameterItemListID_get();
            static /*0x12eec40*/ string kParameterItemListName_get();
            static /*0x12eecc8*/ string kParameterItemName_get();
            static /*0x12eed50*/ string kParameterItemVariant_get();
            static /*0x12eedd8*/ string kParameterItems_get();
            static /*0x12eee60*/ string kParameterLevel_get();
            static /*0x12eeee8*/ string kParameterLevelName_get();
            static /*0x12eef70*/ string kParameterLocation_get();
            static /*0x12eeff8*/ string kParameterLocationID_get();
            static /*0x12ef080*/ string kParameterMarketingTactic_get();
            static /*0x12ef108*/ string kParameterMedium_get();
            static /*0x12ef190*/ string kParameterMethod_get();
            static /*0x12ef218*/ string kParameterNumberOfNights_get();
            static /*0x12ef2a0*/ string kParameterNumberOfPassengers_get();
            static /*0x12ef328*/ string kParameterNumberOfRooms_get();
            static /*0x12ef3b0*/ string kParameterOrigin_get();
            static /*0x12ef438*/ string kParameterPaymentType_get();
            static /*0x12ef4c0*/ string kParameterPrice_get();
            static /*0x12ef548*/ string kParameterPromotionID_get();
            static /*0x12ef5d0*/ string kParameterPromotionName_get();
            static /*0x12ef658*/ string kParameterQuantity_get();
            static /*0x12ef6e0*/ string kParameterScore_get();
            static /*0x12ef768*/ string kParameterScreenClass_get();
            static /*0x12ef7f0*/ string kParameterScreenName_get();
            static /*0x12ef878*/ string kParameterSearchTerm_get();
            static /*0x12ef900*/ string kParameterShipping_get();
            static /*0x12ef988*/ string kParameterShippingTier_get();
            static /*0x12efa10*/ string kParameterSource_get();
            static /*0x12efa98*/ string kParameterSourcePlatform_get();
            static /*0x12efb20*/ string kParameterStartDate_get();
            static /*0x12efba8*/ string kParameterSuccess_get();
            static /*0x12efc30*/ string kParameterTax_get();
            static /*0x12efcb8*/ string kParameterTerm_get();
            static /*0x12efd40*/ string kParameterTransactionId_get();
            static /*0x12efdc8*/ string kParameterTravelClass_get();
            static /*0x12efe50*/ string kParameterValue_get();
            static /*0x12efed8*/ string kParameterVirtualCurrencyName_get();
            static /*0x12eff60*/ string kUserPropertyAllowAdPersonalizationSignals_get();
            static /*0x12effe8*/ string kUserPropertySignUpMethod_get();
            static /*0x12ec2e0*/ nint new_Parameter__SWIG_0(string jarg1, string jarg2);
            static /*0x12ec4a4*/ nint new_Parameter__SWIG_1(string jarg1, long jarg2);
            static /*0x12ec658*/ nint new_Parameter__SWIG_2(string jarg1, double jarg2);
            static /*0x12ec154*/ void delete_Parameter(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x12f0070*/ void SetAnalyticsCollectionEnabled(bool jarg1);
            static /*0x12f00ec*/ void LogEvent__SWIG_0(string jarg1, string jarg2, string jarg3);
            static /*0x12f01bc*/ void LogEvent__SWIG_1(string jarg1, string jarg2, double jarg3);
            static /*0x12f0278*/ void LogEvent__SWIG_2(string jarg1, string jarg2, long jarg3);
            static /*0x12f0334*/ void LogEvent__SWIG_3(string jarg1, string jarg2, int jarg3);
            static /*0x12f03ec*/ void LogEvent__SWIG_4(string jarg1);
            static /*0x12f0478*/ void LogEvent__SWIG_5(string jarg1, nint arg, int jarg2);
            static /*0x12f0518*/ void InitiateOnDeviceConversionMeasurementWithEmailAddress(string jarg1);
            static /*0x12f05a4*/ void SetUserProperty(string jarg1, string jarg2);
            static /*0x12f0650*/ void SetUserId(string jarg1);
            static /*0x12f06dc*/ void SetSessionTimeoutDurationInternal(long jarg1);
            static /*0x12f0758*/ void ResetAnalyticsData();
            static /*0x12f07bc*/ nint GetAnalyticsInstanceId();
            /*0x12f0824*/ FirebaseAnalyticsPINVOKE();

            class SWIGExceptionHelper
            {
                static /*0x0*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
                static /*0x8*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
                static /*0x10*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
                static /*0x18*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
                static /*0x20*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
                static /*0x28*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
                static /*0x30*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
                static /*0x38*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
                static /*0x40*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
                static /*0x48*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
                static /*0x50*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
                static /*0x58*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
                static /*0x60*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
                static /*0x68*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;

                static /*0x12f16a8*/ SWIGExceptionHelper();
                static /*0x12f112c*/ void SWIGRegisterExceptionCallbacks_FirebaseAnalytics(Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
                static /*0x12f1298*/ void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalytics(Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
                static /*0x12f082c*/ void SetPendingApplicationException(string message);
                static /*0x12f08c4*/ void SetPendingArithmeticException(string message);
                static /*0x12f095c*/ void SetPendingDivideByZeroException(string message);
                static /*0x12f09f4*/ void SetPendingIndexOutOfRangeException(string message);
                static /*0x12f0a8c*/ void SetPendingInvalidCastException(string message);
                static /*0x12f0b24*/ void SetPendingInvalidOperationException(string message);
                static /*0x12f0bbc*/ void SetPendingIOException(string message);
                static /*0x12f0c54*/ void SetPendingNullReferenceException(string message);
                static /*0x12f0cec*/ void SetPendingOutOfMemoryException(string message);
                static /*0x12f0d84*/ void SetPendingOverflowException(string message);
                static /*0x12f0e1c*/ void SetPendingSystemException(string message);
                static /*0x12f0eb4*/ void SetPendingArgumentException(string message, string paramName);
                static /*0x12f0f5c*/ void SetPendingArgumentNullException(string message, string paramName);
                static /*0x12f1044*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
                /*0x12ec7ac*/ SWIGExceptionHelper();

                class ExceptionDelegate : System.MulticastDelegate
                {
                    /*0x12f1a94*/ ExceptionDelegate(object object, nint method);
                    /*0x12f1c40*/ void Invoke(string message);
                    /*0x12f1c54*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x12f1c74*/ void EndInvoke(System.IAsyncResult result);
                }

                class ExceptionArgumentDelegate : System.MulticastDelegate
                {
                    /*0x12f1b68*/ ExceptionArgumentDelegate(object object, nint method);
                    /*0x12f1c80*/ void Invoke(string message, string paramName);
                    /*0x12f1c94*/ System.IAsyncResult BeginInvoke(string message, string paramName, System.AsyncCallback callback, object object);
                    /*0x12f1cbc*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class SWIGPendingException
            {
                static /*0x0*/ int numExceptionsPending;
                static /*0x8*/ object exceptionsLock;
                [ThreadStatic] static System.Exception pendingException;

                static /*0x12f1d50*/ SWIGPendingException();
                static /*0x12f1cc8*/ bool get_Pending();
                static /*0x12f14b8*/ void Set(System.Exception e);
                static /*0x12f134c*/ System.Exception Retrieve();
                /*0x12f1dec*/ SWIGPendingException();
            }

            class SWIGStringHelper
            {
                static /*0x0*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

                static /*0x12f1e78*/ SWIGStringHelper();
                static /*0x12f1df8*/ void SWIGRegisterStringCallback_FirebaseAnalytics(Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
                static /*0x12f1df4*/ string CreateString(string cString);
                /*0x12ec7b4*/ SWIGStringHelper();

                class SWIGStringDelegate : System.MulticastDelegate
                {
                    /*0x12f1f14*/ SWIGStringDelegate(object object, nint method);
                    /*0x12f1fe8*/ string Invoke(string message);
                    /*0x12f1ffc*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x12f201c*/ string EndInvoke(System.IAsyncResult result);
                }
            }
        }

        class FirebaseAnalytics
        {
            static /*0x0*/ Firebase.FirebaseApp app;

            static /*0x12f2074*/ FirebaseAnalytics();
            static /*0x12f2028*/ void ExportFix();
            static /*0x12f20e8*/ Firebase.FirebaseApp get_App();
            static /*0x12f2148*/ string get_EventAdImpression();
            static /*0x12f2208*/ string get_EventAddPaymentInfo();
            static /*0x12f22c8*/ string get_EventAddShippingInfo();
            static /*0x12f2388*/ string get_EventAddToCart();
            static /*0x12f2448*/ string get_EventAddToWishlist();
            static /*0x12f2508*/ string get_EventAppOpen();
            static /*0x12f25c8*/ string get_EventBeginCheckout();
            static /*0x12f2688*/ string get_EventCampaignDetails();
            static /*0x12f2748*/ string get_EventEarnVirtualCurrency();
            static /*0x12f2808*/ string get_EventGenerateLead();
            static /*0x12f28c8*/ string get_EventJoinGroup();
            static /*0x12f2988*/ string get_EventLevelEnd();
            static /*0x12f2a48*/ string get_EventLevelStart();
            static /*0x12f2b08*/ string get_EventLevelUp();
            static /*0x12f2bc8*/ string get_EventLogin();
            static /*0x12f2c88*/ string get_EventPostScore();
            static /*0x12f2d48*/ string get_EventPurchase();
            static /*0x12f2e08*/ string get_EventRefund();
            static /*0x12f2ec8*/ string get_EventRemoveFromCart();
            static /*0x12f2f88*/ string get_EventScreenView();
            static /*0x12f3048*/ string get_EventSearch();
            static /*0x12f3108*/ string get_EventSelectContent();
            static /*0x12f31c8*/ string get_EventSelectItem();
            static /*0x12f3288*/ string get_EventSelectPromotion();
            static /*0x12f3348*/ string get_EventShare();
            static /*0x12f3408*/ string get_EventSignUp();
            static /*0x12f34c8*/ string get_EventSpendVirtualCurrency();
            static /*0x12f3588*/ string get_EventTutorialBegin();
            static /*0x12f3648*/ string get_EventTutorialComplete();
            static /*0x12f3708*/ string get_EventUnlockAchievement();
            static /*0x12f37c8*/ string get_EventViewCart();
            static /*0x12f3888*/ string get_EventViewItem();
            static /*0x12f3948*/ string get_EventViewItemList();
            static /*0x12f3a08*/ string get_EventViewPromotion();
            static /*0x12f3ac8*/ string get_EventViewSearchResults();
            static /*0x12f3b88*/ string get_ParameterAchievementId();
            static /*0x12f3c48*/ string get_ParameterAdFormat();
            static /*0x12f3d08*/ string get_ParameterAdNetworkClickID();
            static /*0x12f3dc8*/ string get_ParameterAdPlatform();
            static /*0x12f3e88*/ string get_ParameterAdSource();
            static /*0x12f3f48*/ string get_ParameterAdUnitName();
            static /*0x12f4008*/ string get_ParameterAffiliation();
            static /*0x12f40c8*/ string get_ParameterCP1();
            static /*0x12f4188*/ string get_ParameterCampaign();
            static /*0x12f4248*/ string get_ParameterCampaignID();
            static /*0x12f4308*/ string get_ParameterCharacter();
            static /*0x12f43c8*/ string get_ParameterContent();
            static /*0x12f4488*/ string get_ParameterContentType();
            static /*0x12f4548*/ string get_ParameterCoupon();
            static /*0x12f4608*/ string get_ParameterCreativeFormat();
            static /*0x12f46c8*/ string get_ParameterCreativeName();
            static /*0x12f4788*/ string get_ParameterCreativeSlot();
            static /*0x12f4848*/ string get_ParameterCurrency();
            static /*0x12f4908*/ string get_ParameterDestination();
            static /*0x12f49c8*/ string get_ParameterDiscount();
            static /*0x12f4a88*/ string get_ParameterEndDate();
            static /*0x12f4b48*/ string get_ParameterExtendSession();
            static /*0x12f4c08*/ string get_ParameterFlightNumber();
            static /*0x12f4cc8*/ string get_ParameterGroupId();
            static /*0x12f4d88*/ string get_ParameterIndex();
            static /*0x12f4e48*/ string get_ParameterItemBrand();
            static /*0x12f4f08*/ string get_ParameterItemCategory();
            static /*0x12f4fc8*/ string get_ParameterItemCategory2();
            static /*0x12f5088*/ string get_ParameterItemCategory3();
            static /*0x12f5148*/ string get_ParameterItemCategory4();
            static /*0x12f5208*/ string get_ParameterItemCategory5();
            static /*0x12f52c8*/ string get_ParameterItemId();
            static /*0x12f5388*/ string get_ParameterItemListID();
            static /*0x12f5448*/ string get_ParameterItemListName();
            static /*0x12f5508*/ string get_ParameterItemName();
            static /*0x12f55c8*/ string get_ParameterItemVariant();
            static /*0x12f5688*/ string get_ParameterItems();
            static /*0x12f5748*/ string get_ParameterLevel();
            static /*0x12f5808*/ string get_ParameterLevelName();
            static /*0x12f58c8*/ string get_ParameterLocation();
            static /*0x12f5988*/ string get_ParameterLocationID();
            static /*0x12f5a48*/ string get_ParameterMarketingTactic();
            static /*0x12f5b08*/ string get_ParameterMedium();
            static /*0x12f5bc8*/ string get_ParameterMethod();
            static /*0x12f5c88*/ string get_ParameterNumberOfNights();
            static /*0x12f5d48*/ string get_ParameterNumberOfPassengers();
            static /*0x12f5e08*/ string get_ParameterNumberOfRooms();
            static /*0x12f5ec8*/ string get_ParameterOrigin();
            static /*0x12f5f88*/ string get_ParameterPaymentType();
            static /*0x12f6048*/ string get_ParameterPrice();
            static /*0x12f6108*/ string get_ParameterPromotionID();
            static /*0x12f61c8*/ string get_ParameterPromotionName();
            static /*0x12f6288*/ string get_ParameterQuantity();
            static /*0x12f6348*/ string get_ParameterScore();
            static /*0x12f6408*/ string get_ParameterScreenClass();
            static /*0x12f64c8*/ string get_ParameterScreenName();
            static /*0x12f6588*/ string get_ParameterSearchTerm();
            static /*0x12f6648*/ string get_ParameterShipping();
            static /*0x12f6708*/ string get_ParameterShippingTier();
            static /*0x12f67c8*/ string get_ParameterSource();
            static /*0x12f6888*/ string get_ParameterSourcePlatform();
            static /*0x12f6948*/ string get_ParameterStartDate();
            static /*0x12f6a08*/ string get_ParameterSuccess();
            static /*0x12f6ac8*/ string get_ParameterTax();
            static /*0x12f6b88*/ string get_ParameterTerm();
            static /*0x12f6c48*/ string get_ParameterTransactionId();
            static /*0x12f6d08*/ string get_ParameterTravelClass();
            static /*0x12f6dc8*/ string get_ParameterValue();
            static /*0x12f6e88*/ string get_ParameterVirtualCurrencyName();
            static /*0x12f6f48*/ string get_UserPropertyAllowAdPersonalizationSignals();
            static /*0x12f7008*/ string get_UserPropertySignUpMethod();
            static /*0x12f70c8*/ void SetSessionTimeoutDuration(System.TimeSpan timeSpan);
            static /*0x12f7210*/ void SetAnalyticsCollectionEnabled(bool enabled);
            static /*0x12f72cc*/ void LogEvent(string name, string parameterName, string parameterValue);
            static /*0x12f73a0*/ void LogEvent(string name, string parameterName, double parameterValue);
            static /*0x12f747c*/ void LogEvent(string name, string parameterName, long parameterValue);
            static /*0x12f7550*/ void LogEvent(string name, string parameterName, int parameterValue);
            static /*0x12f7624*/ void LogEvent(string name);
            static /*0x12f76e0*/ void LogEvent(string name, Firebase.Analytics.Parameter[] parameters);
            static /*0x12f7864*/ void InitiateOnDeviceConversionMeasurementWithEmailAddress(string emailAddress);
            static /*0x12f7920*/ void SetUserProperty(string name, string property);
            static /*0x12f79ec*/ void SetUserId(string userId);
            static /*0x12f7154*/ void SetSessionTimeoutDurationInternal(long milliseconds);
            static /*0x12f7aa8*/ void ResetAnalyticsData();
            static /*0x12f7b5c*/ System.Threading.Tasks.Task<string> GetAnalyticsInstanceIdAsync();
            /*0x12f2140*/ FirebaseAnalytics();
        }
    }
}
