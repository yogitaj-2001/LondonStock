namespace LondonStock.Models
{    
    // TODO: fluent validation
    public class Stocks
    {
        public long Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string TickerSymbol { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public double Price { get; set; }
        public double NumberofShares { get; set; }
        public long BrokerId { get; set; }
    }
}
