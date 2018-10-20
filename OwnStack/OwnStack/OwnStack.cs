using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnStack
{
    class OwnStack
    {
        static void Main(string[] args)
        {
            try

            {
                IntStack stack = new IntStack();
                for (int i = 0; i < 11; i++)
                {
                    stack.Push(i);
                }
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(stack.arrStack[i]);
                }
                Console.WriteLine();
                Console.WriteLine(stack.Pop());
                Console.WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(stack.arrStack[i]);
                }
                Console.Read();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: stack is empty");
                Console.Read();
            }
            
        }
    }
}
