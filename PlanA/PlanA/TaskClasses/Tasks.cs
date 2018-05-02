using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.ProductClasses;

namespace PlanA.TaskClasses
{
    class Tasks : INotifyPropertyChanged
    {
        private string _taskDescription;

        private int _refNum;

        private DateTime _startDate;

        //// HAS BEEN MOVED TO THEIR OWN CLASS
        //// private Dictionary<string, IProduct> _productsAssociated; 
        //// private Dictionary<string, CustomerBase> _customerAssociated;

        public Tasks()
        {
            _startDate = DateTime.Now;
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



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
