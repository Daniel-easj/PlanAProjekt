using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.Data.Domain.ExtendedClasses
{
    public partial class Wallcover : ProductBase
    {
        public Wallcover(int quantity, string description, int specificType) : base(quantity, description, specificType)
        {
        }

        public Wallcover()
        {

        }

        public override int Key
        {
            get => WallcoverId;
            set => WallcoverId = value;
        }
    }
}
