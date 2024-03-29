﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ITI_Tasks.Models
{
    public class CourseResult
    {
        [Key]
        public int Id { get; set; }
        public int Degree { get; set; }


        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public Course? Course { get; set; }

        [ForeignKey("Student")]
        public int Student_Id { get; set; }
        public Student? Student { get; set; }
    }
}
