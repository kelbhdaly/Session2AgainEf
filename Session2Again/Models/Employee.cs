using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Again.Models
{
    internal class Employee
    {

        public int Id { get; set; } //PK
        [StringLength(50)]
        public string? Name { get; set; }
        [Range(25, 50)]
        [DeniedValues(60, 65, 67, 68, 69, 70)]
        public int Age { get; set; }
        public decimal Salary { get; set; }
        [EmailAddress] //Application Validation
        [DataType(DataType.EmailAddress)] // Display Value As EmailAddress
        public string? Email { get; set; }
        [NotMapped]
        public int Test { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public required string PhoneNumber { get; set; }

        public Address EmpAddress { get; set; }

    }
}
