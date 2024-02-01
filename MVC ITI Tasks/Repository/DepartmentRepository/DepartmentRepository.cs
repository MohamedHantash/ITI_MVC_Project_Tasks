using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationContext _context;
        public DepartmentRepository(ApplicationContext context)
        {
            this._context = context;
        }
        public List<Department> GetAll()
        {
            return _context.Departments.ToList();
        }
    }
}
