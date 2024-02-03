using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public interface ICourseRepository
    {
        void Add(Course courses);
        void Delete(int id);
        List<Course> GetAll();
        Course GetById(int id);
        int Save();
        void Update(Course course);
    }
}