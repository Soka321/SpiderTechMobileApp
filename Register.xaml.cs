using System.Text.RegularExpressions;
using Microsoft.Maui.ApplicationModel.Communication;
namespace Spide_Tech_App
{


    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegiClicked(object sender, EventArgs e)
        {
    string CorrectEmail= "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]";
			try
			{
				if (!Regex.IsMatch(email.Text, CorrectEmail))
				{
					if (string.IsNullOrEmpty(email.Text))
					{
						lblError.Text = "Invalid entry Please make sure all entries are correct";
					}
					else if (string.IsNullOrEmpty(name.Text))
					{
						lblError.Text = "Invalid entry Please make sure all entries are correct";
					}
					else if (string.IsNullOrEmpty(surname.Text))
					{
						lblError.Text = "Invalid entry Please make sure all entries are correct";
					}
					//else if(string.IsNullOrEmpty(password1.Text))
					//{
					//	password1.Text="Invalid email, please enter correct email";
					//}
					else if (string.IsNullOrEmpty(type.Text))
					{
						lblError.Text = "Invalid entry Please make sure all entries are correct";
					}
					else if (string.IsNullOrEmpty(contact.Text))
					{
						lblError.Text = "Invalid entry Please make sure all entries are correct";
					}
					lblError.Text = "Invalid entry Please make sure all entries are correct";
					
					DisplayAlert("Email Error", "please make sure you enter the correct email","OK");

				}
				else
				{
					//Display box
DisplayAlert("Registration success", "You have successfully registered, you may press proceed to login","Proceed");

                    //Send user email notification
					
					if(Email.Default.IsComposeSupported)
					{
						string[] reciver = new[] { email.Text };
						var message = new EmailMessage()
						{
							Subject = "",
							Body = "Welcome to Spider Tech, you have successfully registered, we'll keep in touc. Enjoy the experience!!",
							BodyFormat = EmailBodyFormat.PlainText,
							To = new List<string>(reciver)
						};	
                      Email.Default.ComposeAsync(message);					   
					}
					//adds user to database
					
					
					

						App.UserService.Register(id.Text,name.Text,surname.Text,email.Text,password.Text,contact.Text,type.Text);
					//Takes user to login page1 ;
					Navigation.PushAsync(new Login());
				}
			}
			catch (RegexMatchTimeoutException ex) { lblError.Text = "Invalid entry Please make sure all entries are correct"; }
        }
        private void GoBack(object sender, EventArgs e)
        {
            //Takes the user back
            Navigation.PopAsync();
        }
    }
}
