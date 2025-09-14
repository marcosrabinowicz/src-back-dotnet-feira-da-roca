using FeiraDaRoca.Models;

namespace FeiraDaRoca.Repositories;

public interface IFeiranteRepository
{
    Task<List<Feirante>> ListarTodos();
}
