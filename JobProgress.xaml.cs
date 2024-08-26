namespace Spide_Tech_App;

public partial class JobProgress : ContentPage
{
	public JobProgress()
	{
		InitializeComponent();
	}

	private void ProgressClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ViewJobProgress());
		//retrive data and put it inside the lblProgress label

	}

    private void BackClicked(object sender, EventArgs e)

    {
		Navigation.PopAsync();
    }
}