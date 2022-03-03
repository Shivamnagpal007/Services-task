
using Services_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_task.Services.IServices
{
   public interface IEmployeeService
    {
        EmployeeTable Get(int Id);

        IEnumerable<EmployeeTable> GetAll();

        bool Add(EmployeeTable entity);

        bool Remove(int id);

       bool Save();
        bool Update(EmployeeTable employeeTable);
    }
}
