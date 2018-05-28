using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.Advertisement;
using PlanA.Data.Domain.ExtendedClasses;

namespace PlanA.ViewModels.Data.Product
{
    class PaintDataViewModel : DataViewModelAppBase<Paint>
    {
        public PaintDataViewModel(Paint obj) : base(obj)
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

        public int Gloss
        {
            get => DataObject.Gloss;
            set
            {
                DataObject.Gloss = value;
                OnPropertyChanged();
            }
        }

        public string InDoor
        {
            get
            {
                if (DataObject.InDoor.ToString().ToLower() == "true")
                {

                    return "Ja";
                }
                else
                {
                    return "Nej";
                }
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
