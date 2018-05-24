using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.CatalogClasses.CombinedCatalogs
{
    public class CustomersCatalog : CatalogAppBase<CustomerBase>
    {

        public bool IDExists(CustomerBase cb)
        {
            foreach (var item in All)
            {
                if (item.CustomerType.ToLower() == cb.CustomerType.ToLower() && cb.Key == item.Key)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
