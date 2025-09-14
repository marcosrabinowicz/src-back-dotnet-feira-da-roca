using FeiraDaRoca.Models;

namespace FeiraDaRoca.Services;

public interface IFeiranteService
{
    Task<List<Feirante>> ListarTodos();
}
