using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class Cover : ProductBase
    {
        public Cover(int quantity, string description, int specificType) : base(quantity, description, specificType)
        {
        }

        public Cover()
        {
            
        }

    }
}
