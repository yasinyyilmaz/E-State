using System.ComponentModel.DataAnnotations;

namespace Estate.UI.Areas.User.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Boş geçilmez.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş geçilmez.")]
        [DataType(DataType.Password, ErrorMessage = "Şifre tipinde değil.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Boş geçilmez.")]
        [DataType(DataType.Password, ErrorMessage = "Şifre tipinde değil.")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "Boş geçilmez.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Boş geçilmez.")]
        public string FullName { get; set; }
    }
}
