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
    class WallCovering : ProductBase
    {

        private string _wallCoveringType = WallCoveringType.Default.ToString();

        public enum WallCoveringType
        {
            Default,
            Glasvæv,
            Glasfilt,
            Savsmuldstapet
        }

        public override string ProductID { get { return "72" + "INDSÆT DB ID"; } }

        public override string SpecificType
        {
            get => _wallCoveringType;
            set
            {
                _wallCoveringType = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return "Vægbeklædning";
        }

    }
}
