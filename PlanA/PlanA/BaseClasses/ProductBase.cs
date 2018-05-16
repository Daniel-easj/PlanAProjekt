using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.BaseClasses
{
    public abstract class ProductBase : DomainBase
    {
        protected string _productID;
        protected int _quantity = 0;
        protected string _description = "Ingen Beskrivelse";

        public abstract string ProductID { get;}

        public virtual int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
            }
        }

        public virtual string Description
        {
            get => _description;
            set
            {
                _description = value;
            }
        }

        public abstract string SpecificType
        {
            get;
            set;
        }

        // Nogle klasser har behov for yderligere properties som kan overrides i de klasser hvor behovet vil opstå.

        public virtual int Gloss { get; set; }
        public virtual bool InDoor { get; set; }
        public virtual string Coarse { get; set; }
    }
}
