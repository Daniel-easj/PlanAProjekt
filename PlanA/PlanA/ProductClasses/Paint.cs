using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.ProductClasses
{
    class Paint : IProduct, INotifyPropertyChanged
    {
        private string _productID;
        private string _description = "Ingen beskrivelse";
        private int _quantity;

        private PaintType _paintType = PaintType.Default;

        public enum PaintType
        {
            Default,
            Træmaling,
            Facademaling,
            Grunder
        }

        public Paint(int quantity)
        {
            _quantity = quantity;
        }

        public string ProductID { get { return _productID; } }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }

        public PaintType SpecificType
        {
            get => _paintType;
            set
            {
                _paintType = value;
                OnPropertyChanged();
            }
        }

        public string SpecificTypeToString
        {
            get => _paintType.ToString();
        }

        // Kort beskrivelse af produktet som laves i Viewet således at der kan kendes forskel på de enkelte objekter med samme enum type
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
