using Microsoft.Maui.ApplicationModel.Communication;

namespace Spide_Tech_App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void CallClicked(object sender, EventArgs e)
        {
           //pplication.Current.NavigateTo(typeof(Home));
        }

        private void OnTowtruck(object sender, EventArgs e)
        {
            //pplication.Current.NavigateTo(typeof(Home));
            Navigation.PushAsync(new Tow_Truck());
        }

        private void OnCarwash(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarWash());
        }

        private void OnProfile(object sender, EventArgs e)
        {
           
        }

        private void OnAbout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }

        private async void OnContact(object sender, EventArgs e)
        {
            await DisplayAlert("Make a call", "Are you sure you want to place a call?", "Accept", "Cancel");
			if(PhoneDialer.Default.IsSupported)
			{
				PhoneDialer.Default.Open("+27743104795");
			}
        }
        private void OnTyre(object sender, EventArgs e)
        {
            //pplication.Current.NavigateTo(typeof(Home));
            Navigation.PushAsync(new Tyre_Purchase());
        }
        private void OnService(object sender, EventArgs e)
        {
            //pplication.Current.NavigateTo(typeof(Home));
            Navigation.PushAsync(new Booking());
        }
        private void LoginClicked(object sender, EventArgs e)
        {
            //pplication.Current.NavigateTo(typeof(Home));
            Navigation.PushAsync(new Login());
}
        private void RegisterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
            //pplication.Current.NavigateTo(typeof(Home));
        }

        private void GuestClicked(object sender, EventArgs e)
        {
            //pplication.Current.NavigateTo(typeof(Home));
            Navigation.PushAsync(new Booking());
        }
    }

}
