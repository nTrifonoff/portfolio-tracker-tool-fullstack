using Microsoft.EntityFrameworkCore;
using PortfolioTrackerTool.Domain.Entities;

namespace PortfolioTrackerTool.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        { 
        }

        public DbSet<Investment> Investments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Investment>()
                .Property(i => i.AssetType)
                .HasConversion<string>();

            modelBuilder.Entity<Investment>()
                .Property(i => i.TransactionType)
                .HasConversion<string>();

            modelBuilder.Entity<Investment>()
                .Property(e => e.PricePerUnit)
                .HasPrecision(15, 2);


            var investments = InvestmentSeedData.GetInvestments();

            modelBuilder.Entity<Investment>()
                .HasData(investments);
        }
    }
}