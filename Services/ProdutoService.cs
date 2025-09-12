using FeiraDaRoca.Data;
using FeiraDaRoca.Models;
using Microsoft.EntityFrameworkCore;

namespace FeiraDaRoca.Services;

public class ProdutoService : IProdutoService
{
    private readonly AppDbContext _context;

    public ProdutoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Produto>> ListarTodos()
    {
        return await _context.Produtos.ToListAsync();
    }
}
