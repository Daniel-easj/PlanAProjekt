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
        private string _cVR;

        public CompanyCustomer(string name, string phone, string address, string email, string cVR) : base(name, phone, address, email)
        {
            _cVR = cVR;
        }

        public string CVR { get; set; }
    }
}
