using Appoint.Models;
using Appoint.Services;
using SQLite;

namespace Appoint.ViewModels
{
    internal class BookingViewModel : ObservableObject
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
