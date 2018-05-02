using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.ProductClasses;

namespace PlanA.TaskClasses
{
    class Associators
    {
        private Dictionary<string, IProduct> _productsAssociated;
        private Dictionary<string, CustomerBase> _customerAssociated;

        public Dictionary<string, CustomerBase> CustomerAssociated { get => _customerAssociated; set => _customerAssociated = value; }
         Dictionary<string, IProduct> ProductsAssociated { get => _productsAssociated; set => _productsAssociated = value; }


    }
}
