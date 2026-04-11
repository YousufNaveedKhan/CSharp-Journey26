using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec07_studentapp
{
    public class Student
    {
        public string name;
        public int age;
        public double marks;

        public string GetResult()
        {
            string grade;
            if (marks >= 90)
                grade = "A+";
            else if (marks >= 80)
                grade = "A";
            else if (marks >= 70)
                grade = "B";
            else if (marks >= 60)
                grade = "C";
            else if (marks >= 50)
                grade = "D";
            else if (marks >= 40)
                grade = "E";
            else
                grade = "F";
            return grade;
        }
    }
}
