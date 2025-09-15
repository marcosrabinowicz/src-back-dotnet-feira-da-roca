using System.ComponentModel.DataAnnotations;

namespace FeiraDaRoca.Models;

public class Produto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do produto é obrigatório.")]
    [StringLength(100)]
    public string Nome { get; set; } = string.Empty;

    [Range(0.01, 9999.99, ErrorMessage = "O preço deve ser maior que zero.")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "O campo FeiranteId é obrigatório.")]
    public int FeiranteId { get; set; }

    public Feirante? Feirante { get; set; }
}
