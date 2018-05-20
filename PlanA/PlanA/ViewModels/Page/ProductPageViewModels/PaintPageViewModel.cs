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
using PlanA.ViewModels.Data.Product;
using Remotion.Linq.Utilities;
using ViewModel.Page.Implementation;

namespace PlanA.ViewModels.Page.ProductPageViewModels
{
    public class PaintPageViewModel : PageViewModelAppBase<Paint>
    {
        public PaintPageViewModel() 
            : base(DomainModel.Catalogs.PaintCatalog, new List<string>(), new List<string>())
        {
        }

        public override IDataWrapper<Paint> CreateDataViewModel(Paint obj)
        {
            return new PaintDataViewModel(obj);
        }
    }
}
