using System.ComponentModel.DataAnnotations;
using System.Data;

namespace AleCell.API.Models;

public class Usuario
{
    [Key]   

    [Required(ErrorMessage ="O nome é obrigatório")]
    [StringLength(50)]
    public string Nome { get; set; }

    [Required(ErrorMessage ="A data é obrigatória")]
    public DateTime DataNascimento { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
    
}