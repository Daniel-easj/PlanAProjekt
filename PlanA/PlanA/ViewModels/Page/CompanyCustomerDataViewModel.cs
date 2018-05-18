using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transformed.Interfaces;
using Model.Interfaces;
using PlanA.Data.Domain.ExtendedClasses;
using PlanA.ViewModels.Base;

namespace PlanA.ViewModels.Page
{
    public class CompanyCustomerDataViewModel : PageViewModelAppBase<CompanyCustomer>
    {
        public CompanyCustomerDataViewModel(ICatalog<CompanyCustomer> catalog, List<string> immutableControls, List<string> mutableControls) : base(catalog, immutableControls, mutableControls)
        {
        }

        public override IDataWrapper<CompanyCustomer> CreateDataViewModel(CompanyCustomer obj)
        {
            throw new NotImplementedException();
        }
    }
}
