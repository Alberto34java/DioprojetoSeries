using System.ComponentModel.DataAnnotations;
using ValueObjects;

namespace Models
{
    public class Filme
    {
        public Filme(string nome, Genero genero, string descricao, int anoLancamento)
        {
            Nome = nome;
            Genero = genero;
            Descricao = descricao;
            AnoLancamento = anoLancamento;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome{get; set;}
        [Required]
        public Genero Genero { get; set; }
        
        [Required]
        public string Descricao { get; set; }
        [Required]
        public int AnoLancamento { get; set; }
        
        
        
        
        
        
    }
}