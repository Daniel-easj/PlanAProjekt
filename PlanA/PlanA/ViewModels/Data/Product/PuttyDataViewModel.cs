using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.Data.Domain.ExtendedClasses;

namespace PlanA.ViewModels.Data.Product
{
    class PuttyDataViewModel : DataViewModelAppBase<Putty>
    {
        public PuttyDataViewModel(Putty obj) : base(obj)
        {
        }

        public int Quantity
        {
            get => DataObject.Quantity;
            set
            {
                DataObject.Quantity = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => DataObject.Description;
            set
            {
                DataObject.Description = value;
                OnPropertyChanged();
            }
        }

        public int SpecificType
        {
            get => DataObject.SpecificType;
            set
            {
                DataObject.SpecificType = value;
                OnPropertyChanged();
            }
        }

        public string Coarse
        {
            get => DataObject.Coarse;
            set
            {
                DataObject.Coarse = value;
                OnPropertyChanged();
            }
        }
    }
}
