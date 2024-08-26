namespace Spide_Tech_App;

public partial class Tow_Truck : ContentPage
{
    UserService us;
	public Tow_Truck(UserService us)
	{
		InitializeComponent();
        this.us = us;
	}

    private void OnTruck(object sender, EventArgs e)
    {
        DisplayAlert("Success", "Tow Truck on its way", "OK");
        Navigation.PushAsync(new MainPage());
    }
}