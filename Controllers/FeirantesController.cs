using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FeiraDaRoca.Models;
using FeiraDaRoca.Data;
using FeiraDaRoca.Services;

namespace FeiraDaRoca.Controllers;

[ApiController]
[Route("[controller]")]
public class FeirantesController(AppDbContext context, IFeiranteService service) : ControllerBase
{
    private readonly AppDbContext _context = context;

    private readonly IFeiranteService _service = service;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var feirantes = await _service.ListarTodos();
        return Ok(feirantes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var feirante = await _context.Feirantes.FindAsync(id);

        return feirante == null ? NotFound() : Ok(feirante);
    }

    [HttpGet("cidade/{cidade}")]
    public async Task<IActionResult> GetByCidade(string cidade)
    {
        var feirantesNaCidade = await _context.Feirantes.Where(f => f.Cidade.Equals(cidade, StringComparison.OrdinalIgnoreCase)).ToListAsync();

        return feirantesNaCidade.Count != 0 ? Ok(feirantesNaCidade) : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Feirante novo)
    {
        _context.Feirantes.Add(novo);

        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = novo.Id }, novo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Feirante atualizacao)
    {
        var feirante = await _context.Feirantes.FindAsync(id);

        if (feirante == null) return NotFound();

        feirante.Nome = atualizacao.Nome;
        feirante.Cidade = atualizacao.Cidade;
        feirante.ProdutoPrincipal = atualizacao.ProdutoPrincipal;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var feirante = await _context.Feirantes.FindAsync(id);

        if (feirante == null) return NotFound();

        _context.Feirantes.Remove(feirante);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}