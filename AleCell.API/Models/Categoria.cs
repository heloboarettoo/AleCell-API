using System.ComponentModel.DataAnnotations;

namespace AleCell.API.Models;

public class Categoria
{
    [Key]
     public int Id { get; set; }  
     [Required]
     [StringLength(50)]
     public string Nome { get; set; } 
     public string Foto { get; set; } 
     public string Cor { get; set; }
}
