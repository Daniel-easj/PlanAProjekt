using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.InMemory.Interfaces;
using Extensions.ViewModel.Implementation;
using Model.Interfaces;

namespace PlanA.ViewModels.Base
{
    public abstract class PageViewModelAppBase<TViewData> : PageViewModelCRUD<TViewData>
        where TViewData : class, ICopyable, IStorable, new()
    {
        protected PageViewModelAppBase(ICatalog<TViewData> catalog, List<string> immutableControls, List<string> mutableControls) : base(catalog, immutableControls, mutableControls)
        {
        }
    }
}
