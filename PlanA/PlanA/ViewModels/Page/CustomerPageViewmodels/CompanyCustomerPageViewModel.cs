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

        // TODO: Lav en "Domainklasse" hvor alle cataloger samles (singleton)
        
        public CompanyCustomerPageViewModel() 
            : base(DomainModel.Catalogs.CompanyCustomersCatalog, new List<string>(), new List<string>())
        {
        }

        //TODO: Saml alle de relevante lister i en ny klasse hvor man kalder en metode til en ny list (property)

        public override IDataWrapper<CompanyCustomer> CreateDataViewModel(CompanyCustomer obj)
        {
            return new CompanyCustomerDataViewModel(obj);
        }
    }
}
