using Microsoft.Maui.ApplicationModel.Communication;

namespace Spide_Tech_App
{
    public partial class MainPage : ContentPage
    {
       private readonly UserService _userService;


        public MainPage()
        {
            InitializeComponent();
            _userService = new UserService();
            getUser();
        }

        private async void getUser()
        {
            try
            {

                var data = await _userService.GetAsync<List<User>>("http://10.254.145.173:4000/api/users/63");


                //lblconnectiontest.Text = data[0].name;
            }
            catch (Exception ex)
            {
                //lblconnectiontest.Text = ex.Message;
            }


        }

       

        private void OnQoutation(object sender, EventArgs e)
        {
            //pplication.Current.NavigateTo(typeof(Home));
            Navigation.PushAsync(new ViewQuotation());
        }

        private void OnTowtruck(object sender, EventArgs e)
        {
            //pplication.Current.NavigateTo(typeof(Home));
            //Navigation.PushAsync(new Tow_Truck(us));
        }

        private void OnCarwash(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarWash());
        }

        private void OnMechanic(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MechanicHome());
        }

        private void OnProfile(object sender, EventArgs e)
        {
           //Navigation.PushAsync(new Profile(us));
        }

        private void Progress(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewJobProgress());
        }

        private void OnAbout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }

        private async void OnContact(object sender, EventArgs e)
        {
          bool result=  await DisplayAlert("Make a call", "Are you sure you want to place a call?", "Accept", "Cancel");
            if (result==true)
            {
                if (PhoneDialer.Default.IsSupported)
                {
                    PhoneDialer.Default.Open("+27743104795");
                }
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
            //Navigation.PushAsync(new Booking(us));
        }
        private void LoginClicked(object sender, EventArgs e)
        {
            //pplication.Current.NavigateTo(typeof(Home));
            Navigation.PushAsync(new Login());
}
        private void RegisterClicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new Register(us));
            //pplication.Current.NavigateTo(typeof(Home));
        }

        private void GuestClicked(object sender, EventArgs e)
        {
            //pplication.Current.NavigateTo(typeof(Home));
            //Navigation.PushAsync(new Booking(us));
        }
    }

}
