using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Again.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public DateOnly DateOfCreation   { get; set; }
        public int Serial { get; set; }

        // By Convention [ManagerId - EmployeeId - ]
        //[ForeignKey("Manager")]
        //[ForeignKey(nameof(Manager))]
        public int DeptManagerId { get; set; }
        //Navigation Property[One]
        // Partial Employee Must Have Department [Mandatory]

        public Employee Manager { get; set; } = null!;
        public Address EmpAddress { get; set; }

    }
}
