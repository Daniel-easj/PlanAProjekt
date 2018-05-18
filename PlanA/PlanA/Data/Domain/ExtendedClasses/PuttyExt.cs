using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.ProductClasses
{
    public partial class Putty : ProductBase
    {
        private string _coarseType;
       

        public Putty(int quantity, string description, int specificType) : base(quantity, description, specificType)
        {
            _coarseType = "";
        }


        public override void SetDefaultValues()
        {
            base.SetDefaultValues();
            _coarseType = "";
        }
    }
}
