using System.ComponentModel.DataAnnotations;

namespace kozmetik.Models
{
    
    public class Cart
    {
        [Key]
        public int CartID{ get; set; }


        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Kullanıcı")]
        public int UserrID { get; set; }

        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Ürün")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Eklenme Zamanı")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date,ErrorMessage ="Tarih uygun formatta değil.")]
        public DateTime RecordDate{ get; set; }


        [Required(ErrorMessage = "{0} Girilmeli."), Display(Name = "Adet"),Range(1,10000,ErrorMessage ="1-10000 adet girmelisiniz.")]
        public int Quantity{ get; set; }


        public Userr  Userr{ get; set; }
        public Product Product{ get; set; }

    }






}
