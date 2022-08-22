using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Ad Soyad Girirniz!")]
        public string NameSurname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Girirniz!")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Mail Adresi Girirniz!")]
        public string Email { get; set; }

        [Display(Name = "Kullancı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı Girirniz!")]
        public string UserName { get; set; }

    }
}
