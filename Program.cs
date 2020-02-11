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
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            //students.Sort(new StudentCompareByAlder());
            students.Sort();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();

        }
    }
}
