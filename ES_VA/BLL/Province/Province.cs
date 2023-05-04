// Prenom : Samuel
// Nom : Gascon
// Matricule : 2151866
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BLL
{
    public class Province : INotifyPropertyChanged
    {
        private string nomProvince;
        public string NomProvince
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
        private string capital;
        public string Capital
        {
            get { return capital; }
            set
            {
                if (this.capital != value)
                {
                    this.capital = value;
                    this.NotifyPropertyChanged(nameof(Capital));
                }
            }
        }
        private int superficie;
        public int Superficie
        {
            get { return superficie; }
            set
            {
                if (this.superficie != value)
                {
                    this.superficie = value;
                    this.NotifyPropertyChanged(nameof(Superficie));
                }
            }
        }
        private int population;
        public int Population
        {
            get { return population; }
            set
            {
                if (this.population != value)
                {
                    this.population = value;
                    this.NotifyPropertyChanged(nameof(Population));
                }
            }
        }
        private double somme;
        public double Somme
        {
            get { return somme; }
            set
            {
                if (this.somme != value)
                {
                    this.somme = value;
                    this.NotifyPropertyChanged(nameof(Somme));
                }
            }

        }
        public void CalculerSomme(int anneDepart, int anneFin, Vehicule vehicule)
        {
            double sommes = 0;
            foreach (var vente in Ventes.ventes)
            {
                if (vente.NomProvince.NomProvince == this.NomProvince && vente.Annee >= anneDepart && vente.Annee <= anneFin && vente.TypeVehicule.TypeVehicule == vehicule.TypeVehicule )
                {
                    sommes += vente.MntPar1000/vente.NbUnites;
                }
            }
            Somme = sommes;

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            return NomProvince.ToString();
        }
    }
}
