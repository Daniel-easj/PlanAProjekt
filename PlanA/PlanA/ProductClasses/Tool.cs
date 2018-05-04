using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.ProductClasses
{
    class Tool : ProductBase
    {

        private string _toolType = ToolType.Default.ToString();

        public enum ToolType
        {
            Default,
            Pensler,
            Sparteljern,
            Skruetrækker,
            Kniv,
            Ruller,
            Teleskopstænger,
            Sandpapir
        }

        public override string SpecificType
        {
            get => _toolType;
            set
            {
                _toolType = value;
                OnPropertyChanged();
            }
        }



        //private string _productID;
        //private string _description = "Ingen beskrivelse";
        //private int _quantity = 0;

        //private string _toolType = ToolType.Default.ToString();


        //public enum ToolType
        //{
        //    Default,
        //    Pensler,
        //    Sparteljern,
        //    Skruetrækker,
        //    Kniv,
        //    Ruller,
        //    Teleskopstænger,
        //    Sandpapir
        //}

        //public Tool()
        //{
        //}

        //public string ProductID { get { return _productID; } }

        //public int Quantity
        //{
        //    get { return _quantity; }
        //    set
        //    {
        //        _quantity = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public string SpecificType
        //{
        //    get => _toolType;
        //    set
        //    {
        //        _toolType = value;
        //        OnPropertyChanged();
        //    }
        //}

        //// Kort beskrivelse af produktet som laves i Viewet således at der kan kendes forskel på de enkelte objekter med samme enum type
        //public string Description
        //{
        //    get => _description;
        //    set
        //    {
        //        _description = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
