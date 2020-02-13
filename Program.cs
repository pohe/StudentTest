using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student("Poul", "123123", 58);
            Student s2= new Student("Sebastian", "54545", 24);
            Student s3 = new Student("Nicolai", "99999",22);
            Student s4 = new Student("Arsen", "54545", 24);
            Student s5 = new Student("Sebastian", "6666", 24);
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            //students.Sort(new StudentCompareByAlder());
            //students.Sort();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            //Predicate<Student> studentMatchFunc = mobileSearch;
            Predicate<Student> studentMatchFunc = (Student s) =>
            {
                return s.Mobile == "54545";
            };
            //Student foundStudent = students.Find(studentMatchFunc);
            Student foundStudent = students.Find((Student s) =>
            {
                return s.Mobile == "54545";
            });
            //Student foundStudent = students.Find(s=>s.Mobile== "54545");

            if (foundStudent != null)
            {
                Console.WriteLine($"Student fundet {foundStudent.ToString()}");
            }

            Console.WriteLine("Find den sidste student i listen med mobile nr 54545");

            Student lastStudent = students.FindLast( s=>  s.Mobile== "54545" );
            if (lastStudent != null)
            {
                Console.WriteLine($"Sidste student fundet med mobile 54545 :{lastStudent.ToString()}");
            }


            Console.WriteLine("Check om der eksisterer en student i listen med navnet Arsen");

            if (students.Exists( s=> s.Name == "Arsen"  ) )
                Console.WriteLine("Student med navnet Arsen findes");
            else
            {
                Console.WriteLine("Student med navnet Arsen findes ikke");
            }

            Console.WriteLine("Find den alle studenter i listen med mobile nr 54545");
            List<Student> studentsFoundMobile = students.FindAll(s => s.Mobile == "54545");
            foreach (Student student in studentsFoundMobile)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Find index for en student i listen med navnet Arsen");
            int indexForArsen = students.FindIndex(s => s.Name == "Arsen");
            Console.WriteLine($"Index for Arsen i listen {indexForArsen}");

            Console.WriteLine("Find sidste index for student i listen med mobile 54545");

            int lastIndexArsen = students.FindLastIndex(s => s.Mobile == "54545");
            Console.WriteLine($"Sidste Index for 54545 i listen {lastIndexArsen}");


            Console.WriteLine("Find student med navnet Sebastian og mobile 54545");
            Student studentSebastian54545 = students.Find(s => s.Mobile == "54545" && s.Name=="Sebastian");
            if (studentSebastian54545!= null)
                Console.WriteLine($"Student fundet med navnet Sebastian og 54545 {studentSebastian54545}");
            else
            {
                Console.WriteLine($"Student fundet med navnet Sebastian og 54545 ikke fundet");
            }

            Console.WriteLine("Find alle studenter med navnet Sebastian og mobile 54545");
            List<Student> stundetsSebastian54545= students.FindAll(s => s.Mobile == "54545" && s.Name == "Sebastian");
            foreach (Student student in stundetsSebastian54545)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("Find alle studenter med navnet Sebastian eller mobile 54545");
            List<Student> stundetsSebastianOr = students.FindAll(s => s.Mobile == "54545" || s.Name == "Sebastian");
            foreach (Student student in stundetsSebastianOr)
            {
                Console.WriteLine(student);
            }


            Console.ReadLine();

            bool mobileSearch(Student s)
            {
                return s.Mobile == "54545";
            }

        }
    }
}
