using Appoint.Models;

namespace Appoint.Pages;


public partial class BookingTabPage : TabbedPage
{
	BookingModel model;
	public BookingTabPage(BookingModel m)
	{
		model = m;
		BindingContext = model;

		InitializeComponent();
	}
}