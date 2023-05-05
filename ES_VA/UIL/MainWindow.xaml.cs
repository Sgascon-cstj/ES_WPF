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

namespace UIL
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserControl UCInitial = new UCInitial();
        private UserControl UcDonne = new UCDonneesComm();
        private UserControl UcVehicule = new UCVehiculesParProvince();
        private UserControl UcGraphique = new UCGraphiqueEvolution();

        public static Menu menu = new Menu();
        public MainWindow()
        {
            InitializeComponent();
            menu = menuMainWindow;

            uc.Children.Add(UCInitial);
        }

        private void Donne_Click(object sender, RoutedEventArgs e)
        {
            uc.Children.Clear();
            uc.Children.Add(UcDonne);
        }

        private void Vehicule_Click(object sender, RoutedEventArgs e)
        {
            uc.Children.Clear();
            uc.Children.Add(UcVehicule);
        }

        private void Graphique_Click(object sender, RoutedEventArgs e)
        {
            uc.Children.Clear();
            uc.Children.Add(UcGraphique);
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
