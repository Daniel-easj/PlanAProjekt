using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.ProductClasses
{
    class Paint : ProductBase
    {

        private int _gloss;
        private bool _inDoor = true;
        private string _paintType = PaintType.Default.ToString();

        public enum PaintType
        {
            Default,
            Træmaling,
            Facademaling,
            Grunder
        }

        public override string SpecificType
        {
            get => _paintType;
            set
            {
                _paintType = value;
                OnPropertyChanged();
            }
        }

        public override bool InDoor { get => _inDoor; set => _inDoor = value; }
        public override int Gloss { get => _gloss; set => _gloss = value; }

        public override string ToString()
        {
            return "Maling";
        }


        //private string _productID;
        //private string _description = "Ingen beskrivelse";
        //private int _quantity = 0;
        //private int _gloss;
        //private bool _inDoor = true;

        //private string _paintType = PaintType.Default.ToString();

        //public enum PaintType
        //{
        //    Default,
        //    Træmaling,
        //    Facademaling,
        //    Grunder
        //}

        //public Paint()
        //{
        //}

        //public string ProductID { get { return _productID; } }
        //public bool InDoor { get => _inDoor; set => _inDoor = value; }

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
        //    get => _paintType;
        //    set
        //    {
        //        _paintType = value;
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
