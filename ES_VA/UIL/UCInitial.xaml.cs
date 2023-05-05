// Prenom : Samuel
// Nom : Gascon
// Matricule : 2151866using System;
using BLL;
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
    /// Logique d'interaction pour UCInitial.xaml
    /// </summary>
    public partial class UCInitial : UserControl
    {
        public UCInitial()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            string mdp = txbMdp.Password;
            string userName = txbUserName.Text;
            Connexion connexion = Connexion.getConnexion();
            if (connexion.SeConnecter(userName, mdp))
            {
                MessageBox.Show("Vous êtes connecter");
                MainWindow.menu.Visibility = Visibility.Visible;
                if (connexion.NomUtilisateur == "admin")
                {
                    lsbAccount.Visibility = Visibility.Visible;
                    lsbAccount.ItemsSource = connexion.GetUserName();
                }
            }
            else
            {
                MessageBox.Show("Erreur veuiller recommencer!");

            }
        }
    }
}
