﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.CatalogClasses;

namespace PlanA.ViewModels
/*
 {


    class HousingAssociationViewModel : INotifyPropertyChanged

    {
        private HousingAssociationCustomerCatalog _housingAssociationCustomerCatalog;
        private ObservableCollection<HousingAssociationCustomer> _listOfHousingAssociationCustomers = new ObservableCollection<HousingAssociationCustomer>();


        public HousingAssociationViewModel()
        {
           
        }

    /*



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    




    
}
