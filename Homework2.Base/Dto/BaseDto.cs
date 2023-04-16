using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Base;

public class BaseDto
{
    
    public int Id { get; set; }

    [Display(Name = "Created By")]
     public string CreatedBy { get; set; }

    [Display(Name = "Created At")]
    public DateTime CreatedAt { get; set; }
}
