class <Module>
{
}

namespace Microsoft
{
    namespace Win32
    {
        class NativeMethods
        {
            static /*0x1091bc0*/ bool DuplicateHandle(System.Runtime.InteropServices.HandleRef hSourceProcessHandle, System.Runtime.InteropServices.HandleRef hSourceHandle, System.Runtime.InteropServices.HandleRef hTargetProcess, ref Microsoft.Win32.SafeHandles.SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions);
            static /*0x1091d30*/ nint GetCurrentProcess();
            static /*0x1091e10*/ bool GetExitCodeProcess(nint processHandle, ref int exitCode);
            static /*0x1091d40*/ bool GetExitCodeProcess(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle, ref int exitCode);
            static /*0x1091d20*/ int GetCurrentProcessId();
            static /*0x1091bb0*/ bool CloseProcess(nint handle);
        }

        namespace SafeHandles
        {
            class SafeProcessHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                static /*0x0*/ Microsoft.Win32.SafeHandles.SafeProcessHandle InvalidHandle;

                static /*0x10a0ca0*/ SafeProcessHandle();
                /*0x10a0d20*/ SafeProcessHandle(nint handle);
                /*0x10a0d50*/ SafeProcessHandle(nint existingHandle, bool ownsHandle);
                /*0x10a0c90*/ bool ReleaseHandle();
            }
        }
    }
}

namespace Internal
{
    namespace Cryptography
    {
        class OidLookup
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName;
            static /*0x8*/ System.Collections.Concurrent.ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid;
            static /*0x10*/ System.Collections.Generic.Dictionary<string, string> s_friendlyNameToOid;
            static /*0x18*/ System.Collections.Generic.Dictionary<string, string> s_oidToFriendlyName;
            static /*0x20*/ System.Collections.Generic.Dictionary<string, string> s_compatOids;

            static /*0x1092410*/ OidLookup();
            static /*0x10921d0*/ string ToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x3ce290*/ bool ShouldUseCache(System.Security.Cryptography.OidGroup oidGroup);
            static /*0x1091e80*/ string NativeFriendlyNameToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);

            class <>c
            {
                static /*0x0*/ Internal.Cryptography.OidLookup.<> <>9;

                static /*0x10a0e00*/ <>c();
                /*0x32f970*/ <>c();
                /*0x10a0d80*/ string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<string, string> kvp);
                /*0x10a0dc0*/ string <.cctor>b__10_1(System.Collections.Generic.KeyValuePair<string, string> kvp);
            }
        }
    }
}

