// Prenom : Samuel
// Nom : Gascon
// Matricule : 2151866
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Logique d'interaction pour UCDonneesComm.xaml
    /// </summary>
    public partial class UCDonneesComm : UserControl
    {
        public UCDonneesComm()
        {
            InitializeComponent();

            DataContext = this;
            Ventes.ChargerListeVente();
            dgVente.ItemsSource = Ventes.ventes;
            cbElement.SelectedIndex = 0;
            cbOrdre.SelectedIndex = 0;
        }

        private void cbOrdre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

                SortDirection();
            
        }

        private void cbElement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
                SortDirection();
    
        }

        private void SortDirection()
        {
            ListSortDirection direction;
            
            if (cbOrdre.SelectedIndex == 0)
            {
                direction = ListSortDirection.Ascending;
            }
            else
            {
                direction = ListSortDirection.Descending;
            }
            
            
            if (cbOrdre != null && cbElement != null && dgVente != null)
            {
                int selectedIndex = cbElement.SelectedIndex;
                
                switch (selectedIndex)
                {
                    case 0:

                        applySortDescriptions(colAnnee, direction);
                        break;
                    case 1:
                        applySortDescriptions(colNbUnite, direction);

                        break;
                    case 2:
                        applySortDescriptions(colPrix, direction);

                        break;

                }
                
            }
  
          

        }
        private void applySortDescriptions(DataGridColumn col, ListSortDirection listSortDirection)
        {
            dgVente.Items.SortDescriptions.Clear();
            

            dgVente.Items.SortDescriptions.Add(new SortDescription((cbElement.SelectedItem as ComboBoxItem).Name, listSortDirection));

            applySortDirection(col, listSortDirection);

            dgVente.Items.Refresh();
        }



        private void applySortDirection(DataGridColumn col, ListSortDirection listSortDirection)
        {
            foreach (DataGridColumn c in dgVente.Columns)
            {
                c.SortDirection = null;
            }
            col.SortDirection = listSortDirection;
        }

    }
}
