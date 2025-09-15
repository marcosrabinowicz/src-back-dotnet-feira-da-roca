using System.ComponentModel.DataAnnotations;

namespace FeiraDaRoca.Models;

public class Feirante
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "A cidade é obrigatória.")]
    [StringLength(100)]
    public string Cidade { get; set; } = string.Empty;

    [Required(ErrorMessage = "O produto principal é obrigatório.")]
    public string ProdutoPrincipal { get; set; } = string.Empty;

    public List<Produto> Produtos { get; set; } = [];
}