using MVC_ITI_Tasks.Models;

namespace MVC_ITI_Tasks.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student ShowResult(int student_Id, int course_Id);
    }
}