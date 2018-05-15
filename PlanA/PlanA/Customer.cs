using System;
using System.Collections.Generic;

namespace PlanA
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int? PhoneNumber { get; set; }
        public string Mail { get; set; }
    }
}
