using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_ITI_Tasks.Models;
using MVC_ITI_Tasks.Repository;
using MVC_ITI_Tasks.ViewModel;
using System.Numerics;

namespace MVC_ITI_Tasks.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ApplicationContext _context;
        public StudentController(IStudentRepository studentRepository, ApplicationContext context)
        {
            this._studentRepository = studentRepository;
            _context = context;
        }
        public IActionResult GetAll()
        {
            List<Student> students = _studentRepository.GetAll();
            return View(students);
        }

        public IActionResult ShowResult(int student_Id, int course_Id = 1)
        {
            Student student = _studentRepository.ShowResult(student_Id, course_Id);
           
            var studentCourseResult = student.CourseResults.FirstOrDefault();
            var viewModelData = new StudentCoursesViewModel();
            viewModelData.Student_Id = student.Id;
            viewModelData.Stuednt_Name = student.Name;
            viewModelData.Degree = studentCourseResult.Degree;
            viewModelData.CourseName = studentCourseResult.Course.Name;

            if (studentCourseResult.Degree >= studentCourseResult.Course.MinDegree)
            {
                viewModelData.Color = "green";
            }
            else
            {
                viewModelData.Color = "red";
            }
            return View(viewModelData);
        }
        public IActionResult ShowStudentResult(int student_Id)
        {
            Student student =_context.Students
                .Include(s=>s.CourseResults)
                .ThenInclude(s=>s.Course).FirstOrDefault(s=>s.Id == student_Id);    

            return View(student);
        }
    }
}
