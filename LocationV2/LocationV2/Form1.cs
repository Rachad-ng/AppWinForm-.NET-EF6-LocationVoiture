using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationV2
{
    public partial class Form1 : Form
    {
        private int _idAgence;

        public int IdAgence
        {
            get => _idAgence;
            set => _idAgence = value;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void agenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Les verifications sont effectués pour empécher le rechargement qu'on ait dans le méme user control.
            try
            {
                if (panel.Controls.Find("UserControlAgence", false).Length == 0)
                {
                    UserControlAgence userControlAgence = new UserControlAgence();
                    panel.Controls.Clear();
                    panel.Controls.Add(userControlAgence);
                }
            }
            catch (Exception)
            {
                UserControlAgence userControlAgence = new UserControlAgence();
                panel.Controls.Clear();
                panel.Controls.Add(userControlAgence);
            }
        }

        private void voitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Les verifications sont effectués pour empécher le rechargement qu'on ait dans le méme user control.
            try
            {
                if (panel.Controls.Find("UserControlVoiture", false).Length == 0)
                {
                    UserControlVoiture userControlVoiture = new UserControlVoiture();
                    panel.Controls.Clear();
                    panel.Controls.Add(userControlVoiture);
                }
            }
            catch (Exception)
            {
                UserControlVoiture userControlVoiture = new UserControlVoiture();
                panel.Controls.Clear();
                panel.Controls.Add(userControlVoiture);
            }
        }

        private void gestionVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel.Controls.Find("UserControlGestionVoiture", false).Length == 0)
                {
                    UserControlGestionVoiture userControlGestionVoiture = new UserControlGestionVoiture();
                    panel.Controls.Clear();
                    panel.Controls.Add(userControlGestionVoiture);
                }
                else if (panel.Controls.Find("UserControlListVoiture", false).Length == 1)
                {
                    UserControlGestionVoiture userControlGestionVoiture = new UserControlGestionVoiture();
                    panel.Controls.Clear();
                    panel.Controls.Add(userControlGestionVoiture);
                }
            }
            catch (Exception)
            {
                UserControlGestionVoiture userControlGestionVoiture = new UserControlGestionVoiture();
                panel.Controls.Clear();
                panel.Controls.Add(userControlGestionVoiture);
            }
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel.Controls.Find("UserControlReservation", false).Length == 0)
                {
                    UserControlReservation userControlReservation = new UserControlReservation();
                    panel.Controls.Clear();
                    panel.Controls.Add(userControlReservation);
                }
            }
            catch (Exception)
            {
                UserControlReservation userControlReservation = new UserControlReservation();
                panel.Controls.Clear();
                panel.Controls.Add(userControlReservation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserControlLogin userControlLogin = new UserControlLogin();
            panel.Controls.Add(userControlLogin);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
