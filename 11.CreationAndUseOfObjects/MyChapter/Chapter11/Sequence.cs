using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChapter.Chapter11
{
    public class Sequence
    {
        private static int currentValue = 0;

        private Sequence()
        {
        }

        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }

        public static int NextValueParam(int currentValue)
        {
            currentValue++;
            return currentValue;
        }
    }
}
