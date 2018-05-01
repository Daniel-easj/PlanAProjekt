using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.ProductClasses;

namespace PlanA.CatalogClasses
{
    class ProductCatalog
    {
        private Dictionary<string, IProduct> _productCatalog;
        private static ProductCatalog _singletonInstance;

        public static ProductCatalog SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new ProductCatalog();
                return _singletonInstance;
            }
        }
        public void AddProduct()
        {
            
        }

        public void RemoveProduct(string id)
        {
            
        }

        public void CheckQuantity(IProduct product)
        {
            
        }

        public void ReserveObject(bool yeees)
        {
            
        }


    }
}
