namespace Spide_Tech_App;

public partial class ViewQuotation : ContentPage
{
    UserService _userService;
	public ViewQuotation()
	{
		InitializeComponent();
        _userService = new UserService();
	}

    private async void OnView(object sender, EventArgs e)
    {

        var data = await _userService.GetAsync<List<User>>($"http://10.254.145.173:4000/api/users/{UserSession.user_id}");

        if (data != null)
        {
            lblNumber.Text = data[0].name;
            lblModel.Text = data[0].surname;
            lblID.Text = data[0].email;
           
        }

    }
    private void OnNext(object sender, EventArgs e)
    {
        DisplayAlert("Success","Your Vechile will be serviced, you will check the updates on view progress","OK");

    }
    private void OnBack(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}