using FeiraDaRoca.Models;
using FeiraDaRoca.Repositories;

namespace FeiraDaRoca.Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repository;

    public ProdutoService(IProdutoRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Produto>> ListarTodos()
    {
        return await _repository.ListarTodos();
    }
}
