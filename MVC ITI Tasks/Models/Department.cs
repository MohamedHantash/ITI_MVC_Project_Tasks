﻿namespace MVC_ITI_Tasks.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manager { get; set; }=string.Empty;


        public List<Instructor>? Instructors { get; set; }
        public List<Course>? Courses { get; set; }

        public List<Student>? Students { get; set; }

    }
}
