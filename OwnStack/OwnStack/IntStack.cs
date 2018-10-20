using System;

namespace OwnStack
{
    class IntStack
    {
        private int Capasity;
        private int Size;
        public int[] arrStack;
        public IntStack()
        {
            //default constructor
            this.Capasity = 10;
            this.Size = 0;
            this.arrStack = new int[Capasity];
        }
        public IntStack(int maxSize)
        {
            // constructor with parameter
            this.Capasity = maxSize;
            this.Size = 0;
            this.arrStack = new int[Capasity];
        }
        public void Resize(int maxSize)
        {
            // function changes stack size by argument
            this.Capasity = maxSize;
            Array.Resize(ref this.arrStack, Capasity);
        }
        public void Push(int element)
        {
            // insert an element at the beginning of the stack
            //if the size of the stack is equal to the maximum size
            //the maximum size increases
            if (this.Capasity <= this.Size)
            {
                this.Capasity++;
                this.Resize(Capasity);
            }
            int[] arrBuffer = new int[Capasity];
            arrBuffer[0] = element;
            Array.Copy(arrStack, 0, arrBuffer, 1, Size);
            Array.Resize(ref this.arrStack, Capasity);
            Array.Copy(arrBuffer, 0, arrStack, 0, Size + 1);
            this.Size++;
        }
        public int Pop()
        {
            // returns the first element of the stack, while removing it from the stack
            if (Size == 0)
            {
                throw new Exception("Error: stack is empty");
            }
            int element = arrStack[0];
            int[] arrBuffer = new int[Capasity];
            this.Size--;
            Array.Copy(arrStack, 1, arrBuffer, 0, Size);
            Array.Clear(arrStack,0,arrStack.Length);
            Array.Copy(arrBuffer, 0, arrStack, 0, Size);
            return element;
        }
        public int GetHead()
        {
            // returns the first element of the stack without deleting it
            return arrStack[0];
        }
    }
}
