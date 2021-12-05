
namespace LocationV2
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.agenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agenceToolStripMenuItem,
            this.voitureToolStripMenuItem,
            this.gestionVoituresToolStripMenuItem,
            this.reservationToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(978, 33);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            this.menu.Visible = false;
            // 
            // agenceToolStripMenuItem
            // 
            this.agenceToolStripMenuItem.Name = "agenceToolStripMenuItem";
            this.agenceToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.agenceToolStripMenuItem.Text = "Agence";
            this.agenceToolStripMenuItem.Click += new System.EventHandler(this.agenceToolStripMenuItem_Click);
            // 
            // voitureToolStripMenuItem
            // 
            this.voitureToolStripMenuItem.Name = "voitureToolStripMenuItem";
            this.voitureToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.voitureToolStripMenuItem.Text = "Voiture";
            this.voitureToolStripMenuItem.Click += new System.EventHandler(this.voitureToolStripMenuItem_Click);
            // 
            // gestionVoituresToolStripMenuItem
            // 
            this.gestionVoituresToolStripMenuItem.Name = "gestionVoituresToolStripMenuItem";
            this.gestionVoituresToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.gestionVoituresToolStripMenuItem.Text = "Gestion Voitures";
            this.gestionVoituresToolStripMenuItem.Click += new System.EventHandler(this.gestionVoituresToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 46);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(978, 415);
            this.panel.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(395, 467);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(150, 51);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Fermer";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem agenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_close;
    }
}

