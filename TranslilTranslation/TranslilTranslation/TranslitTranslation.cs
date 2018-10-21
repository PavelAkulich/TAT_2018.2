using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslilTranslation
{
    class TranslitTranslation
    {
        static void Main(string[] args)
        {
            try
            {
                Translator translator = new Translator();
                Console.WriteLine(translator.GetTransString(args[0]));
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.Write("Exception");
                Console.Read();
            }
        }
    }
}
