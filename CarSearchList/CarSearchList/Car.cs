using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSearchList
{
    //class contains car description
    class Car
    {
        public string Model;
        public string Brand;
        public string Color;
        public Car(string model, string brand, string color)
        {
            Model = model;
            Brand = brand;
            Color = color;
        }
    }
}
