using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public interface IInstructoreRepository
    {
        List<Instructore> GetAll();
        Instructore GetById(int id);
        int Save();
        void Add(Instructore instructore);
        void Update(Instructore instructore);
        void Delete(int id);
    }
}