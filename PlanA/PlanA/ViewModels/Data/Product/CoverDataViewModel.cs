﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.Data.Domain.ExtendedClasses;

namespace PlanA.ViewModels.Data.Product
{
    class CoverDataViewModel : DataViewModelAppBase<Cover>
    {
        public CoverDataViewModel(Cover obj) : base(obj)
        {
        }

        public int? Quantity
        {
            get => DataObject.Quantity;
            set
            {
                DataObject.Quantity = value;
                OnPropertyChanged();
            }     
        }

        public string Description
        {
            get => DataObject.Description;
            set
            {
                DataObject.Description = value;
                OnPropertyChanged();
            }
        }
        public int SpecificType
        { 
            get => DataObject.SpecificType;
            set
            {
                DataObject.SpecificType = value;
                OnPropertyChanged();
            }
    }   }
}
