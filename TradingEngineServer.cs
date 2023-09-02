using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;
using TradingEngineServer.Core.Configuration;
using TradingEngineServer.Logging;

namespace TradingEngineServer.Core
{
    class TradingEngineServer : BackgroundService, ITradingEngineServer

    {
        private readonly IOptions<TradingEngineServerConfiguration> _engineConfiguration;
        private readonly ITextLogger _logger;
        public TradingEngineServer(ITextLogger textLogger, IOptions<TradingEngineServerConfiguration> engineConfiguration)
        {
            _logger = textLogger ?? throw new ArgumentNullException(nameof(textLogger));
            _engineConfiguration = engineConfiguration ?? throw new ArgumentNullException(nameof(engineConfiguration));

        }

        public Task RunAsync(CancellationToken token) => ExecuteAsync(token);

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.Information(nameof(TradingEngineServer), "Starting Trading Engine");
            while (!stoppingToken.IsCancellationRequested)
            {

            }
            _logger.Information(nameof(TradingEngineServer), "Stopping Trading Engine"); 
            return Task.CompletedTask;
        }
    }
}
