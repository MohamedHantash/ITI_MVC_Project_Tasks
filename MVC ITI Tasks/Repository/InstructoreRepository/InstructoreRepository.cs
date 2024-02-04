using Microsoft.EntityFrameworkCore;
using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public class InstructoreRepository : IInstructoreRepository
    {
        private readonly ApplicationContext _context;
        public InstructoreRepository(ApplicationContext context)
        {
            this._context = context;
        }
        public List<Instructor> GetAll()
        {
            return _context.Instructores.Include(d => d.Department).Include(c=>c.Courses).ToList();
        }
        public Instructor GetById(int id)
        {
            return _context.Instructores.FirstOrDefault(i => i.Id == id);
        }
        public void Add(Instructor instructore)
        {
            _context.Instructores.Add(instructore);
        }
        public void Update(Instructor instructore)
        {
            _context.Instructores.Update(instructore);
        }
        public void Delete(int id)
        {
            _context.Instructores.Remove(GetById(id));
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
