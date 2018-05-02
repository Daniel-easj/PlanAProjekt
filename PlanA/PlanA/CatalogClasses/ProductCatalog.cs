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
        public void AddProduct(string key, IProduct product)
        {
            if (!_productCatalog.ContainsKey(key))
            {
                _productCatalog.Add(key, product);
            }
            
            //TODO: Tilføj fejlhåndtering i situationer hvor _productCatalog allerede indeholder "key"
        }

        public void RemoveProduct(string id)
        {
            
        }

        public bool CheckAvailability(IProduct product)
        {
            if (product.Quantity > 0 && !product.IsReserved)
            {
                return true;
            }
            return false;
        }

        public void ReserveObject(IProduct product)
        {
            if (CheckAvailability(product))
            {
                product.IsReserved = true;
            }

            //TODO: Tilføj fejlhåndtering i situationer hvor der ikke kan reseveres et produkt
        }


    }
}
