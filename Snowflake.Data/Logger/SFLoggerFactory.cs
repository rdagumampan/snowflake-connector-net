/*
 * Copyright (c) 2012-2019 Snowflake Computing Inc. All rights reserved.
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

    public static class GlobalConfiguration {

        //public void Configure() { 
        
        //}

    }
}
