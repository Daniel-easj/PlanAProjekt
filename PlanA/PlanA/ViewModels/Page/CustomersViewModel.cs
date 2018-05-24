using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.Annotations;
using PlanA.BaseClasses;
using PlanA.Model;

namespace PlanA.ViewModels.Page
{
    public class CustomersViewModel
    {
       
        public CustomersViewModel()
        {
            CombineCustomerCatalogs();
        }

        public void CombineCustomerCatalogs()
        {
            foreach (var customer in DomainModel.Catalogs.PrivateCustomerCatalog.All)
            {
                if (!DomainModel.Catalogs.IDExists(customer))
                {
                    DomainModel.Catalogs.Customers.Add(customer);
                }

            }

            foreach (var customer in DomainModel.Catalogs.HousingAssociationCustomerCatalog.All)
            {
                if (!DomainModel.Catalogs.IDExists(customer))
                {
                    DomainModel.Catalogs.Customers.Add(customer);
                }

            }

            foreach (var customer in DomainModel.Catalogs.CompanyCustomersCatalog.All)
            {
                if (!DomainModel.Catalogs.IDExists(customer))
                {
                    DomainModel.Catalogs.Customers.Add(customer);
                }
            }
        }

        public ObservableCollection<CustomerBase> Customers
        {
            get { return DomainModel.Catalogs.Customers; }
        }
    }
}
