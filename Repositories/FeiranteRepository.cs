using FeiraDaRoca.Data;
using FeiraDaRoca.Models;
using Microsoft.EntityFrameworkCore;

namespace FeiraDaRoca.Repositories;

public class FeiranteRepository : IFeiranteRepository
{
    private readonly AppDbContext _context;

    public FeiranteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Feirante>> ListarTodos()
    {
        return await _context.Feirantes.ToListAsync();
    }
}
