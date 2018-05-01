using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.ProductClasses
{
    interface IProduct
    {
        int ProductID { get; }

        int Quantity
        {
            get;
            set;
        }

        bool IsReserved
        {
            get;
            set;
        }
    }
}
