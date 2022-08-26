using System.ComponentModel.DataAnnotations;
using System;
namespace EF_CodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }



    }
}
