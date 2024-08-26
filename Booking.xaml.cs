namespace Spide_Tech_App;


public partial class Booking : ContentPage
{
    UserService us;
    public Booking(UserService us)
    {
        InitializeComponent();
        this.us=us;
    }

    private void OnBooking(object sender, EventArgs e)
    {
       // bool state = false;

        //if (state != false)
       // {
            if (string.IsNullOrEmpty(id.Text))
            {
                lblError.Text = "Invalid  entry  please check again";
                
            }
            else if (string.IsNullOrEmpty(number.Text))
            {
                lblError.Text = "Invalid  entry  please check again";
               
            }
            else if (string.IsNullOrEmpty(vin.Text))
            {
                lblError.Text = "Invalid  entry  please check again";
                
            }
            else if (string.IsNullOrEmpty(date.Text))
            {
                lblError.Text = "Invalid  entry  please check again";
               
            }
            
            else if (string.IsNullOrEmpty(type.Text))
            {
                lblError.Text = "Invalid  entry  please check again";
                
            }
            else if (string.IsNullOrEmpty(model.Text))
            {
                lblError.Text = "Invalid  entry  please check again";
               
            }

       // }
        else
        {
           // state = true;
            Navigation.PushAsync(new ViewBooking(us));
           // UserService us = new UserService(); 
            int BookId = Convert.ToInt32(id.Text); 
            int BookVin = Convert.ToInt32(vin.Text);
          //  us.Book(BookId,  vin.Text,number.Text, service1.Text, model.Text, type.Text, date.Text);
        }
    }



    //arrange properly

    private void GoBack(object sender, EventArgs e)
    {
        //Takes the user back
        Navigation.PopAsync();
    }
}
	
	
