using PortfolioTrackerTool.Application.DTOs;
using PortfolioTrackerTool.Application.Interfaces;

namespace PortfolioTrackerTool.Application.Services
{
    public class InvestmentService : IInvestmentService
    {
        private readonly IInvestmentRepository _investmentRepository;

        public InvestmentService(IInvestmentRepository investmentRepository)
        {
            _investmentRepository = investmentRepository;
        }

        public async Task<IEnumerable<InvestmentDto>> GetAllInvestmentsAsync()
        {
            var investments = await _investmentRepository.GetAllAsync();
            
            return investments.Select(i => new InvestmentDto
            {
                Id = i.Id,
                Name = i.Name,
                AssetType = i.AssetType.ToString(),
                TransactionType = i.TransactionType.ToString(),
                Amount = i.Amount,
                PricePerUnit = i.PricePerUnit,
                Date = i.Date,
            });
        }
    }
}