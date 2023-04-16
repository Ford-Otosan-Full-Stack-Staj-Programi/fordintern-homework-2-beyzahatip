using Homework2.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Data;

public interface IUnitOfWork: IDisposable
{
    
    
    void Complete();
}
