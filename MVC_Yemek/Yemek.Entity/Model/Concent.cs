using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek.Entity.Model
{
  public  class Concent
    {
        public int ConcentID { get; set; }
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email boş bırakılamaz")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                             @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                             @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                             ErrorMessage = "Email adresi geçersiz")]
        public string EMail{ get; set; }
        [Required(ErrorMessage = "Lütfen mesajınızı yazınız.")]
        public string Message { get; set; }
        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz.")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
