using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_managemant_system.Data
{
    public class Parcel : ServiceObject
    {
        public int Weight { get; set; }
        public DateTime DateSend { get; set; }
        public DateTime DateCome { get; set; }
        public decimal Price { get; set; }

        // Foreign key to PostOffice
        public int PostOfficeId { get; set; }
        public PostOffice PostOfficeSend { get; set; }
        public PostOffice PostOfficeCome { get; set; }
    }
}
