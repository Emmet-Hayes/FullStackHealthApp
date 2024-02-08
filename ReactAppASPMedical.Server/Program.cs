using Microsoft.EntityFrameworkCore;
using ReactAppASPMedical.Server.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Get the database password from the environment
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

// Configure DbContext with Npgsql and include the secret password
var defaultConnection = builder.Configuration.GetConnectionString("DefaultConnection") + $"Password={dbPassword};";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(defaultConnection));

// TODO: Learn more about configuring Swagger/OpenAPI
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapFallbackToFile("/index.html");

app.Run();
