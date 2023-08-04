using MauiPodcast.MVVM.Models;
using MauiPodcast.Repository;
using MauiPodcast.Services;

namespace MauiPodcast.MVVM.Views;

public partial class LoginPage : ContentPage
{
	readonly IUserRepotory userService = new UserService();
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Login_btn_Clicked(object sender, EventArgs e)
    {
        await ConnectData();
    }

    private async Task ConnectData()
    {
        try
        {
            string email = Entry_Email.Text;
            string password = Entry_Password.Text;

            if (email == null || password == null)
            {
                await Shell.Current.DisplayAlert("Error", "Please Input User & Password", "Ok");
                return;
            }

            User user = await userService.Login(email, password);
            if (user == null)
            {
                await DisplayAlert("Error", "Credentials are incorect", "Ok");
                return;
            }
            await Navigation.PushModalAsync(new HomePodbox());
            await DisplayAlert("Login", "Successfully logged in", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Login", ex.Message, "Ok");
        }
    }
}