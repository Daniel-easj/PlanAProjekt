using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class Paint : ProductBase
    {
        private int _gloss;
        private bool _inDoor;

        public Paint(int quantity, string description, int specificType) : base(quantity, description, specificType)
        {
        }

        public Paint()
        {
            
        }

        public override int Key
        {
            get => PaintId;
            set => PaintId = value;
        }
    }
}
