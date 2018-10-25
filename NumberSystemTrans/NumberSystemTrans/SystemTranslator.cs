using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberSystemTrans
{
    class SystemTranslator
    {
        private string allNumber = "0123456789abcdefghij"; //string contains characters to 20 system
        public string Translate(int startNumber, int resSystem)
        {
            //the method converts the number startNumber to the resSystem system
            //returns the resulting string
            StringBuilder newNumber = new StringBuilder();
            newNumber.Append("");
            while (startNumber > 1)
            {
                newNumber.Append(allNumber[startNumber % resSystem]);
                startNumber = (int)(startNumber / resSystem);
            }
            if (startNumber == 1) newNumber.Append("1");
            char[] buffArray = newNumber.ToString().ToCharArray();
            Array.Reverse(buffArray);
            string resultNumber = new string(buffArray);
            return resultNumber;
        }
    }
}
