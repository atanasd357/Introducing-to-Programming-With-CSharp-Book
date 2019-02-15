using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckStructure
{
    public class Deck
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

        private Node bottom;
        private Node leftTop;
        private Node rightTop;
        private int count;
        private int countLeft;
        private int countRight;

        public int Count
        {
            get { return this.count; }
        }

        public int CountLeft
        {
            get { return this.countLeft; }
        }

        public int CountRight
        {
            get { return this.countRight; }
        }

        public Deck()
        {
            this.bottom = null;
            this.leftTop = null;
            this.rightTop = null;
            this.count = 0;
            this.countLeft = 0;
            this.countRight = 0;
        }

        public void AddLeft(object element)
        {
            if (bottom == null)
            {
                this.bottom = new Node(element);
                this.leftTop = bottom;
            }
            else
            {
                Node newElement = new Node(element, leftTop);
                newElement.Next = leftTop;
                this.leftTop = newElement;
                
            }
            countLeft++;
            count++;
        }

        public void AddRight(object element)
        {
            if (bottom == null)
            {
                this.bottom = new Node(element);
                this.rightTop = bottom;
            }
            else
            {
                Node newElement = new Node(element, rightTop);
                newElement.Next = rightTop;
                this.rightTop = newElement;
            }
            countRight++;
            count++;
        }

        public object PeekLeft()
        {
            if (this.leftTop == null)
            {
                throw new NullReferenceException("The stack is empty");
            }

            return this.leftTop.Element;
        }

        public object PeekRight()
        {
            if (this.rightTop == null)
            {
                throw new NullReferenceException("The stack is empty");
            }

            return this.rightTop.Element;
        }

        public object PopLeft()
        {
            if (this.leftTop == null)
            {
                throw new NullReferenceException("There is no elements in left side!");
            }

            Node elementForRemove = this.leftTop;
            count--;
            countLeft--;
            if (countLeft == 0)
            {
                this.leftTop = null;
            }
            else
            {
                this.leftTop = leftTop.Next;
            }

            return elementForRemove.Element;
        }

        public object PopRight()
        {
            if (this.rightTop == null)
            {
                throw new NullReferenceException("There is no elements in right side!");
            }

            Node elementForRemove = this.rightTop;
            count--;
            countRight--;
            if (countRight == 0)
            {
                this.rightTop = null;
            }
            else
            {
                this.rightTop = rightTop.Next;
            }

            return elementForRemove.Element;
        }

        public void Clear()
        {
            if (this.count == 0)
            {
                throw new NullReferenceException("The deck is empty");
            }

            Node currentLeftNode = this.leftTop;
            Node currentRightNode = this.rightTop;

            while (currentLeftNode != null)
            {
                this.PopLeft();
                currentLeftNode = this.leftTop;
            }

            while (currentRightNode != null)
            {
                this.PopRight();
                currentRightNode = this.rightTop;
            }
        }
    }
}