namespace System
{
    class IPv4AddressHelper
    {
        static /*0x108e850*/ int ParseHostNumber(System.ReadOnlySpan<char> str, int start, int end);
        static /*0x108e370*/ bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme);
        static /*0x108e7c0*/ bool ParseCanonical(System.ReadOnlySpan<char> name, byte* numbers, int start, int end);
        static /*0x108e230*/ bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile);
        static /*0x108e920*/ long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile);
        static /*0x108e500*/ string ParseCanonicalName(string str, int start, int end, ref bool isLoopback);
        static /*0x108ebc0*/ bool Parse(string name, byte* numbers, int start, int end);
    }

    class IPv6AddressHelper
    {
        static /*0x108ec50*/ System.ValueTuple<int, int> FindCompressionRange(System.ReadOnlySpan<ushort> numbers);
        static /*0x108fdd0*/ bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<ushort> numbers);
        static /*0x108f940*/ void Parse(System.ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId);
        static /*0x108f0e0*/ string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId);
        static /*0x108efe0*/ bool IsLoopback(System.ReadOnlySpan<ushort> numbers);
        static /*0x108ed20*/ bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress);
        static /*0x108f0c0*/ bool IsValid(char* name, int start, ref int end);
    }

    class NotImplemented
    {
        static /*0x1091e20*/ System.Exception ByDesignWithMessage(string message);
    }

    class PasteArguments
    {
        static /*0x1093e50*/ void AppendArgument(System.Text.StringBuilder stringBuilder, string argument);
        static /*0x1094030*/ bool ContainsNoWhitespaceOrQuotes(string s);
    }

    class IriHelper
    {
        static /*0x1090430*/ bool CheckIriUnicodeRange(char unicode, bool isQuery);
        static /*0x108feb0*/ bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery);
        static /*0x1090490*/ bool CheckIsReserved(char ch, System.UriComponents component);
        static /*0x10905a0*/ string EscapeUnescapeIri(char* pInput, int start, int end, System.UriComponents component);
    }

    class Uri : System.Runtime.Serialization.ISerializable
    {
        static /*0x0*/ string UriSchemeFile;
        static /*0x8*/ string UriSchemeFtp;
        static /*0x10*/ string UriSchemeGopher;
        static /*0x18*/ string UriSchemeHttp;
        static /*0x20*/ string UriSchemeHttps;
        static /*0x28*/ string UriSchemeWs;
        static /*0x30*/ string UriSchemeWss;
        static /*0x38*/ string UriSchemeMailto;
        static /*0x40*/ string UriSchemeNews;
        static /*0x48*/ string UriSchemeNntp;
        static /*0x50*/ string UriSchemeNetTcp;
        static /*0x58*/ string UriSchemeNetPipe;
        static /*0x60*/ string SchemeDelimiter;
        static /*0x68*/ bool s_ConfigInitialized;
        static /*0x69*/ bool s_ConfigInitializing;
        static /*0x6c*/ System.UriIdnScope s_IdnScope;
        static /*0x70*/ bool s_IriParsing;
        static /*0x71*/ bool useDotNetRelativeOrAbsolute;
        static /*0x72*/ bool IsWindowsFileSystem;
        static /*0x78*/ object s_initLock;
        static /*0x80*/ char[] HexLowerChars;
        static /*0x88*/ char[] _WSchars;
        /*0x10*/ string m_String;
        /*0x18*/ string m_originalUnicodeString;
        /*0x20*/ System.UriParser m_Syntax;
        /*0x28*/ string m_DnsSafeHost;
        /*0x30*/ System.Uri.Flags m_Flags;
        /*0x38*/ System.Uri.UriInfo m_Info;
        /*0x40*/ bool m_iriParsing;

        static /*0x1088af0*/ Uri();
        static /*0x1084bc0*/ bool IriParsingStatic(System.UriParser syntax);
        static /*0x10883b0*/ bool StaticNotAny(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x1088380*/ bool StaticInFact(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x1081970*/ System.ParsingError GetCombinedString(System.Uri baseUri, string relativeStr, bool dontEscape, ref string result);
        static /*0x1082220*/ System.UriFormatException GetException(System.ParsingError err);
        static /*0x1088390*/ bool StaticIsFile(System.UriParser syntax);
        static /*0x1089d30*/ object get_InitializeLock();
        static /*0x10838e0*/ void InitializeUriConfig();
        static /*0x1084d40*/ bool IsGenDelim(char ch);
        static /*0x1084d70*/ bool IsHexDigit(char character);
        static /*0x1081110*/ int FromHex(char digit);
        static /*0x108a1e0*/ bool op_Inequality(System.Uri uri1, System.Uri uri2);
        static /*0x107db60*/ bool CheckForColonInFirstPathSegment(string uriString);
        static /*0x1086270*/ System.ParsingError ParseScheme(string uriString, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x107f790*/ string CreateHostStringHelper(string str, ushort idx, ushort end, ref System.Uri.Flags flags, ref string scopeId);
        static /*0x1085db0*/ ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x107dfc0*/ bool CheckKnownSchemes(long* lptr, ushort nChars, ref System.UriParser syntax);
        static /*0x107e4e0*/ System.ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref System.UriParser syntax);
        static /*0x10888f0*/ void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3);
        static /*0x107eff0*/ char[] Compress(char[] dest, ushort start, ref int destLength, System.UriParser syntax);
        static /*0x107be30*/ int CalculateCaseInsensitiveHashCode(string text);
        static /*0x107e600*/ string CombineUri(System.Uri basePart, string relativePart, System.UriFormat uriFormat);
        static /*0x1084da0*/ bool IsLWS(char ch);
        static /*0x1084ce0*/ bool IsAsciiLetter(char character);
        static /*0x1084c60*/ bool IsAsciiLetterOrDigit(char character);
        static /*0x1084d00*/ bool IsBidiControlCharacter(char ch);
        static /*0x10883c0*/ string StripBidiControlCharacter(char* strToClean, int start, int length);
        static /*0x1088660*/ bool TryCreate(string uriString, System.UriKind uriKind, ref System.Uri result);
        static /*0x1084e20*/ bool IsWellFormedUriString(string uriString, System.UriKind uriKind);
        static /*0x1088740*/ string UnescapeDataString(string stringToUnescape);
        static /*0x107f4b0*/ System.Uri CreateHelper(string uriString, bool dontEscape, System.UriKind uriKind, ref System.UriFormatException e);
        static /*0x1087e10*/ System.Uri ResolveHelper(System.Uri baseUri, System.Uri relativeUri, ref string newUriString, ref bool userEscaped, ref System.UriFormatException e);
        /*0x10893d0*/ Uri(string uriString);
        /*0x10890c0*/ Uri(string uriString, System.UriKind uriKind);
        /*0x1089160*/ Uri(System.Uri baseUri, System.Uri relativeUri);
        /*0x1089560*/ Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x1089500*/ Uri(System.Uri.Flags flags, System.UriParser uriParser, string uri);
        /*0x1089e30*/ bool get_IsImplicitFile();
        /*0x1089e50*/ bool get_IsUncOrDosPath();
        /*0x1089e20*/ bool get_IsDosPath();
        /*0x1089e60*/ bool get_IsUncPath();
        /*0x1089d20*/ System.Uri.Flags get_HostType();
        /*0x61a260*/ System.UriParser get_Syntax();
        /*0x1089e40*/ bool get_IsNotAbsoluteUri();
        /*0x1089920*/ bool get_AllowIdn();
        /*0x107bd30*/ bool AllowIdnStatic(System.UriParser syntax, System.Uri.Flags flags);
        /*0x348b00*/ bool IsIntranet(string schemeHost);
        /*0x108a1c0*/ bool get_UserDrivenParsing();
        /*0x1088360*/ void SetUserDrivenParsing();
        /*0x108a160*/ ushort get_SecuredPathIndex();
        /*0x1084f90*/ bool NotAny(System.Uri.Flags flags);
        /*0x10838d0*/ bool InFact(System.Uri.Flags flags);
        /*0x10807d0*/ System.Uri.UriInfo EnsureUriInfo();
        /*0x10807b0*/ void EnsureParseRemaining();
        /*0x1080740*/ void EnsureHostString(bool allowDnsOptimization);
        /*0x1082a30*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x1082a30*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x10897d0*/ string get_AbsoluteUri();
        /*0x1089e70*/ bool get_IsUnc();
        /*0x1089fc0*/ int get_Port();
        /*0x108a0d0*/ string get_Scheme();
        /*0x1089f00*/ bool get_OriginalStringSwitched();
        /*0x1089f60*/ string get_OriginalString();
        /*0x1089a10*/ string get_DnsSafeHost();
        /*0x104b330*/ bool get_IsAbsoluteUri();
        /*0x108a1d0*/ bool get_UserEscaped();
        /*0x10823d0*/ int GetHashCode();
        /*0x1088540*/ string ToString();
        /*0x1080810*/ bool Equals(object comparand);
        /*0x1084fa0*/ System.UriFormatException ParseMinimal();
        /*0x1086480*/ System.ParsingError PrivateParseMinimal();
        /*0x1086360*/ void PrivateParseMinimalIri(string newHost, ushort idx);
        /*0x10801a0*/ void CreateUriInfo(System.Uri.Flags cF);
        /*0x107f9a0*/ void CreateHostString();
        /*0x1082580*/ void GetHostViaCustomSyntax();
        /*0x1082b20*/ string GetParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x1082130*/ string GetEscapedParts(System.UriComponents uriParts);
        /*0x1082f10*/ string GetUnescapedParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x1086bf0*/ string ReCreateParts(System.UriComponents parts, ushort nonCanonical, System.UriFormat formatAs);
        /*0x1082fe0*/ string GetUriPartsFromUserString(System.UriComponents uriParts);
        /*0x1085020*/ void ParseRemaining();
        /*0x107c730*/ ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, System.UriParser syntax, ref string newHost);
        /*0x107c1e0*/ void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, System.UriParser syntax, string userInfoString, ref System.Uri.Flags flags, ref bool justNormalized, ref string newHost, ref System.ParsingError err);
        /*0x107bee0*/ void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, System.UriParser syntax, ref System.Uri.Flags flags, ref string newHost, ref System.ParsingError err);
        /*0x1081060*/ void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim);
        /*0x1080fc0*/ void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim);
        /*0x107d760*/ System.Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim);
        /*0x10811b0*/ char[] GetCanonicalPath(char[] dest, ref int pos, System.UriFormat formatAs);
        /*0x107ffc0*/ void CreateThis(string uri, bool dontEscape, System.UriKind uriKind);
        /*0x1083b40*/ void InitializeUri(System.ParsingError err, System.UriKind uriKind, ref System.UriFormatException e);
        /*0x107dc10*/ bool CheckForConfigLoad(string data);
        /*0x107de70*/ bool CheckForUnicode(string data);
        /*0x107dcd0*/ bool CheckForEscapedUnreserved(string data);
        /*0x1081f30*/ string GetComponents(System.UriComponents components, System.UriFormat format);
        /*0x1084dd0*/ bool IsWellFormedOriginalString();
        /*0x1084670*/ bool InternalIsWellFormedOriginalString();
        /*0x1080f60*/ string EscapeUnescapeIri(string input, int start, int end, System.UriComponents component);
        /*0x1082b30*/ string GetRelativeSerializationString(System.UriFormat format);
        /*0x1081b90*/ string GetComponentsHelper(System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x107fe10*/ void CreateThisFromUri(System.Uri otherUri);

        enum Flags
        {
            Zero = 0,
            SchemeNotCanonical = 1,
            UserNotCanonical = 2,
            HostNotCanonical = 4,
            PortNotCanonical = 8,
            PathNotCanonical = 16,
            QueryNotCanonical = 32,
            FragmentNotCanonical = 64,
            CannotDisplayCanonical = 127,
            E_UserNotCanonical = 128,
            E_HostNotCanonical = 256,
            E_PortNotCanonical = 512,
            E_PathNotCanonical = 1024,
            E_QueryNotCanonical = 2048,
            E_FragmentNotCanonical = 4096,
            E_CannotDisplayCanonical = 8064,
            ShouldBeCompressed = 8192,
            FirstSlashAbsent = 16384,
            BackslashInPath = 32768,
            IndexMask = 65535,
            HostTypeMask = 458752,
            HostNotParsed = 0,
            IPv6HostType = 65536,
            IPv4HostType = 131072,
            DnsHostType = 196608,
            UncHostType = 262144,
            BasicHostType = 327680,
            UnusedHostType = 393216,
            UnknownHostType = 458752,
            UserEscaped = 524288,
            AuthorityFound = 1048576,
            HasUserInfo = 2097152,
            LoopbackHost = 4194304,
            NotDefaultPort = 8388608,
            UserDrivenParsing = 16777216,
            CanonicalDnsHost = 33554432,
            ErrorOrParsingRecursion = 67108864,
            DosPath = 134217728,
            UncPath = 268435456,
            ImplicitFile = 536870912,
            MinimalUriInfoSet = 1073741824,
            AllUriInfoSet = 2147483648,
            IdnHost = 4294967296,
            HasUnicode = 8589934592,
            HostUnicodeNormalized = 17179869184,
            RestUnicodeNormalized = 34359738368,
            UnicodeHost = 68719476736,
            IntranetUri = 137438953472,
            UseOrigUncdStrOffset = 274877906944,
            UserIriCanonical = 549755813888,
            PathIriCanonical = 1099511627776,
            QueryIriCanonical = 2199023255552,
            FragmentIriCanonical = 4398046511104,
            IriCanonical = 8246337208320,
            CompressedSlashes = 17592186044416,
        }

        class UriInfo
        {
            /*0x10*/ string Host;
            /*0x18*/ string ScopeId;
            /*0x20*/ string String;
            /*0x28*/ System.Uri.Offset Offset;
            /*0x38*/ string DnsSafeHost;
            /*0x40*/ System.Uri.MoreInfo MoreInfo;

            /*0x32f970*/ UriInfo();
        }

        struct Offset
        {
            /*0x10*/ ushort Scheme;
            /*0x12*/ ushort User;
            /*0x14*/ ushort Host;
            /*0x16*/ ushort PortValue;
            /*0x18*/ ushort Path;
            /*0x1a*/ ushort Query;
            /*0x1c*/ ushort Fragment;
            /*0x1e*/ ushort End;
        }

        class MoreInfo
        {
            /*0x10*/ string AbsoluteUri;
            /*0x18*/ int Hash;
            /*0x20*/ string RemoteUrl;

            /*0x32f970*/ MoreInfo();
        }

        enum Check
        {
            None = 0,
            EscapedCanonical = 1,
            DisplayCanonical = 2,
            DotSlashAttn = 4,
            DotSlashEscaped = 128,
            BackslashInPath = 16,
            ReservedFound = 32,
            NotIriCanonical = 64,
            FoundNonAscii = 8,
        }
    }

    class UriFormatException : System.FormatException, System.Runtime.Serialization.ISerializable
    {
        /*0x10a1240*/ UriFormatException();
        /*0x10a1250*/ UriFormatException(string textString);
        /*0xea43e0*/ UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x10a1220*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
    }

    enum UriKind
    {
        RelativeOrAbsolute = 0,
        Absolute = 1,
        Relative = 2,
    }

    enum UriComponents
    {
        Scheme = 1,
        UserInfo = 2,
        Host = 4,
        Port = 8,
        Path = 16,
        Query = 32,
        Fragment = 64,
        StrongPort = 128,
        NormalizedHost = 256,
        KeepDelimiter = 1073741824,
        SerializationInfoString = -2147483648,
        AbsoluteUri = 127,
        HostAndPort = 132,
        StrongAuthority = 134,
        SchemeAndServer = 13,
        HttpRequestUrl = 61,
        PathAndQuery = 48,
    }

    enum UriFormat
    {
        UriEscaped = 1,
        Unescaped = 2,
        SafeUnescaped = 3,
    }

    enum UriIdnScope
    {
        None = 0,
        AllExceptIntranet = 1,
        All = 2,
    }

    enum ParsingError
    {
        None = 0,
        BadFormat = 1,
        BadScheme = 2,
        BadAuthority = 3,
        EmptyUriString = 4,
        LastRelativeUriOkErrIndex = 4,
        SchemeLimit = 5,
        SizeLimit = 6,
        MustRootedPath = 7,
        BadHostName = 8,
        NonEmptyHost = 9,
        BadPort = 10,
        BadAuthorityTerminator = 11,
        CannotCreateRelative = 12,
    }

    enum UnescapeMode
    {
        CopyOnly = 0,
        Escape = 1,
        Unescape = 2,
        EscapeUnescape = 3,
        V1ToStringFlag = 4,
        UnescapeAll = 8,
        UnescapeAllOrThrow = 24,
    }

    class UriHelper
    {
        static /*0x0*/ char[] HexUpperChars;

        static /*0x10a2f50*/ UriHelper();
        static /*0x10a1470*/ char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd);
        static /*0x10a1260*/ char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos);
        static /*0x10a23a0*/ char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x10a2480*/ char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x10a1eb0*/ void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing);
        static /*0x10a1360*/ void EscapeAsciiChar(char ch, char[] to, ref int pos);
        static /*0x10a1ae0*/ char EscapedAscii(char digit, char next);
        static /*0x10a1c10*/ bool IsNotSafeForUnescape(char ch);
        static /*0x10a1c60*/ bool IsReservedUnreservedOrHash(char c);
        static /*0x10a1d90*/ bool IsUnreserved(char c);
        static /*0x10a1b80*/ bool Is3986Unreserved(char c);
    }

    class UriParser
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<string, System.UriParser> m_Table;
        static /*0x8*/ System.Collections.Generic.Dictionary<string, System.UriParser> m_TempTable;
        static /*0x10*/ System.UriParser HttpUri;
        static /*0x18*/ System.UriParser HttpsUri;
        static /*0x20*/ System.UriParser WsUri;
        static /*0x28*/ System.UriParser WssUri;
        static /*0x30*/ System.UriParser FtpUri;
        static /*0x38*/ System.UriParser FileUri;
        static /*0x40*/ System.UriParser GopherUri;
        static /*0x48*/ System.UriParser NntpUri;
        static /*0x50*/ System.UriParser NewsUri;
        static /*0x58*/ System.UriParser MailToUri;
        static /*0x60*/ System.UriParser UuidUri;
        static /*0x68*/ System.UriParser TelnetUri;
        static /*0x70*/ System.UriParser LdapUri;
        static /*0x78*/ System.UriParser NetTcpUri;
        static /*0x80*/ System.UriParser NetPipeUri;
        static /*0x88*/ System.UriParser VsMacrosUri;
        static /*0x90*/ System.UriParser.UriQuirksVersion s_QuirksVersion;
        static /*0x94*/ System.UriSyntaxFlags HttpSyntaxFlags;
        static /*0x98*/ System.UriSyntaxFlags FileSyntaxFlags;
        /*0x10*/ System.UriSyntaxFlags m_Flags;
        /*0x14*/ System.UriSyntaxFlags m_UpdatableFlags;
        /*0x18*/ bool m_UpdatableFlagsUsed;
        /*0x1c*/ int m_Port;
        /*0x20*/ string m_Scheme;

        static /*0x10a3a90*/ UriParser();
        static /*0x10a47d0*/ bool get_ShouldUseLegacyV2Quirks();
        static /*0x10a2fe0*/ System.UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme);
        /*0x10a4760*/ UriParser(System.UriSyntaxFlags flags);
        /*0x61a260*/ string get_SchemeName();
        /*0xc70b00*/ int get_DefaultPort();
        /*0x621ca0*/ System.UriParser OnNewUri();
        /*0x10a3600*/ void InitializeAndValidate(System.Uri uri, ref System.UriFormatException parsingError);
        /*0x10a3870*/ string Resolve(System.Uri baseUri, System.Uri relativeUri, ref System.UriFormatException parsingError);
        /*0x10a3320*/ string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format);
        /*0x10a37f0*/ bool IsWellFormedOriginalString(System.Uri uri);
        /*0x417e30*/ System.UriSyntaxFlags get_Flags();
        /*0x10a3810*/ bool NotAny(System.UriSyntaxFlags flags);
        /*0x10a35a0*/ bool InFact(System.UriSyntaxFlags flags);
        /*0x10a3720*/ bool IsAllSet(System.UriSyntaxFlags flags);
        /*0x10a3780*/ bool IsFullMatch(System.UriSyntaxFlags flags, System.UriSyntaxFlags expected);
        /*0x10a47c0*/ bool get_IsSimple();
        /*0x10a3680*/ System.UriParser InternalOnNewUri();
        /*0x10a3700*/ void InternalValidate(System.Uri thisUri, ref System.UriFormatException parsingError);
        /*0x10a36e0*/ string InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, ref System.UriFormatException parsingError);
        /*0x10a3640*/ string InternalGetComponents(System.Uri thisUri, System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x10a3660*/ bool InternalIsWellFormedOriginalString(System.Uri thisUri);

        enum UriQuirksVersion
        {
            V2 = 2,
            V3 = 3,
        }

        class BuiltInUriParser : System.UriParser
        {
            /*0x108a500*/ BuiltInUriParser(string lwrCaseScheme, int defaultPort, System.UriSyntaxFlags syntaxFlags);
        }
    }

    class DomainNameHelper
    {
        static /*0x108c200*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x108c090*/ bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x108be80*/ bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x108b9c0*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x108bc20*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost);
        static /*0x108bdd0*/ bool IsIdnAce(string input, int index);
        static /*0x108be50*/ bool IsIdnAce(char* input, int index);
        static /*0x108c380*/ string UnicodeEquivalent(string idnHost, char* hostname, int start, int end);
        static /*0x108c430*/ string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x108bda0*/ bool IsASCIILetterOrDigit(char character, ref bool notCanonical);
        static /*0x108c050*/ bool IsValidDomainLabelCharacter(char character, ref bool notCanonical);
    }

    class UncNameHelper
    {
        static /*0x10a10a0*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x10a0e70*/ bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile);
    }

    enum UriSyntaxFlags
    {
        None = 0,
        MustHaveAuthority = 1,
        OptionalAuthority = 2,
        MayHaveUserInfo = 4,
        MayHavePort = 8,
        MayHavePath = 16,
        MayHaveQuery = 32,
        MayHaveFragment = 64,
        AllowEmptyHost = 128,
        AllowUncHost = 256,
        AllowDnsHost = 512,
        AllowIPv4Host = 1024,
        AllowIPv6Host = 2048,
        AllowAnInternetHost = 3584,
        AllowAnyOtherHost = 4096,
        FileLikeUri = 8192,
        MailToLikeUri = 16384,
        V1_UnknownUri = 65536,
        SimpleUserSyntax = 131072,
        BuiltInSyntax = 262144,
        ParserSchemeOnly = 524288,
        AllowDOSPath = 1048576,
        PathIsRooted = 2097152,
        ConvertPathSlashes = 4194304,
        CompressPath = 8388608,
        CanonicalizeAsFilePath = 16777216,
        UnEscapeDotsAndSlashes = 33554432,
        AllowIdn = 67108864,
        AllowIriParsing = 268435456,
    }

    enum IOOperation
    {
        Read = 1,
        Write = 2,
    }

    class IOAsyncCallback : System.MulticastDelegate
    {
        /*0xcf9550*/ IOAsyncCallback(object object, nint method);
        /*0x720980*/ void Invoke(System.IOAsyncResult ioares);
    }

    class IOAsyncResult
    {
        /*0x10*/ System.AsyncCallback async_callback;
        /*0x18*/ object async_state;
        /*0x20*/ System.Threading.ManualResetEvent wait_handle;
        /*0x28*/ bool completed_synchronously;
        /*0x29*/ bool completed;
    }

    class IOSelectorJob
    {
        /*0x10*/ System.IOOperation operation;
        /*0x18*/ System.IOAsyncCallback callback;
        /*0x20*/ System.IOAsyncResult state;
    }

    class UriTypeConverter : System.ComponentModel.TypeConverter
    {
        /*0x534220*/ UriTypeConverter();
        /*0x10a4830*/ bool CanConvert(System.Type type);
    }

    namespace Text
    {
        namespace RegularExpressions
        {
            class Capture
            {
                /*0x10*/ int <Index>k__BackingField;
                /*0x14*/ int <Length>k__BackingField;
                /*0x18*/ string <Text>k__BackingField;

                /*0x108b960*/ Capture(string text, int index, int length);
                /*0x108b930*/ Capture();
                /*0x417e30*/ int get_Index();
                /*0xdcd9c0*/ void set_Index(int value);
                /*0x70a440*/ int get_Length();
                /*0xc70b20*/ void set_Length(int value);
                /*0x32f410*/ string get_Text();
                /*0x7963c0*/ void set_Text(string value);
                /*0x108b900*/ string get_Value();
                /*0x108b900*/ string ToString();
                /*0x108b7a0*/ System.ReadOnlySpan<char> GetLeftSubstring();
                /*0x108b840*/ System.ReadOnlySpan<char> GetRightSubstring();
            }

            class CaptureCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Capture>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Group _group;
                /*0x18*/ int _capcount;
                /*0x20*/ System.Text.RegularExpressions.Capture[] _captures;

                /*0x108b770*/ CaptureCollection();
                /*0x3ce290*/ bool get_IsReadOnly();
                /*0x8a5c20*/ int get_Count();
                /*0x108b320*/ System.Text.RegularExpressions.Capture get_Item(int i);
                /*0x108afa0*/ System.Collections.IEnumerator GetEnumerator();
                /*0x108b160*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator();
                /*0x108ad50*/ System.Text.RegularExpressions.Capture GetCapture(int i);
                /*0x108abb0*/ void ForceInitialized();
                /*0x348b00*/ bool get_IsSynchronized();
                /*0x73d3e0*/ object get_SyncRoot();
                /*0x108aaf0*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x108a920*/ void CopyTo(System.Text.RegularExpressions.Capture[] array, int arrayIndex);
                /*0x108b1d0*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture item);
                /*0x108b280*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, System.Text.RegularExpressions.Capture item);
                /*0x108b2d0*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index);
                /*0x108b320*/ System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index);
                /*0x108b330*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, System.Text.RegularExpressions.Capture value);
                /*0x108b010*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture item);
                /*0x108b060*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear();
                /*0x108b0b0*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture item);
                /*0x108b110*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture item);
                /*0x108b380*/ int System.Collections.IList.Add(object value);
                /*0x108b3d0*/ void System.Collections.IList.Clear();
                /*0x108b420*/ bool System.Collections.IList.Contains(object value);
                /*0x108b560*/ int System.Collections.IList.IndexOf(object value);
                /*0x108b630*/ void System.Collections.IList.Insert(int index, object value);
                /*0x3ce290*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x108b6d0*/ void System.Collections.IList.Remove(object value);
                /*0x108b680*/ void System.Collections.IList.RemoveAt(int index);
                /*0x108b320*/ object System.Collections.IList.get_Item(int index);
                /*0x108b720*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.CaptureCollection _collection;
                    /*0x18*/ int _index;

                    /*0xe2c3c0*/ Enumerator(System.Text.RegularExpressions.CaptureCollection collection);
                    /*0x108c8f0*/ bool MoveNext();
                    /*0x108c9d0*/ System.Text.RegularExpressions.Capture get_Current();
                    /*0x108c9d0*/ object System.Collections.IEnumerator.get_Current();
                    /*0xf64680*/ void System.Collections.IEnumerator.Reset();
                    /*0x32d010*/ void System.IDisposable.Dispose();
                }
            }

            class CollectionDebuggerProxy<T>
            {
            }

            class Group : System.Text.RegularExpressions.Capture
            {
                static /*0x0*/ System.Text.RegularExpressions.Group s_emptyGroup;
                /*0x20*/ int[] _caps;
                /*0x28*/ int _capcount;
                /*0x30*/ System.Text.RegularExpressions.CaptureCollection _capcoll;
                /*0x38*/ string <Name>k__BackingField;

                static /*0x108dfc0*/ Group();
                /*0x108e150*/ Group(string text, int[] caps, int capcount, string name);
                /*0x108e120*/ Group();
                /*0x108e220*/ bool get_Success();
            }

            class GroupCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Group>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Group>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Match _match;
                /*0x18*/ System.Collections.Hashtable _captureMap;
                /*0x20*/ System.Text.RegularExpressions.Group[] _groups;

                /*0x108df60*/ GroupCollection();
                /*0x3ce290*/ bool get_IsReadOnly();
                /*0x108df90*/ int get_Count();
                /*0x108db10*/ System.Text.RegularExpressions.Group get_Item(int groupnum);
                /*0x108ce80*/ System.Collections.IEnumerator GetEnumerator();
                /*0x108d930*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator();
                /*0x108d2f0*/ System.Text.RegularExpressions.Group GetGroup(int groupnum);
                /*0x108cef0*/ System.Text.RegularExpressions.Group GetGroupImpl(int groupnum);
                /*0x348b00*/ bool get_IsSynchronized();
                /*0x73d3e0*/ object get_SyncRoot();
                /*0x108cbb0*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x108cc90*/ void CopyTo(System.Text.RegularExpressions.Group[] array, int arrayIndex);
                /*0x108d9a0*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item);
                /*0x108da70*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, System.Text.RegularExpressions.Group item);
                /*0x108dac0*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index);
                /*0x108db10*/ System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index);
                /*0x108db20*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, System.Text.RegularExpressions.Group value);
                /*0x108d7e0*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item);
                /*0x108d830*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear();
                /*0x108d880*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item);
                /*0x108d8e0*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item);
                /*0x108db70*/ int System.Collections.IList.Add(object value);
                /*0x108dbc0*/ void System.Collections.IList.Clear();
                /*0x108dc10*/ bool System.Collections.IList.Contains(object value);
                /*0x108dd50*/ int System.Collections.IList.IndexOf(object value);
                /*0x108de20*/ void System.Collections.IList.Insert(int index, object value);
                /*0x3ce290*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x108dec0*/ void System.Collections.IList.Remove(object value);
                /*0x108de70*/ void System.Collections.IList.RemoveAt(int index);
                /*0x108db10*/ object System.Collections.IList.get_Item(int index);
                /*0x108df10*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.GroupCollection _collection;
                    /*0x18*/ int _index;

                    /*0xe2c3c0*/ Enumerator(System.Text.RegularExpressions.GroupCollection collection);
                    /*0x108c8a0*/ bool MoveNext();
                    /*0x108c930*/ System.Text.RegularExpressions.Group get_Current();
                    /*0x108c930*/ object System.Collections.IEnumerator.get_Current();
                    /*0xf64680*/ void System.Collections.IEnumerator.Reset();
                    /*0x32d010*/ void System.IDisposable.Dispose();
                }
            }

            class Match : System.Text.RegularExpressions.Group
            {
                static /*0x0*/ System.Text.RegularExpressions.Match <Empty>k__BackingField;
                /*0x40*/ System.Text.RegularExpressions.GroupCollection _groupcoll;
                /*0x48*/ System.Text.RegularExpressions.Regex _regex;
                /*0x50*/ int _textbeg;
                /*0x54*/ int _textpos;
                /*0x58*/ int _textend;
                /*0x5c*/ int _textstart;
                /*0x60*/ int[][] _matches;
                /*0x68*/ int[] _matchcount;
                /*0x70*/ bool _balancing;

                static /*0x10918f0*/ Match();
                static /*0x1091b60*/ System.Text.RegularExpressions.Match get_Empty();
                /*0x10919a0*/ Match(System.Text.RegularExpressions.Regex regex, int capcount, string text, int begpos, int len, int startpos);
                /*0x1091b30*/ Match();
                /*0x1091650*/ void Reset(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart);
                /*0x10915d0*/ System.Text.RegularExpressions.Match NextMatch();
                /*0x1091230*/ System.ReadOnlySpan<char> GroupToStringImpl(int groupnum);
                /*0x1091460*/ System.ReadOnlySpan<char> LastGroupToStringImpl();
                /*0x1090ee0*/ void AddMatch(int cap, int start, int len);
                /*0x10910e0*/ void BalanceMatch(int cap);
                /*0x1091620*/ void RemoveMatch(int cap);
                /*0x10913e0*/ bool IsMatched(int cap);
                /*0x10914b0*/ int MatchIndex(int cap);
                /*0x1091540*/ int MatchLength(int cap);
                /*0x1091700*/ void Tidy(int textpos);
            }

            class MatchSparse : System.Text.RegularExpressions.Match
            {
                /*0x78*/ System.Collections.Hashtable _caps;

                /*0x1090e30*/ MatchSparse(System.Text.RegularExpressions.Regex regex, System.Collections.Hashtable caps, int capcount, string text, int begpos, int len, int startpos);
            }

            class ExclusiveReference
            {
                /*0x10*/ System.Text.RegularExpressions.RegexRunner _ref;
                /*0x18*/ System.Text.RegularExpressions.RegexRunner _obj;
                /*0x20*/ int _locked;

                /*0x32f970*/ ExclusiveReference();
                /*0x108ca60*/ System.Text.RegularExpressions.RegexRunner Get();
                /*0x108cad0*/ void Release(System.Text.RegularExpressions.RegexRunner obj);
            }

            class Regex : System.Runtime.Serialization.ISerializable
            {
                static int CacheDictionarySwitchLimit = 10;
                static string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
                static int MaxOptionShift = 10;
                static /*0x0*/ int s_cacheSize;
                static /*0x8*/ System.Collections.Generic.Dictionary<System.Text.RegularExpressions.Regex.CachedCodeEntryKey, System.Text.RegularExpressions.Regex.CachedCodeEntry> s_cache;
                static /*0x10*/ int s_cacheCount;
                static /*0x18*/ System.Text.RegularExpressions.Regex.CachedCodeEntry s_cacheFirst;
                static /*0x20*/ System.Text.RegularExpressions.Regex.CachedCodeEntry s_cacheLast;
                static /*0x28*/ System.TimeSpan s_maximumMatchTimeout;
                static /*0x30*/ System.TimeSpan s_defaultMatchTimeout;
                static /*0x38*/ System.TimeSpan InfiniteMatchTimeout;
                /*0x10*/ System.TimeSpan internalMatchTimeout;
                /*0x18*/ string pattern;
                /*0x20*/ System.Text.RegularExpressions.RegexOptions roptions;
                /*0x28*/ System.Text.RegularExpressions.RegexRunnerFactory factory;
                /*0x30*/ System.Collections.Hashtable caps;
                /*0x38*/ System.Collections.Hashtable capnames;
                /*0x40*/ string[] capslist;
                /*0x48*/ int capsize;
                /*0x50*/ System.Text.RegularExpressions.ExclusiveReference _runnerref;
                /*0x58*/ System.WeakReference<System.Text.RegularExpressions.RegexReplacement> _replref;
                /*0x60*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x68*/ bool _refsInitialized;

                static /*0x10a04e0*/ Regex();
                static /*0x10a0250*/ bool TryGetCacheValue(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x10a0100*/ bool TryGetCacheValueSmall(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x109ef50*/ System.Text.RegularExpressions.Regex.CachedCodeEntry LookupCachedAndPromote(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key);
                static /*0x109eb90*/ bool IsMatch(string input, string pattern);
                static /*0x109ee20*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x109f670*/ System.Text.RegularExpressions.Match Match(string input, string pattern);
                static /*0x109f4c0*/ System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x109f970*/ string Replace(string input, string pattern, string replacement);
                static /*0x109f7d0*/ string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x10a0370*/ void ValidateMatchTimeout(System.TimeSpan matchTimeout);
                static /*0x109e870*/ System.TimeSpan InitDefaultMatchTimeout();
                /*0x10a0c20*/ Regex();
                /*0x10a0650*/ Regex(string pattern);
                /*0x10a0b90*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options);
                /*0x10a06d0*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout, bool addToCache);
                /*0x109e5d0*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCode(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x109def0*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCodeEntryInternal(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x109dde0*/ void FillCacheDictionary();
                /*0x109ecf0*/ bool IsMatch(string input);
                /*0x109ed90*/ bool IsMatch(string input, int startat);
                /*0x109f420*/ System.Text.RegularExpressions.Match Match(string input);
                /*0x109f5e0*/ System.Text.RegularExpressions.Match Match(string input, int startat);
                /*0x109fb50*/ string Replace(string input, string replacement);
                /*0x109fc80*/ string Replace(string input, string replacement, int count, int startat);
                /*0x10a00c0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context);
                /*0x10a0360*/ bool get_RightToLeft();
                /*0x32f410*/ string ToString();
                /*0x109e740*/ string GroupNameFromNumber(int i);
                /*0x109ea90*/ void InitializeReferences();
                /*0x109fda0*/ System.Text.RegularExpressions.Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat);
                /*0x10a0360*/ bool UseOptionR();
                /*0x10a0350*/ bool UseOptionInvariant();

                struct CachedCodeEntryKey : System.IEquatable<System.Text.RegularExpressions.Regex.CachedCodeEntryKey>
                {
                    /*0x10*/ System.Text.RegularExpressions.RegexOptions _options;
                    /*0x18*/ string _cultureKey;
                    /*0x20*/ string _pattern;

                    static /*0x108a7d0*/ bool op_Equality(System.Text.RegularExpressions.Regex.CachedCodeEntryKey left, System.Text.RegularExpressions.Regex.CachedCodeEntryKey right);
                    /*0x108a790*/ CachedCodeEntryKey(System.Text.RegularExpressions.RegexOptions options, string cultureKey, string pattern);
                    /*0x108a640*/ bool Equals(object obj);
                    /*0x108a5d0*/ bool Equals(System.Text.RegularExpressions.Regex.CachedCodeEntryKey other);
                    /*0x108a720*/ int GetHashCode();
                }

                class CachedCodeEntry
                {
                    /*0x10*/ System.Text.RegularExpressions.Regex.CachedCodeEntry Next;
                    /*0x18*/ System.Text.RegularExpressions.Regex.CachedCodeEntry Previous;
                    /*0x20*/ System.Text.RegularExpressions.Regex.CachedCodeEntryKey Key;
                    /*0x38*/ System.Text.RegularExpressions.RegexCode Code;
                    /*0x40*/ System.Collections.Hashtable Caps;
                    /*0x48*/ System.Collections.Hashtable Capnames;
                    /*0x50*/ string[] Capslist;
                    /*0x58*/ int Capsize;
                    /*0x60*/ System.Text.RegularExpressions.ExclusiveReference Runnerref;
                    /*0x68*/ System.WeakReference<System.Text.RegularExpressions.RegexReplacement> ReplRef;

                    /*0x108a850*/ CachedCodeEntry(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Collections.Hashtable capnames, string[] capslist, System.Text.RegularExpressions.RegexCode code, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref);
                }
            }

            class RegexBoyerMoore
            {
                /*0x10*/ int[] Positive;
                /*0x18*/ int[] NegativeASCII;
                /*0x20*/ int[][] NegativeUnicode;
                /*0x28*/ string Pattern;
                /*0x30*/ int LowASCII;
                /*0x34*/ int HighASCII;
                /*0x38*/ bool RightToLeft;
                /*0x39*/ bool CaseInsensitive;
                /*0x40*/ System.Globalization.CultureInfo _culture;

                /*0x10945c0*/ RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, System.Globalization.CultureInfo culture);
                /*0x1094150*/ bool MatchPattern(string text, int index);
                /*0x10940e0*/ bool IsMatch(string text, int index, int beglimit, int endlimit);
                /*0x1094290*/ int Scan(string text, int index, int beglimit, int endlimit);
            }

            class RegexCharClass
            {
                static /*0x0*/ string s_internalRegexIgnoreCase;
                static /*0x8*/ string s_space;
                static /*0x10*/ string s_notSpace;
                static /*0x18*/ string s_word;
                static /*0x20*/ string s_notWord;
                static /*0x28*/ string SpaceClass;
                static /*0x30*/ string NotSpaceClass;
                static /*0x38*/ string WordClass;
                static /*0x40*/ string NotWordClass;
                static /*0x48*/ string DigitClass;
                static /*0x50*/ string NotDigitClass;
                static /*0x58*/ System.Collections.Generic.Dictionary<string, string> s_definedCategories;
                static /*0x60*/ string[][] s_propTable;
                static /*0x68*/ System.Text.RegularExpressions.RegexCharClass.LowerCaseMapping[] s_lcTable;
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> _rangelist;
                /*0x18*/ System.Text.StringBuilder _categories;
                /*0x20*/ bool _canonical;
                /*0x21*/ bool _negate;
                /*0x28*/ System.Text.RegularExpressions.RegexCharClass _subtractor;

                static /*0x10970f0*/ RegexCharClass();
                static /*0x1096f20*/ char SingletonChar(string set);
                static /*0x10964b0*/ bool IsMergeable(string charClass);
                static /*0x10963d0*/ bool IsEmpty(string charClass);
                static /*0x10966f0*/ bool IsSingleton(string set);
                static /*0x10965b0*/ bool IsSingletonInverse(string set);
                static /*0x1096830*/ bool IsSubtraction(string charClass);
                static /*0x1096580*/ bool IsNegated(string set);
                static /*0x1096330*/ bool IsECMAWordChar(char ch);
                static /*0x1096890*/ bool IsWordChar(char ch);
                static /*0x1096270*/ bool CharInClass(char ch, string set);
                static /*0x1096140*/ bool CharInClassRecursive(char ch, string set, int start);
                static /*0x1095f40*/ bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x1095dd0*/ bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x1095d00*/ bool CharInCategoryGroup(char ch, System.Globalization.UnicodeCategory chcategory, string category, ref int i);
                static /*0x1096960*/ string NegateCategory(string category);
                static /*0x1096c40*/ System.Text.RegularExpressions.RegexCharClass Parse(string charClass);
                static /*0x10969f0*/ System.Text.RegularExpressions.RegexCharClass ParseRecursive(string charClass, int start);
                static /*0x1096cd0*/ string SetFromProperty(string capname, bool invert, string pattern);
                /*0x109dc80*/ RegexCharClass();
                /*0x109dd40*/ RegexCharClass(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, System.Text.StringBuilder categories, System.Text.RegularExpressions.RegexCharClass subtraction);
                /*0x109ddc0*/ bool get_CanMerge();
                /*0xff32d0*/ void set_Negate(bool value);
                /*0x1095000*/ void AddChar(char c);
                /*0x1094de0*/ void AddCharClass(System.Text.RegularExpressions.RegexCharClass cc);
                /*0x10955c0*/ void AddSet(string set);
                /*0x98b030*/ void AddSubtraction(System.Text.RegularExpressions.RegexCharClass sub);
                /*0x1095490*/ void AddRange(char first, char last);
                /*0x1094b30*/ void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern);
                /*0x1094dc0*/ void AddCategory(string category);
                /*0x1095320*/ void AddLowercase(System.Globalization.CultureInfo culture);
                /*0x10950c0*/ void AddLowercaseRange(char chMin, char chMax, System.Globalization.CultureInfo culture);
                /*0x1095970*/ void AddWord(bool ecma, bool negate);
                /*0x1095840*/ void AddSpace(bool ecma, bool negate);
                /*0x1095010*/ void AddDigit(bool ecma, bool negate, string pattern);
                /*0x1096c90*/ int RangeCount();
                /*0x1096f40*/ string ToStringClass();
                /*0x10962d0*/ System.Text.RegularExpressions.RegexCharClass.SingleRange GetRangeAt(int i);
                /*0x1095aa0*/ void Canonicalize();

                struct LowerCaseMapping
                {
                    /*0x10*/ char ChMin;
                    /*0x12*/ char ChMax;
                    /*0x14*/ int LcOp;
                    /*0x18*/ int Data;

                    /*0x10a4900*/ LowerCaseMapping(char chMin, char chMax, int lcOp, int data);
                }

                class SingleRangeComparer : System.Collections.Generic.IComparer<System.Text.RegularExpressions.RegexCharClass.SingleRange>
                {
                    static /*0x0*/ System.Text.RegularExpressions.RegexCharClass.SingleRangeComparer Instance;

                    static /*0x10b5780*/ SingleRangeComparer();
                    /*0x32f970*/ SingleRangeComparer();
                    /*0x10b5720*/ int Compare(System.Text.RegularExpressions.RegexCharClass.SingleRange x, System.Text.RegularExpressions.RegexCharClass.SingleRange y);
                }

                struct SingleRange
                {
                    /*0x10*/ char First;
                    /*0x12*/ char Last;

                    /*0xee74d0*/ SingleRange(char first, char last);
                }
            }

            class RegexCode
            {
                static int Onerep = 0;
                static int Notonerep = 1;
                static int Setrep = 2;
                static int Oneloop = 3;
                static int Notoneloop = 4;
                static int Setloop = 5;
                static int Onelazy = 6;
                static int Notonelazy = 7;
                static int Setlazy = 8;
                static int One = 9;
                static int Notone = 10;
                static int Set = 11;
                static int Multi = 12;
                static int Ref = 13;
                static int Bol = 14;
                static int Eol = 15;
                static int Boundary = 16;
                static int Nonboundary = 17;
                static int Beginning = 18;
                static int Start = 19;
                static int EndZ = 20;
                static int End = 21;
                static int Nothing = 22;
                static int Lazybranch = 23;
                static int Branchmark = 24;
                static int Lazybranchmark = 25;
                static int Nullcount = 26;
                static int Setcount = 27;
                static int Branchcount = 28;
                static int Lazybranchcount = 29;
                static int Nullmark = 30;
                static int Setmark = 31;
                static int Capturemark = 32;
                static int Getmark = 33;
                static int Setjump = 34;
                static int Backjump = 35;
                static int Forejump = 36;
                static int Testref = 37;
                static int Goto = 38;
                static int Prune = 39;
                static int Stop = 40;
                static int ECMABoundary = 41;
                static int NonECMABoundary = 42;
                static int Mask = 63;
                static int Rtl = 64;
                static int Back = 128;
                static int Back2 = 256;
                static int Ci = 512;
                /*0x10*/ int[] Codes;
                /*0x18*/ string[] Strings;
                /*0x20*/ int TrackCount;
                /*0x28*/ System.Collections.Hashtable Caps;
                /*0x30*/ int CapSize;
                /*0x38*/ System.Nullable<System.Text.RegularExpressions.RegexPrefix> FCPrefix;
                /*0x50*/ System.Text.RegularExpressions.RegexBoyerMoore BMPrefix;
                /*0x58*/ int Anchors;
                /*0x5c*/ bool RightToLeft;

                static /*0x10a4920*/ bool OpcodeBacktracks(int Op);
                /*0x10a4980*/ RegexCode(int[] codes, System.Collections.Generic.List<string> stringlist, int trackcount, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft);
            }

            struct RegexFCD
            {
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexFC> _fcStack;
                /*0x18*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x38*/ bool _skipAllChildren;
                /*0x39*/ bool _skipchild;
                /*0x3a*/ bool _failed;

                static /*0x10a5500*/ System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(System.Text.RegularExpressions.RegexTree t);
                static /*0x10a5b50*/ System.Text.RegularExpressions.RegexPrefix Prefix(System.Text.RegularExpressions.RegexTree tree);
                static /*0x10a4b00*/ int Anchors(System.Text.RegularExpressions.RegexTree tree);
                static /*0x10a4a80*/ int AnchorFromType(int type);
                /*0x10a6200*/ RegexFCD(System.Span<int> intStack);
                /*0x10a5f30*/ void PushInt(int i);
                /*0x10a5a10*/ bool IntIsEmpty();
                /*0x10a5b00*/ int PopInt();
                /*0x10a5e80*/ void PushFC(System.Text.RegularExpressions.RegexFC fc);
                /*0x10a54c0*/ bool FCIsEmpty();
                /*0x10a5a50*/ System.Text.RegularExpressions.RegexFC PopFC();
                /*0x10a61a0*/ System.Text.RegularExpressions.RegexFC TopFC();
                /*0x10a5480*/ void Dispose();
                /*0x10a5f80*/ System.Text.RegularExpressions.RegexFC RegexFCFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x10a6190*/ void SkipChild();
                /*0x10a4d70*/ void CalculateFC(int NodeType, System.Text.RegularExpressions.RegexNode node, int CurIndex);
            }

            class RegexFC
            {
                /*0x10*/ System.Text.RegularExpressions.RegexCharClass _cc;
                /*0x18*/ bool _nullable;
                /*0x19*/ bool <CaseInsensitive>k__BackingField;

                /*0x10a64d0*/ RegexFC(bool nullable);
                /*0x10a63d0*/ RegexFC(char ch, bool not, bool nullable, bool caseInsensitive);
                /*0x10a6550*/ RegexFC(string charClass, bool nullable, bool caseInsensitive);
                /*0x10a62d0*/ bool AddFC(System.Text.RegularExpressions.RegexFC fc, bool concatenate);
                /*0x10a65f0*/ bool get_CaseInsensitive();
                /*0x10a6600*/ void set_CaseInsensitive(bool value);
                /*0x10a6390*/ string GetFirstChars(System.Globalization.CultureInfo culture);
            }

            class RegexInterpreter : System.Text.RegularExpressions.RegexRunner
            {
                /*0x80*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x88*/ System.Globalization.CultureInfo _culture;
                /*0x90*/ int _operator;
                /*0x94*/ int _codepos;
                /*0x98*/ bool _rightToLeft;
                /*0x99*/ bool _caseInsensitive;

                /*0x10a9830*/ RegexInterpreter(System.Text.RegularExpressions.RegexCode code, System.Globalization.CultureInfo culture);
                /*0x10a8f40*/ void InitTrackCount();
                /*0x10a6610*/ void Advance(int i);
                /*0x10a8eb0*/ void Goto(int newpos);
                /*0xc6dab0*/ void Textto(int newpos);
                /*0x10a9810*/ void Trackto(int newpos);
                /*0x8a5c20*/ int Textstart();
                /*0x3e3ae0*/ int Textpos();
                /*0x10a97f0*/ int Trackpos();
                /*0x10a97b0*/ void TrackPush();
                /*0x10a9740*/ void TrackPush(int I1);
                /*0x10a96b0*/ void TrackPush(int I1, int I2);
                /*0x10a9600*/ void TrackPush(int I1, int I2, int I3);
                /*0x10a9590*/ void TrackPush2(int I1);
                /*0x10a9500*/ void TrackPush2(int I1, int I2);
                /*0x10a6690*/ void Backtrack();
                /*0x10a91b0*/ void SetOperator(int op);
                /*0x10a94e0*/ void TrackPop();
                /*0x10a94f0*/ void TrackPop(int framesize);
                /*0x10a94b0*/ int TrackPeek();
                /*0x10a9470*/ int TrackPeek(int i);
                /*0x10a92d0*/ void StackPush(int I1);
                /*0x10a9270*/ void StackPush(int I1, int I2);
                /*0x10a9250*/ void StackPop();
                /*0x10a9260*/ void StackPop(int framesize);
                /*0x10a91e0*/ int StackPeek();
                /*0x10a9210*/ int StackPeek(int i);
                /*0xa5b590*/ int Operator();
                /*0x10a8f80*/ int Operand(int i);
                /*0x10a8f70*/ int Leftchars();
                /*0x10a91a0*/ int Rightchars();
                /*0x10a6790*/ int Bump();
                /*0x10a6cd0*/ int Forwardchars();
                /*0x10a6c30*/ char Forwardcharnext();
                /*0x10a9310*/ bool Stringmatch(string str);
                /*0x10a8fd0*/ bool Refmatch(int index, int len);
                /*0x10a6770*/ void Backwardnext();
                /*0x10a67b0*/ char CharAt(int j);
                /*0x10a67d0*/ bool FindFirstChar();
                /*0x10a6cf0*/ void Go();
            }

            class RegexMatchTimeoutException : System.TimeoutException, System.Runtime.Serialization.ISerializable
            {
                /*0x90*/ string <Input>k__BackingField;
                /*0x98*/ string <Pattern>k__BackingField;
                /*0xa0*/ System.TimeSpan <MatchTimeout>k__BackingField;

                /*0x10a9980*/ RegexMatchTimeoutException(string regexInput, string regexPattern, System.TimeSpan matchTimeout);
                /*0x10a9c20*/ RegexMatchTimeoutException();
                /*0x10a9aa0*/ RegexMatchTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x10a9890*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x7378b0*/ string get_Input();
                /*0x9c7a50*/ string get_Pattern();
                /*0xec32e0*/ System.TimeSpan get_MatchTimeout();
            }

            class RegexNode
            {
                /*0x10*/ int NType;
                /*0x18*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode> Children;
                /*0x20*/ string Str;
                /*0x28*/ char Ch;
                /*0x2c*/ int M;
                /*0x30*/ int N;
                /*0x34*/ System.Text.RegularExpressions.RegexOptions Options;
                /*0x38*/ System.Text.RegularExpressions.RegexNode Next;

                /*0x10ab000*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options);
                /*0x10ab040*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, char ch);
                /*0x10aaf10*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, string str);
                /*0x10aaf60*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m);
                /*0x10aafb0*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m, int n);
                /*0x10aaf00*/ bool UseOptionR();
                /*0x10aada0*/ System.Text.RegularExpressions.RegexNode ReverseLeft();
                /*0x10a9fd0*/ void MakeRep(int type, int min, int max);
                /*0x10aab60*/ System.Text.RegularExpressions.RegexNode Reduce();
                /*0x10aae10*/ System.Text.RegularExpressions.RegexNode StripEnation(int emptyType);
                /*0x10aa7d0*/ System.Text.RegularExpressions.RegexNode ReduceGroup();
                /*0x10aa840*/ System.Text.RegularExpressions.RegexNode ReduceRep();
                /*0x10aaa00*/ System.Text.RegularExpressions.RegexNode ReduceSet();
                /*0x10a9fe0*/ System.Text.RegularExpressions.RegexNode ReduceAlternation();
                /*0x10aa3f0*/ System.Text.RegularExpressions.RegexNode ReduceConcatenation();
                /*0x10a9ec0*/ System.Text.RegularExpressions.RegexNode MakeQuantifier(bool lazy, int min, int max);
                /*0x10a9ce0*/ void AddChild(System.Text.RegularExpressions.RegexNode newChild);
                /*0x10a9e60*/ System.Text.RegularExpressions.RegexNode Child(int i);
                /*0x10a9e10*/ int ChildCount();
                /*0x417e30*/ int Type();
            }

            enum RegexOptions
            {
                None = 0,
                IgnoreCase = 1,
                Multiline = 2,
                ExplicitCapture = 4,
                Compiled = 8,
                Singleline = 16,
                IgnorePatternWhitespace = 32,
                RightToLeft = 64,
                ECMAScript = 256,
                CultureInvariant = 512,
            }

            class RegexParser
            {
                static /*0x0*/ byte[] s_category;
                /*0x10*/ System.Text.RegularExpressions.RegexNode _stack;
                /*0x18*/ System.Text.RegularExpressions.RegexNode _group;
                /*0x20*/ System.Text.RegularExpressions.RegexNode _alternation;
                /*0x28*/ System.Text.RegularExpressions.RegexNode _concatenation;
                /*0x30*/ System.Text.RegularExpressions.RegexNode _unit;
                /*0x38*/ string _pattern;
                /*0x40*/ int _currentPos;
                /*0x48*/ System.Globalization.CultureInfo _culture;
                /*0x50*/ int _autocap;
                /*0x54*/ int _capcount;
                /*0x58*/ int _captop;
                /*0x5c*/ int _capsize;
                /*0x60*/ System.Collections.Hashtable _caps;
                /*0x68*/ System.Collections.Hashtable _capnames;
                /*0x70*/ int[] _capnumlist;
                /*0x78*/ System.Collections.Generic.List<string> _capnamelist;
                /*0x80*/ System.Text.RegularExpressions.RegexOptions _options;
                /*0x88*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexOptions> _optionsStack;
                /*0x90*/ bool _ignoreNextParen;

                static /*0x10b1930*/ RegexParser();
                static /*0x10ad360*/ System.Text.RegularExpressions.RegexTree Parse(string re, System.Text.RegularExpressions.RegexOptions op);
                static /*0x10ad1c0*/ System.Text.RegularExpressions.RegexReplacement ParseReplacement(string rep, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions op);
                static /*0x10ac730*/ int HexDigit(char ch);
                static /*0x10acf50*/ System.Text.RegularExpressions.RegexOptions OptionFromCode(char ch);
                static /*0x10ac960*/ bool IsSpecial(char ch);
                static /*0x10ac9e0*/ bool IsStopperX(char ch);
                static /*0x10ac860*/ bool IsQuantifier(char ch);
                static /*0x10ac8e0*/ bool IsSpace(char ch);
                /*0x10b19c0*/ RegexParser(System.Globalization.CultureInfo culture);
                /*0x10b1710*/ void SetPattern(string Re);
                /*0x10ad920*/ void Reset(System.Text.RegularExpressions.RegexOptions topopts);
                /*0x10b0d10*/ System.Text.RegularExpressions.RegexNode ScanRegex();
                /*0x10b15a0*/ System.Text.RegularExpressions.RegexNode ScanReplacement();
                /*0x10aeb20*/ System.Text.RegularExpressions.RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly);
                /*0x10afda0*/ System.Text.RegularExpressions.RegexNode ScanGroupOpen();
                /*0x10ae6c0*/ void ScanBlank();
                /*0x10ada50*/ System.Text.RegularExpressions.RegexNode ScanBackslash(bool scanOnly);
                /*0x10ae000*/ System.Text.RegularExpressions.RegexNode ScanBasicBackslash(bool scanOnly);
                /*0x10af970*/ System.Text.RegularExpressions.RegexNode ScanDollar();
                /*0x10aea60*/ string ScanCapname();
                /*0x10b0b70*/ char ScanOctal();
                /*0x10af8b0*/ int ScanDecimal();
                /*0x10b0a50*/ char ScanHex(int c);
                /*0x10af7e0*/ char ScanControl();
                /*0x10ac840*/ bool IsOnlyTopOption(System.Text.RegularExpressions.RegexOptions option);
                /*0x10b0c10*/ void ScanOptions();
                /*0x10af410*/ char ScanCharEscape();
                /*0x10acff0*/ string ParseProperty();
                /*0x10b1850*/ int TypeFromCode(char ch);
                /*0x10ac1c0*/ void CountCaptures();
                /*0x10acdf0*/ void NoteCaptureSlot(int i, int pos);
                /*0x10acc80*/ void NoteCaptureName(string name, int pos);
                /*0x10acf00*/ void NoteCaptures(System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames);
                /*0x10aba10*/ void AssignNameSlots();
                /*0x10ac0f0*/ int CaptureSlotFromName(string capname);
                /*0x10ac7a0*/ bool IsCaptureSlot(int i);
                /*0x10ac770*/ bool IsCaptureName(string capname);
                /*0x10b1900*/ bool UseOptionN();
                /*0x10b18e0*/ bool UseOptionI();
                /*0x10b18f0*/ bool UseOptionM();
                /*0x10b1910*/ bool UseOptionS();
                /*0x10b1920*/ bool UseOptionX();
                /*0x10b18d0*/ bool UseOptionE();
                /*0x10aca60*/ bool IsTrueQuantifier();
                /*0x10ab340*/ void AddConcatenate(int pos, int cch, bool isReplacement);
                /*0x10ad800*/ void PushGroup();
                /*0x10ad5d0*/ void PopGroup();
                /*0x10ac720*/ bool EmptyStack();
                /*0x10b1780*/ void StartGroup(System.Text.RegularExpressions.RegexNode openGroup);
                /*0x10ab090*/ void AddAlternate();
                /*0x10ab300*/ void AddConcatenate();
                /*0x10ab1c0*/ void AddConcatenate(bool lazy, int min, int max);
                /*0x997630*/ System.Text.RegularExpressions.RegexNode Unit();
                /*0x10ab810*/ void AddUnitOne(char ch);
                /*0x10ab730*/ void AddUnitNotone(char ch);
                /*0x10ab8f0*/ void AddUnitSet(string cc);
                /*0x997640*/ void AddUnitNode(System.Text.RegularExpressions.RegexNode node);
                /*0x10ab990*/ void AddUnitType(int type);
                /*0x10ab560*/ void AddGroup();
                /*0x10ad880*/ void PushOptions();
                /*0x10ad760*/ void PopOptions();
                /*0x10ac6d0*/ bool EmptyOptionsStack();
                /*0x10ad700*/ void PopKeepOptions();
                /*0x10acbe0*/ System.ArgumentException MakeException(string message);
                /*0xbe6be0*/ int Textpos();
                /*0xbe6cc0*/ void Textto(int pos);
                /*0x10ad9c0*/ char RightCharMoveRight();
                /*0x401f20*/ void MoveRight();
                /*0x10acc70*/ void MoveRight(int i);
                /*0x10acc60*/ void MoveLeft();
                /*0x10ac180*/ char CharAt(int i);
                /*0x10ad9f0*/ char RightChar();
                /*0x10ada20*/ char RightChar(int i);
                /*0x10ac1a0*/ int CharsRight();
            }

            struct RegexPrefix
            {
                static /*0x0*/ System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField;
                /*0x10*/ bool <CaseInsensitive>k__BackingField;
                /*0x18*/ string <Prefix>k__BackingField;

                static /*0x10b1a90*/ RegexPrefix();
                static /*0x10b1b50*/ System.Text.RegularExpressions.RegexPrefix get_Empty();
                /*0x10b1b20*/ RegexPrefix(string prefix, bool ci);
                /*0xbad660*/ bool get_CaseInsensitive();
                /*0xa5a7f0*/ string get_Prefix();
            }

            class RegexReplacement
            {
                static int Specials = 4;
                static int LeftPortion = -1;
                static int RightPortion = -2;
                static int LastGroup = -3;
                static int WholeString = -4;
                /*0x10*/ System.Collections.Generic.List<string> _strings;
                /*0x18*/ System.Collections.Generic.List<int> _rules;
                /*0x20*/ string <Pattern>k__BackingField;

                static /*0x10b1bb0*/ System.Text.RegularExpressions.RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions roptions);
                /*0x10b2890*/ RegexReplacement(string rep, System.Text.RegularExpressions.RegexNode concat, System.Collections.Hashtable _caps);
                /*0x61a260*/ string get_Pattern();
                /*0x10b26d0*/ void ReplacementImpl(System.Text.StringBuilder sb, System.Text.RegularExpressions.Match match);
                /*0x10b24f0*/ void ReplacementImplRTL(System.Collections.Generic.List<string> al, System.Text.RegularExpressions.Match match);
                /*0x10b1e10*/ string Replace(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
            }

            class RegexRunner
            {
                static int TimeoutCheckFrequency = 1000;
                /*0x10*/ int runtextbeg;
                /*0x14*/ int runtextend;
                /*0x18*/ int runtextstart;
                /*0x20*/ string runtext;
                /*0x28*/ int runtextpos;
                /*0x30*/ int[] runtrack;
                /*0x38*/ int runtrackpos;
                /*0x40*/ int[] runstack;
                /*0x48*/ int runstackpos;
                /*0x50*/ int[] runcrawl;
                /*0x58*/ int runcrawlpos;
                /*0x5c*/ int runtrackcount;
                /*0x60*/ System.Text.RegularExpressions.Match runmatch;
                /*0x68*/ System.Text.RegularExpressions.Regex runregex;
                /*0x70*/ int _timeout;
                /*0x74*/ bool _ignoreTimeout;
                /*0x78*/ int _timeoutOccursAt;
                /*0x7c*/ int _timeoutChecksToSkip;

                /*0x32f970*/ RegexRunner();
                /*0x10b3920*/ System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, System.TimeSpan timeout);
                /*0x10b3c90*/ void StartTimeoutWatch();
                /*0x10b2d90*/ void CheckTimeout();
                /*0x10b2f80*/ void DoCheckTimeout();
                /*0x180fc0*/ void Go();
                /*0x17cb40*/ bool FindFirstChar();
                /*0x180fc0*/ void InitTrackCount();
                /*0x10b33c0*/ void InitMatch();
                /*0x10b3cc0*/ System.Text.RegularExpressions.Match TidyMatch(bool quick);
                /*0x10b3270*/ void EnsureStorage();
                /*0x10b3670*/ bool IsBoundary(int index, int startpos, int endpos);
                /*0x10b3760*/ bool IsECMABoundary(int index, int startpos, int endpos);
                /*0x10b31c0*/ void DoubleTrack();
                /*0x10b3110*/ void DoubleStack();
                /*0x10b3060*/ void DoubleCrawl();
                /*0x10b2e70*/ void Crawl(int i);
                /*0x10b38e0*/ int Popcrawl();
                /*0x10b2f60*/ int Crawlpos();
                /*0x10b2d00*/ void Capture(int capnum, int start, int end);
                /*0x10b3d30*/ void TransferCapture(int capnum, int uncapnum, int start, int end);
                /*0x10b3e60*/ void Uncapture();
                /*0x10b3850*/ bool IsMatched(int cap);
                /*0x10b3880*/ int MatchIndex(int cap);
                /*0x10b38b0*/ int MatchLength(int cap);
            }

            class RegexRunnerFactory
            {
                /*0x32f970*/ RegexRunnerFactory();
                /*0x1803b0*/ System.Text.RegularExpressions.RegexRunner CreateInstance();
            }

            class RegexTree
            {
                /*0x10*/ System.Text.RegularExpressions.RegexNode Root;
                /*0x18*/ System.Collections.Hashtable Caps;
                /*0x20*/ int[] CapNumList;
                /*0x28*/ int CapTop;
                /*0x30*/ System.Collections.Hashtable CapNames;
                /*0x38*/ string[] CapsList;
                /*0x40*/ System.Text.RegularExpressions.RegexOptions Options;

                /*0x10b3eb0*/ RegexTree(System.Text.RegularExpressions.RegexNode root, System.Collections.Hashtable caps, int[] capNumList, int capTop, System.Collections.Hashtable capNames, string[] capsList, System.Text.RegularExpressions.RegexOptions options);
            }

            struct RegexWriter
            {
                /*0x10*/ System.Collections.Generic.ValueListBuilder<int> _emitted;
                /*0x30*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x50*/ System.Collections.Generic.Dictionary<string, int> _stringHash;
                /*0x58*/ System.Collections.Generic.List<string> _stringTable;
                /*0x60*/ System.Collections.Hashtable _caps;
                /*0x68*/ int _trackCount;

                static /*0x10b5380*/ System.Text.RegularExpressions.RegexCode Write(System.Text.RegularExpressions.RegexTree tree);
                /*0x10b55e0*/ RegexWriter(System.Span<int> emittedSpan, System.Span<int> intStackSpan);
                /*0x10b3f50*/ void Dispose();
                /*0x10b4c60*/ System.Text.RegularExpressions.RegexCode RegexCodeFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x10b4c00*/ void PatchJump(int offset, int jumpDest);
                /*0x10b49b0*/ void Emit(int op);
                /*0x10b48f0*/ void Emit(int op, int opd1);
                /*0x10b4a50*/ void Emit(int op, int opd1, int opd2);
                /*0x10b5280*/ int StringCode(string str);
                /*0x10b4b30*/ int MapCapnum(int capnum);
                /*0x10b3fa0*/ void EmitFragment(int nodetype, System.Text.RegularExpressions.RegexNode node, int curIndex);
            }
        }
    }

    namespace CodeDom
    {
        namespace Compiler
        {
            class GeneratedCodeAttribute : System.Attribute
            {
                /*0x10*/ string tool;
                /*0x18*/ string version;

                /*0xea2f90*/ GeneratedCodeAttribute(string tool, string version);
            }
        }
    }

    namespace Diagnostics
    {
        class AsyncStreamReader
        {
            /*0x10*/ System.IO.Stream stream;
            /*0x18*/ System.Text.Encoding encoding;
            /*0x20*/ System.Text.Decoder decoder;
            /*0x28*/ byte[] byteBuffer;
            /*0x30*/ char[] charBuffer;
            /*0x38*/ bool cancelOperation;
            /*0x40*/ System.Threading.ManualResetEvent eofEvent;
            /*0x48*/ object syncObject;
            /*0x50*/ System.IAsyncResult asyncReadResult;

            /*0xf240d0*/ void Close();
            /*0x10b6c50*/ void Dispose(bool disposing);
            /*0x10b6c40*/ void CancelOperation();
        }

        class Process : System.ComponentModel.Component
        {
            /*0x28*/ bool haveProcessId;
            /*0x2c*/ int processId;
            /*0x30*/ bool haveProcessHandle;
            /*0x38*/ Microsoft.Win32.SafeHandles.SafeProcessHandle m_processHandle;
            /*0x40*/ bool isRemoteMachine;
            /*0x48*/ string machineName;
            /*0x50*/ int m_processAccess;
            /*0x58*/ System.Diagnostics.ProcessThreadCollection threads;
            /*0x60*/ System.Diagnostics.ProcessModuleCollection modules;
            /*0x68*/ bool haveWorkingSetLimits;
            /*0x69*/ bool havePriorityClass;
            /*0x70*/ System.Diagnostics.ProcessStartInfo startInfo;
            /*0x78*/ bool watchForExit;
            /*0x79*/ bool watchingForExit;
            /*0x80*/ System.EventHandler onExited;
            /*0x88*/ bool exited;
            /*0x8c*/ int exitCode;
            /*0x90*/ bool signaled;
            /*0x91*/ bool haveExitTime;
            /*0x92*/ bool raisedOnExited;
            /*0x98*/ System.Threading.RegisteredWaitHandle registeredWaitHandle;
            /*0xa0*/ System.Threading.WaitHandle waitHandle;
            /*0xa8*/ System.ComponentModel.ISynchronizeInvoke synchronizingObject;
            /*0xb0*/ System.IO.StreamReader standardOutput;
            /*0xb8*/ System.IO.StreamWriter standardInput;
            /*0xc0*/ System.IO.StreamReader standardError;
            /*0xc8*/ bool disposed;
            /*0xcc*/ System.Diagnostics.Process.StreamReadMode outputStreamReadMode;
            /*0xd0*/ System.Diagnostics.Process.StreamReadMode errorStreamReadMode;
            /*0xd4*/ System.Diagnostics.Process.StreamReadMode inputStreamReadMode;
            /*0xd8*/ System.Diagnostics.AsyncStreamReader output;
            /*0xe0*/ System.Diagnostics.AsyncStreamReader error;
            /*0xe8*/ string process_name;

            static /*0x10bdb40*/ System.Diagnostics.Process GetCurrentProcess();
            static /*0x10bfd00*/ System.Diagnostics.Process Start(string fileName);
            static /*0x10bfa50*/ System.Diagnostics.Process Start(System.Diagnostics.ProcessStartInfo startInfo);
            static /*0x10be290*/ string ProcessName_icall(nint handle);
            static /*0x10be2a0*/ string ProcessName_internal(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            static /*0xed1490*/ bool ShellExecuteEx_internal(System.Diagnostics.ProcessStartInfo startInfo, ref System.Diagnostics.Process.ProcInfo procInfo);
            static /*0xed1490*/ bool CreateProcess_internal(System.Diagnostics.ProcessStartInfo startInfo, nint stdin, nint stdout, nint stderr, ref System.Diagnostics.Process.ProcInfo procInfo);
            static /*0x10bd2e0*/ void CreatePipe(ref nint read, ref nint write, bool writeDirection);
            static /*0x10c0510*/ bool get_IsWindows();
            static /*0x10bd9e0*/ void FillUserInfo(System.Diagnostics.ProcessStartInfo startInfo, ref System.Diagnostics.Process.ProcInfo procInfo);
            /*0x10bff90*/ Process();
            /*0x10c0020*/ Process(string machineName, bool isRemoteMachine, int processId, System.Diagnostics.ProcessInfo processInfo);
            /*0x10c00c0*/ bool get_Associated();
            /*0x10c01b0*/ bool get_HasExited();
            /*0x10c00d0*/ nint get_Handle();
            /*0x10c07a0*/ System.Diagnostics.ProcessStartInfo get_StartInfo();
            /*0x10c0a30*/ void set_StartInfo(System.Diagnostics.ProcessStartInfo value);
            /*0x10c0870*/ System.ComponentModel.ISynchronizeInvoke get_SynchronizingObject();
            /*0x10be470*/ void ReleaseProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle handle);
            /*0x10bd2c0*/ void CompletionCallback(object context, bool wasSignaled);
            /*0x10bd5e0*/ void Dispose(bool disposing);
            /*0x10bd090*/ void Close();
            /*0x10bd630*/ void EnsureState(System.Diagnostics.Process.State state);
            /*0x10bd8b0*/ void EnsureWatchingForExit();
            /*0x10bdf70*/ void OnExited();
            /*0x10bdc10*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access, bool throwIfExited);
            /*0x10bdf60*/ Microsoft.Win32.SafeHandles.SafeProcessHandle GetProcessHandle(int access);
            /*0x10be1d0*/ Microsoft.Win32.SafeHandles.SafeProcessHandle OpenProcessHandle(int access);
            /*0x10be420*/ void Refresh();
            /*0x10be490*/ void SetProcessHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle);
            /*0x10be4d0*/ void SetProcessId(int processId);
            /*0x10bf8b0*/ bool Start();
            /*0x10bfd70*/ void StopWatchingForExit();
            /*0x10bfe80*/ string ToString();
            /*0x10c0550*/ string get_ProcessName();
            /*0x10bf440*/ bool StartWithShellExecuteEx(System.Diagnostics.ProcessStartInfo startInfo);
            /*0x10be4e0*/ bool StartWithCreateProcess(System.Diagnostics.ProcessStartInfo startInfo);
            /*0x10be370*/ void RaiseOnExited();

            enum StreamReadMode
            {
                undefined = 0,
                syncMode = 1,
                asyncMode = 2,
            }

            enum State
            {
                HaveId = 1,
                IsLocal = 2,
                IsNt = 4,
                HaveProcessInfo = 8,
                Exited = 16,
                Associated = 32,
                IsWin2k = 64,
                HaveNtProcessInfo = 12,
            }

            struct ProcInfo
            {
                /*0x10*/ nint process_handle;
                /*0x18*/ int pid;
                /*0x20*/ string[] envVariables;
                /*0x28*/ string UserName;
                /*0x30*/ string Domain;
                /*0x38*/ nint Password;
                /*0x40*/ bool LoadUserProfile;
            }
        }

        class ProcessInfo
        {
        }

        class ProcessModuleCollection : System.Collections.ReadOnlyCollectionBase
        {
        }

        class ProcessStartInfo
        {
            static /*0x0*/ string[] empty;
            /*0x10*/ string fileName;
            /*0x18*/ string arguments;
            /*0x20*/ string directory;
            /*0x28*/ string verb;
            /*0x30*/ System.Diagnostics.ProcessWindowStyle windowStyle;
            /*0x34*/ bool errorDialog;
            /*0x38*/ nint errorDialogParentHandle;
            /*0x40*/ bool useShellExecute;
            /*0x48*/ string userName;
            /*0x50*/ string domain;
            /*0x58*/ System.Security.SecureString password;
            /*0x60*/ string passwordInClearText;
            /*0x68*/ bool loadUserProfile;
            /*0x69*/ bool redirectStandardInput;
            /*0x6a*/ bool redirectStandardOutput;
            /*0x6b*/ bool redirectStandardError;
            /*0x70*/ System.Text.Encoding standardOutputEncoding;
            /*0x78*/ System.Text.Encoding standardErrorEncoding;
            /*0x80*/ bool createNoWindow;
            /*0x88*/ System.WeakReference weakParentProcess;
            /*0x90*/ System.Collections.Specialized.StringDictionary environmentVariables;
            /*0x98*/ System.Collections.ObjectModel.Collection<string> _argumentList;
            /*0xa0*/ System.Collections.Generic.IDictionary<string, string> environment;
            /*0xa8*/ System.Text.Encoding <StandardInputEncoding>k__BackingField;

            static /*0x10bc820*/ ProcessStartInfo();
            /*0x10bc8d0*/ ProcessStartInfo(System.Diagnostics.Process parent);
            /*0x10bc890*/ ProcessStartInfo(string fileName);
            /*0x10bc960*/ System.Collections.ObjectModel.Collection<string> get_ArgumentList();
            /*0x10bc9f0*/ string get_Arguments();
            /*0x7963c0*/ void set_Arguments(string value);
            /*0x10bca90*/ System.Collections.Specialized.StringDictionary get_EnvironmentVariables();
            /*0x10b58f0*/ bool get_RedirectStandardInput();
            /*0x10b5900*/ bool get_RedirectStandardOutput();
            /*0x10b58e0*/ bool get_RedirectStandardError();
            /*0xecb7b0*/ System.Text.Encoding get_StandardErrorEncoding();
            /*0xd184b0*/ System.Text.Encoding get_StandardOutputEncoding();
            /*0xb61dd0*/ bool get_UseShellExecute();
            /*0x10bcf90*/ string get_UserName();
            /*0xb61940*/ System.Security.SecureString get_Password();
            /*0x10bca40*/ string get_Domain();
            /*0xe7e580*/ bool get_LoadUserProfile();
            /*0x10bcf30*/ string get_FileName();
            /*0x10bcfe0*/ string get_WorkingDirectory();
            /*0x10bcf80*/ bool get_HaveEnvVars();
            /*0xbf2ca0*/ System.Text.Encoding get_StandardInputEncoding();
        }

        class ProcessThreadCollection : System.Collections.ReadOnlyCollectionBase
        {
        }

        class ProcessWaitHandle : System.Threading.WaitHandle
        {
            /*0x10bd030*/ ProcessWaitHandle(Microsoft.Win32.SafeHandles.SafeProcessHandle processHandle);
        }

        class MonitoringDescriptionAttribute : System.ComponentModel.DescriptionAttribute
        {
            /*0x10ba290*/ MonitoringDescriptionAttribute(string description);
            /*0x73d3e0*/ string get_Description();
        }

        enum ProcessWindowStyle
        {
            Hidden = 1,
            Maximized = 3,
            Minimized = 2,
            Normal = 0,
        }

        class Stopwatch
        {
            static /*0x0*/ long Frequency;
            static /*0x8*/ bool IsHighResolution;
            /*0x10*/ long elapsed;
            /*0x18*/ long started;
            /*0x20*/ bool is_running;

            static /*0x10c10e0*/ Stopwatch();
            static /*0xfeda40*/ long GetTimestamp();
            /*0x32f970*/ Stopwatch();
            /*0x10c1490*/ System.TimeSpan get_Elapsed();
            /*0x10c1130*/ long get_ElapsedMilliseconds();
            /*0x10c1420*/ long get_ElapsedTicks();
            /*0x10c1000*/ void Start();
            /*0x10c1060*/ void Stop();
        }

        namespace CodeAnalysis
        {
            class ExcludeFromCodeCoverageAttribute : System.Attribute
            {
                /*0x534220*/ ExcludeFromCodeCoverageAttribute();
            }
        }
    }

    namespace Security
    {
        namespace Cryptography
        {
            class Oid
            {
                /*0x10*/ string _value;
                /*0x18*/ string _friendlyName;
                /*0x20*/ System.Security.Cryptography.OidGroup _group;

                /*0x10baaf0*/ Oid(string oid);
                /*0xce3b90*/ Oid(string value, string friendlyName);
                /*0x10baa50*/ Oid(System.Security.Cryptography.Oid oid);
                /*0x73d3e0*/ string get_Value();
                /*0x9f12f0*/ void set_Value(string value);
            }

            class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.Oid> _list;

                /*0x10ba850*/ OidCollection();
                /*0x10ba4c0*/ int Add(System.Security.Cryptography.Oid oid);
                /*0x10ba910*/ System.Security.Cryptography.Oid get_Item(int index);
                /*0x10ba8d0*/ int get_Count();
                /*0x10ba5a0*/ System.Security.Cryptography.OidEnumerator GetEnumerator();
                /*0x10ba5a0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x10ba610*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x348b00*/ bool get_IsSynchronized();
                /*0x621ca0*/ object get_SyncRoot();
            }

            class OidEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Security.Cryptography.OidCollection _oids;
                /*0x18*/ int _current;

                /*0xe2c3c0*/ OidEnumerator(System.Security.Cryptography.OidCollection oids);
                /*0x10ba9f0*/ System.Security.Cryptography.Oid get_Current();
                /*0x10ba9f0*/ object System.Collections.IEnumerator.get_Current();
                /*0x10ba970*/ bool MoveNext();
                /*0xf64680*/ void Reset();
            }

            enum OidGroup
            {
                All = 0,
                HashAlgorithm = 1,
                EncryptionAlgorithm = 2,
                PublicKeyAlgorithm = 3,
                SignatureAlgorithm = 4,
                Attribute = 5,
                ExtensionOrAttribute = 6,
                EnhancedKeyUsage = 7,
                Policy = 8,
                Template = 9,
                KeyDerivationFunction = 10,
            }

            enum AsnDecodeStatus
            {
                NotDecoded = -1,
                Ok = 0,
                BadAsn = 1,
                BadTag = 2,
                BadLength = 3,
                InformationNotAvailable = 4,
            }

            class AsnEncodedData
            {
                /*0x10*/ System.Security.Cryptography.Oid _oid;
                /*0x18*/ byte[] _raw;

                /*0x32f970*/ AsnEncodedData();
                /*0x10b6a90*/ void set_Oid(System.Security.Cryptography.Oid value);
                /*0x32f410*/ byte[] get_RawData();
                /*0x10b6b40*/ void set_RawData(byte[] value);
                /*0x10b5a80*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x10b67d0*/ string ToString(bool multiLine);
                /*0x10b5bc0*/ string Default(bool multiLine);
                /*0x10b5910*/ string BasicConstraintsExtension(bool multiLine);
                /*0x10b5cf0*/ string EnhancedKeyUsageExtension(bool multiLine);
                /*0x10b5e60*/ string KeyUsageExtension(bool multiLine);
                /*0x10b6660*/ string SubjectKeyIdentifierExtension(bool multiLine);
                /*0x10b6380*/ string SubjectAltName(bool multiLine);
                /*0x10b5fd0*/ string NetscapeCertType(bool multiLine);
            }

            namespace X509Certificates
            {
                enum X509KeyUsageFlags
                {
                    None = 0,
                    EncipherOnly = 1,
                    CrlSign = 2,
                    KeyCertSign = 4,
                    KeyAgreement = 8,
                    DataEncipherment = 16,
                    KeyEncipherment = 32,
                    NonRepudiation = 64,
                    DigitalSignature = 128,
                    DecipherOnly = 32768,
                }

                enum X509SubjectKeyIdentifierHashAlgorithm
                {
                    Sha1 = 0,
                    ShortSha1 = 1,
                    CapiSha1 = 2,
                }

                class PublicKey
                {
                    static /*0x0*/ byte[] Empty;
                    /*0x10*/ System.Security.Cryptography.AsnEncodedData _keyValue;
                    /*0x18*/ System.Security.Cryptography.AsnEncodedData _params;
                    /*0x20*/ System.Security.Cryptography.Oid _oid;

                    static /*0x10c0b00*/ PublicKey();
                    /*0x73d3e0*/ System.Security.Cryptography.AsnEncodedData get_EncodedKeyValue();
                    /*0x32f410*/ System.Security.Cryptography.AsnEncodedData get_EncodedParameters();
                    /*0x61a260*/ System.Security.Cryptography.Oid get_Oid();
                }

                class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.19";
                    static string friendlyName = "Basic Constraints";
                    /*0x28*/ bool _certificateAuthority;
                    /*0x29*/ bool _hasPathLengthConstraint;
                    /*0x2c*/ int _pathLengthConstraint;
                    /*0x30*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x10c3140*/ X509BasicConstraintsExtension();
                    /*0x10c3200*/ X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical);
                    /*0x10c2eb0*/ X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical);
                    /*0x10c3310*/ bool get_CertificateAuthority();
                    /*0x10c3380*/ bool get_HasPathLengthConstraint();
                    /*0x10c33f0*/ int get_PathLengthConstraint();
                    /*0x10c2730*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x10c2960*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x10c2ad0*/ byte[] Encode();
                    /*0x10c2c50*/ string ToString(bool multiLine);
                }

                class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    /*0x28*/ System.Security.Cryptography.OidCollection _enhKeyUsage;
                    /*0x30*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x10c3d00*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical);
                    /*0x10c3460*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x10c3690*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x10c39d0*/ string ToString(bool multiLine);
                }

                class X509Extension : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ bool _critical;

                    /*0x32f970*/ X509Extension();
                    /*0x796120*/ bool get_Critical();
                    /*0x7963b0*/ void set_Critical(bool value);
                    /*0x10c3e10*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x10c4000*/ string FormatUnkownData(byte[] data);
                }

                class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.15";
                    static string friendlyName = "Key Usage";
                    static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags all = 33023;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags _keyUsages;
                    /*0x2c*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x10c4d30*/ X509KeyUsageExtension();
                    /*0x10c4b20*/ X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical);
                    /*0x10c4c30*/ X509KeyUsageExtension(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, bool critical);
                    /*0x10c4df0*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags get_KeyUsages();
                    /*0x10c4100*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x10c4600*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags GetValidFlags(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags flags);
                    /*0x10c4330*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x10c4490*/ byte[] Encode();
                    /*0x10c4610*/ string ToString(bool multiLine);
                }

                class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.14";
                    static string friendlyName = "Subject Key Identifier";
                    /*0x28*/ byte[] _subjectKeyIdentifier;
                    /*0x30*/ string _ski;
                    /*0x38*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    static /*0x10c5260*/ byte FromHexChar(char c);
                    static /*0x10c5290*/ byte FromHexChars(char c1, char c2);
                    static /*0x10c5310*/ byte[] FromHex(string hex);
                    /*0x10c6180*/ X509SubjectKeyIdentifierExtension();
                    /*0x10c5b60*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical);
                    /*0x10c5c70*/ X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical);
                    /*0x10c5e90*/ X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical);
                    /*0x10c5b40*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, bool critical);
                    /*0x10c56f0*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical);
                    /*0x10c6240*/ string get_SubjectKeyIdentifier();
                    /*0x10c4e60*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x10c5090*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x10c51e0*/ byte[] Encode();
                    /*0x10c54a0*/ string ToString(bool multiLine);
                }
            }
        }
    }

    namespace ComponentModel
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object _value;

            /*0x10b7d30*/ DefaultValueAttribute(bool value);
            /*0xa32e30*/ DefaultValueAttribute(string value);
            /*0x73d3e0*/ object get_Value();
            /*0x10b7c00*/ bool Equals(object obj);
            /*0x10b79f0*/ int GetHashCode();
        }

        class EditorBrowsableAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.EditorBrowsableState browsableState;

            /*0xea4040*/ EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState state);
            /*0x10b8650*/ bool Equals(object obj);
            /*0x10b79f0*/ int GetHashCode();
        }

        enum EditorBrowsableState
        {
            Always = 0,
            Never = 1,
            Advanced = 2,
        }

        class BrowsableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.BrowsableAttribute Yes;
            static /*0x8*/ System.ComponentModel.BrowsableAttribute No;
            static /*0x10*/ System.ComponentModel.BrowsableAttribute Default;
            /*0x10*/ bool <Browsable>k__BackingField;

            static /*0x10b7070*/ BrowsableAttribute();
            /*0xe2bcb0*/ BrowsableAttribute(bool browsable);
            /*0x793eb0*/ bool get_Browsable();
            /*0x10b6f50*/ bool Equals(object obj);
            /*0x10b7010*/ int GetHashCode();
        }

        class DescriptionAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DescriptionAttribute Default;
            /*0x10*/ string <DescriptionValue>k__BackingField;

            static /*0x10b7eb0*/ DescriptionAttribute();
            /*0x10b7f60*/ DescriptionAttribute();
            /*0xa32e30*/ DescriptionAttribute(string description);
            /*0x73d3e0*/ string get_Description();
            /*0x73d3e0*/ string get_DescriptionValue();
            /*0x9f12f0*/ void set_DescriptionValue(string value);
            /*0x10b7da0*/ bool Equals(object obj);
            /*0x10b7e70*/ int GetHashCode();
        }

        class DesignerCategoryAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignerCategoryAttribute Component;
            static /*0x8*/ System.ComponentModel.DesignerCategoryAttribute Default;
            static /*0x10*/ System.ComponentModel.DesignerCategoryAttribute Form;
            static /*0x18*/ System.ComponentModel.DesignerCategoryAttribute Generic;
            /*0x10*/ string <Category>k__BackingField;

            static /*0x10b8040*/ DesignerCategoryAttribute();
            /*0x10b8230*/ DesignerCategoryAttribute();
            /*0xa32e30*/ DesignerCategoryAttribute(string category);
            /*0x73d3e0*/ string get_Category();
            /*0x10b7fc0*/ bool Equals(object obj);
            /*0xe77c60*/ int GetHashCode();
        }

        enum DesignerSerializationVisibility
        {
            Hidden = 0,
            Visible = 1,
            Content = 2,
        }

        class DesignerSerializationVisibilityAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DesignerSerializationVisibilityAttribute Content;
            static /*0x8*/ System.ComponentModel.DesignerSerializationVisibilityAttribute Hidden;
            static /*0x10*/ System.ComponentModel.DesignerSerializationVisibilityAttribute Visible;
            static /*0x18*/ System.ComponentModel.DesignerSerializationVisibilityAttribute Default;
            /*0x10*/ System.ComponentModel.DesignerSerializationVisibility <Visibility>k__BackingField;

            static /*0x10b8350*/ DesignerSerializationVisibilityAttribute();
            /*0xea4040*/ DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility visibility);
            /*0x417e30*/ System.ComponentModel.DesignerSerializationVisibility get_Visibility();
            /*0x10b8290*/ bool Equals(object obj);
            /*0x10b79f0*/ int GetHashCode();
        }

        class EventHandlerList
        {
            /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _head;
            /*0x18*/ System.ComponentModel.Component _parent;

            /*0x10b86f0*/ System.Delegate get_Item(object key);
            /*0x10b86d0*/ System.ComponentModel.EventHandlerList.ListEntry Find(object key);

            class ListEntry
            {
                /*0x10*/ System.ComponentModel.EventHandlerList.ListEntry _next;
                /*0x18*/ object _key;
                /*0x20*/ System.Delegate _handler;
            }
        }

        interface IContainer : System.IDisposable
        {
            /*0x17aec0*/ void Remove(System.ComponentModel.IComponent component);
        }

        interface ISite : System.IServiceProvider
        {
            /*0x1803b0*/ System.ComponentModel.IContainer get_Container();
            /*0x17cb40*/ bool get_DesignMode();
            /*0x1803b0*/ string get_Name();
        }

        interface ISynchronizeInvoke
        {
            /*0x17cb40*/ bool get_InvokeRequired();
            /*0x177730*/ System.IAsyncResult BeginInvoke(System.Delegate method, object[] args);
        }

        class ArrayConverter : System.ComponentModel.CollectionConverter
        {
            /*0x32f970*/ ArrayConverter();
        }

        class BaseNumberConverter : System.ComponentModel.TypeConverter
        {
            /*0x32f970*/ BaseNumberConverter();
        }

        class BooleanConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.ComponentModel.TypeConverter.StandardValuesCollection s_values;

            /*0x32f970*/ BooleanConverter();
        }

        class DecimalConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x32f970*/ DecimalConverter();
        }

        class DefaultEventAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultEventAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x10b7a00*/ DefaultEventAttribute();
            /*0xa32e30*/ DefaultEventAttribute(string name);
            /*0x73d3e0*/ string get_Name();
            /*0x10b7980*/ bool Equals(object obj);
            /*0x10b79f0*/ int GetHashCode();
        }

        class DefaultPropertyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.DefaultPropertyAttribute Default;
            /*0x10*/ string <Name>k__BackingField;

            static /*0x10b7af0*/ DefaultPropertyAttribute();
            /*0xa32e30*/ DefaultPropertyAttribute(string name);
            /*0x73d3e0*/ string get_Name();
            /*0x10b7a80*/ bool Equals(object obj);
            /*0x10b79f0*/ int GetHashCode();
        }

        class DoubleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x32f970*/ DoubleConverter();
        }

        class EditorAttribute : System.Attribute
        {
            /*0x10*/ string <EditorBaseTypeName>k__BackingField;
            /*0x18*/ string <EditorTypeName>k__BackingField;

            /*0x10b85a0*/ EditorAttribute(string typeName, string baseTypeName);
            /*0x73d3e0*/ string get_EditorBaseTypeName();
            /*0x32f410*/ string get_EditorTypeName();
            /*0x10b84f0*/ bool Equals(object obj);
            /*0x10b79f0*/ int GetHashCode();
        }

        class ExpandableObjectConverter : System.ComponentModel.TypeConverter
        {
            /*0x32f970*/ ExpandableObjectConverter();
        }

        class Int16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x32f970*/ Int16Converter();
        }

        class Int32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x32f970*/ Int32Converter();
        }

        class Int64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x32f970*/ Int64Converter();
        }

        class ReferenceConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ string s_none;
            /*0x10*/ System.Type _type;

            static /*0x10c0c40*/ ReferenceConverter();
            /*0x49b490*/ ReferenceConverter(System.Type type);
        }

        class SettingsBindableAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.SettingsBindableAttribute Yes;
            static /*0x8*/ System.ComponentModel.SettingsBindableAttribute No;
            /*0x10*/ bool <Bindable>k__BackingField;

            static /*0x10c0e80*/ SettingsBindableAttribute();
            /*0xe2bcb0*/ SettingsBindableAttribute(bool bindable);
            /*0x793eb0*/ bool get_Bindable();
            /*0x10c0d80*/ bool Equals(object obj);
            /*0x10c0e20*/ int GetHashCode();
        }

        class SingleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x32f970*/ SingleConverter();
        }

        class StringConverter : System.ComponentModel.TypeConverter
        {
            /*0x32f970*/ StringConverter();
        }

        class TimeSpanConverter : System.ComponentModel.TypeConverter
        {
            /*0x32f970*/ TimeSpanConverter();
        }

        class TypeConverterAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.TypeConverterAttribute Default;
            /*0x10*/ string <ConverterTypeName>k__BackingField;

            static /*0x10c17b0*/ TypeConverterAttribute();
            /*0x10c18c0*/ TypeConverterAttribute();
            /*0x10c1860*/ TypeConverterAttribute(System.Type type);
            /*0xa32e30*/ TypeConverterAttribute(string typeName);
            /*0x73d3e0*/ string get_ConverterTypeName();
            /*0x10c1740*/ bool Equals(object obj);
            /*0xe77c60*/ int GetHashCode();
        }

        class CollectionConverter : System.ComponentModel.TypeConverter
        {
            /*0x32f970*/ CollectionConverter();
        }

        class Component : System.MarshalByRefObject, System.ComponentModel.IComponent, System.IDisposable
        {
            static /*0x0*/ object EventDisposed;
            /*0x18*/ System.ComponentModel.ISite site;
            /*0x20*/ System.ComponentModel.EventHandlerList events;

            static /*0x10b7820*/ Component();
            /*0x32f970*/ Component();
            /*0x10b7600*/ void Finalize();
            /*0x3ce290*/ bool get_CanRaiseEvents();
            /*0xedfd70*/ bool get_CanRaiseEventsInternal();
            /*0x32f410*/ System.ComponentModel.ISite get_Site();
            /*0x10b72f0*/ void Dispose();
            /*0x10b7360*/ void Dispose(bool disposing);
            /*0x10b7670*/ object GetService(System.Type service);
            /*0x10b78a0*/ bool get_DesignMode();
            /*0x10b7730*/ string ToString();
        }

        class ComponentConverter : System.ComponentModel.ReferenceConverter
        {
            /*0x10b7280*/ ComponentConverter(System.Type type);
        }

        class EnumConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;
            /*0x18*/ System.Type type;

            /*0xe78ae0*/ EnumConverter(System.Type type);
        }

        interface IComponent : System.IDisposable
        {
        }

        class TypeConverter
        {
            static string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
            static /*0x0*/ bool useCompatibleTypeConversion;

            /*0x32f970*/ TypeConverter();

            class StandardValuesCollection
            {
            }
        }

        class Win32Exception : System.Runtime.InteropServices.ExternalException, System.Runtime.Serialization.ISerializable
        {
            /*0x90*/ int nativeErrorCode;

            static /*0x10c1a10*/ string GetErrorMessage(int error);
            /*0x10c25c0*/ Win32Exception();
            /*0x10c26f0*/ Win32Exception(int error);
            /*0x10c26c0*/ Win32Exception(int error, string message);
            /*0x10c2630*/ Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x10c24f0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class NotifyParentPropertyAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.NotifyParentPropertyAttribute Yes;
            static /*0x8*/ System.ComponentModel.NotifyParentPropertyAttribute No;
            static /*0x10*/ System.ComponentModel.NotifyParentPropertyAttribute Default;
            /*0x10*/ bool notifyParent;

            static /*0x10ba3d0*/ NotifyParentPropertyAttribute();
            /*0xe2bcb0*/ NotifyParentPropertyAttribute(bool notifyParent);
            /*0x793eb0*/ bool get_NotifyParent();
            /*0x10ba330*/ bool Equals(object obj);
            /*0x10b79f0*/ int GetHashCode();
        }

        namespace Design
        {
            interface IDesignerHost : System.IServiceProvider
            {
                /*0x1803b0*/ System.ComponentModel.IComponent get_RootComponent();
            }

            namespace Serialization
            {
                class RootDesignerSerializerAttribute : System.Attribute
                {
                    /*0x10*/ bool <Reloadable>k__BackingField;
                    /*0x18*/ string <SerializerTypeName>k__BackingField;
                    /*0x20*/ string <SerializerBaseTypeName>k__BackingField;

                    /*0x10c0cb0*/ RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable);
                }
            }
        }
    }

    namespace Collections
    {
        class HashtableExtensions
        {
            static /*0x17f7b0*/ bool TryGetValue<T>(System.Collections.Hashtable table, object key, ref T value);
        }

        namespace Specialized
        {
            class OrderedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                /*0x10*/ System.Collections.ArrayList _objectsArray;
                /*0x18*/ System.Collections.Hashtable _objectsTable;
                /*0x20*/ int _initialCapacity;
                /*0x28*/ System.Collections.IEqualityComparer _comparer;
                /*0x30*/ bool _readOnly;
                /*0x38*/ object _syncRoot;
                /*0x40*/ System.Runtime.Serialization.SerializationInfo _siInfo;

                /*0x10bc210*/ OrderedDictionary();
                /*0x10bc190*/ OrderedDictionary(int capacity);
                /*0x10bc1d0*/ OrderedDictionary(System.Collections.IEqualityComparer comparer);
                /*0x10bc240*/ OrderedDictionary(int capacity, System.Collections.IEqualityComparer comparer);
                /*0xa10ec0*/ OrderedDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x10bc280*/ int get_Count();
                /*0x995050*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x995050*/ bool get_IsReadOnly();
                /*0x348b00*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x10bc300*/ System.Collections.ICollection get_Keys();
                /*0x10bc400*/ System.Collections.ArrayList get_objectsArray();
                /*0x10bc480*/ System.Collections.Hashtable get_objectsTable();
                /*0x10bc060*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x10bc2c0*/ object get_Item(object key);
                /*0x10bc510*/ void set_Item(object key, object value);
                /*0x10bc380*/ System.Collections.ICollection get_Values();
                /*0x10bb510*/ void Add(object key, object value);
                /*0x10bb640*/ void Clear();
                /*0x10bb6f0*/ bool Contains(object key);
                /*0x10bb730*/ void CopyTo(System.Array array, int index);
                /*0x10bba00*/ int IndexOfKey(object key);
                /*0x10bbf20*/ void Remove(object key);
                /*0x10bb780*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x10bc0d0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x10bb820*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x10bc170*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                /*0x10bbb70*/ void OnDeserialization(object sender);

                class OrderedDictionaryEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ int _objectReturnType;
                    /*0x18*/ System.Collections.IEnumerator _arrayEnumerator;

                    /*0x10bac20*/ OrderedDictionaryEnumerator(System.Collections.ArrayList array, int objectReturnType);
                    /*0x10bac90*/ object get_Current();
                    /*0x10baea0*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x10bafb0*/ object get_Key();
                    /*0x10bb040*/ object get_Value();
                    /*0x10bab80*/ bool MoveNext();
                    /*0x10babd0*/ void Reset();
                }

                class OrderedDictionaryKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _objects;
                    /*0x18*/ bool _isKeys;

                    /*0xf18a30*/ OrderedDictionaryKeyValueCollection(System.Collections.ArrayList array, bool isKeys);
                    /*0x10bb0d0*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x10bb410*/ int System.Collections.ICollection.get_Count();
                    /*0x348b00*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x10bb440*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x10bb470*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class StringDictionary : System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Hashtable contents;

                /*0x10b7210*/ StringDictionary();
                /*0x10c1630*/ void Add(string key, string value);
                /*0x10c16d0*/ System.Collections.IEnumerator GetEnumerator();
            }

            class CaseSensitiveStringDictionary : System.Collections.Specialized.StringDictionary
            {
                /*0x10b7210*/ CaseSensitiveStringDictionary();
                /*0x10b7180*/ void Add(string key, string value);
            }
        }

        namespace Generic
        {
            struct ValueListBuilder<T>
            {
                /*0x0*/ System.Span<T> _span;
                /*0x0*/ T[] _arrayFromPool;
                /*0x0*/ int _pos;

                /*0x2a5510*/ ValueListBuilder(System.Span<T> initialSpan);
                /*0x180980*/ int get_Length();
                /*0x184ab0*/ ref T get_Item(int index);
                /*0x2a5510*/ void Append(T item);
                /*0x2a5510*/ System.ReadOnlySpan<T> AsSpan();
                /*0x180fc0*/ void Dispose();
                /*0x180fc0*/ void Grow();
                /*0x2a5510*/ T Pop();
            }

            class ICollectionDebugView<T>
            {
            }

            class IDictionaryDebugView<K, V>
            {
            }

            class DictionaryKeyCollectionDebugView<TKey, TValue>
            {
            }

            class DictionaryValueCollectionDebugView<TKey, TValue>
            {
            }

            class LinkedList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> head;
                /*0x0*/ int count;
                /*0x0*/ int version;
                /*0x0*/ object _syncRoot;
                /*0x0*/ System.Runtime.Serialization.SerializationInfo _siInfo;

                /*0x180fc0*/ LinkedList();
                LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x180980*/ int get_Count();
                /*0x1803b0*/ System.Collections.Generic.LinkedListNode<T> get_First();
                /*0x17cb40*/ bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                /*0x2a5510*/ void System.Collections.Generic.ICollection<T>.Add(T value);
                /*0x2a5510*/ System.Collections.Generic.LinkedListNode<T> AddLast(T value);
                /*0x180fc0*/ void Clear();
                /*0x2a5510*/ bool Contains(T value);
                /*0x182a70*/ void CopyTo(T[] array, int index);
                /*0x2a5510*/ System.Collections.Generic.LinkedListNode<T> Find(T value);
                /*0x2a5510*/ System.Collections.Generic.LinkedList.Enumerator<T> GetEnumerator();
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x2a5510*/ bool Remove(T value);
                /*0x17aec0*/ void Remove(System.Collections.Generic.LinkedListNode<T> node);
                /*0x180fc0*/ void RemoveFirst();
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x17aec0*/ void OnDeserialization(object sender);
                /*0x183150*/ void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x17aec0*/ void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode);
                /*0x17aec0*/ void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x17aec0*/ void ValidateNode(System.Collections.Generic.LinkedListNode<T> node);
                /*0x17cb40*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1803b0*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x182a70*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    /*0x0*/ System.Collections.Generic.LinkedList<T> _list;
                    /*0x0*/ System.Collections.Generic.LinkedListNode<T> _node;
                    /*0x0*/ int _version;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    /*0x17aec0*/ Enumerator(System.Collections.Generic.LinkedList<T> list);
                    Enumerator(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x2a5510*/ T get_Current();
                    /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x17cb40*/ bool MoveNext();
                    /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                    /*0x180fc0*/ void Dispose();
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x17aec0*/ void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                }
            }

            class LinkedListNode<T>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<T> list;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> next;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> prev;
                /*0x0*/ T item;

                /*0x2a5510*/ LinkedListNode(System.Collections.Generic.LinkedList<T> list, T value);
                /*0x1803b0*/ System.Collections.Generic.LinkedListNode<T> get_Next();
                /*0x2a5510*/ T get_Value();
                /*0x180fc0*/ void Invalidate();
            }

            class SortedList<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                /*0x0*/ TKey[] keys;
                /*0x0*/ TValue[] values;
                /*0x0*/ int _size;
                /*0x0*/ int version;
                /*0x0*/ System.Collections.Generic.IComparer<TKey> comparer;
                /*0x0*/ System.Collections.Generic.SortedList.KeyList<TKey, TValue> keyList;
                /*0x0*/ System.Collections.Generic.SortedList.ValueList<TKey, TValue> valueList;
                /*0x0*/ object _syncRoot;

                static /*0x177700*/ bool IsCompatibleKey(object key);
                /*0x180fc0*/ SortedList();
                /*0x17aa40*/ SortedList(int capacity);
                /*0x2a5510*/ void Add(TKey key, TValue value);
                /*0x2a5510*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x2a5510*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x2a5510*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                /*0x17aa40*/ void set_Capacity(int value);
                /*0x183150*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x180980*/ int get_Count();
                /*0x1803b0*/ System.Collections.Generic.IList<TKey> get_Keys();
                /*0x1803b0*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x1803b0*/ System.Collections.Generic.IList<TValue> get_Values();
                /*0x1803b0*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x1803b0*/ System.Collections.Generic.SortedList.KeyList<TKey, TValue> GetKeyListHelper();
                /*0x1803b0*/ System.Collections.Generic.SortedList.ValueList<TKey, TValue> GetValueListHelper();
                /*0x17cb40*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                /*0x17cb40*/ bool System.Collections.IDictionary.get_IsReadOnly();
                /*0x17cb40*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x17cb40*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1803b0*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x180fc0*/ void Clear();
                /*0x17e620*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x2a5510*/ bool ContainsKey(TKey key);
                /*0x2a5510*/ bool ContainsValue(TValue value);
                /*0x182a70*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x182a70*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x17aa40*/ void EnsureCapacity(int min);
                /*0x2a5510*/ TValue GetByIndex(int index);
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                /*0x1803b0*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x2a5510*/ TKey GetKey(int index);
                /*0x2a5510*/ void set_Item(TKey key, TValue value);
                /*0x1858d0*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x183150*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x2a5510*/ int IndexOfKey(TKey key);
                /*0x2a5510*/ int IndexOfValue(TValue value);
                /*0x2a5510*/ void Insert(int index, TKey key, TValue value);
                /*0x2a5510*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x17aa40*/ void RemoveAt(int index);
                /*0x2a5510*/ bool Remove(TKey key);
                /*0x17aec0*/ void System.Collections.IDictionary.Remove(object key);

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ TKey _key;
                    /*0x0*/ TValue _value;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ int _getEnumeratorRetType;

                    /*0x182a70*/ Enumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList, int getEnumeratorRetType);
                    /*0x180fc0*/ void Dispose();
                    /*0x1803b0*/ object System.Collections.IDictionaryEnumerator.get_Key();
                    /*0x17cb40*/ bool MoveNext();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                    /*0x2a5510*/ System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1803b0*/ object System.Collections.IDictionaryEnumerator.get_Value();
                    /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                }

                class SortedListKeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TKey _currentKey;

                    /*0x17aec0*/ SortedListKeyEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    /*0x180fc0*/ void Dispose();
                    /*0x17cb40*/ bool MoveNext();
                    /*0x2a5510*/ TKey get_Current();
                    /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                }

                class SortedListValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TValue _currentValue;

                    /*0x17aec0*/ SortedListValueEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    /*0x180fc0*/ void Dispose();
                    /*0x17cb40*/ bool MoveNext();
                    /*0x2a5510*/ TValue get_Current();
                    /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                }

                class KeyList<TKey, TValue> : System.Collections.Generic.IList<TKey>, System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    /*0x17aec0*/ KeyList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    /*0x180980*/ int get_Count();
                    /*0x17cb40*/ bool get_IsReadOnly();
                    /*0x17cb40*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x1803b0*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x2a5510*/ void Add(TKey key);
                    /*0x180fc0*/ void Clear();
                    /*0x2a5510*/ bool Contains(TKey key);
                    /*0x182a70*/ void CopyTo(TKey[] array, int arrayIndex);
                    /*0x182a70*/ void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                    /*0x2a5510*/ void Insert(int index, TKey value);
                    /*0x2a5510*/ TKey get_Item(int index);
                    /*0x2a5510*/ void set_Item(int index, TKey value);
                    /*0x1803b0*/ System.Collections.Generic.IEnumerator<TKey> GetEnumerator();
                    /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x2a5510*/ int IndexOf(TKey key);
                    /*0x2a5510*/ bool Remove(TKey key);
                    /*0x17aa40*/ void RemoveAt(int index);
                }

                class ValueList<TKey, TValue> : System.Collections.Generic.IList<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    /*0x17aec0*/ ValueList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    /*0x180980*/ int get_Count();
                    /*0x17cb40*/ bool get_IsReadOnly();
                    /*0x17cb40*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x1803b0*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x2a5510*/ void Add(TValue key);
                    /*0x180fc0*/ void Clear();
                    /*0x2a5510*/ bool Contains(TValue value);
                    /*0x182a70*/ void CopyTo(TValue[] array, int arrayIndex);
                    /*0x182a70*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x2a5510*/ void Insert(int index, TValue value);
                    /*0x2a5510*/ TValue get_Item(int index);
                    /*0x2a5510*/ void set_Item(int index, TValue value);
                    /*0x1803b0*/ System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                    /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x2a5510*/ int IndexOf(TValue value);
                    /*0x2a5510*/ bool Remove(TValue value);
                    /*0x17aa40*/ void RemoveAt(int index);
                }
            }

            interface ISet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
            }
        }
    }

    namespace Net
    {
        class IPAddress
        {
            static long LoopbackMask = 255;
            static int NumberOfLabels = 8;
            static /*0x0*/ System.Net.IPAddress Any;
            static /*0x8*/ System.Net.IPAddress Loopback;
            static /*0x10*/ System.Net.IPAddress Broadcast;
            static /*0x18*/ System.Net.IPAddress None;
            static /*0x20*/ System.Net.IPAddress IPv6Any;
            static /*0x28*/ System.Net.IPAddress IPv6Loopback;
            static /*0x30*/ System.Net.IPAddress IPv6None;
            /*0x10*/ uint _addressOrScopeId;
            /*0x18*/ ushort[] _numbers;
            /*0x20*/ string _toString;
            /*0x28*/ int _hashCode;

            static /*0x10b9ae0*/ IPAddress();
            static /*0x10b9a30*/ byte[] ThrowAddressNullException();
            /*0x10b9f40*/ IPAddress(long newAddress);
            /*0x10b9ea0*/ IPAddress(byte[] address, long scopeid);
            /*0x10b9fe0*/ IPAddress(System.ReadOnlySpan<byte> address, long scopeid);
            /*0x10ba1e0*/ bool get_IsIPv4();
            /*0xfd8400*/ bool get_IsIPv6();
            /*0x417e30*/ uint get_PrivateAddress();
            /*0x10ba1f0*/ void set_PrivateAddress(uint value);
            /*0x417e30*/ uint get_PrivateScopeId();
            /*0x10ba1f0*/ void set_PrivateScopeId(uint value);
            /*0x10ba1c0*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x10b9a80*/ string ToString();
            /*0x10b9460*/ bool Equals(object comparandObj, bool compareScopeId);
            /*0x10b9350*/ bool Equals(object comparand);
            /*0x10b95a0*/ int GetHashCode();

            class ReadOnlyIPAddress : System.Net.IPAddress
            {
                /*0x10c0b70*/ ReadOnlyIPAddress(long newAddress);
            }
        }

        class IPAddressParser
        {
            static /*0x10b8db0*/ string IPv4AddressToString(uint address);
            static /*0x10b8e10*/ void IPv4AddressToString(uint address, System.Text.StringBuilder destination);
            static /*0x10b8b60*/ int IPv4AddressToStringHelper(uint address, char* addressString);
            static /*0x10b9330*/ string IPv6AddressToString(ushort[] address, uint scopeId);
            static /*0x10b8e80*/ System.Text.StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId);
            static /*0x10b8aa0*/ void FormatIPv4AddressNumber(int number, char* addressString, ref int offset);
            static /*0x10b8870*/ void AppendSections(ushort[] address, int fromInclusive, int toExclusive, System.Text.StringBuilder buffer);
            static /*0x10b87c0*/ void AppendHex(ushort value, System.Text.StringBuilder buffer);
            static /*0x10b8a50*/ uint ExtractIPv4Address(ushort[] address);
            static /*0xf0cd50*/ ushort Reverse(ushort number);
        }

        namespace Sockets
        {
            enum AddressFamily
            {
                Unknown = -1,
                Unspecified = 0,
                Unix = 1,
                InterNetwork = 2,
                ImpLink = 3,
                Pup = 4,
                Chaos = 5,
                NS = 6,
                Ipx = 6,
                Iso = 7,
                Osi = 7,
                Ecma = 8,
                DataKit = 9,
                Ccitt = 10,
                Sna = 11,
                DecNet = 12,
                DataLink = 13,
                Lat = 14,
                HyperChannel = 15,
                AppleTalk = 16,
                NetBios = 17,
                VoiceView = 18,
                FireFox = 19,
                Banyan = 21,
                Atm = 22,
                InterNetworkV6 = 23,
                Cluster = 24,
                Ieee12844 = 25,
                Irda = 26,
                NetworkDesigners = 28,
                Max = 29,
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5;
    static /*0x20*/ long 1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B;
    static /*0x28*/ <PrivateImplementationDetails> 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70;
    static /*0x48*/ <PrivateImplementationDetails> B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C;
    static /*0xc8*/ <PrivateImplementationDetails> E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A;

    static /*0xf36e20*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=10
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=128
    {
    }
}

namespace System
{
    namespace Configuration
    {
        interface IConfigurationSectionHandler
        {
        }
    }

    namespace Net
    {
        namespace Configuration
        {
            class BypassElement : System.Configuration.ConfigurationElement
            {
            }

            class BypassElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x10b7150*/ BypassElementCollection();
            }

            class ConnectionManagementElement : System.Configuration.ConfigurationElement
            {
            }

            class ConnectionManagementElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x10b78f0*/ ConnectionManagementElementCollection();
            }

            class ConnectionManagementSection : System.Configuration.ConfigurationSection
            {
                /*0x10b7920*/ ConnectionManagementSection();
                /*0x10b7950*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class DefaultProxySection : System.Configuration.ConfigurationSection
            {
                /*0x10b7ba0*/ DefaultProxySection();
                /*0x10b7bd0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
                /*0x10b7b70*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            }

            class ProxyElement : System.Configuration.ConfigurationElement
            {
                /*0x10c0aa0*/ ProxyElement();
                /*0x10c0ad0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class HttpWebRequestElement : System.Configuration.ConfigurationElement
            {
                /*0x10b8760*/ HttpWebRequestElement();
                /*0x10b8790*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class Ipv6Element : System.Configuration.ConfigurationElement
            {
                /*0x10ba230*/ Ipv6Element();
                /*0x10ba260*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class NetSectionGroup : System.Configuration.ConfigurationSectionGroup
            {
                /*0x10ba300*/ NetSectionGroup();
            }

            class SettingsSection : System.Configuration.ConfigurationSection
            {
                /*0x10c0f40*/ SettingsSection();
                /*0x10c0f70*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class PerformanceCountersElement : System.Configuration.ConfigurationElement
            {
                /*0x10bc7c0*/ PerformanceCountersElement();
                /*0x10bc7f0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class ServicePointManagerElement : System.Configuration.ConfigurationElement
            {
                /*0x10c0d20*/ ServicePointManagerElement();
                /*0x10c0d50*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class SocketElement : System.Configuration.ConfigurationElement
            {
                /*0x10c0fa0*/ SocketElement();
                /*0x10c0fd0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebProxyScriptElement : System.Configuration.ConfigurationElement
            {
                /*0x10c1920*/ WebProxyScriptElement();
                /*0x10c1950*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModulesSection : System.Configuration.ConfigurationSection
            {
                /*0x10c19b0*/ WebRequestModulesSection();
                /*0x10c19e0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModuleElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x10c1980*/ WebRequestModuleElementCollection();
            }

            class WebRequestModuleElement : System.Configuration.ConfigurationElement
            {
            }
        }
    }

    namespace Diagnostics
    {
        class DiagnosticsConfigurationHandler : System.Configuration.IConfigurationSectionHandler
        {
            /*0x10b84c0*/ DiagnosticsConfigurationHandler();
            /*0x10b8490*/ object Create(object parent, object configContext, System.Xml.XmlNode section);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x10c1700*/ void ThrowNotSupportedException();
    }
}
