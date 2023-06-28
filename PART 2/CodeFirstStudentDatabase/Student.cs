using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStudentDatabase
{
    public class Student
    {
        public int StudentID { get; set; }
        public required string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[]? Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public int? GradeId { get; set; }


    }
}
