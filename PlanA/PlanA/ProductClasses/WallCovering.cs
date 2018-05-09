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
    class WallCovering : ProductBase
    {

        private string _wallCoveringType = WallCoveringType.Default.ToString();

        public enum WallCoveringType
        {
            Default,
            Glasvæv,
            Glasfilt,
            Savsmuldstapet
        }

        public override string ProductID { get { return "72" + "INDSÆT DB ID"; } }

        public override string SpecificType
        {
            get => _wallCoveringType;
            set
            {
                _wallCoveringType = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return "Vægbeklædning";
        }


        //private string _productID;
        //private string _description = "Ingen beskrivelse";
        //private int _quantity = 0;

        //private string _wallCoveringType = WallCoveringType.Default.ToString();

        //public enum WallCoveringType
        //{
        //    Default,
        //    Glasvæv,
        //    Glasfilt,
        //    Savsmuldstapet
        //}

        //public WallCovering()
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
        //    get => _wallCoveringType;
        //    set
        //    {
        //        _wallCoveringType = value;
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
