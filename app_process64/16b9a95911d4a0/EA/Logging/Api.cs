class <Module>
{
}

namespace EA
{
    namespace Logging
    {
        namespace Api
        {
            class AssemblyUtils
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Reflection.Assembly, string> AssemblyNameLookup;

                static /*0x2bbb0a4*/ AssemblyUtils();
                static /*0x2bbaf9c*/ string GetAssemblyName(System.Reflection.Assembly assembly);
            }

            class EALog
            {
                static /*0x2bbb13c*/ void Error(System.Exception e, string message);
                static /*0x2bbb330*/ void Error(string message);
                static /*0x1ffc854*/ void Error<TEnum>(TEnum category, System.Exception e, string message);
                static /*0x1ffc854*/ void Error<TEnum>(TEnum category, string message);
                static /*0x1ffc854*/ void Error<TEnum, T1>(TEnum category, string messageFormat, T1 param1);
                static /*0x1ffc854*/ void Error<TEnum, T1, T2>(TEnum category, string messageFormat, T1 param1, T2 param2);
                static /*0x1ffc854*/ void Error<TEnum, T1, T2, T3>(TEnum category, string messageFormat, T1 param1, T2 param2, T3 param3);
                static /*0x1ffc854*/ void Error<TEnum, T1, T2, T3, T4>(TEnum category, string messageFormat, T1 param1, T2 param2, T3 param3, T4 param4);
            }

            class ExplicitLogServiceProviderAttribute : System.Attribute
            {
                /*0x10*/ System.Type <Type>k__BackingField;

                /*0x2bbb444*/ ExplicitLogServiceProviderAttribute(System.Type type);
                /*0x2bbb474*/ System.Type get_Type();
            }

            interface IEACategoryLoggable<TEnum>
            {
            }

            class CategoryLoggableExtensions
            {
                static /*0x1ffc854*/ void Error<TEnum>(EA.Logging.Api.IEACategoryLoggable<TEnum> _, TEnum category, System.Exception e, string message);
                static /*0x1ffc854*/ void Error<TEnum>(EA.Logging.Api.IEACategoryLoggable<TEnum> _, TEnum category, string message);
                static /*0x1ffc854*/ void Error<TEnum, T1>(EA.Logging.Api.IEACategoryLoggable<TEnum> _, TEnum category, string messageFormat, T1 param1);
            }

            interface IEALoggable
            {
            }

            interface IEALoggable<T>
            {
            }

            class LoggableExtensions
            {
                static /*0x1f36f18*/ void Error<T>(EA.Logging.Api.IEALoggable<T> _, string message);
            }

            interface ILogger
            {
                /*0x1f30ebc*/ void Error(string message);
                /*0x1ffc854*/ void Error<T>(string messageFormat, T param);
                /*0x1ffc854*/ void Error<T1, T2>(string messageFormat, T1 param1, T2 param2);
                /*0x1ffc854*/ void Error<T1, T2, T3>(string messageFormat, T1 param1, T2 param2, T3 param3);
                /*0x1ffc854*/ void Error<T1, T2, T3, T4>(string messageFormat, T1 param1, T2 param2, T3 param3, T4 param4);
                /*0x1f30ff0*/ void Error(System.Exception e, string message);
            }

            interface ILoggerFactory
            {
                /*0x1f302cc*/ EA.Logging.Api.ILogger GetLogger(string name);
                /*0x1f302cc*/ EA.Logging.Api.ILogger GetLogger(System.Type type);
                /*0x1ffc854*/ EA.Logging.Api.ILogger GetLogger<TEnum>(TEnum category);
            }

            interface ILogServiceProvider
            {
                /*0x1f30214*/ EA.Logging.Api.ILoggerFactory get_LoggerFactory();
            }

            class LogService
            {
                static /*0x0*/ EA.Logging.Api.ILogServiceProvider _logServiceProvider;

                static /*0x2bbb544*/ LogService();
                static /*0x2bbb47c*/ EA.Logging.Api.ILoggerFactory get_LoggerFactory();
                static /*0x2bbb264*/ EA.Logging.Api.ILogger GetLogger(string name);
                static /*0x2bbb7f0*/ EA.Logging.Api.ILogger GetLogger(System.Type type);
                static /*0x1ffc854*/ EA.Logging.Api.ILogger GetLogger<TEnum>(TEnum category);
                static /*0x2bbb62c*/ void BindStaticServiceProvider();
                static /*0x2bbba4c*/ System.Type[] GetServiceProviderTypes();
                static /*0x2bbb8c0*/ bool BindExplicitServiceProvider();

                class <>c
                {
                    static /*0x0*/ EA.Logging.Api.LogService.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.Assembly, bool> <>9__10_0;
                    static /*0x10*/ System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>> <>9__10_1;

                    static /*0x2bbbd48*/ <>c();
                    /*0x2bbbdb0*/ <>c();
                    /*0x2bbbdb8*/ bool <GetServiceProviderTypes>b__10_0(System.Reflection.Assembly a);
                    /*0x2bbbe44*/ System.Collections.Generic.IEnumerable<System.Type> <GetServiceProviderTypes>b__10_1(System.Reflection.Assembly a);
                }

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ System.Type spi;

                    /*0x2bbbd40*/ <>c__DisplayClass10_0();
                    /*0x2bbbe68*/ bool <GetServiceProviderTypes>b__2(System.Type t);
                }
            }

            class NullLogger : EA.Logging.Api.ILogger
            {
                static /*0x0*/ EA.Logging.Api.NullLogger Instance;

                static /*0x2bbbe98*/ NullLogger();
                /*0x2bbbe90*/ NullLogger();
                /*0x2bbbe88*/ void Error(string message);
                /*0x1ffc854*/ void Error<T>(string messageFormat, T param);
                /*0x1ffc854*/ void Error<T1, T2>(string messageFormat, T1 param1, T2 param2);
                /*0x1ffc854*/ void Error<T1, T2, T3>(string messageFormat, T1 param1, T2 param2, T3 param3);
                /*0x1ffc854*/ void Error<T1, T2, T3, T4>(string messageFormat, T1 param1, T2 param2, T3 param3, T4 param4);
                /*0x2bbbe8c*/ void Error(System.Exception e, string message);
            }

            class NullLoggerFactory : EA.Logging.Api.ILoggerFactory
            {
                static /*0x0*/ EA.Logging.Api.NullLogger NullLogger;

                static /*0x2bbbfb8*/ NullLoggerFactory();
                /*0x2bbbfb0*/ NullLoggerFactory();
                /*0x2bbbf00*/ EA.Logging.Api.ILogger GetLogger(string name);
                /*0x2bbbf58*/ EA.Logging.Api.ILogger GetLogger(System.Type type);
                /*0x1ffc854*/ EA.Logging.Api.ILogger GetLogger<TEnum>(TEnum category);
            }

            class NullLogServiceProvider : EA.Logging.Api.ILogServiceProvider
            {
                /*0x10*/ EA.Logging.Api.ILoggerFactory <LoggerFactory>k__BackingField;

                /*0x2bbb5c0*/ NullLogServiceProvider();
                /*0x2bbc034*/ EA.Logging.Api.ILoggerFactory get_LoggerFactory();
            }
        }
    }
}
