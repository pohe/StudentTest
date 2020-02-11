using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    public class StudentCompareByAlder: IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.Age < s2.Age)
                return -1;
            else if (s1.Age > s2.Age)
                return 1;
            else return 0;

        }
    }
}
