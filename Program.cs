using Microsoft.EntityFrameworkCore;
using SecureOpsAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container so the app can use controllers and the database
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=secureops.db"));

// Add tools to help us test the API visually later
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();