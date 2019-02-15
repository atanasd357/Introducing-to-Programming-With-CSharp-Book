using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercise
{
    public class Student
    {
        //fields
        private string name = null;
        private ulong uniqueNumber = 0;

        //constructors
        public Student() :
            this(null)
        { }

        public Student(string name) :
            this(name, 0)
        { }

        public Student(string name, ulong uniqueNumber)
        {
            this.name = name;
            this.uniqueNumber = uniqueNumber;
        }

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        } 

        public ulong UniqueNumber
        {
            get { return this.uniqueNumber; }
            set { this.uniqueNumber = value; }
        }

        //override method
        public override string ToString()
        {
            StringBuilder studentInfoPrint = new StringBuilder();
            studentInfoPrint.AppendLine("Student name: " + this.name);
            studentInfoPrint.AppendLine("Unique number: " + this.uniqueNumber);
            studentInfoPrint.AppendLine();

            return studentInfoPrint.ToString();
        }
    }
}
