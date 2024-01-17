using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Analyzer
{
    internal class Student
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Year { get; set; }
        public List<double> Grades { get; set; }
        //if there are no grades we return 0.0
        public double AverageGrade => Grades.Any() ? Grades.Average():0.0;
 
    }
}


