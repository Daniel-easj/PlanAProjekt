using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.BaseClasses
{
    public class CustomerBase : DomainBase
    {
        public virtual string Name { get;  set; }
        public virtual string Phone { get; set; }
        public virtual string Address { get; set; }
        public virtual string Email { get; set; }

        public virtual string City { get; set; }
        public virtual string Zip { get; set; }

        public virtual string CustomerType { get; set; }
        protected CustomerBase(string name, string phone, string address, string email)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
        }

        public CustomerBase()
        {

        }

        public override int Key
        {
            get {  throw new Exception();}
            set { throw new Exception(); }
        }
    }
}
