using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.Model;

namespace PlanA.ViewModels.Page
{
    public class ProductsViewModel
    {
        public ProductsViewModel()
        {
            CombineCatalogs();
        }

        public void CombineCatalogs()
        {
            foreach (var product in DomainModel.Catalogs.PaintCatalog.All)
            {
                if (!DomainModel.Catalogs.IDExistsProduct(product))
                {
                    DomainModel.Catalogs.Products.Add(product);
                }

            }

            foreach (var product in DomainModel.Catalogs.ToolCatalog.All)
            {
                if (!DomainModel.Catalogs.IDExistsProduct(product))
                {
                    DomainModel.Catalogs.Products.Add(product);
                }
            }
        }

        public ObservableCollection<ProductBase> Products => DomainModel.Catalogs.Products;
    }
}
