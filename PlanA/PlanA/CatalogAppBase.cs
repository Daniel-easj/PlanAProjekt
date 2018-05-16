using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.InMemory.Interfaces;
using Extensions.Model.Implementation;

namespace PlanA
{
    public class CatalogAppBase<T> : EFCorePersistableCatalogAsync<PlanadbContext, T, T, T>
        where T : class, IStorable, ICopyable, new()
    {
        public override T CreateDomainObjectFromViewDataObject(T obj)
        {
            return obj;
        }

        public override T CreateViewDataObject(T obj)
        {
            return obj;
        }

        public override T CreatePersistentDataObject(T obj)
        {
            return obj;
        }

        public override T CreateDomainObjectFromPersistentDataObject(T obj)
        {
            return obj;
        }
    }
}
