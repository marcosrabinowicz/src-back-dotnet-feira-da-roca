using FeiraDaRoca.Models;

namespace FeiraDaRoca.Repositories;

public interface IProdutoRepository
{
    Task<List<Produto>> ListarTodos();
}
