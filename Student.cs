using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    public class Student//: IComparable<Student>
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int Age { get; set; }

        public Student(string name, string mobile, int age)
        {
            Name = name;
            Mobile = mobile;
            Age = age;
        }

        public override string ToString()
        {
            return $"Navn {Name} telefon {Mobile} alder {Age}";
        }

        public int CompareTo(Student other)
        {
            return Name.CompareTo(other.Name);

        }


    }
}
