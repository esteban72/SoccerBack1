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
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1} caracteres")]
        [Index("Group_Name_Index", IsUnique = true)]
        [Display(Name = "Grupo")]
        public string Name { get; set; }

        [Display(Name = "Usuario")]
        public int OwnerId { get; set; }

        [JsonIgnore]
        public virtual User Owner { get; set; }

        [JsonIgnore]
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }

}
