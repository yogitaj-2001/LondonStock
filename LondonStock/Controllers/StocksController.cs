using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LondonStock.Models;
using LondonStock.Service;

namespace LondonStock.Controllers
{
    // TODO: authentication & authorization

    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly ILondonStockService _londonStockService;

        public StocksController(ILondonStockService londonStockService)
        {
            _londonStockService = londonStockService;
        }

        // GET: api/stocks
        [HttpPost]
        public async Task<ActionResult<List<MarketView>>> GetStocks(List<string> tickerSymbols)
        {
            return Ok(await _londonStockService.GetStocks(tickerSymbols));
        }

        // GET: api/allstocks
        [Route("~/api/allstocks")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarketView>>> GetAllStocks()
        {
            return Ok(await _londonStockService.GetAllStocks());
        }

        // POST: api/addstocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("~/api/addstocks")]
        [HttpPost]
        public async Task<ActionResult> AddStock(Stocks stock)
        {
            await _londonStockService.AddStock(stock);
            return Ok();
        }
    }
}
