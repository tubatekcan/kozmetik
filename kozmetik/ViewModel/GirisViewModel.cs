using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace kozmetik.ViewModel
{
    public class GirisViewModel
    {
        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Eposta"), StringLength(52, MinimumLength = 6, ErrorMessage = "{0} {2} - {1} karakter olmalıdır."), DataType(DataType.EmailAddress, ErrorMessage = "Eposta uygun formatta değil.")]
        public string Emaill { get; set; }



        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Şifre"), StringLength(20, MinimumLength = 6, ErrorMessage = "{0} {2} - {1} karakter olmalıdır."), DataType(DataType.Password)]
        public string Passwordd { get; set; }
    }
}
