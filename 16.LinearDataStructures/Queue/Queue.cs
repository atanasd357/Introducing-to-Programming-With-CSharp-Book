using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        private object head;
        private object tail;
        private object[] array;
        private int count;

        private static readonly int INITIAL_CAPACITY = 8;

        public int Count
        {
            get { return this.count; }
        }

        public Queue()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
            array = new object[INITIAL_CAPACITY];
        }

        public void Enqueue(object element)
        {
            if (head == null && tail == null) 
            {
                this.head = element;
                this.tail = head;
                count++;
            }
            else
            {
                Node newElement = new Node(element, head);
                newElement.Next = tail;
                this.top = newElement;
                count++;
            }
        }
    }
}
