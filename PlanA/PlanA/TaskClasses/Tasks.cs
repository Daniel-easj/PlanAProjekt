using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.CatalogClasses;
using PlanA.ProductClasses;

namespace PlanA.TaskClasses
{
    class Tasks : INotifyPropertyChanged
    {
        private string _taskDescription;
        private int _refNum;
        private DateTime _startDate;

        private Dictionary<string, int> _productsAssociated;
        private Dictionary<string, CustomerBase> _customerAssociated;


        private ProductCatalog _productCatalog;

        //// HAS BEEN MOVED TO THEIR OWN CLASS
        //// private Dictionary<string, IProduct> _productsAssociated; 
        //// private Dictionary<string, CustomerBase> _customerAssociated;

        public Tasks()
        {
            _startDate = DateTime.Now;

            _customerAssociated = new Dictionary<string, CustomerBase>();
            _productsAssociated = new Dictionary<string, int>();
        }

        public string TaskDescription
        {
            get => _taskDescription;
            set
            {
                _taskDescription = value; 
                OnPropertyChanged();
            }
        }

        public int RefNum
        {
            get => _refNum;
            set
            { 
                _refNum = value;
                OnPropertyChanged();
            }
        }


        public void AddAssociatedCustomers(CustomerBase customer)
        {
            if (!_customerAssociated.ContainsKey(customer.ID))
            {
                _customerAssociated.Add(customer.ID, customer);
                OnPropertyChanged();
            }
        }

        public void AddAssociatedProducts(IProduct product, int quantity)
        {
            if (!_productsAssociated.ContainsKey(product.ProductID))
            {
                _productsAssociated.Add(product.ProductID,quantity);
            }
        }

        public Dictionary<string, CustomerBase> CustomerAssociated { get => _customerAssociated; set => _customerAssociated = value; }
        public Dictionary<string, int> ProductsAssociated { get => _productsAssociated; set => _productsAssociated = value; }


        public DateTime StartDate
        {
            get { return _startDate; }
        }

        public enum TaskType
        {
           MalerOpgave,
           RenovationsOpgave,
           SpartelOpgave,
           AndenOpgave
        }

        public enum TaskSource
        {
            ByggeTilbud3,
            EjerForeningDanmark,
            Anmeldhaandvaerker,
            EgetNetværk,
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
