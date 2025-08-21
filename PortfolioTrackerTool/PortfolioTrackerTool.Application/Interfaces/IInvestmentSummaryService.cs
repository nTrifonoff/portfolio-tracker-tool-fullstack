using PortfolioTrackerTool.Application.DTOs;

namespace PortfolioTrackerTool.Application.Interfaces
{
    public interface IInvestmentSummaryService
    {
        Task<IEnumerable<AssetTypeSummaryDto>> GetSummaryByAssetTypeAsync();
    }
}
