using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = args.MakeStartString();
            startString.FindMaxSubstring();
            Console.Read();
        }
        
        
    }
}
