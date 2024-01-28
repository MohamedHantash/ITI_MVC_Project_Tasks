using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_ITI_Tasks.Models;
using MVC_ITI_Tasks.ViewModel;

namespace MVC_ITI_Tasks.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationContext _context;
        public StudentController(ApplicationContext context)
        {
            this._context=context;
        }
            
        public IActionResult ShowResult(int student_Id)//,int course_Id
        {
            Student student = _context.Students.Include(s=>s.CourseResults)
                .ThenInclude(s=>s.Courses)
                .FirstOrDefault(s => s.Id == student_Id);
            var viewModelData = new StudentCoursesViewModel();
            viewModelData.Student_Id = student.Id;
            viewModelData.Stuednt_Name= student.Name;
            
            return View(student);
        }
    }
}
