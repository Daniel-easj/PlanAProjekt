using System;
using System.Collections.Generic;

namespace PlanA.Data.Domain
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
