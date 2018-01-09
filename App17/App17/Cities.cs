using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App17
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class CitiesRepository
    {
        public ObservableCollection<City> Cities { get; set; }
        public CitiesRepository()
        {
            Cities = new ObservableCollection<City>
            {
                new City
                {
                    ID = 1,
                    Name = "Ciudad de México"
                },
                new City
                {
                    ID = 2,
                    Name = "Guadalajara"
                },
                new City
                {
                    ID = 3,
                    Name = "Pachuca"
                }
            };
        }
        public ObservableCollection<City> GetCities()
        {
            return Cities;
        }
    }
}
