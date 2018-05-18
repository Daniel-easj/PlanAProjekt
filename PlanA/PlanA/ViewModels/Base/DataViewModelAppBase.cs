using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Data.Implementation;

namespace PlanA.ViewModels
{
    public abstract class DataViewModelAppBase<TViewData> : DataViewModelBase<TViewData>
    {
        protected DataViewModelAppBase(TViewData obj) : base(obj)
        {
        }
    }
}
