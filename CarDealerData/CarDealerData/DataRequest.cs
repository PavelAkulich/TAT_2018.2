using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerData
{
    /// <summary>
    /// command initiator - invokes a command to perform a specific request
    /// </summary>
    class DataRequest
    {
        ICommandToData commandToData;
        public void SetCommand(ICommandToData command)
        {
            commandToData = command;
        }
        public void ShowCountTypes()
        {
            if(commandToData != null)
            {
                commandToData.CountTypes();
            }
        }
        public void ShowCountAll()
        {
            if (commandToData != null)
            {
                commandToData.CountAll();
            }
        }
        public void ShowAveragePrise()
        {
            if (commandToData != null)
            {
                commandToData.AveragePrise();
            }
        }
        public void ShowAveragePriseOf(string param)
        {
            if (commandToData != null)
            {
                commandToData.AveragePriseOf(param);
            }
        }
    }
}
