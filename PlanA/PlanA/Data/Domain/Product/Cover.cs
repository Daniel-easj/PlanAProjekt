﻿using System;
using System.Collections.Generic;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class Cover
    {
        public int CoverId { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public int SpecificType { get; set; }
    }
}
