/*
 * Copyright (c) 2012-2019 Snowflake Computing Inc. All rights reserved.
 * Notice of modifications:
 *  @rdagumampan : Change default logger into ConsoleFileSFLogger
 */

//using log4net;

namespace Snowflake.Data.Log
{
    class SFLoggerFactory
    {
        public static SFLogger GetLogger<T>()
        {
            return new ConsoleFileSFLogger(typeof(T));
        }
    }
}
