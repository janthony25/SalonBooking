using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalonBooking.Services;

namespace SalonBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessDaysController : ControllerBase
    {
        private readonly IBusinessDayService _businessDayService;
        private readonly ILogger<BusinessDaysController> _logger;

        public BusinessDaysController(IBusinessDayService businessDayService, ILogger<BusinessDaysController> logger)
        {
            _businessDayService = businessDayService;
            _logger = logger;
        }

        [HttpGet("is-open")]
        public async Task<IActionResult> IsBusinessOpen([FromQuery] DateTime date)
        {
            try
            {
                var isOpen = await _businessDayService.IsBusinessOpen(date);
                return Ok(isOpen);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while checking if business is open on {date}");
                return StatusCode(500, new { message = "An error occurred while processing your request." });
            }
            
        }
    }
}
