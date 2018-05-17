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
    class Putty : ProductBase
    {

        private string _coarseType = Coarse.Default.ToString();
        private string _puttyType = PuttyType.Default.ToString();

        public enum PuttyType
        {
            Default,
            Vådrum,
            AlmindeligRum
        }

        public enum Coarse
        {
            Default,
            Light,
            Medium,
            Coarse
        }

        public override string ProductID { get { return "52" + "INDSÆT DB ID"; } }

        public string CoarseType { get { return _coarseType; } }

        public override string SpecificType
        {
            get => _puttyType;
            set
            {
                _puttyType = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return "Spartelmasse";
        }

    }
}
