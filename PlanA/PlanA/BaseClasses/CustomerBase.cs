using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanA.BaseClasses
{
    public abstract class CustomerBase : DomainBase
    {
        private string _name;
        private string _phone;
        private string _address;
        private string _email;

        public CustomerBase(string name, string phone, string address, string email)
        {
            _name = name;
            _phone = phone;
            _address = address;
            _email = email;
        }

        public override void SetDefaultValues()
        {
            _name = "(Not set)";
            _phone = "(Not set)";
            _address = "(Not set)";
            _email = "(Not set)";
        }

    }
}
