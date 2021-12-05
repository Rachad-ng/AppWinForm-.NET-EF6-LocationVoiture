
namespace LocationV2
{
    partial class UserControlReservation
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
            this.comb_marque = new System.Windows.Forms.ComboBox();
            this.comb_serie = new System.Windows.Forms.ComboBox();
            this.comb_matricule = new System.Windows.Forms.ComboBox();
            this.btn_valid = new System.Windows.Forms.Button();
            this.dgv_reservation = new System.Windows.Forms.DataGridView();
            this.dateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marque : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serie : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matricule : ";
            // 
            // comb_marque
            // 
            this.comb_marque.FormattingEnabled = true;
            this.comb_marque.Location = new System.Drawing.Point(124, 41);
            this.comb_marque.Name = "comb_marque";
            this.comb_marque.Size = new System.Drawing.Size(185, 28);
            this.comb_marque.TabIndex = 3;
            this.comb_marque.SelectedIndexChanged += new System.EventHandler(this.comb_marque_SelectedIndexChanged);
            // 
            // comb_serie
            // 
            this.comb_serie.FormattingEnabled = true;
            this.comb_serie.Location = new System.Drawing.Point(124, 116);
            this.comb_serie.Name = "comb_serie";
            this.comb_serie.Size = new System.Drawing.Size(185, 28);
            this.comb_serie.TabIndex = 4;
            this.comb_serie.SelectedIndexChanged += new System.EventHandler(this.comb_serie_SelectedIndexChanged);
            // 
            // comb_matricule
            // 
            this.comb_matricule.FormattingEnabled = true;
            this.comb_matricule.Location = new System.Drawing.Point(124, 189);
            this.comb_matricule.Name = "comb_matricule";
            this.comb_matricule.Size = new System.Drawing.Size(185, 28);
            this.comb_matricule.TabIndex = 5;
            this.comb_matricule.SelectedIndexChanged += new System.EventHandler(this.comb_matricule_SelectedIndexChanged);
            // 
            // btn_valid
            // 
            this.btn_valid.Location = new System.Drawing.Point(82, 262);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(164, 44);
            this.btn_valid.TabIndex = 6;
            this.btn_valid.Text = "Valider";
            this.btn_valid.UseVisualStyleBackColor = true;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // dgv_reservation
            // 
            this.dgv_reservation.AllowUserToAddRows = false;
            this.dgv_reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_reservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDebut,
            this.dateFin});
            this.dgv_reservation.Location = new System.Drawing.Point(372, 41);
            this.dgv_reservation.Name = "dgv_reservation";
            this.dgv_reservation.RowHeadersWidth = 62;
            this.dgv_reservation.RowTemplate.Height = 28;
            this.dgv_reservation.Size = new System.Drawing.Size(544, 336);
            this.dgv_reservation.TabIndex = 8;
            // 
            // dateDebut
            // 
            this.dateDebut.HeaderText = "Date debut";
            this.dateDebut.MinimumWidth = 8;
            this.dateDebut.Name = "dateDebut";
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "Date fin";
            this.dateFin.MinimumWidth = 8;
            this.dateFin.Name = "dateFin";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(82, 333);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(164, 44);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "Confirmer";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.dgv_reservation);
            this.Controls.Add(this.btn_valid);
            this.Controls.Add(this.comb_matricule);
            this.Controls.Add(this.comb_serie);
            this.Controls.Add(this.comb_marque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(978, 415);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comb_marque;
        private System.Windows.Forms.ComboBox comb_serie;
        private System.Windows.Forms.ComboBox comb_matricule;
        private System.Windows.Forms.Button btn_valid;
        private System.Windows.Forms.DataGridView dgv_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.Button btn_confirm;
    }
}
