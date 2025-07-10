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
    public partial class frmCat : Form
    {
        public frmCat()
        {
            InitializeComponent();
        }
        clsCategorie b = new clsCategorie();
        void InsertUpdateDelete(int a)
        {
            b.Designation = txtdesgnation.Text;

            if (a == 1)
            {
                b.Id = -1;
                clsGlossaire.GetInstance().saveCategorie(b);
                dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tCategirie");
            }
            else if (a == 2)
            {
                b.Id = int.Parse(txtid.Text);
                clsGlossaire.GetInstance().saveCategorie(b);
                dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tCategirie");

            }
            else if (a == 3)
            {
                clsGlossaire.GetInstance().deleteData("tCategirie", "id", int.Parse(txtid.Text));
                dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tCategirie");

            }
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtdesgnation.Text = "";

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
            dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tCategirie");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsGlossaire.GetInstance().loadData("tCategirie");
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
    }
}
