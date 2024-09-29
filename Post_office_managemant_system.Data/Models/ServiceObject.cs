using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_managemant_system.Data
{
    public abstract class ServiceObject
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public ServiceObject()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
