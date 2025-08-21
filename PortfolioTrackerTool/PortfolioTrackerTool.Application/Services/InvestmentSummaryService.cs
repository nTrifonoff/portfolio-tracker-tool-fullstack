using PortfolioTrackerTool.Application.DTOs;
using PortfolioTrackerTool.Application.Interfaces;

namespace PortfolioTrackerTool.Application.Services
{
    public class InvestmentSummaryService : IInvestmentSummaryService
    {
        private readonly IInvestmentRepository _investmentRepository;

        public InvestmentSummaryService(IInvestmentRepository investmentRepository)
        {
            _investmentRepository = investmentRepository;
        }

        public async Task<IEnumerable<AssetTypeSummaryDto>> GetSummaryByAssetTypeAsync()
        {
            var investments = await _investmentRepository.GetAllAsync();

            var result = investments
                .GroupBy(i => i.AssetType)
                .Select(g => new AssetTypeSummaryDto
                {
                    AssetType = g.Key.ToString(),
                    TotalValue = g.Sum(i => i.Amount * i.PricePerUnit)
                })
                .ToList();

            return result;
        }
    }
}
