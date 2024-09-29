using Post_office_managemant_system.Data.Models.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_managemant_system.Data.Models
{
    public class Employee : Client, IManageParcels, IManagePerson
    {
        // Employee can manage clients and parcels
        public List<Client> Clients { get; set; } = new List<Client>();

        public List<Parcel> GetAllParcels(List<Parcel> allParcels)
        {
            return allParcels;
        }

        public List<Client> GetClients()
        {
            return Clients;
        }
    }
}
