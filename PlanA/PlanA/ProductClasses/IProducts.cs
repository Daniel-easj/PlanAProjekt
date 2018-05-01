using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;

namespace PlanA.ProductClasses
{
    interface IProducts
    {
        int ProductID
        {
            get;
        }

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
