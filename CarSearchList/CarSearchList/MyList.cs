using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSearchList
{
    //list class
    //contains node, and list size
    class MyList
    {
        public Node NodeEl;
        public int size = 0;
        public MyList()
        {
            NodeEl = new Node();
        }
        public MyList(Car carInput)
        {
            NodeEl = new Node(carInput);
            size++;
        }
        public void AddHead(Car carInput)
        {
            //adds an item to the head of the list
            //increases the size of the list
            Node Node = new Node(carInput, this.NodeEl);
            this.NodeEl = Node;
            size++;
        }
        public MyList Search(Car car)
        {
            // searches the list for items whose Car.Color matches whith car.Color
            // adds search results to the new list
            // returns the resulting list
            MyList list = new MyList();
            while (size >= 1)
            {
                if(this.NodeEl.car.Color == car.Color)
                {
                    list.AddHead(this.NodeEl.car);
                }
                this.NodeEl = this.NodeEl.next;
                size--;
            }
            return list;
        }
        public void Print()
        {
            // display the list items
            while (size >= 1)
            {
                Console.WriteLine(this.NodeEl.car.Color + "   " + this.NodeEl.car.Model);
                this.NodeEl = this.NodeEl.next;
                size--;
            }
        }

    }
}
