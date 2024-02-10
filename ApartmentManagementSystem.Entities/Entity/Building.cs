using ApartmentManagementSystem.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Entities.Entity
{
    public class Building : IEntity
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public int BuildingNumber { get; set; }
        public List<Flat> Flats { get; set; }
        public List<BuildingInvoice> BuildingPayments { get; set; }
    }
}
