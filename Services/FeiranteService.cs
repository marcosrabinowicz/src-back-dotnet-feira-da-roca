using FeiraDaRoca.Models;
using FeiraDaRoca.Repositories;

namespace FeiraDaRoca.Services;

public class FeiranteService : IFeiranteService
{
    private readonly IFeiranteRepository _repository;

    public FeiranteService(IFeiranteRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Feirante>> ListarTodos()
    {
        return await _repository.ListarTodos();
    }
}
