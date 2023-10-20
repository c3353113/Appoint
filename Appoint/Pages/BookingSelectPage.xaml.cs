using Appoint.Models;
using Appoint.ViewModels;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Appoint.Pages;

public partial class BookingSelectPage : ContentPage
{
	BookingViewModel viewModel; 

	public BookingSelectPage()
	{

		BindingContext = viewModel = new BookingViewModel();
		InitializeComponent();


	}
    protected override void OnAppearing()
    {
		viewModel.OnPropertyChanged("SortedItems");
    }

	private void BookingSelectListView_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		BookingModel tapped = (BookingModel)e.Item;
		Navigation.PushAsync(new BookingTabPage(tapped));
	}

	private void AddBookingButton_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new BookingTabPage(new BookingModel()
		{
			 
		})); 
	}
}