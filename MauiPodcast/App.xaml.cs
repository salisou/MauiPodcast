using MauiPodcast.MVVM.Models;

namespace MauiPodcast;

public partial class App : Application
{
	//public static UserInfo UserInfo;

	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}
}
