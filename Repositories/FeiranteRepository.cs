using FeiraDaRoca.Data;
using FeiraDaRoca.Models;
using Microsoft.EntityFrameworkCore;

namespace FeiraDaRoca.Repositories
{
    public class FeiranteRepository : IFeiranteRepository
    {
        private readonly AppDbContext _context;

        public FeiranteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Feirante>> ListarTodos()
        {
            return await _context.Feirantes.ToListAsync();
        }

        public async Task<Feirante?> BuscarPorId(int id)
        {
            return await _context.Feirantes.FindAsync(id);
        }

        public async Task<IEnumerable<Feirante>> BuscarPorCidade(string cidade)
        {
            return await _context.Feirantes
                .Where(f => f.Cidade.Equals(cidade, StringComparison.OrdinalIgnoreCase))
                .ToListAsync();
        }

        public async Task<Feirante> Adicionar(Feirante feirante)
        {
            _context.Feirantes.Add(feirante);
            await _context.SaveChangesAsync();
            return feirante;
        }

        public async Task Atualizar(Feirante feirante)
        {
            _context.Entry(feirante).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Feirante feirante)
        {
            _context.Feirantes.Remove(feirante);
            await _context.SaveChangesAsync();
        }
    }
}
