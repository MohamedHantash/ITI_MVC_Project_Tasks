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
        public List<Instructore> GetAll()
        {
            return _context.Instructores.ToList();
        }
        public Instructore GetById(int id)
        {
            return _context.Instructores.FirstOrDefault(i => i.Id == id);
        }
    }
}
