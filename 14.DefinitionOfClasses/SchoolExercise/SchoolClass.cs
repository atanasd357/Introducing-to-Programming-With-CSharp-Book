using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercise
{
    public class SchoolClass
    {
        //fields
        private string uniqueTextIdentifier = null;
        private List<Teacher> teachersList = new List<Teacher>();

        //constructors
        public SchoolClass() :
            this(null)
        { }

        public SchoolClass(string uniqueTextIdentifier) :
            this(uniqueTextIdentifier, new List<Teacher>())
        { }

        public SchoolClass(string uniqueTextIdentifier, List<Teacher> teachersList)
        {
            this.uniqueTextIdentifier = uniqueTextIdentifier;
            this.teachersList = teachersList;
        }

        //properties
        public string UniqueTextIdentifier
        {
            get { return this.uniqueTextIdentifier; }
            set { this.uniqueTextIdentifier = value; }
        }

        public List<Teacher>TeachersList
        {
            get { return this.teachersList; }
            set { this.teachersList = value; }
        }

        //method
        public void PrintSchoolClassTeachersInfo()
        {
            Console.WriteLine("\nThe list of the teachers who teach the class {0} is:", this.uniqueTextIdentifier);
            foreach(Teacher teacher in this.teachersList)
            {
                Console.WriteLine(teacher.Name);
            }
        }
    }
}
