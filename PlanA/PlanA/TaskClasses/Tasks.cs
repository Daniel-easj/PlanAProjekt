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
        private int _taskdescription;
        private int _refNum;

        private DateTime _startDate;

        private Dictionary<string, IProduct> _productsAssociated;
        private Dictionary<string, CustomerBase> _customersAssociated;

        public Tasks()
        {
            _startDate = DateTime.Now;
        }

        public int Taskdescription { get => _taskdescription; set => _taskdescription = value; }

        public int RefNum { get => _refNum; set => _refNum = value; }


        public DateTime StartDate
        {
            get { return _startDate; }
        }

        public Dictionary<string, CustomerBase> CustomersAssociated
        {
            get => _customersAssociated; set => _customersAssociated = value;
        }

        public Dictionary<string, IProduct> ProductsAssociated
        {
            get => _productsAssociated; set => _productsAssociated = value;
        }


    }
}
