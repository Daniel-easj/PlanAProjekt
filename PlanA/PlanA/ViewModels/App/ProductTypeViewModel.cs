using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.Annotations;

namespace PlanA.ViewModels.App
{
    class ProductTypeViewModel : INotifyPropertyChanged
    {
        private bool _paintEnabled = false;
        private bool _puttyEnabled = false;
        private bool _toolsEnabled = false;
        private bool _coveringEnabled = false;
        private bool _wallCoveringEnabled = false;


        public enum ProductTypes
        {
            Paint = 1,
            Putty = 2,
            Tools = 3,
            Covering = 4,
            WallCovering = 5
        }


        private ProductTypes _selectedType;

        public ProductTypes EnummProductTypes
        {
            get => _selectedType;
            set
            {
                _selectedType = value;
                SetTypeEnabled(value);
                OnPropertyChanged();
            }
        }

        public void SetTypeEnabled(ProductTypes value)
        {
            if (value == ProductTypes.Paint)
            {
                PaintEnabled = true;
                PuttyEnabled = false;
                ToolsEnabled = false;
                CoveringEnabled = false;
                WallCoveringEnabled = false;
            }
            else if (value == ProductTypes.Putty)
            {
                PaintEnabled = false;
                PuttyEnabled = true;
                ToolsEnabled = false;
                CoveringEnabled = false;
                WallCoveringEnabled = false;
            }
            else if (value == ProductTypes.Tools)
            {
                PaintEnabled = false;
                PuttyEnabled = false;
                ToolsEnabled = true;
                CoveringEnabled = false;
                WallCoveringEnabled = false;
            }
            else if (value == ProductTypes.Covering)
            {
                PaintEnabled = false;
                PuttyEnabled = false;
                ToolsEnabled = false;
                CoveringEnabled = true;
                WallCoveringEnabled = false;
            }
            else if (value == ProductTypes.WallCovering)
            {
                PaintEnabled = false;
                PuttyEnabled = false;
                ToolsEnabled = false;
                CoveringEnabled = false;
                WallCoveringEnabled = true;
            }

        }

        public bool PaintEnabled
        {
            get => _paintEnabled;
            set { _paintEnabled = value; OnPropertyChanged(); }
        }
        public bool PuttyEnabled
        {
            get => _puttyEnabled;
            set { _puttyEnabled = value; OnPropertyChanged(); }
        }

        public bool ToolsEnabled
        {
            get => _toolsEnabled;
            set { _toolsEnabled = value; OnPropertyChanged(); }
        }
        public bool CoveringEnabled
        {
            get => _coveringEnabled;
            set { _coveringEnabled = value; OnPropertyChanged(); }
        }
        public bool WallCoveringEnabled
        {
            get => _wallCoveringEnabled;
            set { _wallCoveringEnabled = value; OnPropertyChanged(); }
        }

        public ObservableCollection<ProductTypes> _productTypeChosen;

        public ProductTypeViewModel()
        {
            _productTypeChosen = new ObservableCollection<ProductTypes>
            {
                ProductTypes.Paint,
                ProductTypes.Putty,
                ProductTypes.Tools,
                ProductTypes.Covering,
                ProductTypes.WallCovering

            };
        }

        public ObservableCollection<ProductTypes> ProductTypesChosen => _productTypeChosen;




        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
