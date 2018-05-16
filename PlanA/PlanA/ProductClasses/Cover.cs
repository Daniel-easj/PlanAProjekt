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
    public class Cover : ProductBase
    {
        private string _coverType = CoverType.Default.ToString();

        public enum CoverType
        {
            Default,
            Tape,
            Plast,
            Pap
        }

        public override string ProductID { get { return "32" + "INDSÆT DB ID"; }}

        public override string SpecificType
        {
            get => _coverType;
            set { _coverType = value; }
        }

        public override string ToString()
        {
            return "Afdækning";
        }

        public override void SetDefaultValues()
        {
            
        }
    }
}
