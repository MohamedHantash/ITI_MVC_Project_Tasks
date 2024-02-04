using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ITI_Tasks.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public int Salary { get; set; }
        public string Address { get; set; } = string.Empty;
        public string ImageURL {  get; set; } = string.Empty;


        [Display(Name ="Department")]
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public Department? Department { get; set; }


        [Display(Name ="Course")]
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public Course? Course { get; set; }


    }
}
