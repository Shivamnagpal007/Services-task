﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services_task.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IEmployeeRepository employee { get; }
        void Save();
    }
}
