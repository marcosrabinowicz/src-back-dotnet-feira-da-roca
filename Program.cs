using Microsoft.EntityFrameworkCore;
using FeiraDaRoca.Data;
using FeiraDaRoca.Services;
using FeiraDaRoca.Repositories;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=feirinha.db"));

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

builder.Services.AddScoped<IFeiranteService, FeiranteService>();

builder.Services.AddScoped<IFeiranteRepository, FeiranteRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();
