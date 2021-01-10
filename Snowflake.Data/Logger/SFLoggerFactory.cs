/*
 * Copyright (c) 2012-2019 Snowflake Computing Inc. All rights reserved.
 * Notice of modifications:
 *  @rdagumampan : Change default logger into ConsoleFileSFLogger
 *  @rdagumampan : Made the class public and use singleton instance of logger
 */

//using log4net;

namespace Snowflake.Data.Log
{
    public class SFLoggerFactory
    {
        public static SFLogger GetLogger<T>()
        {
            return ConsoleFileSFLogger.Instance;
        }
    }
}
