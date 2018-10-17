using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string start_string = MakeStartString(args);
            FindMaxSubstring(start_string);
        }

        public static string MakeStartString(string[] args)
        {
            //builds an input string
            string start_string = "";
            if (args.Length == 0)
            {
                //if args is empty
                //ask for console input
                Console.WriteLine("Data is required:");
                start_string = Console.ReadLine();
            }
            foreach (string i in args)
                start_string += i;
            return start_string;
        }

        public static void FindMaxSubstring(string start_string)
        {
            //current line item
            int start_pt = 0;
            int finish_pt = 0;

            //position of the maximum substring in the string
            int max_start = 0;
            int max_finish = 0;

            string substring = "";

            while (start_pt < start_string.Length)
            {
                for (int i = start_pt; i < start_string.Length; i++)
                {
                    //duplicate character search
                    if (i == start_pt)
                    {
                        substring += start_string[i];
                        continue;
                    }
                    if (substring.IndexOf(start_string[i]) != -1)
                        break;
                    substring += start_string[i];
                    finish_pt = i;
                }

                if (substring.Length > (max_finish - max_start))
                {
                    //assigning a position to the maximum of the current position
                    max_start = start_pt;
                    max_finish = finish_pt;
                }

                substring = "";
                start_pt++;
            }

            for (int i = max_start; i <= max_finish; i++)
                //console output
                Console.Write(start_string[i]);
        }
    }
}
