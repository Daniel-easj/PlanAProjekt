using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.CustomerClasses;

namespace PlanA.CatalogClasses
{
    class CompanyCustomerCatalog : CatalogBase<CompanyCustomer>
    {
        private Dictionary<int, CompanyCustomer> _companyCustomer;

        public CompanyCustomerCatalog()
        {
            _companyCustomer = new Dictionary<int, CompanyCustomer>();
        }

        public Dictionary<int, CompanyCustomer> GetCompanyCustomers => _companyCustomer;

        public void AddCompanyCustomer(int key, CompanyCustomer companyCustomer)
        {
            _companyCustomer.Add(key, companyCustomer);
        }

        public void DeleteCompanyCustomer(int key)
        {
            _companyCustomer.Remove(key);
        }
    }
}
