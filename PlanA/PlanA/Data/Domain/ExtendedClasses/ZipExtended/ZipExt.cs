using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA
{
    public partial class City : DomainBase
    {
        public override int Key { get { return Convert.ToInt32(Zip); } set { Convert.ToInt32(Zip); } }
    }
}
