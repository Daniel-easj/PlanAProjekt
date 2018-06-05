using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using PlanA.Data.Domain.ExtendedClasses;
using PlanA.Model;

namespace PlanA.ViewModels.Data.Customer
{
    public class PrivateCustomerDataViewModel : DataViewModelAppBase<PrivateCustomer>
    {
        public PrivateCustomerDataViewModel(PrivateCustomer obj) : base(obj)
        {
        }

        public string Name
        {
            get => DataObject.Name;
            set
            {   
                if (string.IsNullOrWhiteSpace(Name) || Name.Length < 2)
                {
                    throw new Exception();
                }
                else
                {
                    DataObject.Name = value;
                    OnPropertyChanged();
                }
                
            }
        }

        public string Phone
        {
            get => DataObject.Phone;
            set
            {
                if (Phone.Length < 7)
                {
                    DataObject.Phone = value;
                    OnPropertyChanged();
                }
                else
                {
                    DisplayIncorrectPhone();
                    DataObject.Phone = "";
                }
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

        private async void DisplayIncorrectPhone()
        {
            ContentDialog wrongPhoneNumberDialog = new ContentDialog()
            {
                Title = "Telefonnummer ikke gyldigt",
                Content = "Indtast  venligst et telefonnummer med 8 cifre",
                CloseButtonText = "OK"
            };

            await wrongPhoneNumberDialog.ShowAsync();
        }

    }
}
