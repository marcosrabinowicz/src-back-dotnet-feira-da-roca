using FeiraDaRoca.Models;

namespace FeiraDaRoca.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ListarTodos();
        Task<Produto?> BuscarPorId(int id);
        Task<Produto> Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Produto produto);
    }
}
