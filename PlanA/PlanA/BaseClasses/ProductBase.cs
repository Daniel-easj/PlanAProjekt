using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.BaseClasses
{
    public class ProductBase : DomainBase
    {
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int SpecificType { get; set; }

        protected ProductBase(int quantity, string description, int specificType)
        {
            Quantity = quantity;
            Description = description;
            SpecificType = specificType;
        }

        public ProductBase()
        {
            
        }

        public override int Key
        {
            get => throw new Exception();
            set => throw new Exception();
        }
    }
}
