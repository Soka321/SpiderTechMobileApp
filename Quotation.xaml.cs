namespace Spide_Tech_App;

public partial class Quotation : ContentPage
{
	public Quotation()
	{
		InitializeComponent();
	}

    private void QuotClicked(object sender, EventArgs e)
    {
        //Takes the user back

       // UserService us = new UserService();
       // us.Qoutation(Convert.ToInt32(id.Text),part.Text,Convert.ToInt32(num.Text),labour.Text,date.Text);

        Navigation.PushAsync(new ViewQuotation());
    }

    private void GoBack(object sender, EventArgs e)
    {
        //Takes the user back

        Navigation.PopAsync();
    }

}