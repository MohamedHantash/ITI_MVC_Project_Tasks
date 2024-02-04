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
            return _context.Instructors.Include(d => d.Department).Include(c=>c.Course).ToList();
        }
        public Instructor GetById(int id)
        {
            return _context.Instructors.FirstOrDefault(i => i.Id == id);
        }
        public void Add(Instructor instructore)
        {
            _context.Instructors.Add(instructore);
        }
        public void Update(Instructor instructore)
        {
            _context.Instructors.Update(instructore);
        }
        public void Delete(int id)
        {
            _context.Instructors.Remove(GetById(id));
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
