using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using ApiCatalogo.Models;

namespace ApiCatalogo.DTOs;

public class ProdutoDTO
{
    [Key]
    public int ProdutoId { get; set; }
    
    [Required]
    [StringLength(80)]
    public string Nome { get; set; }
    
    [Required]
    [StringLength(300)]
    public string Descricao { get; set; }
    
    [Required]
    public decimal Preco { get; set; }
    
    [Required]
    [StringLength(300)]
    public string Imagemurl { get; set; }
    
    public int CategoriaId { get; set; }
}