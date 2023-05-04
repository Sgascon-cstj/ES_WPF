using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BLL
{
    public class Vehicule : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string typeVehicule;
        public string TypeVehicule
        {
            get { return typeVehicule; }
            set
            {
                if (this.typeVehicule != value)
                {
                    this.typeVehicule = value;
                    this.NotifyPropertyChanged(nameof(TypeVehicule));
                }
            }
        }
        public override string ToString()
        {
            return typeVehicule.ToString();
        }
    }
}
