using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class Wallcover
    {
        public int WallcoverId { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public int SpecificType { get; set; }
    }
}
