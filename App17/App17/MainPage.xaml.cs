using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App17
{
	public partial class MainPage : ContentPage
	{
        public MainPageViewModel vm;
		public MainPage()
		{
			InitializeComponent();
            vm = new MainPageViewModel();
            this.BindingContext = vm;
            btnFillCities.Clicked += BtnFillCities_Clicked;
            pckCities.SelectedIndexChanged += PckCities_SelectedIndexChanged;
		}

        private void PckCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var city = vm.Cities.Cities[(int)e];
            var element =vm.Cities.Cities[pckCities.SelectedIndex] as City;
            DisplayAlert("Elemento seleccionado", element.ID.ToString(), "OK");
        }

        private void BtnFillCities_Clicked(object sender, EventArgs e)
        {
            pckCities.ItemsSource = vm.Cities.Cities;
        }
    }
}
