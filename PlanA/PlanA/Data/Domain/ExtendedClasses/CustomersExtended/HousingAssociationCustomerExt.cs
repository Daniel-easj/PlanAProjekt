using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class HousingAssociationCustomer : CustomerBase
    {
        private string _cVR;
        public HousingAssociationCustomer(string name, string phone, string address, string email, string cVr) : base(name, phone, address, email)
        {

            _cVR = cVr;

        }

        public HousingAssociationCustomer()
        {
        }

        public override int Key
        {
            get => HousingAssociationCustomerId;
            set => HousingAssociationCustomerId = value;
        }

        public override string CustomerType
        {
            get => "HousingAssociationCustomer";
            set => CustomerType = value;
        }

        public override string City
        {
            get => ZipNavigation.City1;
            set => ZipNavigation.City1 = value;
        }
    }
}
