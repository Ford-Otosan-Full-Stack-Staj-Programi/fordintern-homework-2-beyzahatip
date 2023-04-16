using Homework2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Data;

public class Account:ModelBase
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }   
    public string Role { get; set; }
    public DateTime LastActivity { get; set; }
}
