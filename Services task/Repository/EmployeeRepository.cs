using Services_task.Models;
using Services_task.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnifOfWorkTask.Data;
using UnifOfWorkTask.Repository;

namespace Services_task.Repository
{
    public class EmployeeRepository : Repository<EmployeeTable>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
       
        public bool Update(EmployeeTable employee)
        {
            _context.Update(employee);
            return Save();
        }
    }
}
