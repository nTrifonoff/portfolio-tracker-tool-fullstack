using PortfolioTrackerTool.Domain.Entities;
using PortfolioTrackerTool.Domain.Enums;

public static class InvestmentSeedData
{
    public static List<Investment> GetInvestments()
    {
        return new List<Investment>
        {
            new Investment { Id = 1, Name = "Bitcoin", AssetType = AssetType.Crypto, TransactionType = TransactionType.Buy, Amount = 3, PricePerUnit = 32000m, Date = new DateTime(2025,01,15) },
            new Investment { Id = 2, Name = "Ethereum", AssetType = AssetType.Crypto, TransactionType = TransactionType.Buy, Amount = 10, PricePerUnit = 2000m, Date = new DateTime(2025,02,14) },
            new Investment { Id = 3, Name = "Gold", AssetType = AssetType.Metal, TransactionType = TransactionType.Buy, Amount = 15, PricePerUnit = 3300m, Date = new DateTime(2025,03,13) },
            new Investment { Id = 4, Name = "Tesla", AssetType = AssetType.Stock, TransactionType = TransactionType.Buy, Amount = 200, PricePerUnit = 338m, Date = new DateTime(2025,04,12) },
            new Investment { Id = 5, Name = "Silver", AssetType = AssetType.Metal, TransactionType = TransactionType.Buy, Amount = 40, PricePerUnit = 1220m, Date = new DateTime(2025,05,10) },
            new Investment { Id = 6, Name = "Microsoft", AssetType = AssetType.Stock, TransactionType = TransactionType.Buy, Amount = 85, PricePerUnit = 513m, Date = new DateTime(2025,06,09) },
            new Investment { Id = 7, Name = "IBM", AssetType = AssetType.Stock, TransactionType = TransactionType.Buy, Amount = 440, PricePerUnit = 240m, Date = new DateTime(2025,07,08) },
            new Investment { Id = 8, Name = "Apartment", AssetType = AssetType.Property, TransactionType = TransactionType.Buy, Amount = 1, PricePerUnit = 120000m, Date = new DateTime(2025,08,07) },
            new Investment { Id = 9, Name = "House", AssetType = AssetType.Property, TransactionType = TransactionType.Buy, Amount = 1, PricePerUnit = 88000m, Date = new DateTime(2025,07,6) },
            new Investment { Id = 10, Name = "Garage", AssetType = AssetType.Property, TransactionType = TransactionType.Buy, Amount = 1, PricePerUnit = 12000m, Date = new DateTime(2025,06,5) },
            new Investment { Id = 11, Name = "BNB", AssetType = AssetType.Crypto, TransactionType = TransactionType.Buy, Amount = 10, PricePerUnit = 830m, Date = new DateTime(2025,05,4) },
            new Investment { Id = 12, Name = "Platinum", AssetType = AssetType.Metal, TransactionType = TransactionType.Buy, Amount = 14, PricePerUnit = 1300m, Date = new DateTime(2025,04,3) },
        };
    }
}