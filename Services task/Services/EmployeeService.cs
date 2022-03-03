
using Services_task.Models;
using Services_task.Repository.IRepository;
using Services_task.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        
        }
        public bool Add(EmployeeTable entity)
        {
            if (entity == null)
                return false;       
            _unitOfWork.employee.Add(entity);
            return true;
        }

        public EmployeeTable Get(int Id)
        {
            if (Id == 0)
                return null;
            var employee = _unitOfWork.employee.Get(Id);
            if (employee == null)
                return null;       
            return employee;


        }

        public IEnumerable<EmployeeTable> GetAll()
        {
            var employelist = _unitOfWork.employee.GetAll();
            return employelist;
        }

        public bool Remove(int id)
        {
            if (id == 0)
                return false;
            var emp = _unitOfWork.employee.Get(id);
            if (emp == null)
                return false;
            if (!_unitOfWork.employee.Remove(emp))
            {
                return false;
            }
            return true;
        }

    public bool Save()
        {
            return _unitOfWork.employee.Save();
        }

        public bool Update(EmployeeTable employee)
        {
            if (employee == null)
                return false;         
            if (!_unitOfWork.employee.Update(employee))
            {
                return false;
            }
            return true;
        }
    }
}
