using System.ComponentModel.DataAnnotations;
using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations.Schema;

namespace HACKH.Models
{
    public class BookingModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime? BookingDay { get; set; } 
        public TimeSpan? BookingStartTime { get; set; } 
        public TimeSpan? BookingEndTime { get; set; } 
        public int FloorNumber { get; set; }
        public int ParkingId { get; set; }
        public bool bookingConfirmed { get; set; }
        public BookingModel(DateTime date, TimeSpan StartTime, TimeSpan EndTime, int floorNumber, int ParkingId)
        {
            this.BookingDay = date;
            this.BookingStartTime = StartTime;
            this.BookingEndTime = EndTime;
            this.FloorNumber = floorNumber;
            this.ParkingId = ParkingId;
            this.bookingConfirmed = false;
        }

        public BookingModel()
        {
            this.BookingDay = DateTime.Today;
            this.BookingStartTime = new TimeSpan(08, 00, 00);
            this.BookingEndTime = new TimeSpan(18, 00, 00);
            this.FloorNumber = 0;
            this.ParkingId = 0;
            this.bookingConfirmed = false;
        }

        public BookingModel(BookingModel bookingModel)
        {
            this.BookingDay = bookingModel.BookingDay;
            this.BookingStartTime = bookingModel.BookingStartTime;
            this.BookingEndTime = bookingModel.BookingEndTime;
            this.FloorNumber = bookingModel.FloorNumber;
            this.ParkingId = bookingModel.ParkingId;
            this.bookingConfirmed = bookingModel.bookingConfirmed;
        }
    }
}
