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
    public partial class UserControlLogin : UserControl
    {
        private Form1 form;
        private MenuStrip menuStrip;
        private Panel panel;

        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void UserControlLogin_Load(object sender, EventArgs e)
        {
            form = (Form1) this.FindForm();
            menuStrip = (MenuStrip) form.Controls.Find("menu", false).First();
            panel = (Panel) form.Controls.Find("panel", false).First();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = text_login.Text;
            string password = text_password.Text;

            // Traitment du control pour la gestion des droits d'accès
            if (login == "admin" && password == "1234")
            {
                UserControlAgence userControlAgence = new UserControlAgence();

                menuStrip.Items[2].Enabled = false;
                menuStrip.Items[3].Enabled = false;
                menuStrip.Show();

                panel.Controls.Add(userControlAgence);
                this.Hide();
            }
            else
            {
                using (var db = new ModelContainer())
                {
                    List<int> ids = db.Agences.Where(a => a.login == login && a.password == password).Select(a => a.Id).ToList();

                    if (ids.Count == 1)
                    {
                        form.IdAgence = ids.First();

                        UserControlVoiture userControlVoiture = new UserControlVoiture();
                        panel.Controls.Add(userControlVoiture);

                        menuStrip.Items[0].Enabled = false;
                        menuStrip.Show();

                        this.Hide();
                    }
                    else
                        MessageBox.Show("Le login ou/et mot de passe est erroné.!! Ressayer..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
