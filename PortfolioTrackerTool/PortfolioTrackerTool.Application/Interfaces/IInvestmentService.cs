using PortfolioTrackerTool.Application.DTOs;

namespace PortfolioTrackerTool.Application.Interfaces
{
    public interface IInvestmentService
    {
        Task<IEnumerable<InvestmentDto>> GetAllInvestmentsAsync();
    }
}