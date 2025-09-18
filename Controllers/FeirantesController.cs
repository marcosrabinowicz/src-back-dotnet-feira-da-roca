using Microsoft.AspNetCore.Mvc;
using FeiraDaRoca.Models;
using FeiraDaRoca.Services;

namespace FeiraDaRoca.Controllers;

[ApiController]
[Route("[controller]")]
public class FeirantesController : ControllerBase
{
    private readonly IFeiranteService _service;

    public FeirantesController(IFeiranteService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var feirantes = await _service.ListarTodos();
        return Ok(feirantes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var feirante = await _service.BuscarPorId(id);
        return feirante == null ? NotFound() : Ok(feirante);
    }

    [HttpGet("cidade/{cidade}")]
    public async Task<IActionResult> GetByCidade(string cidade)
    {
        var feirantesNaCidade = await _service.BuscarPorCidade(cidade);
        return feirantesNaCidade.Any() ? Ok(feirantesNaCidade) : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Feirante novo)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var criado = await _service.Adicionar(novo);
        return CreatedAtAction(nameof(GetById), new { id = criado.Id }, criado);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Feirante atualizacao)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var atualizado = await _service.Atualizar(id, atualizacao);
        return atualizado ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var removido = await _service.Remover(id);
        return removido ? NoContent() : NotFound();
    }
}
