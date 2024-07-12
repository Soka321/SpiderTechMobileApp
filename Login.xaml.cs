namespace Spide_Tech_App;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void OnLog(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(email.Text))
        {
            email.Placeholder = "Invalid email entry";
            email.PlaceholderColor.Red.ToString();
        }
        if (string.IsNullOrEmpty(Password.Text))
        {
            Password.Placeholder = "Invalid password entry";
            Password.PlaceholderColor.Red.ToString();
        }

        //Takes user to login page1 ;
        Navigation.PushAsync(new MainPage());
        //Allow user to save login info
        Preferences.Set("Would you like Spider tech to save your login info?", true);
        Preferences.Get( "login info", false);
    }
    private void GoBack(object sender, EventArgs e)
    {
        //Takes the user back
        Navigation.PopAsync();
    }
}