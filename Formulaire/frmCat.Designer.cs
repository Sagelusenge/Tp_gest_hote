namespace ChambreHotel.Formulaire
{
    partial class frmCat
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
            txtdesgnation = new TextBox();
            txtid = new TextBox();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(552, 150);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // delete
            // 
            delete.Location = new Point(96, 145);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 20;
            delete.Text = "Supprimer";
            delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.Location = new Point(206, 145);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 19;
            update.Text = "Modif";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // save
            // 
            save.Location = new Point(355, 145);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 18;
            save.Text = "Enregistre";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click_1;
            // 
            // refresh
            // 
            refresh.Location = new Point(473, 145);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 17;
            refresh.Text = "Actualiser";
            refresh.UseVisualStyleBackColor = true;
            // 
            // txtrecherche
            // 
            txtrecherche.Location = new Point(206, 193);
            txtrecherche.Name = "txtrecherche";
            txtrecherche.Size = new Size(342, 23);
            txtrecherche.TabIndex = 15;
            // 
            // txtdesgnation
            // 
            txtdesgnation.Location = new Point(208, 98);
            txtdesgnation.Name = "txtdesgnation";
            txtdesgnation.Size = new Size(282, 23);
            txtdesgnation.TabIndex = 12;
            // 
            // txtid
            // 
            txtid.Location = new Point(208, 57);
            txtid.Name = "txtid";
            txtid.Size = new Size(282, 23);
            txtid.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 196);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 9;
            label7.Text = "Recherche";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 98);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Designation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 60);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 3);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 4;
            label1.Text = "ENREGISTREMENT Ccat";
            label1.Click += label1_Click;
            // 
            // frmCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(save);
            Controls.Add(refresh);
            Controls.Add(txtrecherche);
            Controls.Add(txtdesgnation);
            Controls.Add(txtid);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCat";
            Text = "frmCat";
            Load += frmCat_Load;
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
        private TextBox txtdesgnation;
        private TextBox txtid;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}