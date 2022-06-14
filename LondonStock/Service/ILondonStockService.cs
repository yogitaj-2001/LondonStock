using LondonStock.Models;

namespace LondonStock.Service
{
    public interface ILondonStockService
    {
        public Task<List<MarketView>> GetStocks(List<string> tickerSymbols);
        public Task<List<MarketView>> GetAllStocks();
        public Task AddStock(Stocks stock);

    }
}
