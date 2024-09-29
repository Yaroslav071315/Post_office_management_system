using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_managemant_system.Data.Models
{
    public class HeadPostOffice : Employee
    {
        // HeadPostOffice can manage employees too
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }
    }
}