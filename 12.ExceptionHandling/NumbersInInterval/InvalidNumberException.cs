using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInInterval
{
    class InvalidNumberException : Exception
    {
        public InvalidNumberException()
            : base(String.Format("Invalid number!"))
        {

        }

        public InvalidNumberException(int firstValue, int secondValue)
            : base(String.Format("Invalid number! The number should be between {0} and {1}", firstValue, secondValue))
        {

        }

    }
}
