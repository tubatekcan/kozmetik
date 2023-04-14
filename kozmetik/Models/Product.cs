using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace kozmetik.Models
{
    public class Product
    {
        [Key]


        public int ProductID { get; set; }


        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Ürün Adı"), StringLength(30, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} karakter olmalıdır.")]

        public string ProductName { get; set; }

        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Kategori")]
        public int CategoryID { get; set; }



        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Ürün Açıklaması"), StringLength(400, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} karakter olmalıdır.")]

        public string Description{ get; set; }


        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Ürün Fiyatı"), Precision(6, 2)]
        public decimal ProductPrice { get; set; }

        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Ürün Eski Fiyatı"), Precision(6, 2)]
        public decimal OlderPrice { get; set; }


        public Category Category { get; set; }

    }
}
