using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class PrivateCustomer : CustomerBase
    {
        public PrivateCustomer(string name, string phone, string address, string email) : base(name, phone, address, email)
        {
        }

        public PrivateCustomer()
        {
        }

        public override int Key
        {
            get => PrivateCustomerId;
            set => PrivateCustomerId = value;
        }

        public override string CustomerType
        {
            get => "PrivateCustomer";
            set => CustomerType = value;
        }

        public override string City
        {
            get => ZipNavigation.City1;
            set => ZipNavigation.City1 = value;
        }
    }
}
