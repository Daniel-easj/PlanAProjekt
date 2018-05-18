using System;
using System.Collections.Generic;

namespace PlanA
{
    public partial class Wallcover
    {
        public int WallcoverId { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public int SpecificType { get; set; }
    }
}
