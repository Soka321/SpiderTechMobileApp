

namespace Spide_Tech_App;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
        InitializeComponent();

    }

    private void OnStart(object sender, EventArgs e)
	{

        Navigation.PushAsync(new MainPage());
	}
}