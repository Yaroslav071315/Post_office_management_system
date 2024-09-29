using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_managemant_system.Data
{

    public class City : ServiceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // One-to-many relationship with PostOffice
        public List<PostOffice> PostOffices { get; set; } = new List<PostOffice>();
    }
}
