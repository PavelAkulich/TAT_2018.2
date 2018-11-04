using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerData
{
    /// <summary>
    /// class responsible for finding the command received from the console and its execution
    /// </summary>
    class CommandChecker
    {
        private const int lengthOfAverPrise = 14; //need to define a brandName from a string "average price 'brandName'"
        private DataRequest requestData;
        public CommandChecker( DataRequest request)
        {
            requestData = request;
        }
        public void Check(string command)
        {
            //method that determines the command received from the console
            if (command == "count types")
            {
                requestData.ShowCountTypes();
                return;
            }
            if (command == "count all")
            {
                requestData.ShowCountAll();
                return;
            }
            if (command == "average price")
            {
                requestData.ShowAveragePrise();
                return;
            }
            if (command.StartsWith("average price "))
            {
                string brandName = command.Substring(lengthOfAverPrise);
                requestData.ShowAveragePriseOf(brandName);
                return;
            }
            else
            {
                Console.WriteLine("valid commands: count types, count all, average prise, average prise 'brandName' or exit to exit");
            }
        }
    }
}
