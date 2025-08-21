using Microsoft.AspNetCore.Mvc;
using PortfolioTrackerTool.Application.DTOs;
using PortfolioTrackerTool.Application.Interfaces;

namespace PortfolioTrackerTool.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestmentsController : ControllerBase
    {
        private readonly IInvestmentService _investmentService;
        private readonly IInvestmentSummaryService _investmentSummaryService;

        public InvestmentsController(IInvestmentService investmentService, IInvestmentSummaryService investmentSummaryService)
        {
            _investmentService = investmentService;
            _investmentSummaryService = investmentSummaryService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var investments = await _investmentService.GetAllInvestmentsAsync();
            return Ok(investments);
        }

  
        [HttpGet("summary")]
        public async Task<ActionResult<IEnumerable<AssetTypeSummaryDto>>> GetSummaryByAssetType()
        {
            var summary = await _investmentSummaryService.GetSummaryByAssetTypeAsync();
            return Ok(summary);
        }
    }
}
