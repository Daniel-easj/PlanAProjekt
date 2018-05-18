using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transformed.Interfaces;
using Model.Interfaces;
using PlanA.Data.Domain.ExtendedClasses;
using PlanA.ViewModels.Base;
using PlanA.ViewModels.Data;

namespace PlanA.ViewModels.Page.CustomerPageViewModels
{
    class CompanyCustomerPageViewModel : PageViewModelAppBase<CompanyCustomer>
    {
        public CompanyCustomerPageViewModel(ICatalog<CompanyCustomer> catalog, List<string> immutableControls, List<string> mutableControls) : base(catalog, immutableControls, mutableControls)
        {
        }

        public override IDataWrapper<CompanyCustomer> CreateDataViewModel(CompanyCustomer obj)
        {
            return new CompanyCustomerDataViewModel(obj);
        }
    }
}
