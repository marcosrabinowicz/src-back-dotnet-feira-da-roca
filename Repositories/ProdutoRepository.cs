using FeiraDaRoca.Data;
using FeiraDaRoca.Models;
using Microsoft.EntityFrameworkCore;

namespace FeiraDaRoca.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> ListarTodos()
        {
            return await _context.Produtos
                .Include(p => p.Feirante)
                .ToListAsync();
        }

        public async Task<Produto?> BuscarPorId(int id)
        {
            return await _context.Produtos
                .Include(p => p.Feirante)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Produto> Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task Atualizar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Produto produto)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }
    }
}
