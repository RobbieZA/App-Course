using System.ComponentModel.DataAnnotations;

namespace RPAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength=6, ErrorMessage="You must specify a password between 6 & 8 charaters")]
        public string Password { get; set; }
    }
}