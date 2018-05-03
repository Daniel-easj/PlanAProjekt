using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.TaskClasses;

namespace PlanA.CatalogClasses
{
    class TaskCatalog : CatalogBase<Tasks>
    {
        
       private Dictionary<int, Tasks> _tasks;

       public TaskCatalog()
       {
        _tasks = new Dictionary<int, Tasks>();
       }

        public Dictionary<int, Tasks> GetTasks => _tasks;

       public void AddTask(int key, Tasks task)
       {
        _tasks.Add(key, task);
       }

       public void RemoveTask(int key)
       {
        _tasks.Remove(key);
       }
        
    }
}
