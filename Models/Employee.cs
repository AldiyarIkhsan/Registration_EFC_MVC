using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Registration_EFC_MVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="This field is required.")]
        [DispayName("Full Name")]

        public string FullName { get; set; }
        [DispayName("Emp. Code")]
        public int EmpCode { get; set; }
        public int Position { get; set; }
        [DispayName("Office Location")]
        public int OfiiceLocation { get; set; }
    } 
}

