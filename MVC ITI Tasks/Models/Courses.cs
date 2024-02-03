using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ITI_Tasks.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }=string.Empty;
        public int Degree { get; set; }
        public int MinDegree { get; set; }


        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department? Department { get; set; }

        public List<Instructore>? Instructores { get; set; }
        public List<CourseResult>? CourseResults { get; set; }
    }
}
