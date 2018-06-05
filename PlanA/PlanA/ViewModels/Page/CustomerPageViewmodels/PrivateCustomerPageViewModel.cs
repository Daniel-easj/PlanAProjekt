using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transformed.Interfaces;
using Model.Interfaces;
using PlanA.BaseClasses;
using PlanA.Data.Domain.ExtendedClasses;
using PlanA.Model;
using PlanA.ViewModels.Base;
using PlanA.ViewModels.Data.Customer;
using ViewModel.Page.Implementation;

namespace PlanA.ViewModels.Page.CustomerPageViewmodels
{
    public class PrivateCustomerPageViewModel : PageViewModelAppBase<PrivateCustomer>
    {
        public PrivateCustomerPageViewModel() 
            : base(DomainModel.Catalogs.PrivateCustomerCatalog,new List<string>(), new List<string>())
        {
            CombineCustomerCatalogs();
        }

        private CustomerBase _selectedCustomer;


        public override IDataWrapper<PrivateCustomer> CreateDataViewModel(PrivateCustomer obj)
        {
            return new PrivateCustomerDataViewModel(obj);
        }

        public List<City> ZipCollection => DomainModel.Catalogs.ZipCodes.All;

        public City ZipSelected
        {
            get => null;
            set => ItemDetails.DataObject.Zip = value.Zip;
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

        public CustomerBase SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<CustomerBase> Customers => DomainModel.Catalogs.Customers;


    }
}
