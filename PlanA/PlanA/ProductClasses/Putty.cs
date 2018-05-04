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
    class Putty : ProductBase
    {

        private string _coarseType = Coarse.Default.ToString();
        private string _puttyType = PuttyType.Default.ToString();

        public enum PuttyType
        {
            Default,
            Vådrum,
            AlmindeligRum
        }

        public enum Coarse
        {
            Default,
            Light,
            Medium,
            Coarse
        }

        public string CoarseType { get { return _coarseType; } }

        public override string SpecificType
        {
            get => _puttyType;
            set
            {
                _puttyType = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return "Spartelmasse";
        }

        //private string _productID;
        //private string _description = "Ingen beskrivelse";
        //private int _quantity = 0;

        //private string _coarseType = Coarse.Default.ToString();
        //private string _puttyType = PuttyType.Default.ToString();

        //public enum PuttyType
        //{
        //    Default,
        //    Vådrum,
        //    AlmindeligRum
        //}

        //public enum Coarse
        //{
        //    Default,
        //    Light,
        //    Medium, 
        //    Coarse
        //}

        //public Putty()
        //{
        //}

        //public string ProductID { get { return _productID; } }
        //public string CoarseType { get { return _coarseType; } }

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
        //    get => _puttyType;
        //    set
        //    {
        //        _puttyType = value;
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
