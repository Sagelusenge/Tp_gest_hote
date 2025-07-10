using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChambreHotel.classe;
using ChambreHotel.classe;

namespace ChambreHotel.Formulaire
{
    public partial class frmclient : Form
    {
        public frmclient()
        {
            InitializeComponent();
        }
        clsClient cl = new clsClient();
        void InsertUpdateDelete(int a)
        {
            cl.Noms = txtnoms.Text;
            cl.Adresse = txtadresse.Text;
            cl.Contact = Convert.ToInt32(txtcontact.Text);
            cl.Refcat = int.Parse(comboBox1.Text);
            if (a == 1)
            {
                cl.Id = -1;
                clsGlossaire.GetInstance().saveClient(cl);
                dataGridView1.DataSource = clsGlossaire.GetInstance().getcode_Combo("tClient", "id", "nom_categorie", comboBox1.Text);
            }
            else if (a == 2)
            {
                cl.Id = int.Parse(txtid.Text);
                clsGlossaire.GetInstance().saveClient(cl);
                dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tClient");

            }
            else if (a == 3)
            {
                clsGlossaire.GetInstance().deleteData("tClient", "id", int.Parse(txtid.Text));
                dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tClient");

            }
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtcontact.Text = "";
            txtnoms.Text = "";
            txtadresse.Text = "";
            comboBox1.Text = "";
        }

        private void save_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(3);
        }

        private void frmclient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tClient");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
