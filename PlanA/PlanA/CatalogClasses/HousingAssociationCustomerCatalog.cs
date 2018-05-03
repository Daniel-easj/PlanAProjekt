using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.ProductClasses;

namespace PlanA.CatalogClasses
{
    class HousingAssociationCustomerCatalog : CatalogBase<HousingAssociationCustomer>
    {

        private Dictionary<int, HousingAssociationCustomer> _housingAssociationCustomer;



        public HousingAssociationCustomerCatalog()
        {

            _housingAssociationCustomer = new Dictionary<int, HousingAssociationCustomer>();
        }

        public Dictionary<int, HousingAssociationCustomer> GetHousingAssociationCustomers;

        public void AddHousingAsscoiationCustomer(int key, HousingAssociationCustomer housingAssociationCustomer)

        {

            _housingAssociationCustomer.Add(key, housingAssociationCustomer);

        }

        public void RemoveHousingAssociationCustomer(int key, HousingAssociationCustomer housingAssociationCustomer)
        {


            _housingAssociationCustomer.Add(key, housingAssociationCustomer);


        }

    }



}
