using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.ProductClasses
{
    interface IProduct
    {
        string ProductID { get; }

        int Quantity
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        string SpecificTypeToString
        {
            get;
        }

    }
}
