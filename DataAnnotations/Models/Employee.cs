using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotations.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Employee Name")]
        [Required(ErrorMessage ="Employee Name is required")]
        [StringLength(35, MinimumLength =4)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employee Address is required")]
        [StringLength(300)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(300, 1000000, ErrorMessage= "Salary must be between 3000 and 1000000")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please enter your email Address")]
        [DataType(DataType.EmailAddress)]
        [DisplayName ("Email Address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage ="Please enter correct email address.")]
        public string Email { get; set; }
    }
}