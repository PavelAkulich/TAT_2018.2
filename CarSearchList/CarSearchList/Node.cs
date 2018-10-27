using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSearchList
{
    class Node
    {
        public Car car;
        public Node next;
        public Node prev;
        public Node(Car carIn)
        {
            car = carIn;
            next = null;
            prev = null;
        }
        public Node()
        {
            car = null;
            next = null;
            prev = null;
        }
        public Node(Car car, Node node)
        {
            this.car = car;
            this.next = node;
            node.prev = this;
        }
    }
}
