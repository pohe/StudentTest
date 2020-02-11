using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    class StudentCompareByMobile: IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            return s1.Mobile.CompareTo(s2.Mobile);
        }
    }
}
