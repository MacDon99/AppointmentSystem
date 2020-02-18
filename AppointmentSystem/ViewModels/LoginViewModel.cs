using System.ComponentModel.DataAnnotations;

namespace AppointmentSystem.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password, ErrorMessage = "Password incorrect. Password must include big and small letters and alphanumeric symbol.")]
        
        public string Password { get; set; }
    }
}
