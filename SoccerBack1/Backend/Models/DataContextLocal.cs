using Domain;

namespace Backend.Models
{
    public class DataContextLocal : DataContext
    {
        public System.Data.Entity.DbSet<Domain.Tournament> Tournaments { get; set; }

        public System.Data.Entity.DbSet<Domain.TournamentGroup> TournamentGroups { get; set; }
    }
}