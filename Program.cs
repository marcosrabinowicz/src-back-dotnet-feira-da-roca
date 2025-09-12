using Microsoft.EntityFrameworkCore;
using FeiraDaRoca.Data;
using FeiraDaRoca.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=feirinha.db"));

builder.Services.AddControllers();

builder.Services.AddScoped<IProdutoService, ProdutoService>();

var app = builder.Build();

app.MapControllers();

app.Run();
