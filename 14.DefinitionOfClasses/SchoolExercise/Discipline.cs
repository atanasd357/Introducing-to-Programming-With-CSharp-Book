using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercise
{
    public class Discipline
    {
        //fields
        private string name = null;
        private ushort numberOfLessons = 0;
        private ushort numberOfExercises = 0;

        //constructors
        public Discipline() :
           this(null)
        { }

        public Discipline(string name) :
            this(name, 0)
        { }

        public Discipline(string name, ushort numberOfLessons) :
            this(name, numberOfLessons, 0)
        { }

        public Discipline(string name, ushort numberOfLessons, ushort numberOfExercises)
        {
            this.name = name;
            this.numberOfLessons = numberOfLessons;
            this.numberOfExercises = numberOfExercises;
        }

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public ushort NumberOfLessons
        {
            get { return this.numberOfLessons; }
            set { this.numberOfLessons = value; }
        }

        public ushort NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
        }

        //override method
        public override string ToString()
        {
            StringBuilder disciplineInfoPrint = new StringBuilder();
            disciplineInfoPrint.AppendLine("Discipline name: " + this.name);
            disciplineInfoPrint.AppendLine("Number of lessons: " + this.numberOfLessons);
            disciplineInfoPrint.AppendLine("Number of exercises: " + this.numberOfExercises);

            return disciplineInfoPrint.ToString();
        }
    }
}
