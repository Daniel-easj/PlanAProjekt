using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.Data.Domain.ExtendedClasses;

namespace PlanA.ViewModels.Data.Customer
{
    class HousingAssociationCustomerDataViewModel : DataViewModelAppBase<HousingAssociationCustomer>
    {
        public HousingAssociationCustomerDataViewModel(HousingAssociationCustomer obj) : base(obj)
        {
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

        public string Zip
        {
            get => Zip;
            set
            {
                Zip = value;
                OnPropertyChanged();
            }
        }

        public string Cvr
        {
            get => DataObject.Cvr;
            set
            {
                DataObject.Cvr = value;
                OnPropertyChanged();
            }
            

        }
}   }
