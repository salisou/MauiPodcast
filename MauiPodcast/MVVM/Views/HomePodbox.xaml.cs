using MauiPodcast.MVVM.Models;
using MauiPodcast.MVVM.ViewModels;
using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;

namespace MauiPodcast.MVVM.Views;

public partial class HomePodbox : ContentPage
{
	
	public HomePodbox()
	{
		InitializeComponent();
		ModifySearchBar();
		BindingContext = new PodboxViewModel();
	}

    private void ModifySearchBar()
    {
		SearchBarHandler.Mapper.AppendToMapping("CustomSearchIconColor", (handler, view) =>
		{
#if ANDROID
			var context = handler.PlatformView.Context;
			var searchIconId = context.Resources.GetIdentifier("seach_mag_icon", "id", context.PackageName);

			if(searchIconId != 0)
			{
				var searchIcon = handler.PlatformView.FindViewById<Android.Widget.ImageView>(searchIconId);
				searchIcon.SetColorFilter(Android.Graphics.Color.Rgb(172, 157, 185), Android.Graphics.PorterDuff.Mode.Darken);
			}
#endif
		});
    }

    private void imgPlay_Clicked(object sender, EventArgs e)
    {

    }

    
}