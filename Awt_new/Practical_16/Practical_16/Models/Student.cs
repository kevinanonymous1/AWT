using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_16.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

        public String Courses { get; set; }

        public String Marks { get; set; }
    }
}