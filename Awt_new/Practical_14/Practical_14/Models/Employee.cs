using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_14.Models
{
    public class Employee
    {
        public int Id { get; set }
        [Required(ErrorMessage = " Name is required")]
        [StringLength(50,ErrorMessage = " Cannot exceed 50 characters")]
        public string name { get; set; }
        [Required(ErrorMessage = " Email is required")]
        [EmailAddress(ErrorMessage = " Cannot exceed 50 characters")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Department is required")]
        public string Department { get; set; }
    }
}