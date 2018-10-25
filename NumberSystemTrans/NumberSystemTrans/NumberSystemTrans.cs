using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemTrans
{
    class NumberSystemTrans
    {
        static void Main(string[] args)
        {
            try
            {
                SystemTranslator translator = new SystemTranslator();
                if (args.Length == 0 || Convert.ToInt32(args[1]) < 2 || Convert.ToInt32(args[1])>20)
                {
                    //if args is empty
                    //data request
                    Console.WriteLine("Input data: ");
                    Console.Write("Input number: ");
                    string num1;
                    num1 = Console.ReadLine();
                    string num2;
                    Console.Write("Input system: ");
                    num2 = Console.ReadLine();
                    if (Convert.ToInt32(num2) < 2 || Convert.ToInt32(num2) > 20) throw new Exception();
                    Console.WriteLine(translator.Translate(Convert.ToInt32(num1), Convert.ToInt32(num2)));
                }
                Console.WriteLine(translator.Translate(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])));
                Console.Read();
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error has occurred");
                Console.Read();
            }
        }
    }
}
