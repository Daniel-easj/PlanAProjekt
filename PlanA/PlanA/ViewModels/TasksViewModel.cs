using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.CatalogClasses;
using PlanA.TaskClasses;

namespace PlanA.ViewModels
{
    class TasksViewModel : INotifyPropertyChanged
    {
        private TaskCatalog _taskCatalog;
        private ObservableCollection<Tasks> _listOfTasks = new ObservableCollection<Tasks>();

        public TasksViewModel()
        {
            _taskCatalog = new TaskCatalog();
            foreach (var task in _taskCatalog.GetTasks.Values)
            {
                _listOfTasks.Add(task);
            }
        }

        public ObservableCollection<Tasks> ListAll => _listOfTasks; 

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
