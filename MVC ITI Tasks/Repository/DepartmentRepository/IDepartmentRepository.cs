using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
    }
}