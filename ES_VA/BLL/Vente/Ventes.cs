// Prenom : Samuel
// Nom : Gascon
// Matricule : 2151866
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Ventes
    {
        public static ObservableCollection<Vente> ventes = new ObservableCollection<Vente>();
        
        public static void ChargerListeVente()
        {
            if (ventes.Count > 0)
            {
                ventes = new ObservableCollection<Vente>();
            }
            DataTable dt = AccessDB.GetVente();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ventes.Add(new Vente
                {
                    NomProvince = new Province() { NomProvince = dt.Rows[i]["NomProvince"].ToString() },
                    TypeVehicule = new Vehicule() { TypeVehicule = dt.Rows[i]["TypeVehicule"].ToString() },
                    Annee = (int)dt.Rows[i]["Annee"],
                    NbUnites = (int)dt.Rows[i]["NbUnites"],
                    MntPar1000 = (int)dt.Rows[i]["MntPar1000"],
             
                });
            }


        }
        public static List<int> GetAnneesDesVentes(int anneeMin = 0)
        {
            List<int> toutLesAnnees = ventes.Select(vente =>  vente.Annee).Distinct().ToList();

            return toutLesAnnees.Where(x => x >= anneeMin).ToList();
        }
        public static List<double> RetrouverListDesVentesPourUnTypeEtUneProvince(Vehicule vehicule, Province province)
        {
            List<double> lesVentes = new List<double>();
            foreach (var vente in ventes)
            {
                if (vente.NomProvince.NomProvince == province.NomProvince && vente.TypeVehicule.TypeVehicule == vehicule.TypeVehicule)
                {
                    lesVentes.Add(vente.MntPar1000);
                }
            }

            return lesVentes;
        }

    }
}
