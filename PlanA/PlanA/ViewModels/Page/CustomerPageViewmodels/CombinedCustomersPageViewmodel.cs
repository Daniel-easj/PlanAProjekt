using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transformed.Interfaces;
using Model.Interfaces;
using PlanA.BaseClasses;
using PlanA.Model;
using PlanA.ViewModels.Base;

namespace PlanA.ViewModels.Page.CustomerPageViewmodels
{
     public class CombinedCustomersPageViewmodel : PageViewModelAppBase<CustomerBase>
    {
        public CombinedCustomersPageViewmodel() 
            : base(DomainModel.Catalogs.CustomersCatalog, new List<string>(), new List<string>())
        {
            CombineCustomerCatalogs();
        }

        public void CombineCustomerCatalogs()
        {
            foreach (var customer in DomainModel.Catalogs.PrivateCustomerCatalog.All)
            {
                if (!DomainModel.Catalogs.CustomersCatalog.All.Contains(customer))
                {
                    DomainModel.Catalogs.CustomersCatalog.CreatePersistentDataObject(customer);
                }
                
            }

            foreach (var customer in DomainModel.Catalogs.HousingAssociationCustomer.All)
            {
                if (!DomainModel.Catalogs.CustomersCatalog.All.Contains(customer))
                {
                    DomainModel.Catalogs.CustomersCatalog.CreatePersistentDataObject(customer);
                }
                
            }

            foreach (var customer in DomainModel.Catalogs.CompanyCustomers.All)
            {
                if (!DomainModel.Catalogs.CustomersCatalog.All.Contains(customer))
                {
                    DomainModel.Catalogs.CustomersCatalog.CreatePersistentDataObject(customer);
                }
            }

        }

        public override IDataWrapper<CustomerBase> CreateDataViewModel(CustomerBase obj)
        {
            return new CombinedCustomersPageViewmodel();
        }
    }
}
