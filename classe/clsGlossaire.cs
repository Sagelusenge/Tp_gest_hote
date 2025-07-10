using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ChambreHotel.classe
{
    internal class clsGlossaire
    {
        public static clsGlossaire _instance = null;

        public static clsGlossaire GetInstance()
        {
            if (_instance == null)
            _instance = new clsGlossaire();
            return _instance;
        }


        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter dt = null;
        SqlDataReader dr = null;

        public void InnitialiseConnexion()
        {
            try
            {
                con = new SqlConnection(clsConnection.chemin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de Connextion" + ex.Message);
            }
        }

        //LES INSERTIONS ======================================

        public void saveClient(clsClient cli)
        {
            try
            {
                InnitialiseConnexion();
                con.Open();
                cmd = new SqlCommand("EXEC Pclient @id,@noms,@adresse,@contact,@refcat", con);
                cmd.Parameters.AddWithValue("@id", cli.Id);
                cmd.Parameters.AddWithValue("@noms", cli.Noms);
                cmd.Parameters.AddWithValue("@adresse", cli.Adresse);
                cmd.Parameters.AddWithValue("@contact", cli.Contact);
                cmd.Parameters.AddWithValue("@refcat", cli.Refcat);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadCombo(string nomTable, string nomchamp, System.Windows.Forms.ComboBox comb1)
        {
            InnitialiseConnexion();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("SELECT " + nomchamp + " FROM " + nomTable + "", con);
            try
            {
                DataTable dt1 = new DataTable();
                dt.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    comb1.Items.Add(dr["nomEcol"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }

            con.Close();
        }

        public void saveCategorie(clsCategorie cat)
        {
            try
            {
                InnitialiseConnexion();
                con.Open();
                cmd = new SqlCommand("EXEC PCategorie @id,@designation", con);
                cmd.Parameters.AddWithValue("@id", cat.Id);
                cmd.Parameters.AddWithValue("@designation", cat.Designation);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable loadData(string nomTable)
        {

            InnitialiseConnexion();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select * from " + nomTable + "", con);
            dt.Fill(table);
            con.Close();

            return table;
        }
        public void saveReservation(clsReservation Res)
        {
            try
            {
                InnitialiseConnexion();
                con.Open();
                cmd = new SqlCommand("EXEC Preservation @id,@refchambre,@refclient,@date_entre,@date_sortie", con);
                cmd.Parameters.AddWithValue("@id", Res.Id);
                cmd.Parameters.AddWithValue("@refchambre", Res.Refchambre);
                cmd.Parameters.AddWithValue("@refclient", Res.Refclient);
                cmd.Parameters.AddWithValue("@date_entre", Res.Date_entree);
                cmd.Parameters.AddWithValue("@date_sortie", Res.Date_sortie);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void saveclass(clsClasse clas)
        {
            try
            {
                InnitialiseConnexion();
                con.Open();
                cmd = new SqlCommand("EXEC PClasse  @id,@designation,@prix", con);
                cmd.Parameters.AddWithValue("@id", clas.Id);
                cmd.Parameters.AddWithValue("@designation", clas.Designation);
                cmd.Parameters.AddWithValue("@prix", clas.Prix);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void saveClambre(clsChambre cham)
        {
            try
            {
                InnitialiseConnexion();
                con.Open();
                cmd = new SqlCommand("EXEC PChambre @id,@numero_chambre,@refclasse", con);
                cmd.Parameters.AddWithValue("@id", cham.Id);
                cmd.Parameters.AddWithValue("@numero_chambre", cham.Numero_chambre);
                cmd.Parameters.AddWithValue("@refclasse", cham.Refclasse);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        public void deleteData(string nomTable, string champId, int id)
        {
            try
            {
                InnitialiseConnexion();
                con.Open();
                cmd = new SqlCommand("DELETE FROM " + nomTable + " where " + champId + "=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string getcode_Combo(string nomTable, string nomChampId, string nomChamp, string valeur)
        {
            string IdData = "";
            try
            {
                InnitialiseConnexion();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("select " + nomChampId + " from " + nomTable + " where " + nomChamp + "=@a", con);
                cmd.Parameters.AddWithValue("@a", valeur);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdData = (dr[nomChampId].ToString());
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return IdData;
        }
    }
}
