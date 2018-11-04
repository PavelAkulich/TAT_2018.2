using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerData
{
    /// <summary>
    /// Command recipient. Defines actions to be taken as a result of a request.
    /// </summary>
    class CarData
    {
        private List<Car> CarList = new List<Car>();
        public void AddCar(string brand, string model, int quantity, int prise)
        {
            //Create and add car in List which
            //when trying to create 2 identical entries in the List
            //adds up their amount
            bool flag = false;
            foreach (Car car in CarList)
            {
                if (car.Brand == brand && car.Model == model)
                {
                    if (car.Prise == prise)
                    {
                        car.Quantity += quantity;
                        flag = true;
                        break;
                    }
                    else
                    {
                        //if car have identical brand and model
                        //but different price throw exception
                        flag = true;
                        break;
                        throw new Exception("Wrong!!!");
                    }
                }
            }
            if (!flag)
                CarList.Add(new Car(brand, model, quantity, prise));
        }
        public void ShowNomberOfBrand()
        {
            //the method counts the number of different brands and displays it in the console
            int nomberOfBrands = 0;
            List<string> listBrandName = new List<string>();
            foreach (Car car in CarList)
            {
                bool flag = false;
                foreach(string brandName in listBrandName)
                {
                    if (car.Brand == brandName)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    listBrandName.Add(car.Brand);
                    nomberOfBrands++;
                }
            }
            Console.WriteLine(nomberOfBrands);
        }
        public void ShowNomberOfCar()
        {
            //the method counts the number of cars and displays it in the console
            int nomberOfCars = 0;
            foreach (Car car in CarList)
            {
                nomberOfCars += car.Quantity;
            }
            Console.WriteLine(nomberOfCars);
        }
        public void AveragePriseOfCar()
        {
            //the method counts the average price of car and displays it in the console
            int nomberOfCars = 0;
            double averagePrise = 0;
            foreach(Car car in CarList)
            {
                nomberOfCars += car.Quantity;
                averagePrise += car.Prise * car.Quantity;
            }
            if (nomberOfCars == 0) throw new Exception("Wrong!!!");
            averagePrise /= nomberOfCars;
            Console.WriteLine(averagePrise);
        }
        public void AveragePriseOfBrand(string brand)
        {
            //the method calculates the average price of machines of one brand and displays it in the console
            //brand name is given as an argument
            int nomberOfCars = 0;
            double averagePrise = 0;
            foreach(Car car in CarList)
            {
                if(car.Brand == brand)
                {
                    nomberOfCars += car.Quantity;
                    averagePrise += car.Prise * car.Quantity;

                }
            }
            if (nomberOfCars == 0) throw new Exception("Wrong!!!");
            averagePrise /= nomberOfCars;
            Console.WriteLine(averagePrise);
        }
    }
}
