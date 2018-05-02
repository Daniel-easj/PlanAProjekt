using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.BaseClasses
{
    class CatalogBase<TCatalog>
    {
        //TODO
        private static CatalogBase<TCatalog> _singletonInstance;

        private Dictionary<string,TCatalog> _catalogs;

        public CatalogBase()
        {
            //TODO
        }

        public static CatalogBase<TCatalog> SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new CatalogBase<TCatalog>();
                return _singletonInstance;
            }
        }
    }
}
