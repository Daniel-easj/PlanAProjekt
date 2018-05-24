using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.Annotations;

namespace PlanA.ViewModels.App
{
    class CustomerTypeViewModel : INotifyPropertyChanged
    {
        private bool _cVREnabled;

        public enum CustomerChosen
        {
            Privat = 1,
            Erhverv = 2,
            Boligforening = 3

        }

        private CustomerChosen _selectedCustomer;

        public CustomerChosen EnummCustomerChosen
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                SetCustomerEnabled(value);
                OnPropertyChanged();
            }
        }

        public void SetCustomerEnabled(CustomerChosen value)
        {
            if (value == CustomerChosen.Privat)
            {
                CVREnabled = false;
            }
            else if (value == CustomerChosen.Boligforening)
            {
                CVREnabled = false;
            }
            else if (value == CustomerChosen.Erhverv)
            {
                CVREnabled = true;
            }
        }

        public bool CVREnabled
        {
            get => _cVREnabled;
            set { _cVREnabled = value; OnPropertyChanged(); }
        }

        public ObservableCollection<CustomerChosen> _customerChosens;

        public CustomerTypeViewModel()
        {
            _customerChosens = new ObservableCollection<CustomerChosen>
            {
                CustomerChosen.Privat,
                CustomerChosen.Boligforening,
                CustomerChosen.Erhverv

            };
        }

        public ObservableCollection<CustomerChosen> CustomerChosens => _customerChosens;


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
