﻿using System;
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

namespace PlanA.ViewModels.Page.ProductPageViewModels
{
    public class ToolPageViewModel : PageViewModelAppBase<Tool>
    {
        public ToolPageViewModel() 
            : base(DomainModel.Catalogs.ToolCatalog, new List<string>(), new List<string>())
        {
        }

        public override IDataWrapper<Tool> CreateDataViewModel(Tool obj)
        {
            return new ToolDataViewModel(obj);
        }
    }
}
