using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.CatalogClasses
{

    public class ProduktCatalog
    {

        private static ProduktCatalog _singletonInstance = new ProduktCatalog();




        public static ProduktCatalog SingletonInstance

        {

            get

            {

                if (_singletonInstance != null) return _singletonInstance;

                _singletonInstance = new ProduktCatalog();

                return _singletonInstance;

            }
        }


        //+produktCatalog : Dictionary(ID, IProdukt)

        //+TilføjProdukt() : Void
        //+FjernProdukt(ID) : Void
        //-KontrollérMængde(Objekt) :Bool
        //-ReservérObjekt(bool) : Void
        //-NyInventar() : Class(Singleton)
    }
}
