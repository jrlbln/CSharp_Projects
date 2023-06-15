 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Student
    {
        public String name;
        public String major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa) 
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors() 
        {
            if (gpa >= 3.5) 
            {
                return true;
            }   
                return false;
        } 

    }
}
