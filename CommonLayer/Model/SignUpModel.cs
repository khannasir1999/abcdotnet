using System.ComponentModel.DataAnnotations;

namespace abc.CommonLayer.Model
{
    public class SignUpModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Compare("Confirm_Password")]
        public string Password { get; set; }
        [Required]
        public string Confirm_Password { get; set; } 

    }
}
