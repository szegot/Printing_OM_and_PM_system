using printing_om_and_pm_system_app.Repositories;
using printing_om_and_pm_system_app.Db;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

