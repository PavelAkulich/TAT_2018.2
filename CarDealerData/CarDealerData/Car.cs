using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerData
{
    /// <summary>
    /// the class is a single car entry description
    /// contains brand, model, price and quantity
    /// </summary>
    class Car
    {
        public string Brand { set; get; }
        public string Model { set; get; }
        public int Quantity { set; get; }
        public int Prise { set; get; }
        public Car(string brand, string model, int quantity, int prise)
        {
            Brand = brand;
            Model = model;
            Quantity = quantity;
            Prise = prise;
        }
    }
}
