class <Module>
{
}

namespace UnityEngine
{
    namespace Analytics
    {
        class SubsystemsAnalyticBase : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string subsystem;

            /*0x81c4ddc*/ SubsystemsAnalyticBase(string eventName);
        }

        class SubsystemsAnalyticStart : UnityEngine.Analytics.SubsystemsAnalyticBase
        {
            static /*0x81c4e88*/ UnityEngine.Analytics.SubsystemsAnalyticStart CreateSubsystemsAnalyticStart();
            /*0x81c4e40*/ SubsystemsAnalyticStart();
        }

        class SubsystemsAnalyticStop : UnityEngine.Analytics.SubsystemsAnalyticBase
        {
            static /*0x81c4f20*/ UnityEngine.Analytics.SubsystemsAnalyticStop CreateSubsystemsAnalyticStop();
            /*0x81c4ed8*/ SubsystemsAnalyticStop();
        }

        class SubsystemsAnalyticInfo : UnityEngine.Analytics.SubsystemsAnalyticBase
        {
            /*0x38*/ string id;
            /*0x40*/ string plugin_name;
            /*0x48*/ string version;
            /*0x50*/ string library_name;

            static /*0x81c4fb8*/ UnityEngine.Analytics.SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo();
            /*0x81c4f70*/ SubsystemsAnalyticInfo();
        }

        class VRDeviceAnalyticBase : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x81c5008*/ VRDeviceAnalyticBase();
        }

        class VRDeviceAnalyticAspect : UnityEngine.Analytics.VRDeviceAnalyticBase
        {
            /*0x2c*/ float vr_aspect_ratio;

            static /*0x81c507c*/ UnityEngine.Analytics.VRDeviceAnalyticAspect CreateVRDeviceAnalyticAspect();
            /*0x81c50cc*/ VRDeviceAnalyticAspect();
        }

        class VRDeviceMirrorAnalytic : UnityEngine.Analytics.VRDeviceAnalyticBase
        {
            /*0x2c*/ bool vr_device_mirror_mode;

            static /*0x81c50d0*/ UnityEngine.Analytics.VRDeviceMirrorAnalytic CreateVRDeviceMirrorAnalytic();
            /*0x81c5120*/ VRDeviceMirrorAnalytic();
        }

        class VRDeviceUserAnalytic : UnityEngine.Analytics.VRDeviceAnalyticBase
        {
            /*0x2c*/ int vr_user_presence;

            static /*0x81c5124*/ UnityEngine.Analytics.VRDeviceUserAnalytic CreateVRDeviceUserAnalytic();
            /*0x81c5174*/ VRDeviceUserAnalytic();
        }

        class VRDeviceActiveControllersAnalytic : UnityEngine.Analytics.VRDeviceAnalyticBase
        {
            /*0x30*/ string[] vr_active_controllers;

            static /*0x81c5178*/ UnityEngine.Analytics.VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic();
            /*0x81c51c8*/ VRDeviceActiveControllersAnalytic();
        }

        enum AnalyticsResult
        {
            Ok = 0,
            NotInitialized = 1,
            AnalyticsDisabled = 2,
            TooManyItems = 3,
            SizeLimitReached = 4,
            TooManyRequests = 5,
            InvalidData = 6,
            UnsupportedPlatform = 7,
        }
    }
}

namespace UnityEditor
{
    namespace Analytics
    {
        class AssetDatabaseRefreshAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ bool isV2;
            /*0x30*/ long Imports_Imported;
            /*0x38*/ long Imports_ImportedInProcess;
            /*0x40*/ long Imports_ImportedOutOfProcess;
            /*0x48*/ long Imports_Refresh;
            /*0x50*/ long Imports_DomainReload;
            /*0x58*/ long CacheServer_MetadataRequested;
            /*0x60*/ long CacheServer_MetadataDownloaded;
            /*0x68*/ long CacheServer_MetadataFailedToDownload;
            /*0x70*/ long CacheServer_MetadataUploaded;
            /*0x78*/ long CacheServer_ArtifactsFailedToUpload;
            /*0x80*/ long CacheServer_MetadataVersionsDownloaded;
            /*0x88*/ long CacheServer_MetadataMatched;
            /*0x90*/ long CacheServer_ArtifactsDownloaded;
            /*0x98*/ long CacheServer_ArtifactFilesDownloaded;
            /*0xa0*/ long CacheServer_ArtifactFilesFailedToDownload;
            /*0xa8*/ long CacheServer_ArtifactsUploaded;
            /*0xb0*/ long CacheServer_ArtifactFilesUploaded;
            /*0xb8*/ long CacheServer_ArtifactFilesFailedToUpload;
            /*0xc0*/ long CacheServer_Connects;
            /*0xc8*/ long CacheServer_Disconnects;

