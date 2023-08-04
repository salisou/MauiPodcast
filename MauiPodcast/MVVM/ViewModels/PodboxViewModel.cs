using MauiPodcast.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPodcast.MVVM.ViewModels
{
    public class PodboxViewModel
    {
        public ObservableCollection<PodboxModel> Podbox { get; set; }
        public ObservableCollection<PodboxModel2> Podbox2 { get; set; }

        public PodboxViewModel()
        {
            Podbox = new ObservableCollection<PodboxModel>
            {
                new PodboxModel() { Name = "Author :", Description = "How to make a great design principal?", Author = "Alexander Bay",  Image = "image" },
                new PodboxModel() { Name = "Author :", Description = "How to make a great design principal?", Author = "Alexander Bay",  Image = "image1" },
                new PodboxModel() { Name = "Author :", Description = "How to make a great design principal?", Author = "Alexander Bay",  Image = "image2" },
                new PodboxModel() { Name = "Author :", Description = "How to make a great design principal?", Author = "Alexander Bay",  Image = "image3" },
                new PodboxModel() { Name = "Author :", Description = "How to make a great design principal?", Author = "Alexander Bay",  Image = "podcast" }
            };

            Podbox2 = new ObservableCollection<PodboxModel2>
            {
                new PodboxModel2() { Name1 = "Designing", Image1 = "disigne", contentBox = "Recent"},
                new PodboxModel2() { Name1 = "Technology", Image1 = "technology", contentBox = "Popular"},
                new PodboxModel2() { Name1 = "Business", Image1 = "business", contentBox = "Live Streaming"}
            };
        }
    }
}
