using Appoint.Pages;
using Microsoft.Maui.ApplicationModel.Communication;

namespace Appoint;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void onAppointmentButtonClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new BookingSelectPage());
	}
	


}

