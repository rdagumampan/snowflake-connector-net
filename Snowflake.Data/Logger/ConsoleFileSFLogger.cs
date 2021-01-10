/*
 * Copyright (c) @rdagumampan / Replace default logger until the master repo removed dependency to log4net
 */

using System;
using System.IO;

namespace Snowflake.Data.Log
{
    public class ConsoleFileSFLogger : SFLogger
    {
        private Type _context;

        private string _traceSessionId;

        public ConsoleFileSFLogger(Type context)
        {
            this._context = context;
        }

        public void Debug(string msg, Exception ex = null)
        {
            var traceFile = GetTraceSessionFilePath();
            var traceMessage = $"DBG   {DateTime.UtcNow.ToString("u")}   {msg}. {ex?.ToString()}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public void DebugFmt(string fmt, params object[] args)
        {
            var traceFile = GetTraceSessionFilePath();
            var baseMessage = string.Format(fmt, args);
            var traceMessage = $"DBG   {DateTime.UtcNow.ToString("u")}   {baseMessage}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public void Info(string msg, Exception ex = null)
        {
            var traceFile = GetTraceSessionFilePath();
            var traceMessage = $"INF   {DateTime.UtcNow.ToString("u")}   {msg}. {ex?.ToString()}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.Write(traceMessage);
        }

        public void InfoFmt(string fmt, params object[] args)
        {
            var traceFile = GetTraceSessionFilePath();
            var baseMessage = string.Format(fmt, args);
            var traceMessage = $"INF   {DateTime.UtcNow.ToString("u")}   {baseMessage}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.Write(traceMessage);
        }

        public void Warn(string msg, Exception ex = null)
        {
            var traceFile = GetTraceSessionFilePath();
            var traceMessage = $"WRN   {DateTime.UtcNow.ToString("u")}   {msg}. {ex?.ToString()}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.Write(traceMessage);
        }

        public void WarnFmt(string fmt, params object[] args)
        {
            var traceFile = GetTraceSessionFilePath();
            var baseMessage = string.Format(fmt, args);
            var traceMessage = $"INF   {DateTime.UtcNow.ToString("u")}   {baseMessage}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.Write(traceMessage);
        }

        public void Error(string msg, Exception ex = null)
        {
            var traceFile = GetTraceSessionFilePath();
            var traceMessage = $"ERR   {DateTime.UtcNow.ToString("u")}   {msg}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public void ErrorFmt(string fmt, params object[] args)
        {
            var traceFile = GetTraceSessionFilePath();
            var baseMessage = string.Format(fmt, args);
            var traceMessage = $"ERR   {DateTime.UtcNow.ToString("u")}   {baseMessage}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public void Fatal(string msg, Exception ex = null)
        {
            var traceFile = GetTraceSessionFilePath();
            var traceMessage = $"FAT   {DateTime.UtcNow.ToString("u")}   {msg}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public void FatalFmt(string fmt, params object[] args)
        {
            var traceFile = GetTraceSessionFilePath();
            var baseMessage = string.Format(fmt, args);
            var traceMessage = $"FAT   {DateTime.UtcNow.ToString("u")}   {baseMessage}{Environment.NewLine}";

            File.AppendAllText(traceFile, traceMessage);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(traceMessage);
            Console.ResetColor();
        }

        public bool IsDebugEnabled() => true;

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
