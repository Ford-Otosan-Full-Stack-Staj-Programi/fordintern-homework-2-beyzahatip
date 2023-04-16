using Homework2.Base;
using Homework2.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Dto.Dto
{
    public class AccountDto:BaseDto
    {
        [Required]
        [MaxLength(125)]
        [UserNameAttribute]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required]
        [PasswordAttribute]
        public string Password { get; set; }

        [Required]
        [MaxLength(500)]
        public string Name { get; set; }

        [Required]
        [EmailAddressAttribute]
        [MaxLength(500)]
        public string Email { get; set; }

        [Required]
        [RoleAttribute]
        public string Role { get; set; }

        [Display(Name = "Last Activity")]
        [DataType(DataType.Date)]
        public DateTime LastActivity { get; set; }
    }
}
