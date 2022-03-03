using Microsoft.AspNetCore.Mvc;

using Services_task.Models;
using Services_task.Repository.IRepository;
using Services_task.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace UnifOfWorkTask.Controllers
{
    public class EmployeeController : Controller
    {      
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
          
            _employeeService = employeeService;


        }  
        public IActionResult GetAll()
        {
            var student = _employeeService.GetAll();
            return View(student);
        }
        public IActionResult Upsert(int? id)
        {
            EmployeeTable employee = new EmployeeTable();
            if (id == null)
                return View(employee);
           var Employee = _employeeService.Get(id.GetValueOrDefault());
            if (Employee == null)
                return NotFound();
            return View(Employee);
        }
        [HttpPost]
        public IActionResult Upsert(EmployeeTable employee)
        {           
            if (!ModelState.IsValid)
                return View(employee);
            if (employee.Id == 0)
                _employeeService.Add(employee);
            else
                _employeeService.Update(employee);
            _employeeService.Save();
            return RedirectToAction(nameof(GetAll));
        }
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();        
            _employeeService.Remove(id);           
            return RedirectToAction(nameof(GetAll));         
        }
    }
}
