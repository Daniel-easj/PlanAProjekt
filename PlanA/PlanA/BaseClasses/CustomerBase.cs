using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.BaseClasses
{
    public class CustomerBase : DomainBase
    {
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }


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



        public override void SetDefaultValues()
        {
            Name = "(Not set)";
            Phone = "(Not set)";
            Address = "(Not set)";
            Email = "(Not set)";
        }

    }
}
