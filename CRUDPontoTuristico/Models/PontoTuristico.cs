using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDPontoTuristico.Models
{
    [Table("PontoTuristo")]
    public class PontoTuristico
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome{ get; set; }

        [Column("UF")]
        [Display(Name = "UF")]
        public string UF { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("Referencia")]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }
    }
}
