using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TournamentTeam
    {
        [Key]
        public int TournamentTeamId { get; set; }

        [Index("TournamentTeam_TournamentGroupId_TeamId_Index", IsUnique = true, Order = 1)]
        [Display(Name = "Grupo")]
        public int TournamentGroupId { get; set; }

        [Index("TournamentTeam_TournamentGroupId_TeamId_Index", IsUnique = true, Order = 2)]
        [Display(Name = "Equipo")]
        public int TeamId { get; set; }

        [Display(Name = "Partidos jugados")]
        public int MatchesPlayed { get; set; }

        [Display(Name = "Partidos ganados")]
        public int MatchesWon { get; set; }

        [Display(Name = "Partidos perdidos")]
        public int MatchesLost { get; set; }

        [Display(Name = "Partidos empatados")]
        public int MatchesTied { get; set; }

        [Display(Name = "Goles a favor")]
        public int FavorGoals { get; set; }

        [Display(Name = "Goles en contra")]
        public int AgainstGoals { get; set; }

        [Display(Name = "Puntos")]
        public int Points { get; set; }

        [Display(Name = "Posición")]
        public int Position { get; set; }

        [JsonIgnore]
        public virtual TournamentGroup TournamentGroup { get; set; }

        [JsonIgnore]
        public virtual Team Team { get; set; }

        
    }

}
