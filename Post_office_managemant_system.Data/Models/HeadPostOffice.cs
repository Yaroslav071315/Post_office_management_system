using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_managemant_system.Data.Models
{
    public class HeadPostOffice : Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public string Phone { get; set; }
        public List<Parcel> Parcels { get; set; } = new List<Parcel>();
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
