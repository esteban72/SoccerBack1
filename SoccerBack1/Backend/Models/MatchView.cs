using Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    [NotMapped]
    public class MatchView : Match
    {
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public string DateString { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Hora")]
        public string TimeString { get; set; }

        [Display(Name = "Liga equipo local")]
        public int LocalLeagueId { get; set; }

        [Display(Name = "Liga equipo visitante")]
        public int VisitorLeagueId { get; set; }
    }
}