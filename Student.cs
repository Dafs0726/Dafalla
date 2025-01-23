using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmd
{
    public struct Student
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public int Year { get; set; }
        public int Id { get; set; }

        public float Grades { get; set; }
        public List<SubjectGrade> SubjectGrades { get; set; }
    }
}
