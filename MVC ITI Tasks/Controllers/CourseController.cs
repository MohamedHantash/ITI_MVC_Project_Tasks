using Microsoft.AspNetCore.Mvc;
using MVC_ITI_Tasks.Models;
using MVC_ITI_Tasks.Repository;
using System.Reflection.Metadata.Ecma335;

namespace MVC_ITI_Tasks.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _coursesRepository;
        private readonly IDepartmentRepository _departmentRepository;
        public CourseController (ICourseRepository coursesRepository,
            IDepartmentRepository departmentRepository)
        {
            this._coursesRepository = coursesRepository;
            this._departmentRepository = departmentRepository;
        }
        public IActionResult GetAll()
        {
            return View(_coursesRepository.GetAll());
        }
        public IActionResult Details(int id)
        {
            Courses course =_coursesRepository.GetById(id);
            if(course != null)
            {
                return View(course);
            }
            return RedirectToAction("GetAll");
        }
        public IActionResult Add()
        {
          
            ViewData["deptList"] = _departmentRepository.GetAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Courses course)
        {
            if(ModelState.IsValid)
            {
                _coursesRepository.Add(course);
                _coursesRepository.Save();
                return RedirectToAction("GetAll");
            }
            ViewData["deptList"] = _departmentRepository.GetAll();
            return View(course);
        }
        public IActionResult Edit(int id)
        {
            Courses course = _coursesRepository.GetById(id);
            if(course != null)
            {
                ViewData["deptList"]=_departmentRepository.GetAll();
                return View(course);
            }
            return RedirectToAction("GetAll");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Courses course)
        {
            if(ModelState.IsValid)
            {
                _coursesRepository.Update(course);
                _coursesRepository.Save();
                return RedirectToAction("GetAll");
            }
            ViewData["deptList"] = _departmentRepository.GetAll();
            return View(course);
        }
        public IActionResult Delete(int id)
        {
            Courses course = _coursesRepository.GetById(id);
            if (course != null)
            {
                _coursesRepository.Delete(id); 
                _coursesRepository.Save();
            }
            return RedirectToAction("GetAll");
        }
    }
}
