using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Json;

namespace Spide_Tech_App;

public partial class ViewJobAssigned : ContentPage
{
    UserService _userService;
	public ViewJobAssigned()
	{
		InitializeComponent();

        _userService = new UserService();
	}

    private async void JobClicked(object sender, EventArgs e)
    {
        //retrive data and put it inside the lblJobAssign label

        var data= await _userService.GetAsync<List<User>>($"http://10.254.145.173:4000/api/users/{UserSession.user_id}");

        if (data != null)
        {
            lblName.Text = data[0].name;
            lblJobAssign.Text ="For Vechile :"+ data[0].surname;
            
        }

    }

    private void BackClicked(object sender, EventArgs e)

    {
        Navigation.PopAsync();
    }
}