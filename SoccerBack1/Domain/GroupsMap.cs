using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    internal class GroupsMap : EntityTypeConfiguration<Group>
    {
        public GroupsMap()
        {
            HasRequired(o => o.Owner)
                .WithMany(m => m.UserGroups)
                .HasForeignKey(m => m.OwnerId);
        }
    }
}

