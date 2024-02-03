using Microsoft.EntityFrameworkCore;
using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationContext _context;
        public CourseRepository(ApplicationContext context)
        {
            this._context = context;
        }
        public List<Course> GetAll()
        {
            return _context.Courses.Include(d=>d.Department).ToList();
        }
        public Course GetById(int id)
        {
            return _context.Courses.Include(c=>c.Department).FirstOrDefault(c => c.Id == id);
        }
        public void Update(Course course)
        {
            _context.Courses.Update(course);
        }
        public void Add(Course courses)
        {
            _context.Courses.Add(courses);
        }
        public void Delete(int id)
        {
            _context.Courses.Remove(GetById(id));
        }
        public int Save() => _context.SaveChanges();

    }
}
