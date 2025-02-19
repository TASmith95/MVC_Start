﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Start.Models
{

    public class FavoriteColor
    {
        public string FirstColor { get; set; }
        public string SecondColor { get; set; }
        public string ThirdColor { get; set; }
    }
    public class GuestContact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class ChartModel
    {
        public string ChartType { get; set; }
        public string Labels { get; set; }
        public string Data { get; set; }
        public string Title { get; set; }
    }


}