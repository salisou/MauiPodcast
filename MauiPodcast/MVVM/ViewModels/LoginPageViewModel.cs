using MauiPodcast.MVVM.Models;
using MauiPodcast.MVVM.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiPodcast.MVVM.ViewModels
{
    public partial class LoginPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _userName;

        [ObservableProperty]
        public string _password;

        //readonly ILoginRepository loginRepository = new LoginService();

        //public async void Login()
        //{
        //    if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
        //    {
        //        UserInfo userInfo = await loginRepository.Login(UserName, Password);

        //        if (Preferences.ContainsKey(nameof(App.UserInfo)))
        //        {
        //            Preferences.Remove(nameof(App.UserInfo));
        //        }

        //        string userDetails = JsonConvert.SerializeObject(userInfo);
        //        Preferences.Set(nameof(App.UserInfo), userDetails); 
        //        App.UserInfo = userInfo;

        //        await Shell.Current.GoToAsync($"//{nameof(HomePodbox)}");
        //    }
        //}
    }
}
