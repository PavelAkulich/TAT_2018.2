using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslilTranslation
{
    class Translator
    {
        private string[] rusSymbol = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л",
            "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ы", "э", "ю", "я" };
        private string[] transSymbol = { "a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l",
            "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "sch", "y", "e", "yu", "ya" };
        public string GetTransString(string args)
        {
            // method calls the method of determining the language and then changes 
            //returns a string in another language
            string translatedString = null;
            if (CheckLang(args.ToLower()))
                translatedString = TransFromRusToTranslit(args.ToLower());
            else
                translatedString = TransFromTranslitToRus(args.ToLower());
            return translatedString;
        }
        private bool CheckLang(string args)
        {
            // determines the language in case the string contains characters of two languages ​​gives an error 
            //in the case of the Russian language returns true, if English false
            bool rusSym = false;
            bool engSym = false;
            byte[] byteString = System.Text.Encoding.Default.GetBytes(args);
            foreach(byte i in byteString)
            {
                if (i >= 224 && i <= 255)
                    rusSym = true;
                if (i >= 97 && i <= 122)
                    engSym = true;
            }
            if (engSym && rusSym) throw new Exception("string contain Russian and English characters");
            if (engSym && !rusSym)
                return false;
            else
                return true;
        }
        private string TransFromRusToTranslit(string args)
        {
            // method of translating the language from Russian to transtit 
            //returns the final string
            StringBuilder resString = new StringBuilder();
            resString.Append("");
            for (int i=0;i<args.Length;i++)
            {
                bool isSymbol=true;
                if (args[i].ToString() == "ь" || args[i].ToString() == "ъ")
                    continue;
                for(int j=0;j<31;j++)
                {
                    if(args[i].ToString() == rusSymbol[j])
                    {
                        resString.Append(transSymbol[j]);
                        isSymbol = !isSymbol;
                        break;
                    }
                }
                if (isSymbol) resString.Append(args[i]);
            }
            return resString.ToString();
        }
        private string TransFromTranslitToRus(string args)
        {
            // method of translating the language from transtit to Russian
            //returns the final string
            StringBuilder resString = new StringBuilder();
            resString.Append("");
            for (int i = 0; i < args.Length; i++)
            {
                bool isSymbol = true;
                if (i + 1 < args.Length)
                {
                    if (args[i].ToString() == "y" && args[i + 1].ToString() == "o")
                    {
                        resString.Append(rusSymbol[6]);
                        i += 2;
                        continue;
                    }
                    else if (args[i].ToString() == "y" && args[i + 1].ToString() == "u")
                    {
                        resString.Append(rusSymbol[29]);
                        i += 2;
                        continue;
                    }
                    else if (args[i].ToString() == "y" && args[i + 1].ToString() == "a")
                    {
                        resString.Append(rusSymbol[30]);
                        i += 2;
                        continue;
                    }
                    else if (args[i].ToString() == "z" && args[i + 1].ToString() == "h")
                    {
                        resString.Append(rusSymbol[7]);
                        i += 2;
                        continue;
                    }
                    else if (args[i].ToString() == "k" && args[i + 1].ToString() == "h")
                    {
                        resString.Append(rusSymbol[22]);
                        i += 2;
                        continue;
                    }
                    else if (args[i].ToString() == "t" && args[i + 1].ToString() == "s")
                    {
                        resString.Append(rusSymbol[23]);
                        i += 2;
                        continue;
                    }
                    else if (args[i].ToString() == "c" && args[i + 1].ToString() == "h")
                    {
                        resString.Append(rusSymbol[24]);
                        i += 2;
                        continue;
                    }
                    else if (args[i].ToString() == "s" && args[i + 1].ToString() == "h")
                    {
                        resString.Append(rusSymbol[25]);
                        i += 2;
                        continue;
                    }
                    else if (args[i].ToString() == "s" && args[i + 1].ToString() == "c" && args[i + 2].ToString() == "h")
                    {
                        resString.Append(rusSymbol[26]);
                        i += 3;
                        continue;
                    }
                }
                for (int j = 0; j < 31; j++)
                {
                    if (j == 6 || j == 7 || j == 22 || j == 23 || j == 24 || j == 25 || j == 26 || j == 29 || j == 30)
                        continue;
                    if (args[i].ToString() == transSymbol[j])
                    {
                        resString.Append(rusSymbol[j]);
                        isSymbol = !isSymbol;
                        break;
                    }
                }
                if (isSymbol) resString.Append(args[i]);
            }
            return resString.ToString();
        }
    }
}
