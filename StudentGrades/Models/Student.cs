using System.Collections.Generic;

namespace StudentGrades.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}