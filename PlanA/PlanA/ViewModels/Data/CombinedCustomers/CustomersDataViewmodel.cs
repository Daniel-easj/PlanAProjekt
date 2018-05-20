using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.ViewModels.Data.CombinedCustomers
{
    public class CustomersDataViewmodel : DataViewModelAppBase<CustomerBase>
    {
        public CustomersDataViewmodel(CustomerBase obj) : base(obj)
        {
        }

        public string Name
        {
            get { return DataObject.Name; }
        }

        public string Phone
        {
            get { return DataObject.Phone; }
        }

        public string Address
        {
            get { return DataObject.Address; }
        }

        public string Email
        {
            get { return DataObject.Email; }
        }
    }
}
