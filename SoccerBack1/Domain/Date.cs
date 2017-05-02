using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Date
    {
        [Key]
        public int DateId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "La máxima longitud del campo {0} es {1} caracteres")]
        [Index("Date_Name_TournamentId_Index", IsUnique = true, Order = 1)]
        [Display(Name = "Fecha")]
        public string Name { get; set; }

        [Display(Name = "Tournament")]
        [Index("Date_Name_TournamentId_Index", IsUnique = true, Order = 2)]
        public int TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; }

        //public virtual ICollection<Match> Matches { get; set; }
    }

}
