using System.Text.RegularExpressions;
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
						email.Placeholder = "Invalid entry,Please enter correct entry";
						email.PlaceholderColor.Red.ToString();
					}
					else if (string.IsNullOrEmpty(name.Text))
					{
						name.Placeholder = "Invalid entry,Please enter correct entry";
						name.PlaceholderColor.Red.ToString();
					}
					else if (string.IsNullOrEmpty(surname.Text))
					{
						surname.Placeholder = "Invalid entry,Please enter correct entry";
						surname.PlaceholderColor.Red.ToString();
					}
					//else if(string.IsNullOrEmpty(password1.Text))
					//{
					//	password1.Text="Invalid email, please enter correct email";
					//}
					else if (string.IsNullOrEmpty(type.Text))
					{
						type.Placeholder = "Invalid entry,Please enter correct entry";
						type.PlaceholderColor.Red.ToString();
					}
					else if (string.IsNullOrEmpty(contact.Text))
					{
						contact.Placeholder = "Invalid entry,Please enter correct entry";
						contact.PlaceholderColor.Red.ToString();
					}
					email.Placeholder = "Invalid entry,Please enter correct entry";
					email.PlaceholderColor.Red.ToString();

				}
				else
				{
					//Display box


					//adds user to database
					///conn.Insert(new User{Name=name.text, Surname=surname.text, Email=email.text,Password=password.text,Contact=contact.text, Type=type.text})
					//Takes user to login page1 ;
					Navigation.PushAsync(new Login());
				}
			}
			catch (System.ArgumentNullException ex) { email.Placeholder = "Invaild entry, please provide proper email"; }
        }
        private void GoBack(object sender, EventArgs e)
        {
            //Takes the user back
            Navigation.PopAsync();
        }
    }
}
