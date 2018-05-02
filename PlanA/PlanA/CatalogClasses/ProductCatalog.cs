using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.ProductClasses;
using PlanA.TaskClasses;

namespace PlanA.CatalogClasses
{
    class ProductCatalog
    {
        private Dictionary<string, IProduct> _productCatalog;
        

        public ProductCatalog()
        {
            _productCatalog = new Dictionary<string, IProduct>();
        }

        public Dictionary<string, IProduct> GetProductCatalog => _productCatalog;

        public void AddProduct(string id, IProduct product)
        {
            if (!_productCatalog.ContainsKey(id))
            {
                _productCatalog.Add(id, product);
            }
            
            //TODO: Tilføj fejlhåndtering i situationer hvor _productCatalog allerede indeholder "key"
        }


        // Fjerner et produkt fra kataloget. Metoden bør kun anvendes hvis produktet ikke længere vil eksistere på det fysiske lager
        public void RemoveProduct(string id)
        {
            if (!_productCatalog.ContainsKey(id))
            {
                _productCatalog.Remove(id);
            }
            //TODO: Tilføj fejlhåndtering i situationer hvor _productCatalog ikke indeholder "id / key"
        }

        // *følger gammelt "reserved" logik

        //public bool CheckAvailability(IProduct product)
        //{
        //    if (product.Quantity > 0 && !product.IsReserved)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public bool CheckAvailabilityExistingProduct(string id, int quantity)
        {
            if (_productCatalog.ContainsKey(id) && _productCatalog[id].Quantity >= quantity)
            {
                return true;
            }
            return false;
        }

        // *følger gammelt "reserved" logik

        //public void ReserveObject(IProduct product, int quantity)
        //{
        //    if (CheckAvailability(product) && product.Quantity >= quantity )
        //    {
        //        product.IsReserved = true;
        //    }
        //}

        public void ReserveProductAmount(IProduct product, int amount)
        {
            if (CheckAvailabilityExistingProduct(product.ProductID, amount))
            {
                product.Quantity = product.Quantity - amount;
            }

            //TODO: Tilføj fejlhåndtering i situationer hvor CheckAvailabilityExistingProduct returnerer "false"
        }

        public void ReturnProductAmount(string productId, int amount)
        {
            _productCatalog[productId].Quantity = _productCatalog[productId].Quantity + amount;
        }

        public void CancelledTask(Tasks tasks)
        {
            foreach (var t in tasks.ProductsAssociated)
            {
                ReturnProductAmount(t.Key, t.Value);
            }
        }

    }
}
