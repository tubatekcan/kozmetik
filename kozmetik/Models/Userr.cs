using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace kozmetik.Models
{
    public class Userr
    {

        [Key]
        public int UserrID { get; set; }


        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Eposta"), StringLength(52, MinimumLength = 6, ErrorMessage = "{0} {2} - {1} karakter olmalıdır."), DataType(DataType.EmailAddress, ErrorMessage = "Eposta uygun formatta değil.")]
        public string Emaill { get; set; }



        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Şifre"), StringLength(20, MinimumLength = 6, ErrorMessage = "{0} {2} - {1} karakter olmalıdır."),DataType(DataType.Password)]
        public string Passwordd { get; set; }

        [NotMapped, Display(Name = "Şifre Tekrarı"), DataType(DataType.Password), Compare("Passwordd", ErrorMessage = "Şifre ve Şifre Tekrarı Uyuşmuyor.")]
        public string PasswordRepeatt{ get; set; }

        
        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Rol")]
        public int RoleeID { get; set; }

        public Rolee Rolee { get; set; } // navigasyon için gerekli

    }
}
