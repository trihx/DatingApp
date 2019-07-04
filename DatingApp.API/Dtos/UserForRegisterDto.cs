using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Tai khoan k duoc de trong")]
        public string Username { get; set; }
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Ban phai nhap mat khau nhieu hon 4 ky tu")]
        public string Password { get; set; }
    }
}