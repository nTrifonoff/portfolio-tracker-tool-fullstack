namespace PortfolioTrackerTool.Application.DTOs
{
    public class InvestmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AssetType { get; set; }
        public string TransactionType { get; set; }
        public int Amount { get; set; }
        public decimal PricePerUnit { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue => Amount * PricePerUnit;
    }
}