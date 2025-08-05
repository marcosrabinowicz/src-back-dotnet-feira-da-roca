using Microsoft.EntityFrameworkCore;
using FeiraDaRoca.Models;

namespace FeiraDaRoca.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Feirante> Feirantes => Set<Feirante>();
    public DbSet<Produto> Produtos => Set<Produto>();
}
