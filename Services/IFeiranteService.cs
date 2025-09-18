using FeiraDaRoca.Models;

namespace FeiraDaRoca.Services
{
    public interface IFeiranteService
    {
        Task<IEnumerable<Feirante>> ListarTodos();
        Task<Feirante?> BuscarPorId(int id);
        Task<IEnumerable<Feirante>> BuscarPorCidade(string cidade);
        Task<Feirante> Adicionar(Feirante feirante);
        Task<bool> Atualizar(int id, Feirante feirante);
        Task<bool> Remover(int id);
    }
}
