using System;
using System.Collections.Generic;

namespace PlanA
{
    public partial class Tool
    {
        public int ToolId { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public int SpecificType { get; set; }
    }
}
