using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApp.Models
{
     public class Employee
    {
        public int Id { get; set; }  // Primary key, auto-generated
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;
        public double Salary { get; set; } = 0.0;
    }
}
