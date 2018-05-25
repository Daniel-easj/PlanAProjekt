using System;
using System.Collections.Generic;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class PrivateCustomer
    {
        public int PrivateCustomerId { get; set; }
        public override string Name { get; set; }
        public override string Phone { get; set; }
        public override string Address { get; set; }
        public override string Email { get; set; }
        public override string Zip { get; set; }

        public City ZipNavigation { get; set; }
    }
}
