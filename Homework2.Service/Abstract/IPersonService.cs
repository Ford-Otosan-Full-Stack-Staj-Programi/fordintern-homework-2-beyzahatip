﻿using Homework2.Data.Model;
using Homework2.Dto;
using Homework2.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Service.Abstract
{
    public interface IPersonService: IBaseService<PersonDto,Person>
    {
    }
}
