using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Connexion
    {
        private static Connexion connexion; 
        private Connexion() { }
        private string nomUtilisateur;
        
        public static Connexion getConnexion()
        { 
            if (connexion == null)
            {
                connexion = new Connexion();
            }
            return connexion;
        }

        public bool SeConnecter(string userName, string mdp)
        {
            DataTable dt = AccessDB.GetConnexion(userName,mdp);
            if (dt == null)
            {
                return false;
            }
            else
            {

                nomUtilisateur = userName;
                return true;
            }


        }
    }
}
