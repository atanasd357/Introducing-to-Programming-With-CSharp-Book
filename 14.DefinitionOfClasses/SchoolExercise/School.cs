using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercise
{
    public class School
    {
        //fields
        private string name = null;
        private List<SchoolClass> classesList = new List<SchoolClass>();
        private List<Student> studentsList = new List<Student>();

        //constructors
        public School() :
            this(null)
        { }

        public School(string name) :
            this(name, new List<SchoolClass>())
        { }

        public School(string name, List<SchoolClass> classesList) :
           this(name, classesList, new List<Student>())
        { }

        public School(string name, List<SchoolClass> classesList, List<Student> studentsList)
        {
            this.name = name;
            this.classesList = classesList;
            this.studentsList = studentsList;
        }

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<SchoolClass> ClassesList
        {
            get { return this.classesList; }
            set { this.classesList = value; }
        }

        public List<Student> StudentsList
        {
            get { return this.studentsList; }
            set { this.studentsList = value; }
        }

        //method
        public void PrintSchoolInfo()
        {
            Console.WriteLine("Information about {0}", this.name);
            Console.WriteLine("\nClasses that are studying in this school is:");
            foreach(SchoolClass schoolClass in this.classesList)
            {
                Console.WriteLine(schoolClass.UniqueTextIdentifier);
            }

            Console.WriteLine("\nStudents that are studying in this school is:");
            foreach(Student student in this.studentsList)
            {
                Console.WriteLine("Name: " + student.Name + ", Unique number: " + student.UniqueNumber);
            }          
        }
    }
}
