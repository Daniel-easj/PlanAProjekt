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

        private Dictionary<int, PrivateCustomer> _privateCustomer;

        public PrivateCustomerCatalog()
        {
            _privateCustomer = new Dictionary<int, PrivateCustomer>();
        }

        public Dictionary<int, PrivateCustomer> GetPrivateCustomers => _privateCustomer;

        public void AddPrivateCustomer(int key, PrivateCustomer privateCustomer)
        {
          _privateCustomer.Add(key, privateCustomer);
        }

        public void DeletePrivateCustomer(int key)
        {
            _privateCustomer.Remove(key);
        }




    }
}
