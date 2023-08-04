using MauiPodcast.MVVM.Models;
using MauiPodcast.Repository;
using Newtonsoft.Json;

namespace MauiPodcast.Services
{
    public class UserService : IUserRepotory
    {
        public async Task<User> Login(string email, string password)
        {
            var client = new HttpClient();

            var baseUrl = DeviceInfo.Platform == DevicePlatform.Android
                ? "http://10.0.2.2:5052"
                : "http://localhost:5052";
            // URL Api 
            string url = $"{baseUrl}/api/User/{email}/{password}";

            client.BaseAddress = new Uri(url);

            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                //My Api  is returning List for than i have token List
                User user = JsonConvert.DeserializeObject<User>(content);

                return await Task.FromResult(user);
            }
            else
            {
                return null;
            }
        }
    }
}
