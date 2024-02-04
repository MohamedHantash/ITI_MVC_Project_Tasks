using Microsoft.EntityFrameworkCore;
using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationContext _context;
        public StudentRepository(ApplicationContext context)
        {
            this._context = context;
        }
        public List<Student> GetAll()
        {
            return _context.Students.Include(s=>s.Department).ToList();
        }
        public Student ShowResult(int student_Id, int course_Id)
        {
            Student student = _context.Students
                .Include(s => s.CourseResults.Where(s => s.Course_Id == course_Id))
                .ThenInclude(s => s.Course)
                .FirstOrDefault(s => s.Id == student_Id);

            return student;
        }
    }
}
