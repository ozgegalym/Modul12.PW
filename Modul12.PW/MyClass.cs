using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.PW
{
    public class MyClass : IPropertyChanged
    {
        private int myProperty;

        public int MyProperty
        {
            get { return myProperty; }
            set
            {
                if (myProperty != value)
                {
                    myProperty = value;
                    OnPropertyChanged(nameof(MyProperty));
                }
            }
        }

        public event PropertyEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs(propertyName));
        }
    }

}
