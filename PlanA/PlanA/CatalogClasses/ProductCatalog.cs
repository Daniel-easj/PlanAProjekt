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
    class ProductCatalog : CatalogBase<IProduct>
    {
        private Dictionary<string, ProductBase> _productCatalog;


        public ProductCatalog()
        {
            _productCatalog = new Dictionary<string, ProductBase>();

            AddProduct("p100", new Cover());
            AddProduct("p101", new Paint());
            AddProduct("p102", new Tool());
            AddProduct("p1023", new Tool());
            AddProduct("p10452", new Tool());
            AddProduct("p10345342", new Tool());
            AddProduct("p10345342", new Tool());
            AddProduct("p103452", new Tool());
            AddProduct("p103453422", new Tool());
            AddProduct("p10112", new Tool());
            AddProduct("p10222", new Tool());
            AddProduct("p10332", new Tool());
            AddProduct("p10244", new Tool());
            AddProduct("p15502", new Tool());
        }

        public Dictionary<string, ProductBase> GetProductCatalog => _productCatalog;

        public void AddProduct(string id, ProductBase product)
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

       public bool CheckAvailabilityExistingProduct(string id, int quantity)
        {
            if (_productCatalog.ContainsKey(id) && _productCatalog[id].Quantity >= quantity)
            {
                return true;
            }
            return false;
        }

        // Når et produkt reserveres i forbindelse med en ny opgave kan der reserveres en mængde af materialer. 
        // Metoden fratrækker en specifik mængde fra et specifikt produkt.
        public void ReserveProductAmount(IProduct product, int amount)
        {
            if (CheckAvailabilityExistingProduct(product.ProductID, amount))
            {
                product.Quantity = product.Quantity - amount;
            }

            //TODO: Tilføj fejlhåndtering i situationer hvor CheckAvailabilityExistingProduct returnerer "false"
        }

        // Når en opgave annulleres bør opgave produkter returneres til lageret. 
        // Her looper metoden alle de tilknyttede produkter fra en opgave igennem og tilføjer mængden af de reserverede produkter til lageret. 
        public void CancelledTask(Tasks task, TaskCatalog taskCatalog)
        {
            foreach (var t in task.ProductsAssociated)
            {
                ReturnProductAmount(t.Key, t.Value);
            }

            taskCatalog.RemoveTask(task.RefNum);
        }

        public void ReturnProductAmount(string productId, int amount)
        {
            _productCatalog[productId].Quantity = _productCatalog[productId].Quantity + amount;
        }

    }
}
