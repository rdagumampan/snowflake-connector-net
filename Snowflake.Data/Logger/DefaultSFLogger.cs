/*
 * Copyright (c) 2012-2019 Snowflake Computing Inc. All rights reserved.
 */

using System;

namespace Snowflake.Data.Log
{
    public class DefaultSFLogger : SFLogger
    {
        private Type _context;

        public DefaultSFLogger(Type context)
        {
            this._context = context;
        }

        public void Debug(string msg, Exception ex = null)
        {
            //throw new NotImplementedException();
        }

        public void DebugFmt(string fmt, params object[] args)
        {
            //throw new NotImplementedException();
        }

        public void Error(string msg, Exception ex = null)
        {
            //throw new NotImplementedException();
        }

        public void ErrorFmt(string fmt, params object[] args)
        {
            //throw new NotImplementedException();
        }

        public void Fatal(string msg, Exception ex = null)
        {
            //throw new NotImplementedException();
        }

        public void FatalFmt(string fmt, params object[] args)
        {
            //throw new NotImplementedException();
        }

        public void Info(string msg, Exception ex = null)
        {
            //throw new NotImplementedException();
        }

        public void InfoFmt(string fmt, params object[] args)
        {
            //throw new NotImplementedException();
        }

        public bool IsDebugEnabled()
        {
            throw new NotImplementedException();
        }

        public bool IsErrorEnabled()
        {
            throw new NotImplementedException();
        }

        public bool IsFatalEnabled()
        {
            throw new NotImplementedException();
        }

        public bool IsInfoEnabled()
        {
            throw new NotImplementedException();
        }

        public bool IsWarnEnabled()
        {
            throw new NotImplementedException();
        }

        public void Warn(string msg, Exception ex = null)
        {
            //throw new NotImplementedException();
        }

        public void WarnFmt(string fmt, params object[] args)
        {
            //throw new NotImplementedException();
        }
    }
}
