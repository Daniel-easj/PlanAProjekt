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
        private int _iD = 10000;

        public CustomerBase(string name, string phone, string address, string email)
        {
            _name = name;
            _phone = phone;
            _address = address;
            _email = email;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string ID
        {
            get { return _iD.ToString(); }
            
        }

        public override void SetDefaultValues()
        {
            Name = "";
            Phone = "";
            Address = "";
            Email = "";
        }

    }
}
