using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.CatalogClasses
{
    class CustomerCatalog : CatalogBase<CustomerBase>
    {
        private CustomerCatalog _singletonInstance;

        private Dictionary<string, CustomerBase> _customerCatalog;

        public CustomerCatalog()
        {
            _customerCatalog = new Dictionary<string, CustomerBase>();
        }
    }
}
