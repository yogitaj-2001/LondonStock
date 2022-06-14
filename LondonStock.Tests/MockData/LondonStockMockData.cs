using LondonStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LondonStock.Tests.MockData
{
    public class LondonStockMockData
    {
        public static List<MarketView> GetStock()
        {
            return new List<MarketView>{
             new MarketView{
                 TickerSymbol="A",
                 Price = 356.56
             },
             new MarketView{
                 TickerSymbol="B",
                 Price = 23.45
             }
         };
        }
    }
}
