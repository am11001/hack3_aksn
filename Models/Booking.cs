namespace HACKH.Models
{
    public class Booking
    {
        public DateTime? BookingDay { get; set; } = DateTime.Today;
        public TimeSpan? BookingStartTime { get; set; } = new TimeSpan(08, 00, 00);
        public TimeSpan? BookingEndTime { get; set; } = new TimeSpan(18, 00, 00);

        public bool bookingConfirmed = false;
    }
}
