using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_15.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }

        public int age { get; set; }

        public string address { get; set; }
    }
}