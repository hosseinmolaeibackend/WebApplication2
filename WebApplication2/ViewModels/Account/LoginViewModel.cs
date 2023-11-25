using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ViewModels.Account;

public class LoginViewModel
{
    [Display(Name = "ایمیل")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [EmailAddress(ErrorMessage = "{0} وارد شده معتبر نمیباشد")]
    [MaxLength(150, ErrorMessage = " {0} نمیتواند بیشتر از {1} باشد")]
    [DataType(DataType.EmailAddress)]
    public string Username { get; set; }

    [Display(Name = "پسورد")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(150, ErrorMessage = " {0} نمیتواند بیشتر از {1} باشد")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Display(Name = "مرا بخاطر بسپار")]
    public bool Remeberme { get; set; }
}