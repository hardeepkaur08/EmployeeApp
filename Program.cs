using EmployeeApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=employee.db"));

// Add Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Seed database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    DbInitializer.Initialize(context);
}

// Map Controllers
app.MapControllers();

// Optional root endpoint
app.MapGet("/", () => "Employee API is running");

app.Run();
