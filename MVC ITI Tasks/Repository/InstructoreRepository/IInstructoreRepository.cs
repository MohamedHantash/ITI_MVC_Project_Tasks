using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public interface IInstructoreRepository
    {
        List<Instructore> GetAll();
        Instructore GetById(int id);
    }
}