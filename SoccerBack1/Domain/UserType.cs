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
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1} caracteres")]
        [Index("UserType_Name_Index", IsUnique = true)]
        [Display(Name = "Tipo de usuario")]
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<User> Users { get; set; }
    }

}
