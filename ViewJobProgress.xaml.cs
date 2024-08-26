namespace Spide_Tech_App;

public partial class ViewJobProgress : ContentPage
{
	public ViewJobProgress()
	{
		InitializeComponent();
	}

    private void BackClicked(object sender, EventArgs e)

    {
        Navigation.PopAsync();
    }

    private void OnInvoice(object sender, EventArgs e)

    {
        Navigation.PushAsync(new Invoices());
    }
}