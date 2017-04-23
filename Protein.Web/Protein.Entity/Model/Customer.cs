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
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "* A valid first name is required.")]
        [Display(Name = "First Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "* A valid last name is required.")]
        [Display(Name = "Last Name")]
        public string Surname { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 9, ErrorMessage = "* A valid phone nunber is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string Phone { get; set; }
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Mail adresiniz geçersiz")]
        [EmailAddress(ErrorMessage = "Mail adresiniz geçersiz")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
