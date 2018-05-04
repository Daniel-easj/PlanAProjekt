using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PlanA.CatalogClasses;
using PlanA.CommandClasses;
using PlanA.TaskClasses;

namespace PlanA.ViewModels
{
    class CreateTaskViewModel : INotifyPropertyChanged
    {

        private Tasks _tasks;
        private TaskCatalog _taskCatalog;
        private CreateTaskCommand _createTaskCommand;

        private List<Enum> _taskSource;

        private string _selectedSource;

       

        public CreateTaskViewModel()
        {
            _tasks = new Tasks();
            _taskCatalog = new TaskCatalog();
            _createTaskCommand = new CreateTaskCommand(_tasks, _taskCatalog);
           
        }

        public string SelectedSource
        {
            get => _selectedSource;
            set
            {
                _selectedSource = value.ToString();
                OnPropertyChanged();
            } 
        }

        public List<Enum> TaskSource
        {
          get { return _taskSource; }
        }

        public ICommand CreateTaskCommand => _createTaskCommand;
         
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
