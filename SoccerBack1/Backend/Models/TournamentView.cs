using Domain;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Backend.Models
{
    public class TournamentView : Tournament
    {
        [Display(Name = "Logo")]
        public HttpPostedFileBase LogoFile { get; set; }
    }
}