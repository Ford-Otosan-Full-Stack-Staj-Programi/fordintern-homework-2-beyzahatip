using Homework2.Base;
using System.ComponentModel.DataAnnotations;

namespace Homework2.Dto;

public class TokenRequest
{
    [Required]
    [MaxLength(125)]
    [UserNameAttribute]
    [Display(Name = "User Name")]
    public string Username { get; set; }

    [Required]
    [PasswordAttribute]
    public string Password { get; set; }
}
