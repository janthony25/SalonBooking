namespace SalonBooking.Services
{
    public interface IBusinessDayService
    {
        Task<bool> IsBusinessOpen(DateTime date);
    }
}
