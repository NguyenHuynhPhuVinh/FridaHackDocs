class <Module>
{
}

namespace Google
{
    namespace Play
    {
        namespace Review
        {
            class PlayReviewInfo
            {
                /*0x10*/ UnityEngine.AndroidJavaObject _reviewInfo;

                /*0x2b3266c*/ PlayReviewInfo(UnityEngine.AndroidJavaObject reviewInfo);
                /*0x2b32698*/ UnityEngine.AndroidJavaObject GetReviewInfo();
            }

            enum ReviewErrorCode
            {
                NoError = 0,
                ErrorRequestingFlow = 1,
                ErrorLaunchingFlow = 2,
                PlayStoreNotFound = 3,
            }

            class ReviewManager
            {
                static int JavaReviewErrorCodePlayNotFound = -1;
                /*0x10*/ Google.Play.Review.Internal.ReviewPlayCoreTaskManager _reviewPlayCoreTaskManager;

                /*0x2b326a0*/ ReviewManager();
                /*0x2b329e8*/ Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> RequestReviewFlow();
                /*0x2b32bb0*/ Google.Play.Common.PlayAsyncOperation<Google.Play.Common.VoidResult, Google.Play.Review.ReviewErrorCode> LaunchReviewFlow(Google.Play.Review.PlayReviewInfo reviewInfo);
                /*0x2b329ec*/ Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> RequestReviewFlowInternal();
                /*0x2b32bb4*/ Google.Play.Common.PlayAsyncOperation<Google.Play.Common.VoidResult, Google.Play.Review.ReviewErrorCode> LaunchReviewFlowInternal(Google.Play.Review.PlayReviewInfo reviewInfo);

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ Google.Play.Review.Internal.ReviewAsyncOperation<Google.Play.Review.PlayReviewInfo> operation;
                    /*0x18*/ Google.Play.Core.Internal.PlayCoreTask<UnityEngine.AndroidJavaObject> requestFlowTask;

                    /*0x2b32d84*/ <>c__DisplayClass5_0();
                    /*0x2b33078*/ void <RequestReviewFlowInternal>b__0(UnityEngine.AndroidJavaObject reviewInfo);
                    /*0x2b33130*/ void <RequestReviewFlowInternal>b__1(string reason, int errorCode);
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Google.Play.Review.Internal.ReviewAsyncOperation<Google.Play.Common.VoidResult> operation;
                    /*0x18*/ Google.Play.Core.Internal.PlayCoreTask<UnityEngine.AndroidJavaObject> requestFlowTask;

                    /*0x2b32eec*/ <>c__DisplayClass6_0();
                    /*0x2b331c8*/ void <LaunchReviewFlowInternal>b__0(UnityEngine.AndroidJavaObject result);
                    /*0x2b33278*/ void <LaunchReviewFlowInternal>b__1(string reason, int errorCode);
                }
            }

            namespace Internal
            {
                class ReviewAsyncOperation<TResult> : Google.Play.Common.Internal.PlayAsyncOperationImpl<TResult, Google.Play.Review.ReviewErrorCode>
                {
                    ReviewAsyncOperation();
                    bool get_IsSuccessful();
                }

                class ReviewPlayCoreTaskManager : System.IDisposable
                {
                    /*0x10*/ UnityEngine.AndroidJavaObject _javaReviewManager;

                    /*0x2b32704*/ ReviewPlayCoreTaskManager();
                    /*0x2b32d8c*/ Google.Play.Core.Internal.PlayCoreTask<UnityEngine.AndroidJavaObject> RequestReviewFlow();
                    /*0x2b32ef4*/ Google.Play.Core.Internal.PlayCoreTask<UnityEngine.AndroidJavaObject> LaunchReviewFlow(UnityEngine.AndroidJavaObject reviewInfo);
                    /*0x2b3305c*/ void Dispose();
                }
            }
        }
    }
}
