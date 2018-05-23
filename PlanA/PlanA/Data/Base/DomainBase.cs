using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Data.InMemory.Interfaces;
using Data.Transformed.Implementation;

namespace PlanA.BaseClasses
{
    public abstract class DomainBase : INotifyPropertyChanged, IStorable, ICopyable
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICopyable Copy()
        {
            return (MemberwiseClone() as ICopyable);
        }

        public abstract int Key { get; set; }
    }



}
