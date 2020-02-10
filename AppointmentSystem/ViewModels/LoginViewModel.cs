using System.ComponentModel.DataAnnotations;

namespace AppointmentSystem.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Nazwa Użytkownika")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password, ErrorMessage = "Niepoprawne hasło. Wymaganie są małe i wielkie litery oraz znak alfanumeryczny.")]

        public string Password { get; set; }
    }
}
