﻿using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    [NotMapped]
    public class TournamentTeamView : TournamentTeam
    {
        [Display(Name = "Liga")]
        public int LeagueId { get; set; }
    }
}