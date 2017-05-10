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
    public class Prediction
    {
        [Key]
        public int PredictionId { get; set; }

        [Index("Prediction_UserId_MatchId_Index", IsUnique = true, Order = 1)]
        [Display(Name = "Usuario")]
        public int UserId { get; set; }

        [Index("Prediction_UserId_MatchId_Index", IsUnique = true, Order = 2)]
        [Display(Name = "Partido")]
        public int MatchId { get; set; }

        [Display(Name = "Goles Local")]
        public int LocalGoals { get; set; }

        [Display(Name = "Goles Visitante")]
        public int VisitorGoals { get; set; }

        [Display(Name = "Puntos")]
        public int Points { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }

        [JsonIgnore]
        public virtual Match Match { get; set; }
    }

}
