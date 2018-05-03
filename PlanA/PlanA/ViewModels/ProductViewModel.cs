using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PlanA.CatalogClasses;
using PlanA.CommandClasses;
using PlanA.ProductClasses;

namespace PlanA.ViewModels
{
    class ProductViewModel : INotifyPropertyChanged
    {
        private ProductCatalog _productCatalog;

        //TODO: Implementer detailed view af selectedProduct
       // private IProduct _selectedProduct;

        private ObservableCollection<IProduct> _products = new ObservableCollection<IProduct>();

        public ProductViewModel()
        {
            _productCatalog = new ProductCatalog();

            foreach (var product in _productCatalog.GetProductCatalog.Values)
            {
                _products.Add(product);
            }
        }

        public ObservableCollection<IProduct> Products => _products;

        public void Refresh()
        {
            OnPropertyChanged(nameof(Products));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
