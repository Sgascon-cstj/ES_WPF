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
       

    }
}
