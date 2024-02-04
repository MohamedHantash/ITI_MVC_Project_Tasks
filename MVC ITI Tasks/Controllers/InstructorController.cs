using Microsoft.AspNetCore.Mvc;
using MVC_ITI_Tasks.Models;
using MVC_ITI_Tasks.Repository;

namespace MVC_ITI_Tasks.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructoreRepository _instructoreRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ICourseRepository _courseRepository;
        public InstructorController(IInstructoreRepository instructoreRepository,
            IDepartmentRepository departmentRepository,
            ICourseRepository courseRepository)
        {
           this._instructoreRepository = instructoreRepository;
           this._departmentRepository = departmentRepository;
           this._courseRepository = courseRepository;
        }

        public IActionResult GetAll()
        {
            List<Instructor> instructoresList =_instructoreRepository.GetAll();
            return View(instructoresList);
        }
        public IActionResult Details(int id) 
        {
            Instructor instructore = _instructoreRepository.GetById(id);
            return View(instructore);
        }

        public IActionResult Add()
        {
            // first comment.
            ViewData["deptList"] = _departmentRepository.GetAll();//.Select(d=>new { d.Name,d.Id});
            ViewData["courseList"] = _courseRepository.GetAll();//.Select(c=> new {c.Name,c.Id});
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Instructor instructore)
        {
            if(ModelState.IsValid)
            {
                _instructoreRepository.Add(instructore);
                _instructoreRepository.Save();
                return RedirectToAction("GetAll");
            }
            ViewData["deptList"] = _departmentRepository.GetAll();
            ViewData["courseList"] = _courseRepository.GetAll();
            return View(instructore);
        }

        public IActionResult Edit(int id)
        {
            Instructor instructore = _instructoreRepository.GetById(id);
            ViewData["deptList"] = _departmentRepository.GetAll();
            ViewData["courseList"]=_courseRepository.GetAll();
            return View(instructore);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Instructor instructore)
        {
            if(ModelState.IsValid)
            {
                _instructoreRepository.Update(instructore);
                _instructoreRepository.Save();
                return RedirectToAction("GetAll");
            }
            // it uses them when compiler save in DB
            ViewData["deptList"] = _departmentRepository.GetAll();
            ViewData["courseList"] = _courseRepository.GetAll();
            return View(instructore);
        }
        public IActionResult Delete(int id)
        {
            Instructor instructure = _instructoreRepository.GetById(id);
            if(instructure != null)
            {
                _instructoreRepository.Delete(id); 
                _instructoreRepository.Save();
            }
            return RedirectToAction("GetAll");
        }
    }
}
