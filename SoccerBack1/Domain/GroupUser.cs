﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GroupUser
    {
        [Key]
        public int GroupUserId { get; set; }

        [Index("GroupUser_GroupId_UserId_Index", IsUnique = true, Order = 1)]
        [Display(Name = "Grupo")]
        public int GroupId { get; set; }

        [Index("GroupUser_GroupId_UserId_Index", IsUnique = true, Order = 2)]
        [Display(Name = "Usuario")]
        public int UserId { get; set; }

        [Display(Name = "Esta aceptado?")]
        public bool IsAccepted { get; set; }

        [Display(Name = "Esta bloqueado?")]
        public bool IsBlocked { get; set; }

        [Display(Name = "Puntos")]
        public int Points { get; set; }

        public virtual Group Group { get; set; }

        public virtual User User { get; set; }
    }

}
