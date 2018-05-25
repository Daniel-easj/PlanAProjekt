using System;
using System.Collections.Generic;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class Putty
    {
        public int PuttyId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int SpecificType { get; set; }
        public string Coarse { get; set; }
    }
}
