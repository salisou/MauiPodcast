using MauiPodcast.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPodcast.Repository
{
    public interface IUserRepotory
    {
        Task<User> Login(string username, string password);
    }
}
