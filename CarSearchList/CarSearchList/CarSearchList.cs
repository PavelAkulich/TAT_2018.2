using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSearchList
{
    class CarSearchList
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.AddHead(new Car("calina", "lada", "cherry"));
            list.AddHead(new Car("q7", "audi", "white"));
            list.AddHead(new Car("almera", "nissan", "red"));
            list.AddHead(new Car("passat", "volkswagen", "black"));
            list.AddHead(new Car("picasso", "citroen", "black"));
            Console.WriteLine("newList: ");
            MyList newList = list.Search(new Car("q7","audi","black"));
            newList.Print();
            Console.Read();
        }
    }
}
