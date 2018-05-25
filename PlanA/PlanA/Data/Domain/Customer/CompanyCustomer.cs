using System;
using System.Collections.Generic;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class CompanyCustomer
    {
        public int CompanyCustomer1 { get; set; }
        public override string Name { get; set; }
        public override string Phone { get; set; }
        public override string Address { get; set; }
        public override string Email { get; set; }
        public string Cvr { get; set; }
        public override string Zip { get; set; }

        public City ZipNavigation { get; set; }
    }
}
