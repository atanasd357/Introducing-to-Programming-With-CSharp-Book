using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Display
    {
        //fields
        private decimal size = 0;
        private ulong colors = 0;

        //constructors
        public Display() :
            this(0)
        { }

        public Display(decimal size) :
            this(size, 0)
        { }
        
        public Display(decimal size, ulong colors)
        {
            this.size = size;
            this.colors = colors;
        }

        //properties
        public decimal Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public ulong Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }

        //method
        public string PrintDisplayInfo()
        {
            StringBuilder dInfo = new StringBuilder();
            dInfo.AppendLine("Display size: " + this.size);
            dInfo.AppendLine("Display colors: " + this.colors);

            return dInfo.ToString();
        }
    }
}
