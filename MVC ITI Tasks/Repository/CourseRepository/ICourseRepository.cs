using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public interface ICourseRepository
    {
        void Add(Courses courses);
        void Delete(int id);
        List<Courses> GetAll();
        Courses GetById(int id);
        int Save();
        void Update(Courses course);
    }
}