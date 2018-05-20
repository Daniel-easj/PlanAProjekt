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

namespace PlanA.ViewModels.Page.ProductPageViewModels
{
    public class CombinedProductsPageViewModel : PageViewModelAppBase<ProductBase>
    {
        public CombinedProductsPageViewModel() 
            : base(DomainModel.Catalogs.ProductsCatalog, new List<string>(), new List<string>() )
        {
            CombineProducts();
        }

        public void CombineProducts()
        {
            foreach (var product in DomainModel.Catalogs.CoverCatalog.All) 
            {
                
            }
        }

        public override IDataWrapper<ProductBase> CreateDataViewModel(ProductBase obj)
        {
            throw new NotImplementedException();
        }
    }
}
