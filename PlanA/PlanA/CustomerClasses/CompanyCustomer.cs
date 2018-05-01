using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.CustomerClasses
{
    class CompanyCustomer : CustomerBase
    {
        public CompanyCustomer(string name, string phone, string address, string email) : base(name, phone, address, email)
        {
        }
    }
}
