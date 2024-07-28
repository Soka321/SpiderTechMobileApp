namespace Spide_Tech_App;


public partial class Booking : ContentPage
{
    public Booking()
    {
        InitializeComponent();
    }

    private void OnBooking(object sender, EventArgs e)
    {
		bool state=false;
		
		if(state!=true)
		{
			else    if (string.IsNullOrEmpty(id.Text))
        {
			 lblError.Text = "Invalid  entry  please check again";
            lblError.TextColor="Red";
		}
    else    if (string.IsNullOrEmpty(number.Text))
        {
			 lblError.Text = "Invalid  entry  please check again";
            lblError.TextColor="Red";
		}
      else  if (string.IsNullOrEmpty(vin.Text))
        {
             lblError.Text = "Invalid  entry  please check again";
            lblError.TextColor="Red";
        }
     else   if (string.IsNullOrEmpty(date.Text))
        {
            lblError.Text = "Invalid  entry  please check again";
            lblError.TextColor="Red";
        }
     else   if (string.IsNullOrEmpty(service.Text))
        {
            lblError.Text = "Invalid  entry  please check again";
            lblError.TextColor="Red";
        }
        if (string.IsNullOrEmpty(type.Text))
        {
            lblError.Text = "Invalid  entry  please check again";
            lblError.TextColor="Red";
        }
      else  if (string.IsNullOrEmpty(model.Text))
        {
            lblError.Text = "Invalid  entry  please check again";
            lblError.TextColor="Red";
        }
		
		}
		else{
        Navigation.PushAsync(new ViewBooking());
		await	App.UserService.Book(id.Text,number.Text,vin.Text,date.Text,service.Text,type.Text,model.Text);
		}
		
	
		
		//arrange properly
	
    }
	
	 private void GoBack(object sender, EventArgs e)
    {
        //Takes the user back
        Navigation.PopAsync();
    }
}