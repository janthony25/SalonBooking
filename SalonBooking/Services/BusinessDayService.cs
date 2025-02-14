
using Microsoft.EntityFrameworkCore;
using SalonBooking.Data;

namespace SalonBooking.Services
{
    public class BusinessDayService : IBusinessDayService
    {
        private readonly DataContext _data;
        private readonly ILogger<BusinessDayService> _logger;

        public BusinessDayService(DataContext data, ILogger<BusinessDayService> logger)
        {
            _data = data;
            _logger = logger;
        }
        public async Task<bool> IsBusinessOpen(DateTime date)
        {
            try
            {
                var isSpecialClosure = await _data.SpecialClosures
                       .AnyAsync(sc => sc.Date.Date == date.Date);

                if (isSpecialClosure) return false;

                // check regular business days
                var dayOfWeek = date.DayOfWeek.ToString();
                var businessDay = await _data.BusinessDays
                        .FirstOrDefaultAsync(bd => bd.DayName == dayOfWeek);

                return businessDay?.IsOpen ?? false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while checking if business is open");
                throw;
            }
        }
    }
}
