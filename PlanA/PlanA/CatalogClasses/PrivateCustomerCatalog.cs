using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.CustomerClasses;

namespace PlanA.CatalogClasses
{
    class PrivateCustomerCatalog : CatalogBase<PrivateCustomer>
    {

        private Dictionary<string, PrivateCustomer> _privateCustomer;

        public PrivateCustomerCatalog()
        {
            _privateCustomer = new Dictionary<string, PrivateCustomer>();
        }

        public Dictionary<string, PrivateCustomer> GetPrivateCustomers => _privateCustomer;

        public void AddPrivateCustomer(string key, PrivateCustomer privateCustomer)
        {
          _privateCustomer.Add(key, privateCustomer);
        }

        public void DeletePrivateCustomer(string key)
        {
            _privateCustomer.Remove(key);
        }




    }
}
