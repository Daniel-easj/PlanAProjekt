using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PlanA.BaseClasses;
using PlanA.CatalogClasses;
using PlanA.CommandClasses;
using PlanA.ProductClasses;

namespace PlanA.ViewModels
{
    class ProductViewModel : INotifyPropertyChanged
    {
        private ProductCatalog _productCatalog = ProductCatalog.SingletonInstance;

        private ObservableCollection<ProductBase> _products = new ObservableCollection<ProductBase>();

        //TODO: Implementer detailed view af selectedProduct
       // private IProduct _selectedProduct;
        public ProductViewModel()
        {
            foreach (var product in _productCatalog.GetProductCatalog.Values)
            {
                _products.Add(product);
                //TODO: Product.ProductID mangler implementation før der kan laves en instance af ProductViewModel
                //if (!_productCatalog.GetProductCatalog.ContainsKey(product.ProductID))
                //{

                //}
            }
        }

        public ObservableCollection<ProductBase> Products => _products;

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
