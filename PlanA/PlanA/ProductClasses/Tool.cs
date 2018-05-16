using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.ProductClasses
{
    class Tool : ProductBase
    {

        private string _toolType = ToolType.Default.ToString();

        public enum ToolType
        {
            Default,
            Pensler,
            Sparteljern,
            Skruetrækker,
            Kniv,
            Ruller,
            Teleskopstænger,
            Sandpapir
        }

        public override string ProductID { get { return "62" + "INDSÆT DB ID"; } }

        public override string SpecificType
        {
            get => _toolType;
            set
            {
                _toolType = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return "Værktøj";
        }

    }
}
