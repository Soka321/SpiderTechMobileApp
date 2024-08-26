
namespace Spide_Tech_App;

public partial class ViewBooking : ContentPage
{
	UserService us;
	public ViewBooking(UserService us)
	{
		InitializeComponent();
		this.us = us;	
	}


	private void OnBook(object sender, EventArgs e)
	{
		//UserService us = new UserService();
        DisplayPromptAsync("ID required", "please enter your id to view your booking", "OK", "Cancel", lblID.Text);
     //lblVin.Text=  us.ViewBooking(Convert.ToInt32(lblID.Text)).ToString();
		

	}

	private void OnNext(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainPage());
	}
        private void AdjustBook(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

    }