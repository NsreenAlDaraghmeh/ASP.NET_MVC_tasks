using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HandleError.Models
{
  
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }

    public class StudentCourse
    {
        public int Id { get; set; }

        public int StudentId { get; set; }


        public int CourseId { get; set; }
        [ForeignKey("CourseId")]

        public Course Course { get; set; }

        [ForeignKey("StudentId")]

        public Student Student { get; set; }


    }
}