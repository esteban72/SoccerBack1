using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Tournament
    {
        [Key]
        public int TournamentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1} caracteres")]
        [Index("Tournament_Name_Index", IsUnique = true)]
        [Display(Name = "Torneo")]
        public string Name { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Display(Name = "Esta activo?")]
        public bool IsActive { get; set; }

        [Display(Name = "Orden")]
        public int Order { get; set; }

        [JsonIgnore]
        public virtual ICollection<TournamentGroup> Groups { get; set; }

        [JsonIgnore]
        public virtual ICollection<Date> Dates { get; set; }

    }
}
