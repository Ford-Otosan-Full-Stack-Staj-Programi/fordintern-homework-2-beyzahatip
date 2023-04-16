using Homework2.Base;
using Homework2.Base;
using System.ComponentModel.DataAnnotations;

namespace Homework2.Dto;

public class PersonDto:BaseDto
{
    public int AccountId { get; set; }

    [Required]
    [MaxLength(500)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(500)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [EmailAddress]
    [MaxLength(500)]
    public string Email { get; set; }

    [MaxLength(500)]
    public string Description { get; set; }

    [Phone]
    [MaxLength(25)]
    public string Phone { get; set; }


    [Required]
    [DateOfBirth]
    [DataType(DataType.Date)]
    [Display(Name = "Date Of Birth")]
    public DateTime DateOfBirth { get; set; }
}
