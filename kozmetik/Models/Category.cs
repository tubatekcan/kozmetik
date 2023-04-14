using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace kozmetik.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Kategori Adı"), StringLength(30, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} karakter olmalıdır.")]
        public string CategoryName { get; set; }
    }
}
