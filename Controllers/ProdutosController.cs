using Microsoft.AspNetCore.Mvc;
using FeiraDaRoca.Models;
using FeiraDaRoca.Services;

namespace FeiraDaRoca.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly IProdutoService _service;

    public ProdutosController(IProdutoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var produtos = await _service.ListarTodos();
        return Ok(produtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var produto = await _service.BuscarPorId(id);
        return produto == null ? NotFound() : Ok(produto);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Produto novo)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var criado = await _service.Adicionar(novo);
        return CreatedAtAction(nameof(GetById), new { id = criado.Id }, criado);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Produto atualizacao)
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
