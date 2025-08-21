using Microsoft.EntityFrameworkCore;
using PortfolioTrackerTool.Application.Interfaces;
using PortfolioTrackerTool.Domain.Entities;

namespace PortfolioTrackerTool.Infrastructure.Repositories
{
    public class InvestmentRepository : IInvestmentRepository
    {
        private readonly AppDbContext _dbContext;

        public InvestmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Investment>> GetAllAsync()
        {
            return await _dbContext.Investments.ToListAsync();
        }
    }
}
