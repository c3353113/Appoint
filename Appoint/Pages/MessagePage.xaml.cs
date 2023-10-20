namespace Appoint.Pages;

public partial class MessagePage : ContentPage
{
    public string PhoneNumber { get; set; }

    public string Message { get; set; }
	public MessagePage()
	{
		InitializeComponent();
        BindingContext = this;
	}
    private async void SendSMS(string phoneNumber, string text)
    {
        if (Sms.Default.IsComposeSupported)
        {
            string[] recipients = new[] { phoneNumber };

            var smsMessage = new SmsMessage(text, recipients);

            await Sms.Default.ComposeAsync(smsMessage);
        }
        else
        {

        }
    }
    private void SendSMSButton_Clickd(object sender, EventArgs e)
    {
       

        SendSMS(PhoneNumber, Message);
    }
}