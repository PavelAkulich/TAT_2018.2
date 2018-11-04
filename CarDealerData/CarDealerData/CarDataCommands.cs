using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerData
{
    /// <summary>
    /// concrete implementation of commands, 
    /// implements the methods CountTypes (), CountAll (), AveragePrice (), AveragePriceOf (string objParam) 
    /// in which the specific method defined in the CarData class is called
    /// </summary>
    class CarDataCommands : ICommandToData
    {
        CarData carData;
        public CarDataCommands(CarData cars)
        {
            carData = cars;
        }
        public void CountTypes()
        {
            carData.ShowNomberOfBrand();
        }
        public void CountAll()
        {
            carData.ShowNomberOfCar();
        }
        public void AveragePrise()
        {
            carData.AveragePriseOfCar();
        }
        public void AveragePriseOf(string objectParam)
        {
            carData.AveragePriseOfBrand(objectParam);
        }
    }
}
