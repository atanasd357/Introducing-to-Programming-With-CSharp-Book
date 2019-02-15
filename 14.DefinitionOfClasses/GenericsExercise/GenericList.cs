using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    public class GenericList<T>
    {
        //const field
        private const int defaultListSize = 50;

        //fields
        private T[] elementsArray;
        private int count;

        //constructors
        public GenericList() :
            this(defaultListSize)
        { }
         
        public GenericList(int listSize)
        {
            this.elementsArray = new T[listSize];
            this.count = 0;
        }

        //methods
        public void AddElement(T newElement)
        {
            if (this.count >= this.elementsArray.Length)
            {
                Array.Resize(ref this.elementsArray, this.elementsArray.Length * 2);
            }
            this.elementsArray[this.count] = newElement;
            this.count++;
        }

        public T AccessElement(int elementIndex)
        {
            if (elementIndex <= 0 || elementIndex >= this.count)
            {
                throw new ArgumentOutOfRangeException("Invalid element index.");
            }
            return elementsArray[elementIndex];
        }

        public void RemoveElement(int elementIndex)
        {
            if (elementIndex <= 0 || elementIndex >= this.count)
            {
                throw new ArgumentOutOfRangeException("Invalid element index.");
            }
            
            for (int i = elementIndex; i < this.count - 1; i++) 
            {
                this.elementsArray[i] = this.elementsArray[i + 1];
            }
            this.elementsArray[this.count-1] = default(T);
            this.count--;
            Array.Resize(ref this.elementsArray, this.elementsArray.Length - 1);
        }

        public void InsertElementAtPosition(T element, int position)
        {
            if (position <= 0 || position >= this.count) 
            {
                throw new ArgumentOutOfRangeException("Invalid element position.");
            }
            this.elementsArray[position] = element;
        }

        public void ClearList()
        {
            for (int i = 0; i < this.elementsArray.Length; i++)
            {
                this.elementsArray[i] = default(T);
            }
            Array.Resize(ref this.elementsArray, 0);
        }

        public void SearchElementByValue(T elementValue)
        {
            bool isExist = false;
            for (int i = 0; i < this.count; i++)
            {
                if (this.elementsArray[i].Equals(elementValue) == true)
                {
                    if (!isExist)
                    {
                        Console.WriteLine("The element with value: {0} is finded in position: {1} in the list.",
                            elementValue, i);

                        isExist = true;
                    }
                    else
                    {
                        Console.WriteLine("The element with this value also finded in position: {0} in the list.", i);
                    }
                }
            }

            if (!isExist) 
            {
                Console.WriteLine("There is no element with this value in the list.");
            }          
        }

        //override method
        public override string ToString()
        {
            StringBuilder printList = new StringBuilder();
            if (this.elementsArray.Length != 0)
            {
                for (int i = 0; i < this.count; i++)
                {
                    printList.AppendLine(elementsArray[i].ToString());
                }           
            }
            else
            {
                printList.AppendLine("The list is empty!");
            }
            return printList.ToString();
        }
    }
}
