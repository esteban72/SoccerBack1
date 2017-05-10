using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1} caracteres")]
        [Index("Team_Name_LeagueId_Index", IsUnique = true, Order = 1)]
        [Display(Name = "Equipo")]
        public string Name { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(3, ErrorMessage = "La longitud para el campo {0} debe ser de {1} caracteres", MinimumLength = 3)]
        [Index("Team_Initials_LeagueId_Index", IsUnique = true, Order = 1)]
        [Display(Name = "Iniciales")]
        public string Initials { get; set; }

        [Index("Team_Name_LeagueId_Index", IsUnique = true, Order = 2)]
        [Index("Team_Initials_LeagueId_Index", IsUnique = true, Order = 2)]
        [Display(Name = "Liga")]
        public int LeagueId { get; set; }

        [JsonIgnore]
        public virtual League League { get; set; }

        [JsonIgnore]
        public virtual ICollection<TournamentTeam> TournamentTeams { get; set; }

        [JsonIgnore]
        public virtual ICollection<User> Fans { get; set; }

        [JsonIgnore]
        public virtual ICollection<Match> Locals { get; set; }

        [JsonIgnore]
        public virtual ICollection<Match> Visitors { get; set; }
    }
}
