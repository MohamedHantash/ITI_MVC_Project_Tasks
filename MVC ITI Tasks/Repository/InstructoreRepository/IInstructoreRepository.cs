using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public interface IInstructoreRepository
    {
        List<Instructor> GetAll();
        Instructor GetById(int id);
        int Save();
        void Add(Instructor instructore);
        void Update(Instructor instructore);
        void Delete(int id);
    }
}