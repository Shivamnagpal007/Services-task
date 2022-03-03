
using Services_task.Repository;
using Services_task.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnifOfWorkTask.Data;
using UnifOfWorkTask.Repository;


namespace BookShopping_Practice.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
       // private StudentRepository _studentRepository { get; set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            employee = new EmployeeRepository(_context);

        }    
        public IEmployeeRepository employee { get; private set; }

        //public IStudentRepository StudentRepository => _studentRepository ??= new StudentRepository(_context);

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
