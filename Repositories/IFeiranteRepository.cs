using FeiraDaRoca.Models;

namespace FeiraDaRoca.Repositories
{
    public interface IFeiranteRepository
    {
        Task<IEnumerable<Feirante>> ListarTodos();
        Task<Feirante?> BuscarPorId(int id);
        Task<IEnumerable<Feirante>> BuscarPorCidade(string cidade);
        Task<Feirante> Adicionar(Feirante feirante);
        Task Atualizar(Feirante feirante);
        Task Remover(Feirante feirante);
    }
}
