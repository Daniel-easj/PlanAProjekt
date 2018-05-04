using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PlanA.CatalogClasses;
using PlanA.CustomerClasses;

namespace PlanA.CommandClasses
{
    class CreatePrivateCustomerCommand : ICommand
    {
        private PrivateCustomer _privateCustomer;
        private PrivateCustomerCatalog _privateCustomerCatalog;

        public CreatePrivateCustomerCommand(PrivateCustomer privateCustomer, PrivateCustomerCatalog privateCustomerCatalog)
        {
            _privateCustomer = privateCustomer;
            _privateCustomerCatalog = privateCustomerCatalog;
        }

        public bool CanExecute(object parameter)
        {
            if (_privateCustomerCatalog.GetPrivateCustomers.ContainsKey(_privateCustomer.ID))
            {
                return false;
            }
            return true;
        }

        public void Execute(object parameter)
        {
            _privateCustomerCatalog.AddPrivateCustomer(_privateCustomer.ID, _privateCustomer);
        }

        public event EventHandler CanExecuteChanged;
    }
}
