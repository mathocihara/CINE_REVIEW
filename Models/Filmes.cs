using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_CINEMA.Models
{
    [Table("Filmes")]
    public class Filmes
    {
        [Column("Id")]
        [Display(Name="Identificador")]
        public int Id { get; set; }


        [Column("Filme")]
        [Display(Name = "Filme")]
        public string Filme { get; set; }

        [Column("Ingresso")]
        [Display(Name = "Ingresso")]
        public float Ingresso { get; set; }

        [Column("Crítica")]
        [Display(Name = "Crítica")]
        public float Crítica { get; set; }


    }
}
