class <Module>
{
}

namespace PopCap
{
    namespace Logging
    {
        interface IChunkedLogOutputHandler : PopCap.Logging.ILogOutputHandler
        {
        }

        interface ILogFormatter
        {
            /*0x1f2ffc8*/ int get_Priority();
            /*0x1f31134*/ void Format(string logLevel, string logCategory, System.Text.StringBuilder message, object context);
        }

        interface ILogOutputHandler
        {
            void OnLogMessage(PopCap.Logging.LogLevel logLevel, object logCategory, string formattedMessage, object context);
        }

        class LogFactory
        {
            static /*0x0*/ System.Collections.Generic.IDictionary<string, PopCap.Logging.ILogger> _loggers;

            static /*0x30d0304*/ LogFactory();
            static /*0x30cfebc*/ PopCap.Logging.ILogger GetLogger(string name);
            static /*0x30d0194*/ void ResetLogger(string name);
        }

        class CategoryFormatter : PopCap.Logging.ILogFormatter
        {
            /*0x10*/ int <Priority>k__BackingField;

            /*0x30d03a4*/ CategoryFormatter();
            /*0x30d03c4*/ CategoryFormatter(int priority);
            /*0x30d039c*/ int get_Priority();
            /*0x30d03ec*/ void Format(string logLevel, string logCategory, System.Text.StringBuilder message, object context);
        }

        class LogLevelFormatter : PopCap.Logging.ILogFormatter
        {
            /*0x10*/ int <Priority>k__BackingField;

            /*0x30d0478*/ LogLevelFormatter();
            /*0x30d0498*/ LogLevelFormatter(int priority);
            /*0x30d04c0*/ int get_Priority();
            /*0x30d04c8*/ void Format(string logLevel, string logCategory, System.Text.StringBuilder message, object context);
        }

        class TimestampFormatter : PopCap.Logging.ILogFormatter
        {
            /*0x10*/ int <Priority>k__BackingField;

            /*0x30d0554*/ TimestampFormatter();
            /*0x30d0574*/ TimestampFormatter(int priority);
            /*0x30d059c*/ int get_Priority();
            /*0x30d05a4*/ void Format(string logLevel, string logCategory, System.Text.StringBuilder message, object context);
        }

        class TypeFormatter : PopCap.Logging.ILogFormatter
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, string> DicTypeName;
            /*0x10*/ int <Priority>k__BackingField;

            static /*0x30d0a58*/ TypeFormatter();
            /*0x30d089c*/ TypeFormatter();
            /*0x30d08bc*/ TypeFormatter(int priority);
            /*0x30d0894*/ int get_Priority();
            /*0x30d08e4*/ void Format(string logLevel, string logCategory, System.Text.StringBuilder message, object context);
        }

        enum LogLevel
        {
            Debug = 0,
            Info = 1,
            Warn = 2,
            Error = 3,
            Super = 4,
            Exception = 5,
        }

        interface ILogger
        {
            /*0x1f2ffc8*/ PopCap.Logging.LogLevel get_LogLevel();
            /*0x1f30b78*/ void set_LogLevel(PopCap.Logging.LogLevel value);
            /*0x1f30b78*/ void set_LogCategories(int value);
            /*0x1f30b78*/ void set_MaxLogLength(int value);
            /*0x1f302cc*/ PopCap.Logging.ILogger AddFormatter(PopCap.Logging.ILogFormatter formatter);
            /*0x1f302cc*/ PopCap.Logging.ILogger AddOutputHandler(PopCap.Logging.ILogOutputHandler outputHandler);
            /*0x1f30ee8*/ void SetCategorySpecificLogLevel(object category, PopCap.Logging.LogLevel logLevel);
            /*0x1f30ebc*/ void UnsetCategorySpecificLogLevel(object category);
            void Log(PopCap.Logging.LogLevel level, object category, object message, object context);
            /*0x1f30ff0*/ void Debug(object category, object message);
            /*0x1f310fc*/ void Debug(object category, object message, object context);
            /*0x1f30ff0*/ void Info(object category, object message);
            /*0x1f310fc*/ void Info(object category, object message, object context);
            /*0x1f30ff0*/ void Warn(object category, object message);
            /*0x1f310fc*/ void Warn(object category, object message, object context);
            /*0x1f30ff0*/ void Error(object category, object message);
            /*0x1f310fc*/ void Error(object category, object message, object context);
            /*0x1f30ff0*/ void Super(object category, object message);
            /*0x1f30ff0*/ void Exception(object category, System.Exception exception);
            /*0x1f310fc*/ void Exception(object category, System.Exception exception, object context);
        }

