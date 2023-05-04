// Prenom : Samuel
// Nom : Gascon
// Matricule : 2151866
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;

namespace UIL
{
    /// <summary>
    /// Logique d'interaction pour UCVehiculesParProvince.xaml
    /// </summary>
    public partial class UCVehiculesParProvince : UserControl
    {
        public UCVehiculesParProvince()
        {
            InitializeComponent();
            Ventes.ChargerListeVente();
            Provinces.ChargerListProvince();
            Vehicules.ChargerListVehicule();
            type.ItemsSource = Vehicules.vehicules;
            anneDepart.ItemsSource = Ventes.GetAnneesDesVentes();
            anneDepart.SelectionChanged += AnneDepart_SelectionChanged;
            anneDepart.SelectedIndex = 0;
            type.SelectedIndex = 0;

        }

        private void AnneDepart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            anneFin.ItemsSource = Ventes.GetAnneesDesVentes(Convert.ToInt32(anneDepart.SelectedItem));
            anneFin.SelectedIndex = 0;
        }

        private void btn_valider_Click(object sender, RoutedEventArgs e)
        {
            Provinces.CalculerLesSommes(Convert.ToInt32(anneDepart.SelectedItem), Convert.ToInt32(anneFin.SelectedItem),(type.SelectedItem as Vehicule));
            listViewVehicule.ItemsSource = Provinces.provinces;
        }
    }
}
