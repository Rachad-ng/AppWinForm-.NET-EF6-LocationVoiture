
namespace LocationV2
{
    partial class UserControlListVoiture
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
            this.dgv_voiture = new System.Windows.Forms.DataGridView();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voiture)).BeginInit();
            this.SuspendLayout();
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
            this.kilometrage});
            this.dgv_voiture.Location = new System.Drawing.Point(100, 35);
            this.dgv_voiture.Name = "dgv_voiture";
            this.dgv_voiture.RowHeadersWidth = 62;
            this.dgv_voiture.RowTemplate.Height = 28;
            this.dgv_voiture.Size = new System.Drawing.Size(771, 354);
            this.dgv_voiture.TabIndex = 0;
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
            // kilometrage
            // 
            this.kilometrage.HeaderText = "Kilometrage";
            this.kilometrage.MinimumWidth = 8;
            this.kilometrage.Name = "kilometrage";
            // 
            // UserControlListVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_voiture);
            this.Name = "UserControlListVoiture";
            this.Size = new System.Drawing.Size(978, 415);
            this.Load += new System.EventHandler(this.UserControlListVoiture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voiture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_voiture;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrage;
    }
}
