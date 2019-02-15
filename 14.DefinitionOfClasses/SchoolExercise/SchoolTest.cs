using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercise
{
    public class SchoolTest
    {
        public static void TestSchool()
        {
            //create Teacher objects
            Teacher ivanVelkov = new Teacher("Ivan Velkov", new List<Discipline>());
            ivanVelkov.DisciplinesList.Add(new Discipline("Math", 25, 10));
            ivanVelkov.DisciplinesList.Add(new Discipline("Physics", 20, 10));
            ivanVelkov.DisciplinesList.Add(new Discipline("Informatics", 30, 20));

            Teacher dimitarHristov = new Teacher("Dimitar Hristov", new List<Discipline>());
            dimitarHristov.DisciplinesList.Add(new Discipline("Biology", 20, 15));
            dimitarHristov.DisciplinesList.Add(new Discipline("Physical Education", 5, 25));
            dimitarHristov.DisciplinesList.Add(new Discipline("Literature", 22, 8));

            Teacher georgiTerziev = new Teacher("Georgi Terziev", new List<Discipline>());
            georgiTerziev.DisciplinesList.Add(new Discipline("History", 23, 5));
            georgiTerziev.DisciplinesList.Add(new Discipline("Psychology", 17, 5));
            georgiTerziev.DisciplinesList.Add(new Discipline("Philosophy", 15, 5));

            //create Student objects
            Student atanasPetkov = new Student("Atanas Petkov", 1485);
            Student dianaMiroslavova = new Student("Diana Miroslavova", 8796);
            Student gerganaDimitrova = new Student("Gergana Dimitrova", 6524);
            Student hristoDinkov = new Student("Hristo Dinkov", 2342);
            Student dimitarMilchev = new Student("Dimitar Milchev", 6423);
            Student hristinaShtereva = new Student("Hristina Shtereva", 3245);
            Student georgiSavov = new Student("Georgi Savov", 9249);
            Student petarSimeonov = new Student("Petar Simeonov", 9742);
            Student yanaFilipova = new Student("Yana Filipova", 3256);
            Student teodorDaskalov = new Student("Teodor Daskalov", 3984);

            //create SchoolClass objects
            SchoolClass nineB = new SchoolClass("9B", new List<Teacher>());
            nineB.TeachersList.Add(ivanVelkov);
            nineB.TeachersList.Add(dimitarHristov);

            SchoolClass elevenA = new SchoolClass("11A", new List<Teacher>());
            elevenA.TeachersList.Add(ivanVelkov);
            elevenA.TeachersList.Add(georgiTerziev);

            SchoolClass twelfB = new SchoolClass("12B", new List<Teacher>());
            twelfB.TeachersList.Add(dimitarHristov);
            twelfB.TeachersList.Add(georgiTerziev);

            //create school object
            School mathHighSchool = new School("Mathematical High School \"Konstantin Velichkov\"");

            //add school classes to School object's classes list
            mathHighSchool.ClassesList.Add(nineB);
            mathHighSchool.ClassesList.Add(elevenA);
            mathHighSchool.ClassesList.Add(twelfB);

            //add students to School object's students list
            mathHighSchool.StudentsList.Add(atanasPetkov);
            mathHighSchool.StudentsList.Add(dianaMiroslavova);
            mathHighSchool.StudentsList.Add(gerganaDimitrova);
            mathHighSchool.StudentsList.Add(hristoDinkov);
            mathHighSchool.StudentsList.Add(dimitarMilchev);
            mathHighSchool.StudentsList.Add(hristinaShtereva);
            mathHighSchool.StudentsList.Add(georgiSavov);
            mathHighSchool.StudentsList.Add(petarSimeonov);
            mathHighSchool.StudentsList.Add(yanaFilipova);
            mathHighSchool.StudentsList.Add(teodorDaskalov);

            //print info for school
            mathHighSchool.PrintSchoolInfo();

            //print info for school classes
            nineB.PrintSchoolClassTeachersInfo();
            elevenA.PrintSchoolClassTeachersInfo();
            twelfB.PrintSchoolClassTeachersInfo();

            //print info for teachers
            ivanVelkov.PrintDisciplineList();
            dimitarHristov.PrintDisciplineList();
            georgiTerziev.PrintDisciplineList();
        }
    }
}
