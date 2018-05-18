using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.BaseClasses
{
    public abstract class ProductBase : DomainBase
    {
        protected int _quantity;
        protected string _description;
        protected int _specificType;

        protected ProductBase(int quantity, string description, int specificType)
        {
            _quantity = quantity;
            _description = description;
            _specificType = specificType;
        }

        protected ProductBase()
        {
            
        }
        public override void SetDefaultValues()
        {
            _quantity = 0;
            _description = "(Not set)";
            _specificType = 0;
        }

    }
}
