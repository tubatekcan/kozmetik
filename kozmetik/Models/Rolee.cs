using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kozmetik.Models
{
    public class Rolee
    {
        [Key]
        public int RoleeID { get; set; }

        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Rol Adı"), StringLength(30, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} karakter olmalıdır.")]
        public string RoleeName { get; set; }

    }
}