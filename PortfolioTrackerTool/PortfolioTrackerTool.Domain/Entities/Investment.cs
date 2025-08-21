using PortfolioTrackerTool.Domain.Enums;

namespace PortfolioTrackerTool.Domain.Entities
{
    public class Investment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AssetType AssetType { get; set; }
        public TransactionType TransactionType  { get; set; }
        public int Amount { get; set; }
        public decimal PricePerUnit { get; set; }
        public DateTime Date { get; set; }
    }
}
