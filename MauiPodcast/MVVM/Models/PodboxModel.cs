﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPodcast.MVVM.Models
{
    public class PodboxModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public TimeSpan ReadTime { get; set; }
        public string Image { get; set; }
    }
}
