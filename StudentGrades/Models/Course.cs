using System.Collections.Generic;

namespace StudentGrades.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}