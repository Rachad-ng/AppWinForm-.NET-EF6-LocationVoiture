
namespace LocationV2
{
    partial class UserControlAgence
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
            this.label5 = new System.Windows.Forms.Label();
            this.text_rs = new System.Windows.Forms.TextBox();
            this.text_ville = new System.Windows.Forms.TextBox();
            this.text_tel = new System.Windows.Forms.TextBox();
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_agence = new System.Windows.Forms.DataGridView();
            this.rs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agence)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RS : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ville : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password : ";
            // 
            // text_rs
            // 
            this.text_rs.Location = new System.Drawing.Point(123, 25);
            this.text_rs.Name = "text_rs";
            this.text_rs.Size = new System.Drawing.Size(166, 26);
            this.text_rs.TabIndex = 5;
            // 
            // text_ville
            // 
            this.text_ville.Location = new System.Drawing.Point(123, 68);
            this.text_ville.Name = "text_ville";
            this.text_ville.Size = new System.Drawing.Size(166, 26);
            this.text_ville.TabIndex = 6;
            // 
            // text_tel
            // 
            this.text_tel.Location = new System.Drawing.Point(123, 115);
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(166, 26);
            this.text_tel.TabIndex = 7;
            // 
            // text_login
            // 
            this.text_login.Location = new System.Drawing.Point(123, 163);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(166, 26);
            this.text_login.TabIndex = 8;
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(123, 212);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(166, 26);
            this.text_password.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(68, 260);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(140, 41);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(68, 307);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(140, 41);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Modifier";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(68, 354);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(140, 41);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_agence
            // 
            this.dgv_agence.AllowUserToAddRows = false;
            this.dgv_agence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_agence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_agence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rs,
            this.ville,
            this.tel,
            this.login,
            this.password});
            this.dgv_agence.Location = new System.Drawing.Point(308, 25);
            this.dgv_agence.Name = "dgv_agence";
            this.dgv_agence.RowHeadersWidth = 62;
            this.dgv_agence.RowTemplate.Height = 28;
            this.dgv_agence.Size = new System.Drawing.Size(644, 370);
            this.dgv_agence.TabIndex = 13;
            this.dgv_agence.SelectionChanged += new System.EventHandler(this.dgv_agence_SelectionChanged);
            // 
            // rs
            // 
            this.rs.HeaderText = "RS";
            this.rs.MinimumWidth = 8;
            this.rs.Name = "rs";
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.MinimumWidth = 8;
            this.ville.Name = "ville";
            // 
            // tel
            // 
            this.tel.HeaderText = "Tel";
            this.tel.MinimumWidth = 8;
            this.tel.Name = "tel";
            // 
            // login
            // 
            this.login.HeaderText = "Login";
            this.login.MinimumWidth = 8;
            this.login.Name = "login";
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            // 
            // UserControlAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_agence);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.text_tel);
            this.Controls.Add(this.text_ville);
            this.Controls.Add(this.text_rs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAgence";
            this.Size = new System.Drawing.Size(978, 415);
            this.Load += new System.EventHandler(this.UserControlAgence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_rs;
        private System.Windows.Forms.TextBox text_ville;
        private System.Windows.Forms.TextBox text_tel;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_agence;
        private System.Windows.Forms.DataGridViewTextBoxColumn rs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}