            static /*0x81c5240*/ UnityEditor.Analytics.AssetDatabaseRefreshAnalytic CreateAssetDatabaseRefreshAnalytic();
            /*0x81c51cc*/ AssetDatabaseRefreshAnalytic();
        }

        class BuildAssetBundleAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ bool success;
            /*0x30*/ string error;

            static /*0x81c5304*/ UnityEditor.Analytics.BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic();
            /*0x81c5290*/ BuildAssetBundleAnalytic();
        }

        class CollabOperationAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string category;
            /*0x38*/ string operation;
            /*0x40*/ string result;
            /*0x48*/ long start_ts;
            /*0x50*/ long duration;

            static /*0x81c53c8*/ UnityEditor.Analytics.CollabOperationAnalytic CreateCollabOperationAnalytic();
            /*0x81c5354*/ CollabOperationAnalytic();
        }

        class LicensingErrorAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string licensingErrorType;
            /*0x38*/ string additionalData;
            /*0x40*/ string errorMessage;
            /*0x48*/ string correlationId;
            /*0x50*/ string sessionId;

            static /*0x81c548c*/ UnityEditor.Analytics.LicensingErrorAnalytic CreateLicensingErrorAnalytic();
            /*0x81c5418*/ LicensingErrorAnalytic();
        }

        class LicensingInitAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string licensingProtocolVersion;
            /*0x38*/ string licensingClientVersion;
            /*0x40*/ string channelType;
            /*0x48*/ double initTime;
            /*0x50*/ bool isLegacy;
            /*0x58*/ string sessionId;
            /*0x60*/ string correlationId;

            static /*0x81c5550*/ UnityEditor.Analytics.LicensingInitAnalytic CreateLicensingInitAnalytic();
            /*0x81c54dc*/ LicensingInitAnalytic();
        }

        class MetalPatchShaderComputeBufferAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            static /*0x81c5614*/ UnityEditor.Analytics.MetalPatchShaderComputeBufferAnalytic CreateMetalPatchShaderComputeBufferAnalytic();
            /*0x81c55a0*/ MetalPatchShaderComputeBufferAnalytic();
        }

        class NavmeshBakingAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ bool new_nav_api;
            /*0x2d*/ bool bake_at_runtime;
            /*0x30*/ int height_meshes_count;
            /*0x34*/ int offmesh_links_count;

            static /*0x81c56d8*/ UnityEditor.Analytics.NavmeshBakingAnalytic CreateNavmeshBakingAnalytic();
            /*0x81c5664*/ NavmeshBakingAnalytic();
        }

        class ProjectSettingsInformationAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int agent_types_count;
            /*0x30*/ int areas_count;

            static /*0x81c579c*/ UnityEditor.Analytics.ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic();
            /*0x81c5728*/ ProjectSettingsInformationAnalytic();
        }

        class SendGameBuildAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int navmesh_count;

            static /*0x81c5860*/ UnityEditor.Analytics.SendGameBuildAnalytic CreateSendGameBuildAnalytic();
            /*0x81c57ec*/ SendGameBuildAnalytic();
        }

        class PackageManagerBaseAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ long start_ts;
            /*0x38*/ long duration;
            /*0x40*/ bool blocking;
            /*0x48*/ string package_id;
            /*0x50*/ int status_code;
            /*0x58*/ string error_message;

            /*0x81c58b0*/ PackageManagerBaseAnalytic(string eventName);
        }

        class PackageManagerAddPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81c595c*/ UnityEditor.Analytics.PackageManagerAddPackageAnalytic CreatePackageManagerAddPackageAnalytic();
            /*0x81c5914*/ PackageManagerAddPackageAnalytic();
        }

        class PackageManagerTestAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81c59f4*/ UnityEditor.Analytics.PackageManagerTestAnalytic CreatePackageManagerTestAnalytic();
            /*0x81c59ac*/ PackageManagerTestAnalytic();
        }

        class PackageManagerRemovePackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81c5a8c*/ UnityEditor.Analytics.PackageManagerRemovePackageAnalytic CreatePackageManagerRemovePackageAnalytic();
            /*0x81c5a44*/ PackageManagerRemovePackageAnalytic();
        }

        class PackageManagerResolvePackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            /*0x60*/ string[] packages;
            /*0x68*/ string[] package_registries;
            /*0x70*/ string[] package_signatures;
            /*0x78*/ string[] package_sources;
            /*0x80*/ string[] package_types;

            static /*0x81c5b24*/ UnityEditor.Analytics.PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic();
            /*0x81c5adc*/ PackageManagerResolvePackageAnalytic();
        }

        class PackageManagerEmbedPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81c5bbc*/ UnityEditor.Analytics.PackageManagerEmbedPackageAnalytic CreatePackageManagerEmbedPackageAnalytic();
            /*0x81c5b74*/ PackageManagerEmbedPackageAnalytic();
        }

        class PackageManagerResetPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81c5c54*/ UnityEditor.Analytics.PackageManagerResetPackageAnalytic CreatePackageManagerResetPackageAnalytic();
            /*0x81c5c0c*/ PackageManagerResetPackageAnalytic();
        }

        class PackageManagerResolveErrorPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            /*0x60*/ string reason;
            /*0x68*/ string action;

            static /*0x81c5cec*/ UnityEditor.Analytics.PackageManagerResolveErrorPackageAnalytic CreatePackageManagerResolveErrorPackageAnalytic();
            /*0x81c5ca4*/ PackageManagerResolveErrorPackageAnalytic();
        }

        class PackageManagerStartServerPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81c5d84*/ UnityEditor.Analytics.PackageManagerStartServerPackageAnalytic CreatePackageManagerStartServerPackageAnalytic();
            /*0x81c5d3c*/ PackageManagerStartServerPackageAnalytic();
        }

        class AssetImportStatusAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string package_name;
            /*0x38*/ int package_items_count;
            /*0x3c*/ int package_import_status;
            /*0x40*/ string error_message;
            /*0x48*/ int project_assets_count;
            /*0x4c*/ int unselected_assets_count;
            /*0x50*/ int selected_new_assets_count;
            /*0x54*/ int selected_changed_assets_count;
            /*0x58*/ int unchanged_assets_count;
            /*0x60*/ string[] selected_asset_extensions;

            static /*0x81c5e48*/ UnityEditor.Analytics.AssetImportStatusAnalytic CreateAssetImportStatusAnalytic();
            /*0x81c5dd4*/ AssetImportStatusAnalytic();
        }

        class AssetImportAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string package_name;
            /*0x38*/ int package_import_choice;

            static /*0x81c5f0c*/ UnityEditor.Analytics.AssetImportAnalytic CreateAssetImportAnalytic();
            /*0x81c5e98*/ AssetImportAnalytic();
        }

        class AssetExportAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string package_name;
            /*0x38*/ string error_message;
            /*0x40*/ int items_count;
            /*0x48*/ string[] asset_extensions;
            /*0x50*/ bool include_upm_dependencies;

            static /*0x81c5fd0*/ UnityEditor.Analytics.AssetExportAnalytic CreateAssetExportAnalytic();
            /*0x81c5f5c*/ AssetExportAnalytic();
        }

        class StallSummaryAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ double Duration;

            static /*0x81c6094*/ UnityEditor.Analytics.StallSummaryAnalytic CreateStallSummaryAnalytic();
            /*0x81c6020*/ StallSummaryAnalytic();
        }

        class StallMarkerAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string Name;
            /*0x38*/ bool HasProgressMarkup;
            /*0x40*/ double Duration;

            static /*0x81c6158*/ UnityEditor.Analytics.StallMarkerAnalytic CreateStallMarkerAnalytic();
            /*0x81c60e4*/ StallMarkerAnalytic();
        }

        class TestAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int param;

            static /*0x81c621c*/ UnityEditor.Analytics.TestAnalytic CreateTestAnalytic();
            /*0x81c61a8*/ TestAnalytic();
        }
    }
}
