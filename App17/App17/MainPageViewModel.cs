using System;
using System.Collections.Generic;
using System.Text;

namespace App17
{
    public class MainPageViewModel
    {
        public CitiesRepository Cities { get; set; }
        public MainPageViewModel()
        {
            Cities = new CitiesRepository();
        }
    }
}
