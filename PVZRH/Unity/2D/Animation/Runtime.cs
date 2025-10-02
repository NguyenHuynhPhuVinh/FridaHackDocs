class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x10db060*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace UnityEngine
{
    namespace U2D
    {
        namespace Animation
        {
            class Bone : UnityEngine.MonoBehaviour
            {
                /*0x20*/ string m_Guid;

                /*0x31c640*/ Bone();
                /*0x61a260*/ string get_guid();
                /*0x7965a0*/ void set_guid(string value);
            }

            class VertexBuffer
            {
                /*0x10*/ int m_Id;
                /*0x14*/ bool m_IsActive;
                /*0x18*/ int m_DeactivateFrame;
                /*0x20*/ UnityEngine.U2D.Animation.NativeByteArray[] m_Buffers;
                /*0x28*/ int m_ActiveIndex;

                static /*0x10d7fd0*/ int GetCurrentFrame();
                /*0x10dc510*/ VertexBuffer(int id, int size, bool needDoubleBuffering);
                /*0x10dc6b0*/ int get_bufferCount();
                /*0x417e30*/ int GetHashCode();
                /*0x10dc100*/ UnityEngine.U2D.Animation.NativeByteArray GetBuffer(int size);
                /*0x10dc3b0*/ void ResizeBuffer(int bufferId, int newSize);
                /*0x10dc000*/ void Deactivate();
                /*0x10dc030*/ void Dispose();
                /*0x10dc380*/ bool IsSafeToDispose();
            }

            class BufferManager : UnityEngine.ScriptableObject
            {
                static /*0x0*/ UnityEngine.U2D.Animation.BufferManager s_Instance;
                /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.U2D.Animation.VertexBuffer> m_Buffers;
                /*0x20*/ System.Collections.Generic.Queue<UnityEngine.U2D.Animation.VertexBuffer> m_BuffersToDispose;
                /*0x28*/ bool <needDoubleBuffering>k__BackingField;

                static /*0x10c7c10*/ UnityEngine.U2D.Animation.BufferManager get_instance();
                /*0x10c7a00*/ BufferManager();
                /*0x10c7ac0*/ int get_bufferCount();
                /*0x4ba480*/ bool get_needDoubleBuffering();
                /*0xd18990*/ void set_needDoubleBuffering(bool value);
                /*0x10c7730*/ void OnEnable();
                /*0x10c7610*/ void OnDisable();
                /*0x10c72c0*/ void ForceClearBuffers();
                /*0x10c7560*/ UnityEngine.U2D.Animation.NativeByteArray GetBuffer(int id, int bufferSize);
                /*0x10c7040*/ UnityEngine.U2D.Animation.VertexBuffer CreateBuffer(int id, int bufferSize);
                /*0x10c7850*/ void ReturnBuffer(int id);
                /*0x10c7930*/ void Update();
            }

            class IconUtility
            {
                static string IconPath = "Packages/com.unity.2d.animation/Editor/Assets/ComponentIcons/";
            }

            class NativeArrayHelpers
            {
                static /*0x182b00*/ void ResizeIfNeeded<T>(ref Unity.Collections.NativeArray<T> nativeArray, int size, Unity.Collections.Allocator allocator);
                static /*0x182b00*/ void ResizeAndCopyIfNeeded<T>(ref Unity.Collections.NativeArray<T> nativeArray, int size, Unity.Collections.Allocator allocator);
                static /*0x2a5510*/ void DisposeIfCreated<T>(Unity.Collections.NativeArray<T> nativeArray);
                static /*0x2a5510*/ void CopyFromNativeSlice<T, S>(Unity.Collections.NativeArray<T> nativeArray, int dstStartIndex, int dstEndIndex, Unity.Collections.NativeSlice<S> slice, int srcStartIndex, int srcEndIndex);
            }

            struct NativeCustomSlice<T>
            {
                /*0x0*/ nint data;
                /*0x0*/ int length;
                /*0x0*/ int stride;

                static /*0x2a5510*/ UnityEngine.U2D.Animation.NativeCustomSlice<T> Default();
                /*0x2a5510*/ NativeCustomSlice(Unity.Collections.NativeSlice<T> nativeSlice);
                /*0x2a5510*/ NativeCustomSlice(Unity.Collections.NativeSlice<byte> slice, int length, int stride);
                /*0x2a5510*/ T get_Item(int index);
                /*0x180980*/ int get_Length();
            }

            struct NativeCustomSliceEnumerator<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ UnityEngine.U2D.Animation.NativeCustomSlice<T> nativeCustomSlice;
                /*0x0*/ int index;

                /*0x2a5510*/ NativeCustomSliceEnumerator(Unity.Collections.NativeSlice<byte> slice, int length, int stride);
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x180fc0*/ void System.IDisposable.Dispose();
            }

            class SkeletonAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.U2D.SpriteBone[] m_SpriteBones;

                /*0x533ec0*/ SkeletonAsset();
                /*0x32f410*/ UnityEngine.U2D.SpriteBone[] GetSpriteBones();
                /*0x7963c0*/ void SetSpriteBones(UnityEngine.U2D.SpriteBone[] spriteBones);
            }

            interface ISpriteLibraryCategory
            {
                /*0x1803b0*/ string get_name();
                /*0x1803b0*/ System.Collections.Generic.IEnumerable<UnityEngine.U2D.Animation.ISpriteLibraryLabel> get_labels();
            }

            interface ISpriteLibraryLabel
            {
                /*0x1803b0*/ string get_name();
                /*0x1803b0*/ UnityEngine.Sprite get_sprite();
            }

            class SpriteLibrary : UnityEngine.MonoBehaviour, UnityEngine.U2D.Common.IPreviewable, UnityEngine.Animations.IAnimationPreviewable
            {
                /*0x20*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> m_Library;
                /*0x28*/ UnityEngine.U2D.Animation.SpriteLibraryAsset m_SpriteLibraryAsset;
                /*0x30*/ System.Collections.Generic.Dictionary<int, UnityEngine.U2D.Animation.SpriteLibrary.CategoryEntrySprite> m_CategoryEntryHashCache;
                /*0x38*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<string>> m_CategoryEntryCache;
                /*0x40*/ int m_PreviousSpriteLibraryAsset;
                /*0x48*/ long m_PreviousModificationHash;

                static /*0x10ccb10*/ int GetHashForCategoryAndEntry(string category, string entry);
                static /*0x10cc990*/ UnityEngine.U2D.Animation.SpriteCategoryEntry GetEntry(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> entries, string entry, bool addIfNotExist);
                /*0x10cd440*/ SpriteLibrary();
                /*0x10cd510*/ void set_spriteLibraryAsset(UnityEngine.U2D.Animation.SpriteLibraryAsset value);
                /*0x79a150*/ UnityEngine.U2D.Animation.SpriteLibraryAsset get_spriteLibraryAsset();
                /*0x10cce10*/ void OnEnable();
                /*0x32d010*/ void OnPreviewUpdate();
                /*0x10ccc80*/ UnityEngine.Sprite GetSprite(string category, string label);
                /*0x10ccd30*/ UnityEngine.Sprite GetSprite(int hash);
                /*0x10cd310*/ void UpdateCacheOverridesIfNeeded();
                /*0x10cc5d0*/ bool GetCategoryAndEntryNameFromHash(int hash, ref string category, ref string entry);
                /*0x10ccbc0*/ UnityEngine.Sprite GetSpriteFromCategoryAndEntryHash(int hash, ref bool validEntry);
                /*0x10cc6e0*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> GetEntries(string category, bool addIfNotExist);
                /*0x10cba70*/ void AddOverride(UnityEngine.U2D.Animation.SpriteLibraryAsset spriteLib, string category, string label);
                /*0x10cb820*/ void AddOverride(UnityEngine.U2D.Animation.SpriteLibraryAsset spriteLib, string category);
                /*0x10cb9f0*/ void AddOverride(UnityEngine.Sprite sprite, string category, string label);
                /*0x10cd0b0*/ void RemoveOverride(string category);
                /*0x10cd1e0*/ void RemoveOverride(string category, string label);
                /*0x10ccdd0*/ bool HasOverride(string category, string label);
                /*0x10cce20*/ void RefreshSpriteResolvers();
                /*0x10cd4c0*/ System.Collections.Generic.IEnumerable<string> get_categoryNames();
                /*0x10cc8f0*/ System.Collections.Generic.IEnumerable<string> GetEntryNames(string category);
                /*0x10cbcb0*/ void CacheOverrides();

                struct CategoryEntrySprite
                {
                    /*0x10*/ string category;
                    /*0x18*/ string entry;
                    /*0x20*/ UnityEngine.Sprite sprite;
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ string category;

                    /*0x32f970*/ <>c__DisplayClass18_0();
                    /*0x10dabe0*/ bool <GetEntries>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ string entry;

                    /*0x32f970*/ <>c__DisplayClass19_0();
                    /*0x10dabe0*/ bool <GetEntry>b__0(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ int categoryHash;

                    /*0x32f970*/ <>c__DisplayClass21_0();
                    /*0x10dab10*/ bool <AddOverride>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ string category;

                    /*0x32f970*/ <>c__DisplayClass23_0();
                    /*0x10dabe0*/ bool <RemoveOverride>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ string label;

                    /*0x32f970*/ <>c__DisplayClass24_0();
                    /*0x10dabe0*/ bool <RemoveOverride>b__0(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }
            }

            interface INameHash
            {
                /*0x1803b0*/ string get_name();
                /*0x17aec0*/ void set_name(string value);
                /*0x180980*/ int get_hash();
            }

            class SpriteCategoryEntry : UnityEngine.U2D.Animation.INameHash, UnityEngine.U2D.Animation.ISpriteLibraryLabel
            {
                /*0x10*/ string m_Name;
                /*0x18*/ int m_Hash;
                /*0x20*/ UnityEngine.Sprite m_Sprite;

                /*0x32f970*/ SpriteCategoryEntry();
                /*0x73d3e0*/ string get_name();
                /*0x10c9320*/ void set_name(string value);
                /*0x8a5c20*/ int get_hash();
                /*0x61a260*/ UnityEngine.Sprite get_sprite();
                /*0x7965a0*/ void set_sprite(UnityEngine.Sprite value);
                /*0x10c92a0*/ void UpdateHash();
            }

            class SpriteLibCategory : UnityEngine.U2D.Animation.INameHash, UnityEngine.U2D.Animation.ISpriteLibraryCategory
            {
                /*0x10*/ string m_Name;
                /*0x18*/ int m_Hash;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> m_CategoryList;

                /*0x32f970*/ SpriteLibCategory();
                /*0x73d3e0*/ string get_name();
                /*0x10c98f0*/ void set_name(string value);
                /*0x8a5c20*/ int get_hash();
                /*0x61a260*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> get_categoryList();
                /*0x7965a0*/ void set_categoryList(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntry> value);
                /*0x61a260*/ System.Collections.Generic.IEnumerable<UnityEngine.U2D.Animation.ISpriteLibraryLabel> get_labels();
                /*0x10c9660*/ void UpdateHash();
                /*0x10c9830*/ void ValidateLabels(bool log);

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ bool log;

                    /*0x32f970*/ <>c__DisplayClass14_0();
                    /*0x10dab50*/ void <ValidateLabels>b__0(string originalName, string newName);
                }
            }

            class SpriteLibraryAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> m_Labels;
                /*0x20*/ long m_ModificationHash;
                /*0x28*/ int m_Version;

                static /*0x10c9e20*/ UnityEngine.U2D.Animation.SpriteLibraryAsset CreateAsset(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> categories, string assetName, long modificationHash);
                static /*0x10ca980*/ void RenameDuplicate(System.Collections.Generic.IEnumerable<UnityEngine.U2D.Animation.INameHash> nameHashList, System.Action<string, string> onRename);
                /*0x10cb090*/ SpriteLibraryAsset();
                /*0x32f410*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> get_categories();
                /*0x10cb110*/ void set_categories(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategory> value);
                /*0x61a260*/ long get_modificationHash();
                /*0x10cb140*/ void set_modificationHash(long value);
                /*0xc6dab0*/ void set_version(int value);
                /*0x10ca670*/ void OnEnable();
                /*0x10cae90*/ void UpdateToVersionOne();
                /*0x10ca3c0*/ UnityEngine.Sprite GetSprite(int categoryHash, int labelHash);
                /*0x10ca510*/ UnityEngine.Sprite GetSprite(int categoryHash, int labelHash, ref bool validEntry);
                /*0x10ca1e0*/ UnityEngine.Sprite GetSprite(string category, string label);
                /*0x10ca0c0*/ System.Collections.Generic.IEnumerable<string> GetCategoryNames();
                /*0x10c9ed0*/ System.Collections.Generic.IEnumerable<string> GetCategorylabelNames(string category);
                /*0x10c9ed0*/ System.Collections.Generic.IEnumerable<string> GetCategoryLabelNames(string category);
                /*0x10c9980*/ void AddCategoryLabel(UnityEngine.Sprite sprite, string category, string label);
                /*0x10ca6a0*/ void RemoveCategoryLabel(string category, string label, bool deleteCategory);
                /*0x10cad90*/ void UpdateHashes();
                /*0x10caeb0*/ void ValidateCategories(bool log);

                class <>c
                {
                    static /*0x0*/ UnityEngine.U2D.Animation.SpriteLibraryAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.U2D.Animation.SpriteLibCategory, string> <>9__17_0;
                    static /*0x10*/ System.Func<UnityEngine.U2D.Animation.SpriteCategoryEntry, string> <>9__19_1;

                    static /*0x10daf80*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x10daaf0*/ string <GetCategoryNames>b__17_0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                    /*0x10daaf0*/ string <GetCategoryLabelNames>b__19_1(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ int categoryHash;
                    /*0x14*/ int labelHash;

                    /*0x32f970*/ <>c__DisplayClass14_0();
                    /*0x10dab10*/ bool <GetSprite>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                    /*0x10dab30*/ bool <GetSprite>b__1(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ string category;

                    /*0x32f970*/ <>c__DisplayClass19_0();
                    /*0x10dabe0*/ bool <GetCategoryLabelNames>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ int catHash;

                    /*0x32f970*/ <>c__DisplayClass20_0();
                    /*0x10dab10*/ bool <AddCategoryLabel>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass20_1
                {
                    /*0x10*/ int labelHash;

                    /*0x32f970*/ <>c__DisplayClass20_1();
                    /*0x10dab10*/ bool <AddCategoryLabel>b__1(UnityEngine.U2D.Animation.SpriteCategoryEntry y);
                }

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ int catHash;
                    /*0x18*/ UnityEngine.U2D.Animation.SpriteLibCategory libCategory;

                    /*0x32f970*/ <>c__DisplayClass21_0();
                    /*0x10dab10*/ bool <RemoveCategoryLabel>b__0(UnityEngine.U2D.Animation.SpriteLibCategory x);
                    /*0x10dac10*/ bool <RemoveCategoryLabel>b__2(UnityEngine.U2D.Animation.SpriteLibCategory x);
                }

                class <>c__DisplayClass21_1
                {
                    /*0x10*/ int labelHash;

                    /*0x32f970*/ <>c__DisplayClass21_1();
                    /*0x10dab10*/ bool <RemoveCategoryLabel>b__1(UnityEngine.U2D.Animation.SpriteCategoryEntry x);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ bool log;

                    /*0x32f970*/ <>c__DisplayClass23_0();
                    /*0x10dac70*/ void <ValidateCategories>b__0(string originalName, string newName);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ UnityEngine.U2D.Animation.INameHash category;

                    /*0x32f970*/ <>c__DisplayClass24_0();
                    /*0x10dadd0*/ bool <RenameDuplicate>b__0(UnityEngine.U2D.Animation.INameHash x);
                }

                class <>c__DisplayClass24_1
                {
                    /*0x10*/ UnityEngine.U2D.Animation.INameHash categoryClash;

                    /*0x32f970*/ <>c__DisplayClass24_1();
                }

                class <>c__DisplayClass24_2
                {
                    /*0x10*/ int nameHash;
                    /*0x18*/ string name;
                    /*0x20*/ UnityEngine.U2D.Animation.SpriteLibraryAsset.<> CS$<>8__locals1;

                    /*0x32f970*/ <>c__DisplayClass24_2();
                    /*0x10daeb0*/ bool <RenameDuplicate>b__1(UnityEngine.U2D.Animation.INameHash x);
                }
            }

            class SpriteCategoryEntryOverride : UnityEngine.U2D.Animation.SpriteCategoryEntry
            {
                /*0x28*/ bool m_FromMain;
                /*0x30*/ UnityEngine.Sprite m_SpriteOverride;

                /*0x32f970*/ SpriteCategoryEntryOverride();
                /*0x4ba480*/ bool get_fromMain();
                /*0xd18990*/ void set_fromMain(bool value);
                /*0x997630*/ UnityEngine.Sprite get_spriteOverride();
                /*0x997640*/ void set_spriteOverride(UnityEngine.Sprite value);
            }

            class SpriteLibCategoryOverride : UnityEngine.U2D.Animation.SpriteLibCategory
            {
                /*0x28*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntryOverride> m_OverrideEntries;
                /*0x30*/ bool m_FromMain;
                /*0x34*/ int m_EntryOverrideCount;

                /*0x32f970*/ SpriteLibCategoryOverride();
                /*0x995050*/ bool get_fromMain();
                /*0x995180*/ void set_fromMain(bool value);
                /*0x995160*/ int get_entryOverrideCount();
                /*0x9952f0*/ void set_entryOverrideCount(int value);
                /*0x79a150*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntryOverride> get_overrideEntries();
                /*0x98b030*/ void set_overrideEntries(System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteCategoryEntryOverride> value);
                /*0x10c94c0*/ void UpdateOverrideCount();
                /*0x10c93b0*/ void RenameDuplicateOverrideEntries();

                class <>c
                {
                    static /*0x0*/ UnityEngine.U2D.Animation.SpriteLibCategoryOverride.<> <>9;
                    static /*0x8*/ System.Action<string, string> <>9__13_0;

                    static /*0x10daff0*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x32d010*/ void <RenameDuplicateOverrideEntries>b__13_0(string _, string _);
                }
            }

            class SpriteLibrarySourceAsset : UnityEngine.ScriptableObject
            {
                static string defaultName = "New Sprite Library Asset";
                static string extension = ".spriteLib";
                /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteLibCategoryOverride> m_Library;
                /*0x20*/ string m_PrimaryLibraryGUID;
                /*0x28*/ long m_ModificationHash;
                /*0x30*/ int m_Version;

                /*0x10cb5f0*/ SpriteLibrarySourceAsset();
                /*0x32f410*/ System.Collections.Generic.IReadOnlyList<UnityEngine.U2D.Animation.SpriteLibCategoryOverride> get_library();
                /*0x61a260*/ string get_primaryLibraryGUID();
                /*0x79a150*/ long get_modificationHash();
                /*0xa79cc0*/ int get_version();
                /*0x10cb290*/ void InitializeWithAsset(UnityEngine.U2D.Animation.SpriteLibrarySourceAsset source);
                /*0x10cb450*/ void SetLibrary(System.Collections.Generic.IList<UnityEngine.U2D.Animation.SpriteLibCategoryOverride> newLibrary);
                /*0x10cb510*/ void SetPrimaryLibraryGUID(string newPrimaryLibraryGUID);
                /*0x10cb150*/ void AddCategory(UnityEngine.U2D.Animation.SpriteLibCategoryOverride newCategory);
                /*0x10cb340*/ void RemoveCategory(UnityEngine.U2D.Animation.SpriteLibCategoryOverride categoryToRemove);
                /*0x10cb230*/ void ClearCategories();
                /*0x10cb3d0*/ void RemoveCategory(int indexToRemove);
                /*0x10cb560*/ void UpdateModificationHash();
            }

            class SpriteLibraryUtility
            {
                static /*0x0*/ System.Func<string, int> GetStringHash;

                static /*0x10cb790*/ SpriteLibraryUtility();
                static /*0x10cb6d0*/ int Convert32BitTo30BitHash(int input);
                static /*0x10cb670*/ int Bit30Hash_GetStringHash(string value);
                static /*0x10cb780*/ int PreserveFirst30Bits(int input);
                static /*0x10cb720*/ long GenerateHash();
            }

            class SpriteResolver : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver, UnityEngine.U2D.Common.IPreviewable, UnityEngine.Animations.IAnimationPreviewable
            {
                /*0x20*/ float m_CategoryHash;
                /*0x24*/ float m_labelHash;
                /*0x28*/ float m_SpriteKey;
                /*0x2c*/ int m_SpriteHash;
                /*0x30*/ int m_CategoryHashInt;
                /*0x34*/ int m_LabelHashInt;
                /*0x38*/ int m_PreviousCategoryHash;
                /*0x3c*/ int m_PreviousLabelHash;
                /*0x40*/ int m_PreviousSpriteKeyInt;
                /*0x44*/ int m_PreviousSpriteHash;

                static /*0x10ce030*/ bool IsInGUIUpdateLoop();
                static /*0x10cd5a0*/ int ConvertCategoryLabelHashToSpriteKey(UnityEngine.U2D.Animation.SpriteLibrary library, int categoryHash, int labelHash);
                /*0x31c640*/ SpriteResolver();
                /*0x10ce090*/ void Reset();
                /*0x10ce5b0*/ void SetSprite(UnityEngine.Sprite sprite);
                /*0x10ce060*/ void OnEnable();
                /*0x10cdcb0*/ void InitializeSerializedData();
                /*0x10ce9d0*/ UnityEngine.SpriteRenderer get_spriteRenderer();
                /*0x10ce570*/ bool SetCategoryAndLabel(string category, string label);
                /*0x10cd980*/ string GetCategory();
                /*0x10cda70*/ string GetLabel();
                /*0x10ce980*/ UnityEngine.U2D.Animation.SpriteLibrary get_spriteLibrary();
                /*0x32d010*/ void OnPreviewUpdate();
                /*0x10ce050*/ void LateUpdate();
                /*0x10ce380*/ void ResolveUpdatedValue();
                /*0x10cdb60*/ UnityEngine.Sprite GetSprite(ref bool validEntry);
                /*0x10ce170*/ bool ResolveSpriteToSpriteRenderer();
                /*0x10ce080*/ void OnTransformParentChanged();
                /*0x32d010*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x32d010*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            }

            struct PositionVertex
            {
                /*0x10*/ UnityEngine.Vector3 position;
            }

            struct PositionTangentVertex
            {
                /*0x10*/ UnityEngine.Vector3 position;
                /*0x1c*/ UnityEngine.Vector4 tangent;
            }

            class SpriteSkin : UnityEngine.MonoBehaviour, UnityEngine.U2D.Common.IPreviewable, UnityEngine.Animations.IAnimationPreviewable, UnityEngine.ISerializationCallbackReceiver
            {
                /*0x20*/ UnityEngine.Transform m_RootBone;
                /*0x28*/ UnityEngine.Transform[] m_BoneTransforms;
                /*0x30*/ UnityEngine.Bounds m_Bounds;
                /*0x48*/ bool m_AlwaysUpdate;
                /*0x49*/ bool m_AutoRebind;
                /*0x50*/ UnityEngine.U2D.Animation.NativeByteArray m_DeformedVertices;
                /*0x58*/ int m_CurrentDeformVerticesLength;
                /*0x60*/ UnityEngine.SpriteRenderer m_SpriteRenderer;
                /*0x68*/ int m_CurrentDeformSprite;
                /*0x6c*/ bool m_ForceSkinning;
                /*0x6d*/ bool m_IsValid;
                /*0x70*/ int m_TransformsHash;
                /*0x74*/ int m_VertexDeformationHash;
                /*0x78*/ int m_TransformId;
                /*0x80*/ Unity.Collections.NativeArray<int> m_BoneTransformId;
                /*0x90*/ int m_RootBoneTransformId;
                /*0x98*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector2> m_SpriteUVs;
                /*0xa8*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector3> m_SpriteVertices;
                /*0xb8*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector4> m_SpriteTangents;
                /*0xc8*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> m_SpriteBoneWeights;
                /*0xd8*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Matrix4x4> m_SpriteBindPoses;
                /*0xe8*/ UnityEngine.U2D.Animation.NativeCustomSlice<int> m_BoneTransformIdNativeSlice;
                /*0xf8*/ bool m_SpriteHasTangents;
                /*0xfc*/ int m_SpriteVertexStreamSize;
                /*0x100*/ int m_SpriteVertexCount;
                /*0x104*/ int m_SpriteTangentVertexOffset;
                /*0x108*/ int m_DataIndex;
                /*0x10c*/ bool m_BoneCacheUpdateToDate;
                /*0x110*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin.TransformData>> m_HierarchyCache;

                static /*0x10ce030*/ bool IsInGUIUpdateLoop();
                static /*0x10d60e0*/ void CacheChildren(UnityEngine.Transform current, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin.TransformData>> cache);
                static /*0x10d7280*/ string GenerateTransformPath(UnityEngine.Transform rootBone, UnityEngine.Transform child);
                static /*0x10d8490*/ bool GetSpriteBonesTransforms(UnityEngine.U2D.Animation.SpriteSkin spriteSkin, ref UnityEngine.Transform[] outTransform);
                static /*0x10d7fe0*/ bool GetSpriteBonesTransformFromPath(UnityEngine.U2D.SpriteBone[] spriteBones, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin.TransformData>> hierarchyCache, UnityEngine.Transform[] outNewBoneTransform);
                static /*0x10d6b30*/ void CalculateBoneTransformsPath(int index, UnityEngine.U2D.SpriteBone[] spriteBones, string[] paths);
                static /*0x10d6d50*/ int CountChildren(UnityEngine.Transform transform);
                static /*0x10d7fd0*/ int GetNewVertexDeformationHash();
                /*0x10d9670*/ SpriteSkin();
                /*0x10d9790*/ UnityEngine.Sprite get_sprite();
                /*0xe643b0*/ UnityEngine.SpriteRenderer get_spriteRenderer();
                /*0x10d9780*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> get_spriteBoneWeights();
                /*0xbf2c70*/ int get_dataIndex();
                /*0x10d9730*/ bool get_autoRebind();
                /*0x10d9820*/ void set_autoRebind(bool value);
                /*0x79a150*/ UnityEngine.Transform[] get_boneTransforms();
                /*0x10d9860*/ void set_boneTransforms(UnityEngine.Transform[] value);
                /*0x61a260*/ UnityEngine.Transform get_rootBone();
                /*0x10d98e0*/ void set_rootBone(UnityEngine.Transform value);
                /*0x10d9740*/ UnityEngine.Bounds get_bounds();
                /*0x10d98c0*/ void set_bounds(UnityEngine.Bounds value);
                /*0xe85db0*/ bool get_alwaysUpdate();
                /*0x10d9810*/ void set_alwaysUpdate(bool value);
                /*0x10d9760*/ bool get_isValid();
                /*0x10d8910*/ int GetSpriteInstanceID();
                /*0x10d59d0*/ void Awake();
                /*0x10d8ef0*/ void OnEnable();
                /*0x10d8d70*/ void OnEnableBatch();
                /*0x10d8fa0*/ void OnResetBatch();
                /*0x10d8b20*/ void OnDisableBatch();
                /*0x10d8b10*/ void OnBoneTransformChanged();
                /*0x10d8b10*/ void OnRootBoneTransformChanged();
                /*0x32d010*/ void OnBeforeSerialize();
                /*0x32d010*/ void OnAfterDeserialize();
                /*0x32d010*/ void OnBeforeSerializeBatch();
                /*0x32d010*/ void OnAfterSerializeBatch();
                /*0x10d59d0*/ void OnEditorEnable();
                /*0x10d6b00*/ void CacheValidFlag();
                /*0x10d5a20*/ bool BatchValidate();
                /*0x10d9110*/ void Reset();
                /*0x10d5aa0*/ void CacheBoneTransformIds(bool forceUpdate);
                /*0x10d8fe0*/ void RemoveTransformFromSpriteSkinComposite();
                /*0x10d7f00*/ UnityEngine.U2D.Animation.NativeByteArray GetDeformedVertices(int spriteVertexCount);
                /*0x10d89b0*/ bool HasCurrentDeformedVertices();
                /*0x10d7760*/ Unity.Collections.NativeArray<byte> GetCurrentDeformedVertices();
                /*0x10d7590*/ Unity.Collections.NativeSlice<UnityEngine.U2D.Animation.PositionVertex> GetCurrentDeformedVertexPositions();
                /*0x10d73c0*/ Unity.Collections.NativeSlice<UnityEngine.U2D.Animation.PositionTangentVertex> GetCurrentDeformedVertexPositionsAndTangents();
                /*0x10d79f0*/ System.Collections.Generic.IEnumerable<UnityEngine.Vector3> GetDeformedVertexPositionData();
                /*0x10d7c60*/ System.Collections.Generic.IEnumerable<UnityEngine.Vector4> GetDeformedVertexTangentData();
                /*0x10d8c30*/ void OnDisable();
                /*0x32d010*/ void OnPreviewUpdate();
                /*0x10d6ec0*/ void Deform();
                /*0x10d63a0*/ void CacheCurrentSprite(bool rebind);
                /*0x10d91c0*/ void UpdateSpriteDeform();
                /*0x10d6ca0*/ void CopyToSpriteSkinData(ref UnityEngine.U2D.Animation.SpriteSkinData data, int spriteSkinIndex);
                /*0x10d8a50*/ bool NeedUpdateCompositeCache();
                /*0x10d66d0*/ void CacheHierarchy();
                /*0x10d6dc0*/ void DeactivateSkinning();
                /*0x10d90d0*/ void ResetSprite();

                class Profiling
                {
                    static /*0x0*/ Unity.Profiling.ProfilerMarker cacheCurrentSprite;
                    static /*0x8*/ Unity.Profiling.ProfilerMarker cacheHierarchy;
                    static /*0x10*/ Unity.Profiling.ProfilerMarker getSpriteBonesTransformFromGuid;
                    static /*0x18*/ Unity.Profiling.ProfilerMarker getSpriteBonesTransformFromPath;

                    static /*0x10c86e0*/ Profiling();
                }

                struct TransformData
                {
                    /*0x10*/ string fullName;
                    /*0x18*/ UnityEngine.Transform transform;
                }

                class <>c__DisplayClass92_0
                {
                    /*0x10*/ string boneHash;

                    /*0x32f970*/ <>c__DisplayClass92_0();
                    /*0x10daf50*/ bool <GetSpriteBonesTransforms>b__0(UnityEngine.U2D.Animation.Bone x);
                }
            }

            struct PerSkinJobData
            {
                /*0x10*/ int deformVerticesStartPos;
                /*0x14*/ Unity.Mathematics.int2 bindPosesIndex;
                /*0x1c*/ Unity.Mathematics.int2 verticesIndex;
            }

            struct SpriteSkinData
            {
                /*0x10*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector3> vertices;
                /*0x20*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights;
                /*0x30*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Matrix4x4> bindPoses;
                /*0x40*/ UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.Vector4> tangents;
                /*0x50*/ bool hasTangents;
                /*0x54*/ int spriteVertexStreamSize;
                /*0x58*/ int spriteVertexCount;
                /*0x5c*/ int tangentVertexOffset;
                /*0x60*/ int deformVerticesStartPos;
                /*0x64*/ int transformId;
                /*0x68*/ UnityEngine.U2D.Animation.NativeCustomSlice<int> boneTransformId;
            }

            struct PrepareDeformJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> perSkinJobData;
                /*0x20*/ int batchDataSize;
                /*0x28*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> boneLookupData;
                /*0x38*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> vertexLookupData;

                /*0x10c8340*/ void Execute();
            }

            struct BoneDeformBatchedJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransform;
                /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> rootTransform;
                /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> boneLookupData;
                /*0x40*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinData;
                /*0x50*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> rootTransformIndex;
                /*0x60*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> boneTransformIndex;
                /*0x70*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> finalBoneTransforms;

                /*0x10c6d20*/ void Execute(int i);
            }

            struct SkinDeformBatchedJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeSlice<byte> vertices;
                /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> finalBoneTransforms;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> perSkinJobData;
                /*0x40*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinData;
                /*0x50*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> vertexLookupData;

                /*0x10c8800*/ void Execute(int i);
            }

            struct CalculateSpriteSkinAABBJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeSlice<byte> vertices;
                /*0x20*/ Unity.Collections.NativeArray<bool> isSpriteSkinValidForDeformArray;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinData;
                /*0x40*/ Unity.Collections.NativeArray<UnityEngine.Bounds> bounds;

                /*0x10c7ec0*/ void Execute(int i);
            }

            struct FillPerSkinJobSingleThread : Unity.Jobs.IJob
            {
                /*0x10*/ UnityEngine.U2D.Animation.PerSkinJobData combinedSkinBatch;
                /*0x28*/ Unity.Collections.NativeArray<bool> isSpriteSkinValidForDeformArray;
                /*0x38*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinDataArray;
                /*0x48*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> perSkinJobDataArray;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> combinedSkinBatchArray;

                /*0x10c8070*/ void Execute();
            }

            struct CopySpriteRendererBuffersJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<bool> isSpriteSkinValidForDeformArray;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> spriteSkinData;
                /*0x30*/ nint ptrVertices;
                /*0x38*/ Unity.Collections.NativeArray<nint> buffers;
                /*0x48*/ Unity.Collections.NativeArray<int> bufferSizes;

                /*0x10c7fe0*/ void Execute(int i);
            }

            class SpriteSkinComposite : UnityEngine.ScriptableObject
            {
                static /*0x0*/ UnityEngine.U2D.Animation.SpriteSkinComposite s_Instance;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin> m_SpriteSkinsToAdd;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin> m_SpriteSkinsToRemove;
                /*0x28*/ System.Collections.Generic.List<int> m_TransformIdsToRemove;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin> m_SpriteSkins;
                /*0x38*/ UnityEngine.SpriteRenderer[] m_SpriteRenderers;
                /*0x40*/ UnityEngine.U2D.Animation.NativeByteArray m_DeformedVerticesBuffer;
                /*0x48*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> m_FinalBoneTransforms;
                /*0x58*/ Unity.Collections.NativeArray<bool> m_IsSpriteSkinActiveForDeform;
                /*0x68*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.SpriteSkinData> m_SpriteSkinData;
                /*0x78*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> m_PerSkinJobData;
                /*0x88*/ Unity.Collections.NativeArray<UnityEngine.Bounds> m_BoundsData;
                /*0x98*/ Unity.Collections.NativeArray<nint> m_Buffers;
                /*0xa8*/ Unity.Collections.NativeArray<int> m_BufferSizes;
                /*0xb8*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> m_BoneLookupData;
                /*0xc8*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> m_VertexLookupData;
                /*0xd8*/ Unity.Collections.NativeArray<UnityEngine.U2D.Animation.PerSkinJobData> m_SkinBatchArray;
                /*0xe8*/ UnityEngine.U2D.Animation.TransformAccessJob m_LocalToWorldTransformAccessJob;
                /*0xf0*/ UnityEngine.U2D.Animation.TransformAccessJob m_WorldToLocalTransformAccessJob;
                /*0xf8*/ Unity.Jobs.JobHandle m_BoundJobHandle;
                /*0x108*/ Unity.Jobs.JobHandle m_DeformJobHandle;
                /*0x118*/ Unity.Jobs.JobHandle m_CopyJobHandle;
                /*0x128*/ UnityEngine.GameObject m_Helper;

                static /*0x10d2020*/ UnityEngine.U2D.Animation.SpriteSkinComposite get_instance();
                static /*0x10cfb10*/ bool DoesContainSpriteSkin(ref System.Collections.Generic.List<UnityEngine.U2D.Animation.SpriteSkin> collection, UnityEngine.U2D.Animation.SpriteSkin skin);
                /*0x10d1ec0*/ SpriteSkinComposite();
                /*0x10d2010*/ UnityEngine.GameObject get_helperGameObject();
                /*0x10d1c30*/ void RemoveTransformById(int transformId);
                /*0x10cea10*/ void AddSpriteSkinBoneTransform(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x10ceb10*/ void AddSpriteSkinRootBoneTransform(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x10cebd0*/ void AddSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x10cf730*/ void CopyToSpriteSkinData(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x10cf530*/ void CopyToSpriteSkinData(int index);
                /*0x10d1aa0*/ void RemoveSpriteSkin(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                /*0x10d01a0*/ void Init();
                /*0x10cf7d0*/ void CreateHelper();
                /*0x10d1a00*/ void OnHelperDestroyed(UnityEngine.GameObject helperGo);
                /*0x10d1c60*/ void ResetComposite();
                /*0x10d16a0*/ void OnEnable();
                /*0x10d0280*/ void InitializeArrays();
                /*0x10d12b0*/ void OnDisable();
                /*0x10d0440*/ void LateUpdate();
                /*0x10cf120*/ void BatchRemoveSpriteSkins();
                /*0x10ced00*/ void BatchAddSpriteSkins();
                /*0x10d1db0*/ void ResizeAndCopyArrays(int updatedCount);
                /*0x10cf9a0*/ void DeactivateDeformableBuffers();
                /*0x10d0120*/ bool HasDeformableBufferForSprite(int dataIndex);
                /*0x10cfee0*/ Unity.Collections.NativeArray<byte> GetDeformableBufferForSprite(int dataIndex);
                /*0x10cfbd0*/ string GetDebugLog();
                /*0x10d00c0*/ UnityEngine.U2D.Animation.SpriteSkin[] GetSpriteSkins();
                /*0x10d0110*/ UnityEngine.U2D.Animation.TransformAccessJob GetWorldToLocalTransformAccessJob();
                /*0x10d00b0*/ UnityEngine.U2D.Animation.TransformAccessJob GetLocalToWorldTransformAccessJob();

                class Profiling
                {
                    static /*0x0*/ Unity.Profiling.ProfilerMarker batchAddSpriteSkin;
                    static /*0x8*/ Unity.Profiling.ProfilerMarker batchRemoveSpriteSkin;
                    static /*0x10*/ Unity.Profiling.ProfilerMarker prepareData;
                    static /*0x18*/ Unity.Profiling.ProfilerMarker validateSpriteSkinData;
                    static /*0x20*/ Unity.Profiling.ProfilerMarker transformAccessJob;
                    static /*0x28*/ Unity.Profiling.ProfilerMarker getSpriteSkinBatchData;
                    static /*0x30*/ Unity.Profiling.ProfilerMarker resizeBuffers;
                    static /*0x38*/ Unity.Profiling.ProfilerMarker prepare;
                    static /*0x40*/ Unity.Profiling.ProfilerMarker scheduleJobs;
                    static /*0x48*/ Unity.Profiling.ProfilerMarker setBatchDeformableBufferAndLocalAABB;
                    static /*0x50*/ Unity.Profiling.ProfilerMarker deactivateDeformableBuffer;

                    static /*0x10c8430*/ Profiling();
                }
            }

            class SpriteSkinUpdateHelper : UnityEngine.MonoBehaviour
            {
                /*0x20*/ System.Action<UnityEngine.GameObject> <onDestroyingComponent>k__BackingField;
                /*0x28*/ Unity.Profiling.ProfilerMarker m_ProfilerMarker;

                /*0x10d2290*/ SpriteSkinUpdateHelper();
                /*0x61a260*/ System.Action<UnityEngine.GameObject> get_onDestroyingComponent();
                /*0x7965a0*/ void set_onDestroyingComponent(System.Action<UnityEngine.GameObject> value);
                /*0x10d2250*/ void OnDestroy();
                /*0x10d2170*/ void LateUpdate();
            }

            enum SpriteSkinValidationResult
            {
                SpriteNotFound = 0,
                SpriteHasNoSkinningInformation = 1,
                SpriteHasNoWeights = 2,
                RootTransformNotFound = 3,
                InvalidTransformArray = 4,
                InvalidTransformArrayLength = 5,
                TransformArrayContainsNull = 6,
                InvalidBoneWeights = 7,
                Ready = 8,
            }

            class NativeByteArray
            {
                /*0x10*/ Unity.Collections.NativeArray<byte> <array>k__BackingField;

                /*0x836380*/ NativeByteArray(Unity.Collections.NativeArray<byte> array);
                /*0x8a5c20*/ int get_Length();
                /*0x10c82e0*/ bool get_IsCreated();
                /*0x10c8320*/ byte get_Item(int index);
                /*0x8b2880*/ Unity.Collections.NativeArray<byte> get_array();
                /*0x10c8290*/ void Dispose();
            }

            class SpriteSkinUtility
            {
                static /*0x10d57a0*/ UnityEngine.U2D.Animation.SpriteSkinValidationResult Validate(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x10d2b50*/ void CreateBoneHierarchy(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x10d53b0*/ int GetVertexStreamSize(UnityEngine.Sprite sprite);
                static /*0x10d5310*/ int GetVertexStreamOffset(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel);
                static /*0x10d2de0*/ void CreateGameObject(int index, UnityEngine.U2D.SpriteBone[] spriteBones, UnityEngine.Transform[] transforms, UnityEngine.Transform root);
                static /*0x10d5400*/ void ResetBindPose(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x10d52f0*/ int GetHash(UnityEngine.Matrix4x4 matrix);
                static /*0x10d29f0*/ int CalculateTransformHash(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x10d4500*/ void Deform(UnityEngine.Sprite sprite, UnityEngine.Matrix4x4 rootInv, Unity.Collections.NativeSlice<UnityEngine.Vector3> vertices, Unity.Collections.NativeSlice<UnityEngine.Vector4> tangents, Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, Unity.Collections.NativeArray<UnityEngine.Matrix4x4> boneTransforms, Unity.Collections.NativeSlice<UnityEngine.Matrix4x4> bindPoses, Unity.Collections.NativeArray<byte> deformableVertices);
                static /*0x10d4900*/ void Deform(Unity.Mathematics.float4x4 rootInv, Unity.Collections.NativeSlice<Unity.Mathematics.float3> vertices, Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransforms, Unity.Collections.NativeSlice<Unity.Mathematics.float4x4> bindPoses, Unity.Collections.NativeSlice<Unity.Mathematics.float3> deformed);
                static /*0x10d3340*/ void Deform(Unity.Mathematics.float4x4 rootInv, Unity.Collections.NativeSlice<Unity.Mathematics.float3> vertices, Unity.Collections.NativeSlice<Unity.Mathematics.float4> tangents, Unity.Collections.NativeSlice<UnityEngine.BoneWeight> boneWeights, Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransforms, Unity.Collections.NativeSlice<Unity.Mathematics.float4x4> bindPoses, Unity.Collections.NativeSlice<Unity.Mathematics.float3> deformed, Unity.Collections.NativeSlice<Unity.Mathematics.float4> deformedTangents);
                static /*0x10d3090*/ void Deform(UnityEngine.Sprite sprite, UnityEngine.Matrix4x4 invRoot, UnityEngine.Transform[] boneTransformsArray, Unity.Collections.NativeArray<byte> deformVertexData);
                static /*0x10d22f0*/ void Bake(UnityEngine.U2D.Animation.SpriteSkin spriteSkin, Unity.Collections.NativeArray<byte> deformVertexData);
                static /*0x10d2420*/ void CalculateBounds(UnityEngine.U2D.Animation.SpriteSkin spriteSkin);
                static /*0x10d2700*/ UnityEngine.Bounds CalculateSpriteSkinBounds(Unity.Collections.NativeSlice<Unity.Mathematics.float3> deformablePositions);
                static /*0x10d5640*/ void UpdateBounds(UnityEngine.U2D.Animation.SpriteSkin spriteSkin, Unity.Collections.NativeArray<byte> deformedVertices);
            }

            class BurstedSpriteSkinUtilities
            {
                static /*0x10c7e60*/ bool ValidateBoneWeights(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                static /*0x10c7d30*/ bool ValidateBoneWeights$BurstManaged(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);

                class ValidateBoneWeights_0000011E$PostfixBurstDelegate : System.MulticastDelegate
                {
                    /*0x10dbf40*/ ValidateBoneWeights_0000011E$PostfixBurstDelegate(object , nint );
                    /*0x722200*/ bool Invoke(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                    /*0x10dbea0*/ System.IAsyncResult BeginInvoke(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount, System.AsyncCallback , object );
                    /*0xa75650*/ bool EndInvoke(System.IAsyncResult );
                }

                class ValidateBoneWeights_0000011E$BurstDirectCall
                {
                    static /*0x0*/ nint Pointer;
                    static /*0x8*/ nint DeferredCompilation;

                    static /*0x10db880*/ ValidateBoneWeights_0000011E$BurstDirectCall();
                    static /*0x10db930*/ void GetFunctionPointerDiscard(ref nint );
                    static /*0x10dba60*/ nint GetFunctionPointer();
                    static /*0x10db880*/ void Constructor();
                    static /*0x32d010*/ void Initialize();
                    static /*0x10dbbd0*/ bool Invoke(ref UnityEngine.U2D.Animation.NativeCustomSlice<UnityEngine.BoneWeight> boneWeights, int bindPoseCount);
                }
            }

            class TransformAccessJob
            {
                /*0x10*/ UnityEngine.Transform[] m_Transform;
                /*0x18*/ UnityEngine.Jobs.TransformAccessArray m_TransformAccessArray;
                /*0x20*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> m_TransformData;
                /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> m_TransformMatrix;
                /*0x40*/ bool m_Dirty;
                /*0x48*/ Unity.Jobs.JobHandle m_JobHandle;

                static /*0x2a5510*/ void ArrayAdd<T>(ref T[] array, T item);
                static /*0x1827f0*/ void ArrayRemoveAt<T>(ref T[] array, int index);
                /*0x10daa60*/ TransformAccessJob();
                /*0x10da6d0*/ void ResetCache();
                /*0x10d9ea0*/ void InitializeDataStructures();
                /*0x10d9ba0*/ void Destroy();
                /*0x10d9ae0*/ void ClearDataStructures();
                /*0xc53890*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> get_transformData();
                /*0x10daa90*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> get_transformMatrix();
                /*0x10d9950*/ void AddTransform(UnityEngine.Transform t);
                /*0x10da870*/ void UpdateTransformIndex();
                /*0x10da6f0*/ Unity.Jobs.JobHandle StartLocalToWorldJob();
                /*0x10da7b0*/ Unity.Jobs.JobHandle StartWorldToLocalJob();
                /*0x10d9bd0*/ string GetDebugLog();
                /*0x10da1a0*/ void RemoveTransformsByIds(System.Collections.Generic.IList<int> idsToRemove);
                /*0x10d9fd0*/ void RemoveTransformById(int transformId);

                struct TransformData
                {
                    /*0x10*/ int transformIndex;
                    /*0x14*/ int refCount;

                    /*0x10daaa0*/ TransformData(int index);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ int id;

                    /*0x32f970*/ <>c__DisplayClass23_0();
                    /*0x10dac40*/ bool <RemoveTransformsByIds>b__0(UnityEngine.Transform t);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ int transformId;

                    /*0x32f970*/ <>c__DisplayClass24_0();
                    /*0x10dac40*/ bool <RemoveTransformById>b__0(UnityEngine.Transform t);
                }
            }

            struct LocalToWorldTransformAccessJob : UnityEngine.Jobs.IJobParallelForTransform
            {
                /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> outMatrix;

                /*0x10c81f0*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
            }

            struct WorldToLocalTransformAccessJob : UnityEngine.Jobs.IJobParallelForTransform
            {
                /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> outMatrix;

                /*0x10dc6d0*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
            }

            struct UpdateBoundJob : Unity.Jobs.IJobParallelFor
            {
                /*0x10*/ Unity.Collections.NativeArray<int> rootTransformId;
                /*0x20*/ Unity.Collections.NativeArray<int> rootBoneTransformId;
                /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> rootTransform;
                /*0x40*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> boneTransform;
                /*0x50*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> rootTransformIndex;
                /*0x60*/ Unity.Collections.NativeHashMap<int, UnityEngine.U2D.Animation.TransformAccessJob.TransformData> boneTransformIndex;
                /*0x70*/ Unity.Collections.NativeArray<UnityEngine.Bounds> spriteSkinBound;
                /*0x80*/ Unity.Collections.NativeArray<UnityEngine.Bounds> bounds;

                /*0x10db140*/ void Execute(int i);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 6402E429D3AA320257F6400640DB3FE1EA05934A9DE6BA5B40B82084727140ED;
    static /*0x8e3*/ <PrivateImplementationDetails> 786BC0008B7F192867EF220214C5AD0E98B1B4573756BD929D06326E45E16518;

    struct __StaticArrayInitTypeSize=1803
    {
    }

    struct __StaticArrayInitTypeSize=2275
    {
    }
}

class $BurstDirectCallInitializer
{
    static /*0x10daab0*/ void Initialize();
}
