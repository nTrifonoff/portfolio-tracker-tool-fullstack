using PortfolioTrackerTool.Domain.Entities;

namespace PortfolioTrackerTool.Application.Interfaces
{
    public interface IInvestmentRepository
    {
        public Task<IEnumerable<Investment>> GetAllAsync();
    }
}