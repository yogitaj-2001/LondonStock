using LondonStock.Models;
using Microsoft.EntityFrameworkCore;

namespace LondonStock.Service
{
    public class LondonStockService : ILondonStockService
    {
        private readonly StocksContext _context;

        public LondonStockService(StocksContext context)
        {
            _context = context;
        }
        public async Task<List<MarketView>> GetStocks(List<string> tickerSymbols)
        {
            return await _context.Stocks.GroupBy(a => a.TickerSymbol)
            .Select(a => new MarketView { Price = a.Average(b => b.Price), TickerSymbol = a.Key })
            .Where(x => tickerSymbols.Any(y => y == x.TickerSymbol))
            .ToListAsync();
        }
        public async Task<List<MarketView>> GetAllStocks()
        {
            return await _context.Stocks.GroupBy(a => a.TickerSymbol)
            .Select(a => new MarketView { Price = a.Average(b => b.Price), TickerSymbol = a.Key })
            .ToListAsync();
        }
        public async Task AddStock(Stocks stock)
        {
            _context.Stocks.Add(stock);
            await _context.SaveChangesAsync();
        }

    }
}
