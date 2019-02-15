using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicStack
{
    public class DynamicStack
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return this.element; }
                set { this.element = value; }
            }

            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }

            public Node(object element)
            {
                this.element = element;
                this.next = null;
            }

            public Node(object element, Node previousNode)
            {
                this.element = element;
                this.next = previousNode;
            }  
        }

        private Node top;
        private int count;

        public int Count
        {
            get { return this.count; }
        }

        public DynamicStack()
        {
            this.top = null;
            this.count = 0;
        }

        public void Push(object element)
        {
            if (top == null)
            {
                this.top = new Node(element);
                count++;
            }
            else
            {
                Node newElement = new Node(element, top);
                newElement.Next = top;
                this.top = newElement;          
                count++;
            }
        }

        public object Peek()
        {
            if (this.top == null)
            {
                throw new NullReferenceException("The stack is empty");
            }

            return this.top.Element;
        }

        public object Pop()
        {
            if (this.top == null)
            {
                throw new NullReferenceException("The stack is empty");
            }

            Node elementForRemove = this.top;

            count--;
            if (count == 0)
            {
                this.top = null;
            }
            else
            {
                this.top = top.Next;
            }

            return elementForRemove.Element;
        }

        public bool Contains(object element)
        {
            Node currentNode = this.top;
            bool isFinded = false;

            while (currentNode != null)
            {
                if (currentNode.Element.Equals(element))
                {
                    isFinded = true;
                    return isFinded;
                }
                currentNode = currentNode.Next;
            }

            return isFinded;
        }

        public object[] ToArray()
        {
            if (count <= 0)
            {
                throw new NullReferenceException("The stack is empty");
            }

            object[] array = new object[this.count];

            Node currentNode = this.top;
            int index = 0;

            while (currentNode != null)
            {
                array[index] = currentNode.Element;
                currentNode = currentNode.Next;
                index++;
            }

            return array;
        }

        public void Clear()
        {
            if (this.top == null)
            {
                throw new NullReferenceException("The stack is empty");
            }

            Node currentNode = this.top;

            while (currentNode != null)
            {
                this.Pop();
                currentNode = this.top;
            }
        }
    }
}
