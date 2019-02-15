using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercise
{
    public class Teacher
    {
        //fields
        private string name = null;
        private List<Discipline> disciplinesList = new List<Discipline>();

        //constructors
        public Teacher() :
            this(null)
        { }

        public Teacher(string name) :
            this(name, new List<Discipline>())
        { }

        public Teacher(string name, List<Discipline> disciplinesList)
        {
            this.name = name;
            this.disciplinesList = disciplinesList;
        }

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<Discipline> DisciplinesList
        {
            get { return this.disciplinesList; }
            set { this.disciplinesList = value; }
        }

        //method
        public void PrintDisciplineList()
        {
            Console.WriteLine("\nA list of the disciplines of the teacher {0}:\n", this.name);
            foreach (Discipline discipline in this.disciplinesList)
            {
                Console.WriteLine(discipline);
            }
        }
    }
}
