using System.ComponentModel.DataAnnotations;

namespace Login.API.JWT.Token.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is Required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string? Password { get; set; }
    }
}
