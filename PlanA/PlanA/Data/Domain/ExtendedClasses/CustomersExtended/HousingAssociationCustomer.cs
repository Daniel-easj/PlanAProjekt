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

            _cVR = CVR;

        }


        public HousingAssociationCustomer()
        {
        }


        public string CVR { get; set; }
        public override void SetDefaultValues()
        {
            base.SetDefaultValues();
            CVR = "";
        }

    }
}
