using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.ViewModels
{
    public class CreateCustomerViewModel : INotifyPropertyChanged
    {
        private bool _cVRenabled;

        public enum CustomerChosen
        {
            Privat,
            Offentlig,
            Erhverv
        }

        private CustomerChosen _selectedCustomer;

        public CustomerChosen EnummOrderStatus
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                SetTextEnabled(value);
                OnPropertyChanged();
            }
        }

        public void SetTextEnabled(CustomerChosen value)
        {
            if (value == CustomerChosen.Privat)
            {
                CVRenabled = false;
            }
            else if (value == CustomerChosen.Offentlig)
            {
                CVRenabled = false;
            }
            else if (value == CustomerChosen.Erhverv)
            {
                CVRenabled = true;
            }
        }

        public bool CVRenabled
        {
            get => _cVRenabled;
            set { _cVRenabled = value; OnPropertyChanged(); }
        }

        public ObservableCollection<CustomerChosen> _CustomerChosens;

        public CreateCustomerViewModel()
        {
            _CustomerChosens = new ObservableCollection<CustomerChosen>
            {
                CustomerChosen.Privat,
                CustomerChosen.Offentlig,
                CustomerChosen.Erhverv
            };
        }

        public ObservableCollection<CustomerChosen> CustomerChosens => _CustomerChosens;



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
