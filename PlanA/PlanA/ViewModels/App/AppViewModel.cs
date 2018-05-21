using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Commands.Implementation;
using PlanA.Model;
using ViewModel.App.Implementation;

namespace PlanA.ViewModels.App
{
    public class AppViewModel : AppViewModelBase
    {

        public AppViewModel()
        {
            AddCommands();
        }

        public override void AddCommands()
        {
            NavigationCommands.Add("Load", new RelayCommand(async () => await DomainModel.Instance.LoadAsync()));
            NavigationCommands.Add("Save", new RelayCommand(async () => await DomainModel.Instance.SaveAsync()));
        }
    }
}
