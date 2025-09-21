using FeiraDaRoca.Models;

namespace FeiraDaRoca.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> ListarTodos();
        Task<Produto?> BuscarPorId(int id);
        Task<Produto> Adicionar(Produto produto);
        Task<bool> Atualizar(int id, Produto produto);
        Task<bool> Remover(int id);
    }
}
