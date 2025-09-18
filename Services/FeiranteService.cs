using FeiraDaRoca.Models;
using FeiraDaRoca.Repositories;

namespace FeiraDaRoca.Services
{
    public class FeiranteService : IFeiranteService
    {
        private readonly IFeiranteRepository _repository;

        public FeiranteService(IFeiranteRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Feirante>> ListarTodos()
        {
            return await _repository.ListarTodos();
        }

        public async Task<Feirante?> BuscarPorId(int id)
        {
            return await _repository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Feirante>> BuscarPorCidade(string cidade)
        {
            return await _repository.BuscarPorCidade(cidade);
        }

        public async Task<Feirante> Adicionar(Feirante feirante)
        {
            return await _repository.Adicionar(feirante);
        }

        public async Task<bool> Atualizar(int id, Feirante feirante)
        {
            var existente = await _repository.BuscarPorId(id);
            if (existente == null) return false;

            existente.Nome = feirante.Nome;
            existente.Cidade = feirante.Cidade;
            existente.ProdutoPrincipal = feirante.ProdutoPrincipal;

            await _repository.Atualizar(existente);
            return true;
        }

        public async Task<bool> Remover(int id)
        {
            var existente = await _repository.BuscarPorId(id);
            if (existente == null) return false;

            await _repository.Remover(existente);
            return true;
        }
    }
}
