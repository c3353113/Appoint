using Appoint.Models;
using Appoint.ViewModels;
using System.Collections.ObjectModel;

namespace Appoint.Pages;

public partial class BookingDetailsPage : ContentPage

{
  
    public BookingDetailsPage()
	{
     

		InitializeComponent();


	}    
    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        var model = (BookingModel)Parent.BindingContext;
        if (model.CusName == null || model.CusName.Length < 1) {
            await DisplayAlert("Warning", "You must enter a customer name before saving!", "Okay");
            return;
        }
        if (model.BookingDate == null || model.BookingDate.Length < 10)
        {
            await DisplayAlert("Warning", "You must enter a valid date before saving!", "Okay");
            return;
        }
        if (model.BookingTime == null)
        {
            await DisplayAlert("Warning", "You must enter a booking time before saving!", "Okay");
            return;
        }

        BookingViewModel.Current.SaveBooking(model);

        await Navigation.PopAsync();
    }


    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (await DisplayAlert("Confirm Delete", "Are you sure you want to remove this appointmnet? This cannot be undone.", "Yes", "No") != true)
            return;
        var model = (BookingModel)Parent.BindingContext;
        BookingViewModel.Current.DeleteBooking(model);

        await Navigation.PopAsync();
    }
}