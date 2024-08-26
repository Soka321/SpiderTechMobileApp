namespace Spide_Tech_App;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Json;


public partial class Profile : ContentPage
{
    private readonly UserService _userService;
    public Profile()
    {
        InitializeComponent();
        _userService = new UserService();
    }

    private async void OnProfile(object sender, EventArgs e)
	{

        //Task<string> res = us.GetLogin(email.Text, password.Text);

        // lblProfile.Text = res.ToString();


        var data = await _userService.GetAsync<List<User>>($"http://10.254.145.173:4000/api/users/{UserSession.user_id}");

        if(data != null)
        {
            lblProfile.Text = data[0].name;
            lblSurname.Text = data[0].surname;
            lblEmail.Text = data[0].email;
            lblNumber.Text = data[0].phone_num;
            lblAddress.Text = data[0].address;
        }

    }


	private void OnBack(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
    }