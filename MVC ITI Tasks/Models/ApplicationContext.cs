using Microsoft.EntityFrameworkCore;

namespace MVC_ITI_Tasks.Models
{
    public class ApplicationContext:DbContext
    {
        
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
        {

        }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseResult> CourseResults { get; set; }

    }
}
