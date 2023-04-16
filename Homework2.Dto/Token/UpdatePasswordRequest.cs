using Homework2.Base;
using System.ComponentModel.DataAnnotations;

namespace Homework2.Dto;

public class UpdatePasswordRequest
{
    [Required]
    [PasswordAttribute]
    public string OldPassword { get; set; }

    [Required]
    [Password]
    public string NewPassword { get; set; }
}
