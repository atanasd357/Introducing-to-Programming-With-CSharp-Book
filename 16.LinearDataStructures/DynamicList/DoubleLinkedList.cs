using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    public class DoubleLinkedList
    {
        private class Node
        {
            private object element;
            private Node previous;
            private Node next;
            
            public object Element
            {
                get { return this.element; }
                set { this.element = value; }
            }

            public Node Previous
            {
                get { return this.previous; }
                set { this.previous = value; }
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
                this.previous = null;
            }

            public Node(object element, Node previousNode)
            {
                this.element = element;
                previousNode.next = this;
                this.next = null;
                this.previous = previousNode;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public int Count
        {
            get { return this.count; }
        }

        public DoubleLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object element)
        {
            if (head == null) 
            {
                this.head = new Node(element);
                this.tail = head;
                count++;
            }
            else
            {
                Node newElement = new Node(element, tail);
                newElement.Previous = tail;
                tail = newElement;
                count++;
            }
        }

        public object this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index!");
                }

                Node currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Element;
            }

            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index!");
                }

                Node currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Element = value;
            }
        }

        public void InsertAt(int index, object element)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }

            this[index] = element;
        }

        public void Remove(object element)
        {
            Node currentNode = this.head;
            Node previousNode = null;

            while (currentNode != null)
            {
                if ((currentNode.Element != null && currentNode.Element.Equals(element))
                    || (currentNode.Element == null) && (element == null))
                {
                    break;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            if (currentNode != null)
            {
                count--;
                if (count == 0)
                {
                    head = null;
                }
                else if (previousNode == null)
                {
                    head = currentNode.Next;
                }
                else
                {
                    previousNode.Next = currentNode.Next;
                }

                Node lastElement = null;
                if (this.head != null)
                {
                    lastElement = this.head;

                    while (lastElement.Next != null)
                    {
                        lastElement = lastElement.Next;
                    }
                }

                this.tail = lastElement;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }

            if (this.head != null)
            {
                Node currentNode = this.head;
                Node previousNode = null;
                int indexCount = 0;

                while (currentNode != null)
                {
                    if (indexCount == index)
                    {
                        break;
                    }

                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                    indexCount++;
                }

                if (currentNode != null)
                {
                    count--;
                    if (count == 0)
                    {
                        head = null;
                    }
                    else if (previousNode == null)
                    {
                        head = currentNode.Next;
                    }
                    else
                    {
                        previousNode.Next = currentNode.Next;
                    }

                    Node lastElement = null;
                    if (this.head != null)
                    {
                        lastElement = this.head;

                        while (lastElement.Next != null)
                        {
                            lastElement = lastElement.Next;
                        }
                    }

                    this.tail = lastElement;
                }
            }
        }

        public int IndexOf(object element)
        {
            Node currentNode = this.head;
            int index = 0;

            while (currentNode != null)
            {
                if ((currentNode.Element != null && currentNode.Element.Equals(element))
                    || (currentNode.Element == null) && (element == null))
                {
                    return index;
                }

                currentNode = currentNode.Next;
                index++;
            }

            return -1;
        }

        public bool Contains(object element)
        {
            int index = IndexOf(element);
            bool isFinded = false;

            if (index != -1) 
            {
                isFinded = true;
                return isFinded;
            }
            else
            {
                return isFinded;
            }
        }

        //Task 15
        public void Sort()
        {
            object temp;
            for (int i = 0; i < this.count - 1; i++)
            {
                for (int j = 0; j < this.count - 1; j++) 
                {
                    if ((int)this[j] > (int)this[j + 1]) 
                    {
                        temp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = temp;
                    }
                }
            }
        }

        public object[] ToArray()
        {
            object[] array = new object[this.count];
            if (count > 0)
            {
                Node currentNode = this.head;
                int index = 0;

                while (currentNode != null)
                {
                    array[index] = currentNode.Element;
                    currentNode = currentNode.Next;
                    index++;
                }
            }
            return array;
        }
    }
}
