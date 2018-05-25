using System;
using System.Collections.Generic;

namespace PlanA
{
    public partial class Task
    {
        public int RefNr { get; set; }
        public string TaskDescription { get; set; }
        public string TaskSource { get; set; }
        public DateTime? TaskStart { get; set; }
        public DateTime? TaskEnd { get; set; }
    }
}
