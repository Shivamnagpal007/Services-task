using Services_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services_task.Repository.IRepository
{
    public interface IEmployeeRepository : IRepository<EmployeeTable>
    {
        bool Update(EmployeeTable employee);

    }
}
