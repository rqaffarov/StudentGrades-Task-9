using StudentGrades.Models;
using StudentGrades.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentGrades.Repositories
{
    public class CourseRepository
    {
        private readonly SchoolContext _context;

        public CourseRepository()
        {
            _context = new SchoolContext();
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void Update(Course course)
        {
            var existing = _context.Courses.Find(course.Id);
            if (existing != null)
            {
                existing.Title = course.Title;
                existing.Credits = course.Credits;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }

        public int Count()
        {
            return _context.Courses.Count();
        }
    }
}