
namespace LocationV2
{
    partial class UserControlVoiture
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
            this.comb_ville = new System.Windows.Forms.ComboBox();
            this.comb_agence = new System.Windows.Forms.ComboBox();
            this.text_matricule = new System.Windows.Forms.TextBox();
            this.dgv_voiture = new System.Windows.Forms.DataGridView();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voiture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ville : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agence : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matricule : ";
            // 
            // comb_ville
            // 
            this.comb_ville.FormattingEnabled = true;
            this.comb_ville.Location = new System.Drawing.Point(117, 34);
            this.comb_ville.Name = "comb_ville";
            this.comb_ville.Size = new System.Drawing.Size(165, 28);
            this.comb_ville.TabIndex = 3;
            this.comb_ville.SelectedIndexChanged += new System.EventHandler(this.comb_ville_SelectedIndexChanged);
            // 
            // comb_agence
            // 
            this.comb_agence.FormattingEnabled = true;
            this.comb_agence.Location = new System.Drawing.Point(117, 109);
            this.comb_agence.Name = "comb_agence";
            this.comb_agence.Size = new System.Drawing.Size(165, 28);
            this.comb_agence.TabIndex = 4;
            this.comb_agence.SelectedIndexChanged += new System.EventHandler(this.comb_agence_SelectedIndexChanged);
            // 
            // text_matricule
            // 
            this.text_matricule.Location = new System.Drawing.Point(117, 183);
            this.text_matricule.Name = "text_matricule";
            this.text_matricule.Size = new System.Drawing.Size(165, 26);
            this.text_matricule.TabIndex = 5;
            this.text_matricule.TextChanged += new System.EventHandler(this.text_matricule_TextChanged);
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
            this.dgv_voiture.Location = new System.Drawing.Point(321, 34);
            this.dgv_voiture.Name = "dgv_voiture";
            this.dgv_voiture.RowHeadersWidth = 62;
            this.dgv_voiture.RowTemplate.Height = 28;
            this.dgv_voiture.Size = new System.Drawing.Size(622, 358);
            this.dgv_voiture.TabIndex = 6;
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
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(13, 255);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(292, 24);
            this.checkBox.TabIndex = 7;
            this.checkBox.Text = "Afficher la liste de toutes les voitures";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // UserControlVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.dgv_voiture);
            this.Controls.Add(this.text_matricule);
            this.Controls.Add(this.comb_agence);
            this.Controls.Add(this.comb_ville);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlVoiture";
            this.Size = new System.Drawing.Size(978, 415);
            this.Load += new System.EventHandler(this.UserControlVoiture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comb_ville;
        private System.Windows.Forms.ComboBox comb_agence;
        private System.Windows.Forms.TextBox text_matricule;
        private System.Windows.Forms.DataGridView dgv_voiture;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
