using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Catalogue
{
    class CatalogueVehicle
    {
        public CatalogueVehicle()
        {
            cars = new List<Car>();
            trucks = new List<Truck>();
        }
        public List<Car> cars { get; set; }
        public List<Truck> trucks { get; set; }
    }
}
