﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
}
