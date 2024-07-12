namespace Spide_Tech_App;


public partial class Booking : ContentPage
{
    public Booking()
    {
        InitializeComponent();
    }

    private void OnBooking(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(number.Text))
        {
            number.Placeholder = "Invalid  entry";
            number.PlaceholderColor.Red.ToString();
        }
        if (string.IsNullOrEmpty(vin.Text))
        {
            vin.Placeholder = "Invalid  entry";
            vin.PlaceholderColor.Red.ToString();
        }
        if (string.IsNullOrEmpty(date.Text))
        {
            date.Placeholder = "Invalid  entry";
            date.PlaceholderColor.Red.ToString();
        }
        if (string.IsNullOrEmpty(service.Text))
        {
            service.Placeholder = "Invalid  entry";
            service.PlaceholderColor.Red.ToString();
        }
        if (string.IsNullOrEmpty(type.Text))
        {
            type.Placeholder = "Invalid  entry";
            type.PlaceholderColor.Red.ToString();
        }
        if (string.IsNullOrEmpty(model.Text))
        {
            model.Placeholder = "Invalid  entry";
            model.PlaceholderColor.Red.ToString();
        }
        Navigation.PushAsync(new ViewBooking());
    }
}