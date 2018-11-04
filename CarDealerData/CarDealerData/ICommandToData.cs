using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerData
{
    /// <summary>
    /// interface representing the commands 
    /// CountTypes (), CountAll (), AveragePrice (), AveragePriceOf (string objParam)
    /// </summary>
    interface ICommandToData
    {
        void CountTypes();
        void CountAll();
        void AveragePrise();
        void AveragePriseOf(string objectParam);
    }
}
