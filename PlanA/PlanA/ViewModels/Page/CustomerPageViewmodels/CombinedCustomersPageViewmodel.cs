//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Data.Transformed.Interfaces;
//using Model.Interfaces;
//using PlanA.BaseClasses;
//using PlanA.Model;
//using PlanA.ViewModels.Base;
//using PlanA.ViewModels.Data.CombinedCustomers;

//namespace PlanA.ViewModels.Page.CustomerPageViewmodels
//{
//     public class CombinedCustomersPageViewmodel : PageViewModelAppBase<CustomerBase>
//    {
//        public CombinedCustomersPageViewmodel() 
//            : base(DomainModel.Catalogs.CustomersCatalog, new List<string>(), new List<string>())
//        {
//            CombineCustomerCatalogs();

//            int count = DomainModel.Catalogs.CustomersCatalog.All.Count;
//            int b = count;
//        }

//        public void CombineCustomerCatalogs()
//        {
//            foreach (var customer in DomainModel.Catalogs.PrivateCustomerCatalog.All)
//            {
//                if (!DomainModel.Catalogs.CustomersCatalog.IDExists(customer))
//                {
//                    DomainModel.Catalogs.CustomersCatalog.Create(customer);
//                }
                
//            }

//            foreach (var customer in DomainModel.Catalogs.HousingAssociationCustomerCatalog.All)
//            {
//                if (!DomainModel.Catalogs.CustomersCatalog.IDExists(customer))
//                {
//                    DomainModel.Catalogs.CustomersCatalog.Create(customer);
//                }
                
//            }

//            foreach (var customer in DomainModel.Catalogs.CompanyCustomersCatalog.All)
//            {
//                if (!DomainModel.Catalogs.CustomersCatalog.IDExists(customer))
//                {
//                    DomainModel.Catalogs.CustomersCatalog.Create(customer);
//                }
//            }

//        }


//        public override IDataWrapper<CustomerBase> CreateDataViewModel(CustomerBase obj)
//        {
//            return new CustomersDataViewmodel(obj);
//        }
//    }
//}
