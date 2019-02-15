using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExercise
{
    public class StudentTest
    {
        //static field
        private static Student[] students;

        //static constructor
        static StudentTest()
        {
            students = new Student[3];
            GenerateStudents();
        }

        // static property
        public static Student[] Students
        {
            get { return students; }
            set { students = value; }
        }

        //static method
        public static void GenerateStudents()
        {
            students[0] = new Student("Ivan", "Delchev", 2, Specialty.Informatics, University.NewBulgarianUniversity,
                  "ivandel@abv.bg");

            students[1] = new Student("Atanas", "Delyanov", 4, Specialty.Finance, University.UniversityOfPlovdiv,
                "atanas_delyanov@abv.bg", 0870000000);

            students[2] = new Student("Vencislav", "Todorov", 3, Specialty.Chemistry, University.UNWE);         
        }
    }
}
