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
    public partial class Tool : ProductBase
    {
        public Tool(int quantity, string description, int specificType) : base(quantity, description, specificType)
        {
        }

        public Tool()
        {
            
        }

        public override int Key
        {
            get => ToolId;
            set => ToolId = value;
        }
    }
}
