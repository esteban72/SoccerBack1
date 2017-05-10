using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }

        [Display(Name = "Fecha")]
        public int DateId { get; set; }

        [Display(Name = "Fecha/Hora partido")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        [Display(Name = "Local")]
        public int LocalId { get; set; }

        [Display(Name = "Visitante")]
        public int VisitorId { get; set; }

        [Display(Name = "Goles de local")]
        public int? LocalGoals { get; set; }

        [Display(Name = "Goles de visitante")]
        public int? VisitorGoals { get; set; }

        [Display(Name = "Estado")]
        public int StatusId { get; set; }

        [Display(Name = "Grupo")]
        public int TournamentGroupId { get; set; }

        [JsonIgnore]
        public virtual Date Date { get; set; }

        [JsonIgnore]
        public virtual Team Local { get; set; }

        [JsonIgnore]
        public virtual Team Visitor { get; set; }

        [JsonIgnore]
        public virtual Status Status { get; set; }

        [JsonIgnore]
        public virtual TournamentGroup TournamentGroup { get; set; }

    }
}
