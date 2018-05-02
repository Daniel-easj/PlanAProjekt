using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.ProductClasses
{
    class Tool : IProduct, INotifyPropertyChanged
    {
        private string _productID;
        private string _description;
        private int _quantity;

        private ToolType _toolType;


        public enum ToolType
        {
            Pensler,
            Sparteljern,
            Skruetrækker,
            Kniv,
            Ruller,
            Teleskopstænger,
            Sandpapir
        }

        public Tool(int quantity)
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

        public ToolType SpecificType
        {
            get => _toolType;
            set
            {
                _toolType = value;
                OnPropertyChanged();
            }
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
