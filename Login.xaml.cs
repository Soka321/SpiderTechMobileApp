namespace Spide_Tech_App;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void OnLog(object sender, EventArgs e)
    {
		//use an if statement for if registered then the others use else if
		
        if(string.IsNullOrEmpty(email.Text))
        {
            lblError.Text = "Invalid email entry Or Password";
            
        }
       else if (string.IsNullOrEmpty(Password.Text))
        {
           lblError.Text = "Invalid email entry Or Password";
        }
		
		else{
        //Takes user to login page1 ;
	
	App.UserService.Login(email.Text,Password.Text);
        //Navigation.PushAsync(new MainPage());
		btnLog.Text="Log Out";
        //Allow user to save login info
        Preferences.Set("Would you like Spider tech to save your login info?", true);
        Preferences.Get( "login info", false);
		}
    }
    private void GoBack(object sender, EventArgs e)
    {
        //Takes the user back
        Navigation.PopAsync();
    }
}