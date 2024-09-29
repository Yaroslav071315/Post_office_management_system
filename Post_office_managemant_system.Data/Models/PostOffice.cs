using Post_office_managemant_system.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_managemant_system.Data
{
    public class PostOffice : ServiceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Parcel> Parcels { get; set; } = new List<Parcel>();
        public HeadPostOffice HeadPostOffice { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        //FK for conection with City Зовнішній ключ для зв'язку з City
        public int CityId { get; set; }
        public City City { get; set; }
    }

}
