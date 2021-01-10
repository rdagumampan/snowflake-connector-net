/*
 * Copyright (c) @rdagumampan / Replace default logger until the master repo removed dependency to log4net
 */

using System;
using System.IO;

namespace Snowflake.Data.Log
{
    public sealed class ConsoleFileSFLogger : SFLogger
    {
        private static readonly string _traceSessionId = DateTime.Now.ToString("MMddyyyy-HHmmss");
        private static readonly ConsoleFileSFLogger _instance = new ConsoleFileSFLogger();

        ///<inheritdoc/>
        static ConsoleFileSFLogger() {
        }

        ///<inheritdoc/>
        private ConsoleFileSFLogger() { }

        /// <summary>
        /// Returns global singleton instance of session configuration
        /// </summary>
        public static ConsoleFileSFLogger Instance
        {
            get
            {
                return _instance;
            }
        }

        private bool _debuEnabled = false;
        public void SetDebugMode(bool enabled = false)
        {
            _debuEnabled = enabled;
        }

        public void Debug(string msg, Exception ex = null)
        {
            if (IsDebugEnabled()) {
                var traceFile = GetTraceSessionFilePath();
                var traceMessage = $"DBG   {DateTime.UtcNow.ToString("u")}   Snowflake   {msg}. {ex?.ToString()}{Environment.NewLine}";

                File.AppendAllText(traceFile, traceMessage);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(traceMessage);
                Console.ResetColor();
            }
        }

        public void DebugFmt(string fmt, params object[] args)
        {
            if (IsDebugEnabled())
            {
                var traceFile = GetTraceSessionFilePath();
                var baseMessage = string.Format(fmt, args);
                var traceMessage = $"DBG   {DateTime.UtcNow.ToString("u")}   Snowflake   {baseMessage}{Environment.NewLine}";

                File.AppendAllText(traceFile, traceMessage);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(traceMessage);
                Console.ResetColor();
            }
        }

        public void Info(string msg, Exception ex = null)
        {
            var traceFile = GetTraceSessionFilePath();
            var traceMessage = $"INF   {DateTime.UtcNow.ToString("u")}   Snowflake   {msg}. {ex?.ToString()}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.Write(traceMessage);
        }

        public void InfoFmt(string fmt, params object[] args)
        {
            var traceFile = GetTraceSessionFilePath();
            var baseMessage = string.Format(fmt, args);
            var traceMessage = $"INF   {DateTime.UtcNow.ToString("u")}   Snowflake   {baseMessage}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.Write(traceMessage);
        }

        public void Warn(string msg, Exception ex = null)
        {
            var traceFile = GetTraceSessionFilePath();
            var traceMessage = $"WRN   {DateTime.UtcNow.ToString("u")}   Snowflake   {msg}. {ex?.ToString()}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.Write(traceMessage);
        }

        public void WarnFmt(string fmt, params object[] args)
        {
            var traceFile = GetTraceSessionFilePath();
            var baseMessage = string.Format(fmt, args);
            var traceMessage = $"INF   {DateTime.UtcNow.ToString("u")}   Snowflake   {baseMessage}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.Write(traceMessage);
        }

        public void Error(string msg, Exception ex = null)
        {
            var traceFile = GetTraceSessionFilePath();
            var traceMessage = $"ERR   {DateTime.UtcNow.ToString("u")}   Snowflake   {msg}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public void ErrorFmt(string fmt, params object[] args)
        {
            var traceFile = GetTraceSessionFilePath();
            var baseMessage = string.Format(fmt, args);
            var traceMessage = $"ERR   {DateTime.UtcNow.ToString("u")}   Snowflake   {baseMessage}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public void Fatal(string msg, Exception ex = null)
        {
            var traceFile = GetTraceSessionFilePath();
            var traceMessage = $"FAT   {DateTime.UtcNow.ToString("u")}   Snowflake   {msg}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public void FatalFmt(string fmt, params object[] args)
        {
            var traceFile = GetTraceSessionFilePath();
            var baseMessage = string.Format(fmt, args);
            var traceMessage = $"FAT   {DateTime.UtcNow.ToString("u")}   Snowflake   {baseMessage}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public bool IsDebugEnabled() => _debuEnabled;

        public bool IsErrorEnabled() => true;

        public bool IsFatalEnabled() => true;

        public bool IsInfoEnabled() => true;

        public bool IsWarnEnabled() => true;

        private string GetTraceSessionFilePath()
        {
            return Path.Combine(Environment.CurrentDirectory, $"snowflake-log-{_traceSessionId}.txt");
        }
    }
}
