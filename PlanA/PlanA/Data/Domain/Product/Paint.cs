using System;
using System.Collections.Generic;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class Paint
    {
        public int PaintId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int SpecificType { get; set; }
        public int Gloss { get; set; }
        public bool? InDoor { get; set; }
    }
}