        class Logger : PopCap.Logging.ILogger
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, string> LogLevelLookup;
            static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<int, string>> LogCategoryLookup;
            static /*0x10*/ System.Text.StringBuilder CachedStringBuilder;
            static /*0x18*/ int ThreadId;
            /*0x10*/ PopCap.Logging.LogLevel <LogLevel>k__BackingField;
            /*0x14*/ int <LogCategories>k__BackingField;
            /*0x18*/ int <MaxLogLength>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<PopCap.Logging.ILogFormatter> _logFormatters;
            /*0x28*/ System.Collections.Generic.List<PopCap.Logging.ILogOutputHandler> _logOutputHandlers;
            /*0x30*/ System.Collections.Generic.Dictionary<int, PopCap.Logging.LogLevel> _categorySpecificLogLevels;

            static /*0x30d1888*/ Logger();
            /*0x30d005c*/ Logger();
            /*0x30d0af0*/ PopCap.Logging.LogLevel get_LogLevel();
            /*0x30d0af8*/ void set_LogLevel(PopCap.Logging.LogLevel value);
            /*0x30d0b00*/ int get_LogCategories();
            /*0x30d0b08*/ void set_LogCategories(int value);
            /*0x30d0b10*/ int get_MaxLogLength();
            /*0x30d0b18*/ void set_MaxLogLength(int value);
            /*0x30d0b20*/ PopCap.Logging.ILogger AddFormatter(PopCap.Logging.ILogFormatter formatter);
            /*0x30d0c58*/ PopCap.Logging.ILogger AddOutputHandler(PopCap.Logging.ILogOutputHandler outputHandler);
            /*0x30d0cb8*/ void SetCategorySpecificLogLevel(object category, PopCap.Logging.LogLevel logLevel);
            /*0x30d0d64*/ void UnsetCategorySpecificLogLevel(object category);
            /*0x30d0e08*/ void Log(PopCap.Logging.LogLevel level, object category, object message, object context);
            /*0x30d17ac*/ void Debug(object category, object message);
            /*0x30d17c0*/ void Debug(object category, object message, object context);
            /*0x30d17d4*/ void Info(object category, object message);
            /*0x30d17e8*/ void Info(object category, object message, object context);
            /*0x30d17fc*/ void Warn(object category, object message);
            /*0x30d1810*/ void Warn(object category, object message, object context);
            /*0x30d1824*/ void Error(object category, object message);
            /*0x30d1838*/ void Error(object category, object message, object context);
            /*0x30d184c*/ void Super(object category, object message);
            /*0x30d1860*/ void Exception(object category, System.Exception exception);
            /*0x30d1874*/ void Exception(object category, System.Exception exception, object context);
            /*0x30d0e0c*/ void LogInternal(PopCap.Logging.LogLevel logLevel, object logCategory, object message, object context);

            class <>c
            {
                static /*0x0*/ PopCap.Logging.Logger.<> <>9;
                static /*0x8*/ System.Comparison<PopCap.Logging.ILogFormatter> <>9__20_0;

                static /*0x30d19e0*/ <>c();
                /*0x30d1a48*/ <>c();
                /*0x30d1a50*/ int <AddFormatter>b__20_0(PopCap.Logging.ILogFormatter x, PopCap.Logging.ILogFormatter y);
            }
        }

        class FileLogAppender : PopCap.Logging.ILogOutputHandler
        {
            /*0x10*/ string _directory;
            /*0x18*/ System.IO.StreamWriter _file;

            /*0x30d1b74*/ FileLogAppender(string directory, string fileName);
            /*0x30d1c74*/ void OnLogMessage(PopCap.Logging.LogLevel logLevel, object logCategory, string formattedMessage, object context);
            /*0x30d1bfc*/ void Initialize(string fileName);
            /*0x30d1c98*/ System.IO.StreamWriter CreateLogFile(string fileName);
        }

        class TimestampedFileLogAppender : PopCap.Logging.FileLogAppender
        {
            /*0x30d1d6c*/ TimestampedFileLogAppender(string directory, string baseName);
            /*0x30d1d70*/ System.IO.StreamWriter CreateLogFile(string fileName);
        }

        class LogCoreUtils
        {
            static /*0x0*/ int ThreadId;
            static /*0x8*/ char[] CharArray;

            static /*0x30d206c*/ LogCoreUtils();
            static /*0x30d1ec8*/ int UintToCharArray(uint value, ref char[] charArray);
            static /*0x30d0808*/ void StringBuilderNoGCAppendUint(System.Text.StringBuilder sb, uint value);
        }
    }
}
