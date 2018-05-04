using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PlanA.CatalogClasses;
using PlanA.TaskClasses;

namespace PlanA.CommandClasses
{
    class CreateTaskCommand : ICommand
    {
        private Tasks _task;
        private TaskCatalog _taskCatalog;

        public CreateTaskCommand(Tasks task, TaskCatalog taskCatalog )
        {
            _task = task;
            _taskCatalog = taskCatalog;
        }


        public bool CanExecute(object parameter)
        {
            if (_taskCatalog.GetTasks.ContainsKey(_task.RefNum))
            {
                return false;
            }
            return true;
        }   

        public void Execute(object parameter)
        {
           _taskCatalog.AddTask(_task.RefNum, _task );
        }

        public event EventHandler CanExecuteChanged;
    }
}
