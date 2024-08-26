using System.Runtime.CompilerServices;

namespace Spide_Tech_App;

public partial class MechanicHome : ContentPage
{
   private readonly UserService us;
    public MechanicHome()
	{
       
		InitializeComponent();
        us = new UserService();
	}
    

    private void OnTyre(object sender, EventArgs e)
    {
        //pplication.Current.NavigateTo(typeof(Home));
        Navigation.PushAsync(new Tyre_Purchase());
    }

    private void OnTowtruck(object sender, EventArgs e)
    {
        //pplication.Current.NavigateTo(typeof(Home));
        Navigation.PushAsync(new Tow_Truck(us));
    }

    private void OnCarwash(object sender, EventArgs e)
    {
        //pplication.Current.NavigateTo(typeof(Home));
        Navigation.PushAsync(new CarWash());
    }

    private void OnJob(object sender, EventArgs e)
    {
        //pplication.Current.NavigateTo(typeof(Home));
        Navigation.PushAsync(new ViewJobAssigned());
    }

    private void OnJobProgress(object sender, EventArgs e)
    {
        //pplication.Current.NavigateTo(typeof(Home));
        Navigation.PushAsync(new JobProgress());
    }

    private void OnHome(object sender, EventArgs e)
    {
        //pplication.Current.NavigateTo(typeof(Home));
        Navigation.PushAsync(new MechanicHome());
    }

    private void OnContact(object sender, EventArgs e)
    {
        //pplication.Current.NavigateTo(typeof(Home));
        Navigation.PushAsync(new CarWash());
    }
    private void OnService(object sender, EventArgs e)
    {
        //pplication.Current.NavigateTo(typeof(Home));
        Navigation.PushAsync(new Booking(us));
    }
    private void LoginClicked(object sender, EventArgs e)
    {
        //pplication.Current.NavigateTo(typeof(Home));
        Navigation.PushAsync(new Login());
    }

    private void BackClicked(object sender, EventArgs e)

    {
        Navigation.PopAsync();
    }

    private void OnProfile(object sender, EventArgs e)

    {
        Navigation.PopAsync();
    }
}