using MauiPodcast.MVVM.Views;

namespace MauiPodcast;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private  void btnNavigate_Clicked(object sender, EventArgs e)
    {
		 Navigation.PushModalAsync(new Login());
    }
}

