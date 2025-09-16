# EmployeeApp - ASP.Net Core MVC + SQLite
A simple CRUD application to manage employee records. Built using ASP .Net Core MVC (Model View Controller), SQLite, and Entity Framework Core.

# Project Structure

- **Controllers/** → Handles API requests (`EmployeesController.cs`)  
- **Data/** → Database context and seeding (`AppDbContext.cs`, `DbInitializer.cs`)  
- **Models/** → Entity definitions (`Employee.cs`)  
- **Program.cs** → App configuration, routing, and DB initialization   

# Features

- Get all employees (`GET /api/employees`)  
- Get a single employee (`GET /api/employees/{id}`)  
- Create new employee (`POST /api/employees`)  
- Update employee (`PUT /api/employees/{id}`)  
- Delete employee (`DELETE /api/employees/{id}`)  

- # Debugging Notes - EmployeeApp

#### Issues Faced & Solutions

1. **SQLite UNIQUE constraint failed**
   - **Cause:** Manually inserting Ids for employees  
   - **Solution:** Removed Ids from seed data; let SQLite auto-generate

2. **ERR_SSL_PROTOCOL_ERROR / HTTPS errors**
   - **Cause:** Localhost not configured for HTTPS  
   - **Solution:** Access app via HTTP (`http://localhost:5206`)

3. **Missing EF Core namespaces**
   - **Cause:** Required NuGet packages missing  
   - **Solution:** Installed:
     - Microsoft.EntityFrameworkCore  
     - Microsoft.EntityFrameworkCore.Sqlite  
     - Microsoft.EntityFrameworkCore.Tools  

4. **Non-nullable property warnings**
   - **Cause:** Properties without default values  
   - **Solution:** Used `= null!` or default initializations


##### Notes for Readers

- Seeded data is in `DbInitializer.cs`  
- Use `dotnet ef database update` to apply migrations  
- Folders are organized for clarifications:
  - Controllers → API logic
  - Data → DB logic
  - Models → Entities
  - Views → Index.cshtml
