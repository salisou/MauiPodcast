using CommunityToolkit.Maui;
using MauiPodcast.MVVM.Models;
using MauiPodcast.MVVM.ViewModels;
using MauiPodcast.MVVM.Views;
using MauiPodcast.Repository;
using Microsoft.Extensions.Logging;

namespace MauiPodcast;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Epilogue-Medium.ttf", "Epilogue");
				fonts.AddFont("fontello.ttf", "Icons");
			});



		//builder.Services.AddSingleton<HomePodbox>();
		//builder.Services.AddSingleton<Login>();
		//
		//builder.Services.AddSingleton<LoginPageViewModel>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
