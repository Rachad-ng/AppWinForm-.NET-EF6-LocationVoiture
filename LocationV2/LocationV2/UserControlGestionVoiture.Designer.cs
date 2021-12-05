
namespace LocationV2
{
    partial class UserControlGestionVoiture
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comb_marque = new System.Windows.Forms.ComboBox();
            this.comb_serie = new System.Windows.Forms.ComboBox();
            this.text_matricule = new System.Windows.Forms.TextBox();
            this.text_prix = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.dgv_voiture = new System.Windows.Forms.DataGridView();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voiture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marque : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serie : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matricule : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix/Jour : ";
            // 
            // comb_marque
            // 
            this.comb_marque.FormattingEnabled = true;
            this.comb_marque.Location = new System.Drawing.Point(101, 30);
            this.comb_marque.Name = "comb_marque";
            this.comb_marque.Size = new System.Drawing.Size(188, 28);
            this.comb_marque.TabIndex = 4;
            this.comb_marque.SelectedIndexChanged += new System.EventHandler(this.comb_marque_SelectedIndexChanged);
            // 
            // comb_serie
            // 
            this.comb_serie.FormattingEnabled = true;
            this.comb_serie.Location = new System.Drawing.Point(101, 89);
            this.comb_serie.Name = "comb_serie";
            this.comb_serie.Size = new System.Drawing.Size(188, 28);
            this.comb_serie.TabIndex = 5;
            // 
            // text_matricule
            // 
            this.text_matricule.Location = new System.Drawing.Point(101, 145);
            this.text_matricule.Name = "text_matricule";
            this.text_matricule.Size = new System.Drawing.Size(188, 26);
            this.text_matricule.TabIndex = 6;
            // 
            // text_prix
            // 
            this.text_prix.Location = new System.Drawing.Point(101, 204);
            this.text_prix.Name = "text_prix";
            this.text_prix.Size = new System.Drawing.Size(188, 26);
            this.text_prix.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(30, 261);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(96, 47);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(170, 261);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 47);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Modifier";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(30, 330);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 47);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Location = new System.Drawing.Point(170, 330);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(96, 47);
            this.btn_imprimer.TabIndex = 11;
            this.btn_imprimer.Text = "Imprimer";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // dgv_voiture
            // 
            this.dgv_voiture.AllowUserToAddRows = false;
            this.dgv_voiture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_voiture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_voiture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_voiture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marque,
            this.serie,
            this.matricule,
            this.prix});
            this.dgv_voiture.Location = new System.Drawing.Point(312, 30);
            this.dgv_voiture.Name = "dgv_voiture";
            this.dgv_voiture.RowHeadersWidth = 62;
            this.dgv_voiture.RowTemplate.Height = 28;
            this.dgv_voiture.Size = new System.Drawing.Size(623, 347);
            this.dgv_voiture.TabIndex = 12;
            this.dgv_voiture.SelectionChanged += new System.EventHandler(this.dgv_voiture_SelectionChanged);
            // 
            // marque
            // 
            this.marque.HeaderText = "Marque";
            this.marque.MinimumWidth = 8;
            this.marque.Name = "marque";
            // 
            // serie
            // 
            this.serie.HeaderText = "Serie";
            this.serie.MinimumWidth = 8;
            this.serie.Name = "serie";
            // 
            // matricule
            // 
            this.matricule.HeaderText = "Matricule";
            this.matricule.MinimumWidth = 8;
            this.matricule.Name = "matricule";
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix/Jour";
            this.prix.MinimumWidth = 8;
            this.prix.Name = "prix";
            // 
            // UserControlGestionVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_voiture);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.text_prix);
            this.Controls.Add(this.text_matricule);
            this.Controls.Add(this.comb_serie);
            this.Controls.Add(this.comb_marque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGestionVoiture";
            this.Size = new System.Drawing.Size(978, 415);
            this.Load += new System.EventHandler(this.UserControlGestionVoiture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comb_marque;
        private System.Windows.Forms.ComboBox comb_serie;
        private System.Windows.Forms.TextBox text_matricule;
        private System.Windows.Forms.TextBox text_prix;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.DataGridView dgv_voiture;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
    }
}
