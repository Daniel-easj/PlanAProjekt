using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.ViewModels.Data.CombinedProducts
{
    public class ProductsDataViewmodel : DataViewModelAppBase<ProductBase>
    {
        public ProductsDataViewmodel(ProductBase obj) : base(obj)
        {
        }

        public int Quantity
        {
            get { return DataObject.Quantity; }
        }

        public string Description
        {
            get { return DataObject.Description; }
        }

        public int SpecificType
        {
            get { return DataObject.SpecificType; }
        }
    }
}
