using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_managemant_system.Data.Models.Interfeces
{
    public interface IManageParcels
    {
        List<Parcel> GetUserParcels();
    }
}
