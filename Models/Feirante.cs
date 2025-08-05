namespace FeiraDaRoca.Models;

public class Feirante
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string ProdutoPrincipal { get; set; } = string.Empty;

    public List<Produto> Produtos { get; set; } = [];
}