// Prenom : Samuel
// Nom : Gascon
// Matricule : 2151866
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Vente : INotifyPropertyChanged
    {
        private Province nomProvince;
        public Province NomProvince
        {
            get { return nomProvince; }
            set
            {
                if (this.nomProvince != value)
                {
                    this.nomProvince = value;
                    this.NotifyPropertyChanged(nameof(NomProvince));
                }
            }
        }


        private Vehicule typeVehicule;
        public Vehicule TypeVehicule
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


        private int annee;
        public int Annee
        {
            get { return annee; }
            set
            {
                if (this.annee != value)
                {
                    this.annee = value;
                    this.NotifyPropertyChanged(nameof(Annee));
                }
            }
        }


        private double nbUnites;
        public double NbUnites
        {
            get { return nbUnites; }
            set
            {
                if (this.nbUnites != value)
                {
                    this.nbUnites = value;
                    this.NotifyPropertyChanged(nameof(NbUnites));
                }
            }
        }


        private double mntPar1000;
        public double MntPar1000
        {
            get { return mntPar1000; }
            set
            {
                if (this.mntPar1000 != value)
                {
                    this.mntPar1000 = value;
                    this.NotifyPropertyChanged(nameof(MntPar1000));
                }
            }
        }

        private double prixMoyenPar1000;
        public double PrixMoyenPar1000
        {
            get { return CalculerPrixMoyenPar1000(); }
     
        }
        
        public double CalculerPrixMoyenPar1000()
        {
            double calcule = (mntPar1000 * 1000) / NbUnites;
            if (double.IsNaN(calcule))
            {
                return 0;
            }
            else
            {
                return calcule;
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
