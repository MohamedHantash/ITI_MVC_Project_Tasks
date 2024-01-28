using Microsoft.AspNetCore.Mvc;
using MVC_ITI_Tasks.Models;
using MVC_ITI_Tasks.Repository;

namespace MVC_ITI_Tasks.Controllers
{
    public class InstructoreController : Controller
    {
        private readonly IInstructoreRepository _instructoreRepository;
        public InstructoreController(IInstructoreRepository instructoreRepository)
        {
           this._instructoreRepository = instructoreRepository;
        }

        public IActionResult GetAll()
        {
            List<Instructore> instructoresList =_instructoreRepository.GetAll();
            return View(instructoresList);
        }
        public IActionResult Details(int id) 
        {
            Instructore instructore = _instructoreRepository.GetById(id);
            return View(instructore);
        }
    }
}
