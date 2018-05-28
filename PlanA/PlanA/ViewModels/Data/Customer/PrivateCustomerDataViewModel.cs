using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.Data.Domain.ExtendedClasses;
using PlanA.Model;

namespace PlanA.ViewModels.Data.Customer
{
    class PrivateCustomerDataViewModel : DataViewModelAppBase<PrivateCustomer>
    {

        //private ObservableCollection<string> _zipCodes;

        public PrivateCustomerDataViewModel(PrivateCustomer obj) : base(obj)
        {
            // _zipCodes = new ObservableCollection<string>();


        }

        public string Name
        {
            get => DataObject.Name;
            set
            {
                DataObject.Name = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => DataObject.Phone;
            set
            {
                DataObject.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get => DataObject.Address;
            set
            {
                DataObject.Address = value;
                OnPropertyChanged();
            }
        }



        public string Email
        {
            get => DataObject.Email;
            set
            {
                DataObject.Email = value;
                OnPropertyChanged();
            }
        }

    }
}
