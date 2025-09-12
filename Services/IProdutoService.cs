using FeiraDaRoca.Models;

namespace FeiraDaRoca.Services;

public interface IProdutoService
{
    Task<List<Produto>> ListarTodos();
}
