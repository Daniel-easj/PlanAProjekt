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
            get { return DataObject.Name.TrimEnd(); }
        }

        public string Phone
        {
            get { return DataObject.Phone.TrimEnd(); }
        }

        public string Address
        {
            get { return DataObject.Address.TrimEnd(); }
        }

        public string Email
        {
            get { return DataObject.Email.TrimEnd(); }
        }
    }
}
