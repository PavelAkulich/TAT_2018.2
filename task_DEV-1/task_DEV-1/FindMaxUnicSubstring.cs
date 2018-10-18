using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_1
{
    static class FindMaxUnicSubstring
    {
        public static string MakeStartString(this string[] args)
        {
            //builds an input string
            StringBuilder startString = new StringBuilder();
            if (args.Length == 0)
            {
                //if args is empty
                //ask for console input
                Console.Write("Data is required: ");
                string da = Console.ReadLine();
                startString.Append(da); 
            }
            foreach (string i in args)
                startString.Append(i);
            return startString.ToString();
        }
        public static void FindMaxSubstring(this string startString)
        {
            //current line item
            int startPt = 0;
            int finishPt = 0;
            //position of the maximum substring in the string
            int maxStart = 0;
            int maxFinish = 0;
            StringBuilder substring = new StringBuilder();
            while (startPt < startString.Length)
            {
                for (int i = startPt; i < startString.Length; i++)
                {
                    //duplicate character search
                    if (i == startPt)
                    {
                        substring.Append(startString[i]);
                        continue;
                    }
                    if (substring.ToString().IndexOf(startString[i]) != -1)
                        break;
                    substring.Append(startString[i]);
                    finishPt = i;
                }
                if (substring.Length > (maxFinish - maxStart))
                {
                    //assigning a position to the maximum of the current position
                    maxStart = startPt;
                    maxFinish = finishPt;
                }
                substring.Clear();
                startPt++;
            }
            Console.Write("Maximum length: ");
            Console.WriteLine(maxFinish - maxStart + 1);
            Console.Write("Maximum substring: ");
            for (int i = maxStart; i <= maxFinish; i++)
                Console.Write(startString[i]);
        }
    }
}
