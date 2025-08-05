namespace FeiraDaRoca.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }

    
    public int FeiranteId { get; set; }
    public Feirante? Feirante { get; set; }
}
