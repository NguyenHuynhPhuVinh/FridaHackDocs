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

            /*0x81dc20c*/ SubsystemsAnalyticBase(string eventName);
        }

        class SubsystemsAnalyticStart : UnityEngine.Analytics.SubsystemsAnalyticBase
        {
            static /*0x81dc2b8*/ UnityEngine.Analytics.SubsystemsAnalyticStart CreateSubsystemsAnalyticStart();
            /*0x81dc270*/ SubsystemsAnalyticStart();
        }

        class SubsystemsAnalyticStop : UnityEngine.Analytics.SubsystemsAnalyticBase
        {
            static /*0x81dc350*/ UnityEngine.Analytics.SubsystemsAnalyticStop CreateSubsystemsAnalyticStop();
            /*0x81dc308*/ SubsystemsAnalyticStop();
        }

        class SubsystemsAnalyticInfo : UnityEngine.Analytics.SubsystemsAnalyticBase
        {
            /*0x38*/ string id;
            /*0x40*/ string plugin_name;
            /*0x48*/ string version;
            /*0x50*/ string library_name;

            static /*0x81dc3e8*/ UnityEngine.Analytics.SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo();
            /*0x81dc3a0*/ SubsystemsAnalyticInfo();
        }

        class VRDeviceAnalyticBase : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x81dc438*/ VRDeviceAnalyticBase();
        }

        class VRDeviceAnalyticAspect : UnityEngine.Analytics.VRDeviceAnalyticBase
        {
            /*0x2c*/ float vr_aspect_ratio;

            static /*0x81dc4ac*/ UnityEngine.Analytics.VRDeviceAnalyticAspect CreateVRDeviceAnalyticAspect();
            /*0x81dc4fc*/ VRDeviceAnalyticAspect();
        }

        class VRDeviceMirrorAnalytic : UnityEngine.Analytics.VRDeviceAnalyticBase
        {
            /*0x2c*/ bool vr_device_mirror_mode;

            static /*0x81dc500*/ UnityEngine.Analytics.VRDeviceMirrorAnalytic CreateVRDeviceMirrorAnalytic();
            /*0x81dc550*/ VRDeviceMirrorAnalytic();
        }

        class VRDeviceUserAnalytic : UnityEngine.Analytics.VRDeviceAnalyticBase
        {
            /*0x2c*/ int vr_user_presence;

            static /*0x81dc554*/ UnityEngine.Analytics.VRDeviceUserAnalytic CreateVRDeviceUserAnalytic();
            /*0x81dc5a4*/ VRDeviceUserAnalytic();
        }

        class VRDeviceActiveControllersAnalytic : UnityEngine.Analytics.VRDeviceAnalyticBase
        {
            /*0x30*/ string[] vr_active_controllers;

            static /*0x81dc5a8*/ UnityEngine.Analytics.VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic();
            /*0x81dc5f8*/ VRDeviceActiveControllersAnalytic();
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

            static /*0x81dc670*/ UnityEditor.Analytics.AssetDatabaseRefreshAnalytic CreateAssetDatabaseRefreshAnalytic();
            /*0x81dc5fc*/ AssetDatabaseRefreshAnalytic();
        }

        class BuildAssetBundleAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ bool success;
            /*0x30*/ string error;

            static /*0x81dc734*/ UnityEditor.Analytics.BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic();
            /*0x81dc6c0*/ BuildAssetBundleAnalytic();
        }

        class CollabOperationAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string category;
            /*0x38*/ string operation;
            /*0x40*/ string result;
            /*0x48*/ long start_ts;
            /*0x50*/ long duration;

            static /*0x81dc7f8*/ UnityEditor.Analytics.CollabOperationAnalytic CreateCollabOperationAnalytic();
            /*0x81dc784*/ CollabOperationAnalytic();
        }

        class LicensingErrorAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string licensingErrorType;
            /*0x38*/ string additionalData;
            /*0x40*/ string errorMessage;
            /*0x48*/ string correlationId;
            /*0x50*/ string sessionId;

            static /*0x81dc8bc*/ UnityEditor.Analytics.LicensingErrorAnalytic CreateLicensingErrorAnalytic();
            /*0x81dc848*/ LicensingErrorAnalytic();
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

            static /*0x81dc980*/ UnityEditor.Analytics.LicensingInitAnalytic CreateLicensingInitAnalytic();
            /*0x81dc90c*/ LicensingInitAnalytic();
        }

        class MetalPatchShaderComputeBufferAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            static /*0x81dca44*/ UnityEditor.Analytics.MetalPatchShaderComputeBufferAnalytic CreateMetalPatchShaderComputeBufferAnalytic();
            /*0x81dc9d0*/ MetalPatchShaderComputeBufferAnalytic();
        }

        class NavmeshBakingAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ bool new_nav_api;
            /*0x2d*/ bool bake_at_runtime;
            /*0x30*/ int height_meshes_count;
            /*0x34*/ int offmesh_links_count;

            static /*0x81dcb08*/ UnityEditor.Analytics.NavmeshBakingAnalytic CreateNavmeshBakingAnalytic();
            /*0x81dca94*/ NavmeshBakingAnalytic();
        }

        class ProjectSettingsInformationAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int agent_types_count;
            /*0x30*/ int areas_count;

            static /*0x81dcbcc*/ UnityEditor.Analytics.ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic();
            /*0x81dcb58*/ ProjectSettingsInformationAnalytic();
        }

        class SendGameBuildAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int navmesh_count;

            static /*0x81dcc90*/ UnityEditor.Analytics.SendGameBuildAnalytic CreateSendGameBuildAnalytic();
            /*0x81dcc1c*/ SendGameBuildAnalytic();
        }

        class PackageManagerBaseAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ long start_ts;
            /*0x38*/ long duration;
            /*0x40*/ bool blocking;
            /*0x48*/ string package_id;
            /*0x50*/ int status_code;
            /*0x58*/ string error_message;

            /*0x81dcce0*/ PackageManagerBaseAnalytic(string eventName);
        }

        class PackageManagerAddPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81dcd8c*/ UnityEditor.Analytics.PackageManagerAddPackageAnalytic CreatePackageManagerAddPackageAnalytic();
            /*0x81dcd44*/ PackageManagerAddPackageAnalytic();
        }

        class PackageManagerTestAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81dce24*/ UnityEditor.Analytics.PackageManagerTestAnalytic CreatePackageManagerTestAnalytic();
            /*0x81dcddc*/ PackageManagerTestAnalytic();
        }

        class PackageManagerRemovePackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81dcebc*/ UnityEditor.Analytics.PackageManagerRemovePackageAnalytic CreatePackageManagerRemovePackageAnalytic();
            /*0x81dce74*/ PackageManagerRemovePackageAnalytic();
        }

        class PackageManagerResolvePackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            /*0x60*/ string[] packages;
            /*0x68*/ string[] package_registries;
            /*0x70*/ string[] package_signatures;
            /*0x78*/ string[] package_sources;
            /*0x80*/ string[] package_types;

            static /*0x81dcf54*/ UnityEditor.Analytics.PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic();
            /*0x81dcf0c*/ PackageManagerResolvePackageAnalytic();
        }

        class PackageManagerEmbedPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81dcfec*/ UnityEditor.Analytics.PackageManagerEmbedPackageAnalytic CreatePackageManagerEmbedPackageAnalytic();
            /*0x81dcfa4*/ PackageManagerEmbedPackageAnalytic();
        }

        class PackageManagerResetPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81dd084*/ UnityEditor.Analytics.PackageManagerResetPackageAnalytic CreatePackageManagerResetPackageAnalytic();
            /*0x81dd03c*/ PackageManagerResetPackageAnalytic();
        }

        class PackageManagerResolveErrorPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            /*0x60*/ string reason;
            /*0x68*/ string action;

            static /*0x81dd11c*/ UnityEditor.Analytics.PackageManagerResolveErrorPackageAnalytic CreatePackageManagerResolveErrorPackageAnalytic();
            /*0x81dd0d4*/ PackageManagerResolveErrorPackageAnalytic();
        }

        class PackageManagerStartServerPackageAnalytic : UnityEditor.Analytics.PackageManagerBaseAnalytic
        {
            static /*0x81dd1b4*/ UnityEditor.Analytics.PackageManagerStartServerPackageAnalytic CreatePackageManagerStartServerPackageAnalytic();
            /*0x81dd16c*/ PackageManagerStartServerPackageAnalytic();
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

            static /*0x81dd278*/ UnityEditor.Analytics.AssetImportStatusAnalytic CreateAssetImportStatusAnalytic();
            /*0x81dd204*/ AssetImportStatusAnalytic();
        }

        class AssetImportAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string package_name;
            /*0x38*/ int package_import_choice;

            static /*0x81dd33c*/ UnityEditor.Analytics.AssetImportAnalytic CreateAssetImportAnalytic();
            /*0x81dd2c8*/ AssetImportAnalytic();
        }

        class AssetExportAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string package_name;
            /*0x38*/ string error_message;
            /*0x40*/ int items_count;
            /*0x48*/ string[] asset_extensions;
            /*0x50*/ bool include_upm_dependencies;

            static /*0x81dd400*/ UnityEditor.Analytics.AssetExportAnalytic CreateAssetExportAnalytic();
            /*0x81dd38c*/ AssetExportAnalytic();
        }

        class StallSummaryAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ double Duration;

            static /*0x81dd4c4*/ UnityEditor.Analytics.StallSummaryAnalytic CreateStallSummaryAnalytic();
            /*0x81dd450*/ StallSummaryAnalytic();
        }

        class StallMarkerAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ string Name;
            /*0x38*/ bool HasProgressMarkup;
            /*0x40*/ double Duration;

            static /*0x81dd588*/ UnityEditor.Analytics.StallMarkerAnalytic CreateStallMarkerAnalytic();
            /*0x81dd514*/ StallMarkerAnalytic();
        }

        class TestAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int param;

            static /*0x81dd64c*/ UnityEditor.Analytics.TestAnalytic CreateTestAnalytic();
            /*0x81dd5d8*/ TestAnalytic();
        }
    }
}
