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
            get { return DataObject.Name; }
            set
            {
                DataObject.Name = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return DataObject.Phone; }
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
            get { return DataObject.Email; }
            set
            {
                DataObject.Email = value;
                OnPropertyChanged();
            }
        }

        public string Zip
        {
            get { return Zip; }
            set
            {
                Zip = value;
                OnPropertyChanged();
            }
        }

        public string Cvr
        {
            get { return DataObject.Cvr; }
            set
            {
                DataObject.Cvr = value;
                OnPropertyChanged();
            }
        }

    }
}
