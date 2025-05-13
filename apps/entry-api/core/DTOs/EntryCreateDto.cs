using System.ComponentModel.DataAnnotations;

namespace EntryApi.core.DTOs;

public class EntryCreateDto
{
    [Required(ErrorMessage = "O valor é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero.")]
    public double Amount { get; set; }

    [Required(ErrorMessage = "O tipo é obrigatório.")]
    [RegularExpression("^(credit|debit)$", ErrorMessage = "O tipo deve ser 'credit' ou 'debit'.")]
    public string Type { get; set; }

    [Required(ErrorMessage = "A data é obrigatória.")]
    public DateTime Date { get; set; }

    [StringLength(255, ErrorMessage = "A descrição deve ter no máximo 255 caracteres.")]
    public string Description { get; set; }
}