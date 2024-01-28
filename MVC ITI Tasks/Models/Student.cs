using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ITI_Tasks.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Address { get; set; }=string.Empty;  
        public string ImageURL { get; set; }=string.Empty;
        public int Grade { get; set; }


        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department? Department { get; set; }

        public List<CourseResult>? CourseResults { get; set; }

    }
}
