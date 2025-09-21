using FeiraDaRoca.Models;
using FeiraDaRoca.Repositories;

namespace FeiraDaRoca.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Produto>> ListarTodos()
        {
            return await _repository.ListarTodos();
        }

        public async Task<Produto?> BuscarPorId(int id)
        {
            return await _repository.BuscarPorId(id);
        }

        public async Task<Produto> Adicionar(Produto produto)
        {
            return await _repository.Adicionar(produto);
        }

        public async Task<bool> Atualizar(int id, Produto produto)
        {
            var existente = await _repository.BuscarPorId(id);
            if (existente == null) return false;

            existente.Nome = produto.Nome;
            existente.Preco = produto.Preco;

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
