namespace ChambreHotel.Formulaire
{
    partial class frmchambre
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
            dataGridView1 = new DataGridView();
            delete = new Button();
            update = new Button();
            save = new Button();
            refresh = new Button();
            txtrecherche = new TextBox();
            classe = new TextBox();
            chmbre = new TextBox();
            txtid = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(552, 150);
            dataGridView1.TabIndex = 21;
            // 
            // delete
            // 
            delete.Location = new Point(147, 189);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 20;
            delete.Text = "Supprimer";
            delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.Location = new Point(257, 189);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 19;
            update.Text = "Modif";
            update.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            save.Location = new Point(406, 189);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 18;
            save.Text = "Enregistre";
            save.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            refresh.Location = new Point(524, 189);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 17;
            refresh.Text = "Actualiser";
            refresh.UseVisualStyleBackColor = true;
            // 
            // txtrecherche
            // 
            txtrecherche.Location = new Point(257, 237);
            txtrecherche.Name = "txtrecherche";
            txtrecherche.Size = new Size(342, 23);
            txtrecherche.TabIndex = 15;
            // 
            // classe
            // 
            classe.Location = new Point(269, 135);
            classe.Name = "classe";
            classe.Size = new Size(282, 23);
            classe.TabIndex = 13;
            // 
            // chmbre
            // 
            chmbre.Location = new Point(269, 100);
            chmbre.Name = "chmbre";
            chmbre.Size = new Size(282, 23);
            chmbre.TabIndex = 12;
            // 
            // txtid
            // 
            txtid.Location = new Point(269, 59);
            txtid.Name = "txtid";
            txtid.Size = new Size(282, 23);
            txtid.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(147, 240);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 9;
            label7.Text = "Recherche";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 143);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "CLASSE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 108);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 5;
            label3.Text = "NUMERO CHAMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 62);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 5);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 4;
            label1.Text = "ENREGISTREMENT CHAMBRE";
            // 
            // frmchambre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 536);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(save);
            Controls.Add(refresh);
            Controls.Add(txtrecherche);
            Controls.Add(classe);
            Controls.Add(chmbre);
            Controls.Add(txtid);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmchambre";
            Text = "frmchambre";
            Load += frmchambre_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button delete;
        private Button update;
        private Button save;
        private Button refresh;
        private TextBox txtrecherche;
        private TextBox classe;
        private TextBox chmbre;
        private TextBox txtid;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}