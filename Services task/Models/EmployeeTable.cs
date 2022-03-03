using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Services_task.Models
{
    public class EmployeeTable
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email  { get; set; }
       
    }
}
