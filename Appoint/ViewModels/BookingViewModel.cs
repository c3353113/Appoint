using Appoint.Models;
using Appoint.Services;
using SQLite;

namespace Appoint.ViewModels
{
    public class BookingViewModel : ObservableObject
    {
        public static BookingViewModel Current { get; set; }


        SQLiteConnection connection;

        public BookingViewModel()
        {
            Current = this;
            connection = DatabaseService.Connection;
        }

        public List<BookingModel> Bookings
        {
            get
            {
                return connection.Table<BookingModel>().ToList();
            }
        }

        public List<BookingModel> SortedItems
        {
            get
            {
                return Bookings.OrderBy(Bookings => Bookings.CusName).ToList();
            }
        }

  

        public void SaveBooking(BookingModel model)
        {
            if (model.Id > 0)
            {
                connection.Update(model);
            }

            else
            {
                connection.Insert(model);
            }
        }

        public void DeleteBooking(BookingModel model)
        {
            if (model.Id > 0)
            {
                connection.Delete(model);
            }
        }
    }
}
