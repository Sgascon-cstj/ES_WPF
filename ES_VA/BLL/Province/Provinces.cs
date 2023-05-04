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
    public class Provinces
    {
        public static ObservableCollection<Province> provinces = new ObservableCollection<Province>();
        public static void ChargerListProvince()
        {
            if (provinces.Count > 0)
            {
                provinces = new ObservableCollection<Province>();
            }
            DataTable dt = AccessDB.GetProvince();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                provinces.Add(new Province
                {
                    NomProvince = dt.Rows[i]["NomProvince"].ToString() ,
                    Capital = dt.Rows[i]["Capitale"].ToString(),
                    Superficie = (int)dt.Rows[i]["Superficie"],
                    Population = (int)dt.Rows[i]["Population"],

                });
            }


        }

        public static void CalculerLesSommes(int anneeDepart, int anneFin, Vehicule vehicule)
        {

            foreach (Province province in provinces)
            {
               province.CalculerSomme(anneeDepart, anneFin, vehicule);
            }
        }

    }
}
