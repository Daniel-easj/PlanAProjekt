﻿using System;
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

    }
}
