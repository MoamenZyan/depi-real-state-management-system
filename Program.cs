using depi_real_state_management_system.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Database registeration ---> services بسجل الداتا بيز في ال
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("Server=localhost;Database=depi_real_state;Trusted_Connection=True;TrustServerCertificate=True");
});

// Add Authentication JWT Feature (طريقه توثيق يوزر) ----> TO DO

// Add more services if needed


var app = builder.Build();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
