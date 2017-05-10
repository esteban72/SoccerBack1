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
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1} caracteres")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1} caracteres")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Display(Name = "Tipo de Usuario")]
        public int UserTypeId { get; set; }
        
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Foto")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1} caracteres")]
        [DataType(DataType.EmailAddress)]
        [Index("User_Email_Index", IsUnique = true)]
        //[RegularExpression("\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,4}\b", ErrorMessage = "Mail incorrecto, verifique que no tenga caracteres especiales")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1} caracteres")]
        [Index("User_NickName_Index", IsUnique = true)]
        [Display(Name = "Nombre de usuario")]
        public string NickName { get; set; }

        [Display(Name = "Equipo favorito")]
        public int FavoriteTeamId { get; set; }

        [Display(Name = "Puntos")]
        public int Points { get; set; }

        [JsonIgnore]
        public virtual UserType UserType { get; set; }

        [JsonIgnore]
        public virtual Team FavoriteTeam { get; set; }

        [JsonIgnore]
        public virtual ICollection<Group> UserGroups { get; set; }

        [JsonIgnore]
        public virtual ICollection<GroupUser> GroupUsers { get; set; }

        [JsonIgnore]
        public virtual ICollection<Prediction> Predictions { get; set; }
    }

}
