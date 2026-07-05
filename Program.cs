using DemoApp.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Use standard API controllers instead of heavy MVC views
builder.Services.AddTransient<EmpModel>();

var app = builder.Build();

// Enable serving static html files from your wwwroot folder
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseAuthorization();

// Maps your EmployeeApiController routes (/api/EmployeeApi)
app.MapControllers();

app.Run();