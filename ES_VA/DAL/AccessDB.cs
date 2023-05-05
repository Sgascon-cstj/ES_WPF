// Prenom : Samuel
// Nom : Gascon
// Matricule : 2151866
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class AccessDB
    {
        public static DataTable GetVente()
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=bd-es-va; uid=root; PASSWORD=;");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM vente", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adp.Fill(ds, "vente");
                var dt = ds.Tables["vente"];
                return dt;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("GetVehicule " + ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
            
        public static DataTable GetProvince()
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=bd-es-va; uid=root; PASSWORD=;");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM province", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adp.Fill(ds, "province");
                var dt = ds.Tables["province"];
                return dt;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("GetProvince " + ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public static DataTable GetVehicules()
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=bd-es-va; uid=root; PASSWORD=;");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM vehicule", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adp.Fill(ds, "vehicule");
                var dt = ds.Tables["vehicule"];
                return dt;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("GetVehicule " +ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public static DataTable GetConnexion(string identifiant, string mdp)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=bd-es-va; uid=root; PASSWORD=;");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT Identifiant FROM connexion WHERE Identifiant='${identifiant}' AND MotDePasse='${mdp}'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adp.Fill(ds, "connexion");
                var dt = ds.Tables["connexion"];
                return dt;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public static DataTable GetUserName()
        {
            MySqlConnection conn = new MySqlConnection("SERVER=localhost; DATABASE=bd-es-va; uid=root; PASSWORD=;");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT Identifiant FROM connexion", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adp.Fill(ds, "connexion");
                var dt = ds.Tables["connexion"];
                return dt;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
    }
}
