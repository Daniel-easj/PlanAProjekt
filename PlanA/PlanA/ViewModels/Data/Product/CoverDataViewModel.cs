using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.Data.Domain.ExtendedClasses;

namespace PlanA.ViewModels.Data.Product
{
    class CoverDataViewModel : DataViewModelAppBase<Cover>
    {
        public CoverDataViewModel(Cover obj) : base(obj)
        {
        }

        public int? Quantity
        {
            get { return DataObject.Quantity; }
            set { DataObject.Quantity = value; }     
        }

        public string Description
        {
            get { return DataObject.Description; }
            set { DataObject.Description = value; }
        }
        
        public int SpecificType
        { 
            get { return DataObject.SpecificType; }
            set { DataObject.SpecificType = value; }

    }   }
}
