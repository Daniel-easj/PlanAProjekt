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
                if (!value.Any(char.IsDigit))
                {
                    {
                        DataObject.Name = value;
                        OnPropertyChanged();
                    }
                }
                else
                {
                    DisplayIncorrectName(value);
                }

            }
        }

        public string Phone
        {
            get => DataObject.Phone;
            set
            {
                if (value.Length == 8)
                {
                    DataObject.Phone = value;
                    OnPropertyChanged();
                }
                else
                {
                    DisplayIncorrectPhone(value);
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
                if (value.Contains("@") && value.Contains("."))
                {
                    DataObject.Email = value;
                    OnPropertyChanged();
                }
                else
                {
                    DisplayIncorrectEmail(value);
                }

            }
        }

        private async void DisplayIncorrectPhone(string incorrectPhone)
        {
            ContentDialog wrongPhoneNumberDialog = new ContentDialog()
            {
                Title = "Telefonnummer ikke gyldigt",
                Content = $"Du indtastede {incorrectPhone}. Indtast venligst et gyldigt telefonnummer (8 cifre). Eksempel: 12345678",
                CloseButtonText = "OK"
            };

            await wrongPhoneNumberDialog.ShowAsync();
        }

        private async void DisplayIncorrectEmail(string incorrectEmail)
        {
            ContentDialog wrongPhoneNumberDialog = new ContentDialog()
            {
                Title = "Ugyldig E-mailadresse",
                Content = $"Du indtastede {incorrectEmail}. Indtast venligst en gyldig E-mail. Eksempel: mail@mail.dk",
                CloseButtonText = "OK"
            };

            await wrongPhoneNumberDialog.ShowAsync();
        }

        private async void DisplayIncorrectName(string incorrectName)
        {
            ContentDialog wrongPhoneNumberDialog = new ContentDialog()
            {
                Title = "Navn ikke gyldigt",
                Content = $"Du indtastede {incorrectName}. Indtast venligst et gyldigt navn uden tal. Eksempel: Hans Hansen",
                CloseButtonText = "OK"
            };

            await wrongPhoneNumberDialog.ShowAsync();
        }

    }
}
