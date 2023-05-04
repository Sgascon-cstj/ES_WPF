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
using LiveCharts;
using LiveCharts.Wpf;

namespace UIL
{
    /// <summary>
    /// Logique d'interaction pour UCGraphiqueEvolution.xaml
    /// </summary>
    public partial class UCGraphiqueEvolution : UserControl
    {
        public SeriesCollection SC { get; set; }
        public string[] Labels { get; set; }

        public UCGraphiqueEvolution()
        {
            InitializeComponent();
            DataContext = this;

            Ventes.ChargerListeVente();
            Labels = Ventes.GetAnneesDesVentes().Select(x => x.ToString()).ToArray();


            Provinces.ChargerListProvince();
            provinces.ItemsSource = Provinces.provinces;

            Vehicules.ChargerListVehicule();
            vehicules.ItemsSource = Vehicules.vehicules;


            SC = new SeriesCollection()
            {
                new ColumnSeries
                {
                    Title= "Prix moyen",
                    Values = new ChartValues<double>(),


                },

            };

            provinces.SelectedIndex = 0;

            provinces.SelectionChanged += SelectionChange;
            vehicules.SelectionChanged += SelectionChange;
            vehicules.SelectedIndex = 0;



        }

        private void SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            List<double> values = Ventes.RetrouverListDesVentesPourUnTypeEtUneProvince((vehicules.SelectedItem as Vehicule), (provinces.SelectedItem as Province));
            SC[0].Values = new ChartValues<double>(values);
   
        }
    }
}
