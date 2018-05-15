using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PlanA.BaseClasses;
using PlanA.CatalogClasses;
using PlanA.CustomerClasses;

namespace PlanA.CommandClasses
{
    class CreateCustomerCommand : ICommand
    {
        private CustomerBase _customer;
        private PrivateCustomerCatalog _privateCustomerCatalog;

        public CreateCustomerCommand(CustomerBase customer, PrivateCustomerCatalog privateCustomerCatalog)
        {
            _customer = customer;
            _privateCustomerCatalog = privateCustomerCatalog;
        }

        public bool CanExecute(object parameter)
        {
            if (_privateCustomerCatalog.GetPrivateCustomers.ContainsKey(_customer.ID))
            {
                return false;
            }
            return true;
        }

        public void Execute(object parameter)
        {
            _privateCustomerCatalog.AddPrivateCustomer(_customer.ID, _customer);
        }

        public event EventHandler CanExecuteChanged;
    }
}
