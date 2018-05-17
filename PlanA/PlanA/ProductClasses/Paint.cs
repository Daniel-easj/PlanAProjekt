using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;

namespace PlanA.ProductClasses
{
    class Paint : ProductBase
    {

        private int _gloss;
        private bool _inDoor = true;
        private string _paintType = PaintType.Default.ToString();

        public enum PaintType
        {
            Default,
            Træmaling,
            Facademaling,
            Grunder
        }

        public override string ProductID { get { return "42" + "INDSÆT DB ID"; } }

        public override string SpecificType
        {
            get => _paintType;
            set
            {
                _paintType = value;
                OnPropertyChanged();
            }
        }

        public override bool InDoor { get => _inDoor; set => _inDoor = value; }
        public override int Gloss { get => _gloss; set => _gloss = value; }

        public override string ToString()
        {
            return "Maling";
        }

    }
}
