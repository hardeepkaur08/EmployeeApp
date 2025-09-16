using EmployeeApp.Models;

namespace EmployeeApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            // Create DB if it does not exist
            context.Database.EnsureCreated();

            // If employees already exist, do nothing
            if (context.Employees.Any())
            {
                return;
            }

            // Seed data without specifying Id
            var employees = new Employee[]
            {
                new Employee { Name = "Alice Johnson", Position = "Manager", Salary = 80000 },
                new Employee { Name = "Bob Smith", Position = "Developer", Salary = 60000 },
                new Employee { Name = "Charlie Brown", Position = "Tester", Salary = 50000 }
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}
