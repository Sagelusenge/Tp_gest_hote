namespace ChambreHotel.Formulaire
{
    partial class frmclient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtid = new TextBox();
            txtnoms = new TextBox();
            txtadresse = new TextBox();
            txtcontact = new TextBox();
            refresh = new Button();
            save = new Button();
            update = new Button();
            delete = new Button();
            label7 = new Label();
            txtrecherche = new TextBox();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "ENREGISTREMENT CLIENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 66);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 104);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Noms";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 147);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "adresse";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 189);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 0;
            label5.Text = "contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 225);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 0;
            label6.Text = "refcat";
            // 
            // txtid
            // 
            txtid.Location = new Point(178, 63);
            txtid.Name = "txtid";
            txtid.Size = new Size(282, 23);
            txtid.TabIndex = 1;
            // 
            // txtnoms
            // 
            txtnoms.Location = new Point(178, 104);
            txtnoms.Name = "txtnoms";
            txtnoms.Size = new Size(282, 23);
            txtnoms.TabIndex = 1;
            // 
            // txtadresse
            // 
            txtadresse.Location = new Point(178, 139);
            txtadresse.Name = "txtadresse";
            txtadresse.Size = new Size(282, 23);
            txtadresse.TabIndex = 1;
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(178, 181);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(282, 23);
            txtcontact.TabIndex = 1;
            // 
            // refresh
            // 
            refresh.Location = new Point(445, 259);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 2;
            refresh.Text = "Actualiser";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // save
            // 
            save.Location = new Point(327, 259);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 2;
            save.Text = "Enregistre";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // update
            // 
            update.Location = new Point(178, 259);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 2;
            update.Text = "Modif";
            update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(68, 259);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 2;
            delete.Text = "Supprimer";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 310);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 0;
            label7.Text = "Recherche";
            // 
            // txtrecherche
            // 
            txtrecherche.Location = new Point(178, 307);
            txtrecherche.Name = "txtrecherche";
            txtrecherche.Size = new Size(342, 23);
            txtrecherche.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 345);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(552, 150);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(178, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // frmclient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 507);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(save);
            Controls.Add(refresh);
            Controls.Add(txtrecherche);
            Controls.Add(txtcontact);
            Controls.Add(txtadresse);
            Controls.Add(txtnoms);
            Controls.Add(txtid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmclient";
            Text = "frmclient";
            Load += frmclient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtid;
        private TextBox txtnoms;
        private TextBox txtadresse;
        private TextBox txtcontact;
        private Button refresh;
        private Button save;
        private Button update;
        private Button delete;
        private Label label7;
        private TextBox txtrecherche;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
    }
}