using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.Data.Domain.ExtendedClasses;

namespace PlanA.ViewModels.Data.Product
{
    class WallCoverDataViewModel : DataViewModelAppBase<Wallcover>
    {
        public WallCoverDataViewModel(Wallcover obj) : base(obj)
        {
        }

        public int? Quantity
        {
            get { return DataObject.Quantity; }
            set { DataObject.Quantity = value; OnPropertyChanged(); }
        }
        public string Description
        {
            get { return DataObject.Description; }
            set
            {
                DataObject.Description = value;
                OnPropertyChanged();
            }
        }

        public int SpecificType
        {
            get { return DataObject.SpecificType; }
            set
            {
                DataObject.SpecificType = value;
                OnPropertyChanged();
            }


        }
}   }
