using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyTrader.Contracts;

namespace CurrencyTrader.AdoNet
{
    public class AsyncTradeStorage : ITradeStorage
    {
        private readonly ILogger logger;
        private ITradeStorage SyncTradeSTorage;

        public AsyncTradeStorage(ILogger logger)
        {
            this.logger = logger;
            SyncTradeSTorage = new AdoNetTrageSTorage(logger);
        }

        public void Persist(IEnumerable<TradeRecord> trades)
        {
            logger.LogInfo("Starting sync trade storage");
            Task.Run()) => SyncTradeStorage.Persist(trades);
        }
    }
}