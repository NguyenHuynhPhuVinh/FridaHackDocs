class <Module>
{
}

namespace Yeti
{
    interface IYetiLogger
    {
    }

    enum LogCategory
    {
        None = 0,
        System = 2,
        Boot = 4,
        Network = 8,
        GameService = 16,
        Assets = 32,
        Audio = 64,
        Gameplay = 128,
        Localization = 256,
        Ui = 512,
        Social = 1024,
        Mtx = 2048,
        Nimble = 4096,
        Notifications = 8192,
        Telemetry = 16384,
        Automation = 32768,
        Editor = 65536,
        Navigation = 131072,
        Pvp = 262144,
        Deeplink = 524288,
        Store = 1048576,
        Initializer = 2097152,
        Performance = 4194304,
        External = 8388608,
        EadpSdk = 16777216,
        All = 2147483647,
    }

    class YetiLog
    {
        static /*0x0*/ PopCap.Logging.ILogger Logger;

        static /*0x4107028*/ YetiLog();
        static /*0x4106920*/ PopCap.Logging.ILogger CreateYetiLogger();
        static /*0x4106b64*/ void SetLevel(PopCap.Logging.LogLevel logLevel);
        static /*0x4106c38*/ void SetLevel(Yeti.LogCategory category, PopCap.Logging.LogLevel logLevel);
        static /*0x4106d48*/ void UnsetLevel(Yeti.LogCategory category);
        static /*0x4106e50*/ PopCap.Logging.LogLevel GetLevel();
        static /*0x4106f18*/ void Super(Yeti.LogCategory category, string message);
    }
}
