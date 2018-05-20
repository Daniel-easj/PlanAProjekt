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
using PlanA.ViewModels.Data.Customer;

namespace PlanA.ViewModels.Page.CustomerPageViewmodels
{
    public class HousingAssociationCustomerPageViewModel : PageViewModelAppBase<HousingAssociationCustomer>
    {
        public HousingAssociationCustomerPageViewModel() 
            : base(DomainModel.Catalogs.HousingAssociationCustomer, new List<string>(), new List<string>())
        {
        }

        public override IDataWrapper<HousingAssociationCustomer> CreateDataViewModel(HousingAssociationCustomer obj)
        {
            return new HousingAssociationCustomerDataViewModel(obj);
        }
    }
}
