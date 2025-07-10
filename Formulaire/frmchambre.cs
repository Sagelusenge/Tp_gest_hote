using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChambreHotel.classe;

namespace ChambreHotel.Formulaire
{
    public partial class frmchambre : Form
    {
        public frmchambre()
        {
            InitializeComponent();
        }
        clsChambre d=new clsChambre();
        void InsertUpdateDelete(int a)
        {
            d.Id = int.Parse(txtid.Text);
            d.Refclasse = int.Parse(classe.Text);
            d.Numero_chambre = int.Parse(classe.Text);

            if (a == 1)
            {
                d.Id = -1;
                clsGlossaire.GetInstance().saveClambre(d);
                dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tChambre");
            }
            else if (a == 2)
            {
                d.Id = int.Parse(txtid.Text);
                clsGlossaire.GetInstance().saveClambre(d);
                dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tChambre");

            }
            else if (a == 3)
            {
                clsGlossaire.GetInstance().deleteData("tChambre", "id", int.Parse(txtid.Text));
                dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tChambre");

            }
        }
        
        private void refresh_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            classe.Text = "";
            chmbre.Text = "";

        }

        private void save_Click(object sender, EventArgs e)
        {

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
            dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tChambre");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCat_Load(object sender, EventArgs e)
        {
        }

        private void update_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(2);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_Click_1(object sender, EventArgs e)
        {
            InsertUpdateDelete(1);
        }
        private void frmchambre_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tChambre");

        }
    }
    }

