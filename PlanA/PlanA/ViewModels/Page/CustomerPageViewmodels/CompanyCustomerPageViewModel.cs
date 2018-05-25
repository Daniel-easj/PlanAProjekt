using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transformed.Interfaces;
using Model.Interfaces;
using PlanA.Data.Domain.ExtendedClasses;
using PlanA.Model;
using PlanA.ViewModels.Base;
using PlanA.ViewModels.Data;

namespace PlanA.ViewModels.Page.CustomerPageViewmodels
{
    class CompanyCustomerPageViewModel : PageViewModelAppBase<CompanyCustomer>
    {        
        public CompanyCustomerPageViewModel() 
            : base(DomainModel.Catalogs.CompanyCustomersCatalog, new List<string>(), new List<string>())
        {
        }

        public override IDataWrapper<CompanyCustomer> CreateDataViewModel(CompanyCustomer obj)
        {
            return new CompanyCustomerDataViewModel(obj);
        }
    }
}
