using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.Data.Domain.ExtendedClasses;

namespace PlanA.ViewModels.Data
{
    class CompanyCustomerDataViewModel : DataViewModelAppBase<CompanyCustomer>
    {
        public CompanyCustomerDataViewModel(CompanyCustomer obj) : base(obj)
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
            get { return DataObject.Address; }
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

    }
}
