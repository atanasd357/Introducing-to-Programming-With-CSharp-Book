using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExercise
{
    //enumerations
    public enum University
    {
        UniversityOfPlovdiv,
        UniversityOfSofia,
        NewBulgarianUniversity, 
        UNWE
    }

    public enum Specialty
    {
        Biology,
        Chemistry,
        Math,
        Informatics,
        Finance
    }

    public class Student
    {
        //static field
        public static int studentCount = 0;

        //non-static fields
        private string firstName = null;
        private string secondName = null;
        private int course = 0;
        private Specialty specialty = 0;
        private University university = 0;
        private string email = null;
        private int telNumber = 0;

        //constructors
        public Student() :
            this(null)
        { }

        public Student(string firstName) :
            this(firstName, null)
        { }

        public Student(string firstName, string secondName) :
            this(firstName, secondName, 0)
        { }

        public Student(string firstName, string secondName, int course) :
            this(firstName, secondName, course, new Specialty())
        { }

        public Student(string firstName, string secondName, int course, Specialty specialty) :
            this(firstName, secondName, course, specialty, new University())
        { }

        public Student(string firstName, string secondName, int course, Specialty specialty,
            University university) :
            this(firstName, secondName, course, specialty, university, "not entered")
        { }

        public Student(string firstName, string secondName, int course, Specialty specialty,
            University university, string email) :
            this(firstName, secondName, course, specialty, university, email, 0)
        { }
        
        public Student(string firstName, string secondName, int course, Specialty specialty,
         University university, string email, int telNumber)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Email = email;
            this.TelNumber = telNumber;
            Student.studentCount++;
        }

        //properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public int Course { get => course; set => course = value; }
        public Specialty Specialty { get => specialty; set => specialty = value; }
        public University University { get => university; set => university = value; }
        public string Email { get => email; set => email = value; }
        public int TelNumber { get => telNumber; set => telNumber = value; }

        //method
        public void PrintStudentInfo()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.SecondName + "\n" +
                "Course: " + this.Course + "\n" +
                "Speciality: " + this.Specialty + "\n" +
                "University: " + this.University + "\n" +
                "E-mail: " + this.Email + "\n" +
                "Telephone number: " + this.TelNumber + "\n");
        }
    }
}
