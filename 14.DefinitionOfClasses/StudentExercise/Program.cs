using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 1, 2, 3, 4, 5, 6, 7
namespace StudentExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initial students data:");
            for (int i = 0; i < StudentTest.Students.Length; i++)
            {
                StudentTest.Students[i].PrintStudentInfo();
            }

            Console.WriteLine("The number of the students is: {0}\n", Student.studentCount);

            StudentTest.Students[0].TelNumber = 445000000;
            StudentTest.Students[1].FirstName = "Dimitar";
            StudentTest.Students[2].Email = "todorov@abv.bg";
            StudentTest.Students[2].TelNumber = 359000000;

            Console.WriteLine("Modified students data:");
            for (int i = 0; i < StudentTest.Students.Length; i++)
            {
                StudentTest.Students[i].PrintStudentInfo();
            }          
        }
    }
}
