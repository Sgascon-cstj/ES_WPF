// Prenom : Samuel
// Nom : Gascon
// Matricule : 2151866
using DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Vehicules
    {
        public static ObservableCollection<Vehicule> vehicules = new ObservableCollection<Vehicule>();
        public static void ChargerListVehicule()
        {
            if (vehicules.Count > 0)
            {
                vehicules = new ObservableCollection<Vehicule>();
            }
            DataTable dt = AccessDB.GetVehicules();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                vehicules.Add(new Vehicule
                {
                    TypeVehicule = dt.Rows[i]["TypeVehicule"].ToString(),


                });
            }


        }
    }
}
