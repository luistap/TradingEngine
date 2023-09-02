using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging
{
    public interface ILogger 
    {
        void Debug(String module, String message);

        void Debug(String module, Exception exception);

        void Information(String module, String message);

        void Information(String module, Exception exception);

        void Warning(String module, String message);

        void Warning(String module, Exception exception);

        void Error(String module, String message);

        void Error(String module, Exception exception);

    }
}
