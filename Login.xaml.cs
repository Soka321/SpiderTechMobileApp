namespace Spide_Tech_App;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

public partial class Login : ContentPage
{
    private readonly UserService _userService;


    public Login()
	{
		InitializeComponent();
        _userService = new UserService();


    }

    private async void OnLog(object sender, EventArgs e)
    {
        //use an if statement for if registered then the others use else if

        if (string.IsNullOrEmpty(email.Text))
        {
            lblError.Text = "Invalid email entry Or Password";

        }
        else if (string.IsNullOrEmpty(Password.Text))
        {
            lblError.Text = "Invalid email entry Or Password";
        }

        else
        {

            //Takes user to login page1 ;

            //User usertolog = new User();

           
            var usertolog = new User
            {
                email = email.Text,
                password = Password.Text
            };
            

            string jsonString = JsonSerializer.Serialize(usertolog);
            HttpContent content= new StringContent(jsonString, Encoding.UTF8,
    "application/json");

            var data = await _userService.PostAsync<User>("http://10.254.145.173:4000/api/users/login", content);

            if (data.usertype == 1)
            {
                UserSession.user_id = data.user_id;
                UserSession.email = data.email;
                UserSession.name = data.name;
                UserSession.surname = data.surname;
                UserSession.phone_num = data.phone_num;
                UserSession.password = data.password;
                UserSession.created_at = data.created_at;
                UserSession.updated_at = data.updated_at;
                UserSession.address = data.address;
                UserSession.isActive = data.isActive;
                UserSession.userType = data.usertype;
                await Navigation.PushAsync(new Home());
                await DisplayAlert("Success", "Welcome dear Client", " Ok");
            }
            else if(data.usertype == 2)
            {
                UserSession.user_id = data.user_id;
                UserSession.email = data.email;
                UserSession.name = data.name;
                UserSession.surname = data.surname;
                UserSession.phone_num = data.phone_num;
                UserSession.password = data.password;
                UserSession.created_at = data.created_at;
                UserSession.updated_at = data.updated_at;
                UserSession.address = data.address;
                UserSession.isActive = data.isActive;
               UserSession.userType = data.usertype;
              await Navigation.PushAsync(new MechanicHome());
             await   DisplayAlert("Success", "Welcome dear Mechanic", " Ok");
            }
            else
            {
                await DisplayAlert("Test Usertype:", Convert.ToString(data.usertype), "Ok");
                lblError.Text = "User not registered";
            }

        }
    }
    private void GoBack(object sender, EventArgs e)
    {
        //Takes the user back
        Navigation.PopAsync();
    }
}