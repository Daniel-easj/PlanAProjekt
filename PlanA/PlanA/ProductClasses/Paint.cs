﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.ProductClasses
{
    class Paint : IProduct, INotifyPropertyChanged
    {
        private int _productID;
        private int _quantity;
        private bool _isReserved;

        public enum PaintType
        {
            Træmaling,
            Facademaling,
            Grunder
        }

        public Paint(int quantity)
        {
            _quantity = quantity;
            _isReserved = false;
        }

        public int ProductID { get { return _productID; } }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }

        public bool IsReserved
        {
            get
            {
                return _isReserved;
            }
            set
            {
                _isReserved = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}