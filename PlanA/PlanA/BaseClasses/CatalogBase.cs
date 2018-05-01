using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.BaseClasses
{
    class CatalogBase
    {
        //TODO
        private static CatalogBase _singletonInstance;

        public CatalogBase()
        {
            //TODO
        }

        public static CatalogBase SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new CatalogBase();
                return _singletonInstance;
            }
        }
    }
}
