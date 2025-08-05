using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FeiraDaRoca.Models;
using FeiraDaRoca.Data;

namespace FeiraDaRoca.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutosController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _context.Produtos.ToListAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);

        return produto == null ? NotFound() : Ok(produto);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Produto novo)
    {
        _context.Produtos.Add(novo);

        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = novo.Id }, novo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Produto atualizacao)
    {
        var produto = await _context.Produtos.FindAsync(id);

        if (produto == null) return NotFound();

        produto.Nome = atualizacao.Nome;
        produto.Preco = atualizacao.Preco;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);

        if (produto == null) return NotFound();

        _context.Produtos.Remove(produto);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}
