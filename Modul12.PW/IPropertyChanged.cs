using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.PW
{
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }

    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName { get; }

        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }

}
