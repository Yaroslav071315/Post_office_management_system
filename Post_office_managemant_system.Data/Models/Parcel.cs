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

        // FK for conection with PostOffice
        public int PostOfficeId { get; set; } // Foreign key
        public PostOffice PostOfficeSend { get; set; }
        public PostOffice PostOfficeCome { get; set; }

        public Parcel(int weight, DateTime dateSend, DateTime dateCome, decimal price)
        {
            Weight = weight;
            DateSend = dateSend;
            DateCome = dateCome;
            Price = price;
        }
    }
}
