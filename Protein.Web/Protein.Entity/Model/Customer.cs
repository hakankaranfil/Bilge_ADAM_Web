using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Protein.Entity.Model
{
  public  class Customer
    {
        public int CustomerID { get; set; }
        //[Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        
        public string Surname { get; set; }
        //[Required(ErrorMessage = "Lütfen telefon numaranızı giriniz.")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email boş bırakılamaz")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                             @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                             @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                             ErrorMessage = "Email adresi geçersiz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        public string Address { get; set; }
    }
}
