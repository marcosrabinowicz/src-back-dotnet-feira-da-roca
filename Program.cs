using Microsoft.EntityFrameworkCore;
using FeiraDaRoca.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=feirinha.db"));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
