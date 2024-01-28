namespace MVC_ITI_Tasks.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manager { get; set; }=string.Empty;

        public List<Instructore>? Instructores { get; set; }
        public List<Courses>? Courses { get; set; }

        public List<Student>? Students { get; set; }

    }
}
