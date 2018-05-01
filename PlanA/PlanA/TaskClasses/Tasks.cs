using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.ProductClasses;

namespace PlanA.TaskClasses
{
    class Tasks
    {
        private string _taskDescription;

        private int _refNum;

        private DateTime _startDate;

        private Dictionary<string, IProduct> _productsAssociated;
        private Dictionary<string, CustomerBase> _customerAssociated;

        public Tasks()
        {
            _startDate = DateTime.Now;
        }

        public string TaskDescription { get => _taskDescription; set => _taskDescription = value; }

        public int RefNum { get => _refNum; set => _refNum = value; }


        public DateTime StartDate
        {
            get { return _startDate; }
        }

        public Dictionary<string, CustomerBase> CustomersAssociated
        {
            get => _customerAssociated; set => _customerAssociated = value;
        }

        public Dictionary<string, IProduct> ProductsAssociated
        {
            get => _productsAssociated; set => _productsAssociated = value;
        }


    }
}
