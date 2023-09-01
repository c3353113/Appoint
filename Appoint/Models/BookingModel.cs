using SQLite;

namespace Appoint.Models
{
    [Table("bookings")]
    public class BookingModel : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CusName { get; set; }
        public string CusAddress { get; set; }
        public string CusBookingType { get; set; }
        public double BookingPrice { get; set; }
        public string BookingType { get; set; }
        public string CusPhoneNo { get; set; }
        public string BookingTime { get; set; }
        public string BookingLocation { get; set; }
        public string BookingDate { get; set; }
    }
}