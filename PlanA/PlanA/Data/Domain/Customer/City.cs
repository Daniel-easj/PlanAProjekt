using System;
using System.Collections.Generic;
using PlanA.Data.Domain.ExtendedClasses;

namespace PlanA
{
    public partial class City
    {
        public City()
        {
            CompanyCustomers = new HashSet<CompanyCustomer>();
            HousingAssociationCustomers = new HashSet<HousingAssociationCustomer>();
            PrivateCustomers = new HashSet<PrivateCustomer>();
        }

        public string Zip { get; set; }
        public string City1 { get; set; }

        public ICollection<CompanyCustomer> CompanyCustomers { get; set; }
        public ICollection<HousingAssociationCustomer> HousingAssociationCustomers { get; set; }
        public ICollection<PrivateCustomer> PrivateCustomers { get; set; }
    }
}
