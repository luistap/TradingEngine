using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging.LoggingConfiguration
{
    public class LoggerConfiguration
    {
        public LoggerType LoggerType { get; set; }

        public TextLoggerConfiguration TextLoggerConfiguration { get; set; }


    }

    public class TextLoggerConfiguration
    {
        public string Directory { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }


    }
}
