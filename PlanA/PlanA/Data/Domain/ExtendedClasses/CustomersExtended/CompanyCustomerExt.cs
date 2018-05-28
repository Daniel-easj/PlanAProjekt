using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class CompanyCustomer : CustomerBase
    {
        private string _cVR;

        public CompanyCustomer(string name, string phone, string address, string email, string cVR) : base(name, phone, address, email)
        {
            _cVR = cVR;
        }

        public CompanyCustomer()
        {
        }

        public override int Key
        {
            get => CompanyCustomer1;
            set => CompanyCustomer1 = value;
        }

        public override string CustomerType
        {
            get => "CompanyCustomer";
            set => CustomerType = value;
        }

        public override string City
        {
            get => ZipNavigation.City1;
            set => ZipNavigation.City1 = value;
        }

    }
}
