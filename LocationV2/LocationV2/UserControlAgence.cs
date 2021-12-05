using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationV2
{
    public partial class UserControlAgence : UserControl
    {
        private DataGridViewRowCollection rows;

        public UserControlAgence()
        {
            InitializeComponent();
            rows = dgv_agence.Rows;
        }

        private void UserControlAgence_Load(object sender, EventArgs e)
        {
            using (var db = new ModelContainer())
            {
                var data = db.Agences.ToList();
                foreach (var item in data)
                    rows.Add(item.rs, item.ville, item.tel, item.login, item.password);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string rs, ville, tele, login, password;

            rs = text_rs.Text.Trim();
            ville = text_ville.Text.Trim();
            tele = text_tel.Text.Trim();
            login = text_login.Text.Trim();
            password = text_password.Text.Trim();

            // Verification des données.
            if (dataValid(rs, ville, tele, login, password))
            {
                using (var db = new ModelContainer())
                {
                    // Verification de la contrainte du l'unicité du rs des agences de chaque ville
                    int number = db.Agences.Where(a => a.rs == rs && a.ville == ville).Count();

                    if (number == 0)
                    {
                        Agence agence = new Agence();
                        agence.rs = rs;
                        agence.ville = ville;
                        agence.tel = tele;
                        agence.login = login;
                        agence.password = password;
                        db.Agences.Add(agence);

                        rows.Add(rs, ville, tele, login, password);

                        db.SaveChanges();
                    }
                    else
                        MessageBox.Show("Le rs saisi est déja réservé dans cette ville.!! Ressayez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Boolean requiredDataExist(string rs, string ville, string tele, string login, string password)
        {
            if (rs == "" || ville == "" || tele == "" || login == "" || password == "")
            {
                MessageBox.Show("Vous devez saisir toutes les informations nécessaire.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Boolean villeValid(string ville)
        {
            string pattern = @"^[A-Z][a-zA-Z ]{3,30}$";
            if (Regex.IsMatch(ville, pattern))
                return true;
            else
                MessageBox.Show("La ville n'est pas valide.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private Boolean rsValid(string rs, string ville)
        {
            if (rs.Length >= 3)
            {
                using (var db = new ModelContainer())
                {
                    int number = db.Agences.Where(a => a.rs == rs && a.ville == ville).Count();

                    if (number == 1)
                        MessageBox.Show("Le rs saisi est déja reservé dans cette ville.!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        return true;
                }
            }
            else
                MessageBox.Show("Le rs doit contenir au moins 3 lettres .!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private Boolean teleValid(string tele)
        {
            string pattern = @"^[0-9]{3,11}$";
            if (Regex.IsMatch(tele, pattern))
                return true;
            else
                MessageBox.Show("Le telephone n'est pas valide.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private Boolean loginValid(string login)
        {
            if (login.Length >= 3)
                return true;
            else
                MessageBox.Show("Le login doit contenir au moins 3 lettres.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private Boolean passValid(string password)
        {
            if (password.Length >= 4)
                return true;
            else
                MessageBox.Show("Le mot de passe doit contenir au moins 4 lettres.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private Boolean dataValid(string rs, string ville, string tele, string login, string password)
        {
            return requiredDataExist(rs, ville, tele, login, password) && villeValid(ville) && rsValid(rs, ville) && teleValid(tele) && loginValid(login) && passValid(password);
        }

        private void updateRow(ref DataGridViewRow row, string rs, string ville, string tele, string login, string password)
        {
            DataGridViewCellCollection cells = row.Cells;
            cells[0].Value = rs;
            cells[1].Value = ville;
            cells[2].Value = tele;
            cells[3].Value = login;
            cells[4].Value = password;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgv_agence.SelectedRows;

            if (rows.Count > 0)
            {
                string oldRs, newRs, newVille, newTele, newLogin, newPassword;

                newRs = text_rs.Text.Trim();
                newVille = text_ville.Text.Trim();
                newTele = text_tel.Text.Trim();
                newLogin = text_login.Text.Trim();
                newPassword = text_password.Text.Trim();

                if (requiredDataExist(newRs, newVille, newTele, newLogin, newPassword) && villeValid(newVille) && teleValid(newTele) && loginValid(newLogin) && passValid(newPassword))
                {
                    if (newRs.Length >= 3)
                    {
                        using (var db = new ModelContainer())
                        {
                            int number = db.Agences.Where(a => a.rs == newRs && a.ville == newVille).Count();

                            if (number == 0 || newRs == selectedRows[0].Cells[0].Value.ToString())
                            {
                                oldRs = selectedRows[0].Cells[0].Value.ToString();

                                Agence agence = db.Agences.Where(a => a.rs == oldRs).First();
                                agence.rs = newRs;
                                agence.ville = newVille;
                                agence.tel = newTele;
                                agence.login = newLogin;
                                agence.password = newPassword;

                                DataGridViewRow row = selectedRows[0];
                                updateRow(ref row, newRs, newVille, newTele, newLogin, newPassword);

                                db.SaveChanges();
                            }
                            else
                                MessageBox.Show("Le rs saisi est déja réservé.!! Ressayez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Le rs doit contenir au moins 3 lettres.!! Ressayez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Aucune agence selectionnée.!! Ressayez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dgv_agence_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_agence.SelectedRows.Count > 0)
            {
                DataGridViewCellCollection cells = dgv_agence.SelectedRows[0].Cells;

                text_rs.Text = cells[0].Value.ToString();
                text_ville.Text = cells[1].Value.ToString();
                text_tel.Text = cells[2].Value.ToString();
                text_login.Text = cells[3].Value.ToString();
                text_password.Text = cells[4].Value.ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgv_agence.SelectedRows;

            if (rows.Count > 0)
            {
                using (var db = new ModelContainer())
                {
                    Agence currentAgence;
                    string currentRs;
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        currentRs = row.Cells[0].Value.ToString();
                        currentAgence = db.Agences.Where(a => a.rs == currentRs).First();
                        db.Agences.Remove(currentAgence);

                        rows.Remove(row);
                    }
                    db.SaveChanges();
                }
            }
            else
                MessageBox.Show("Aucune(s) agence(s) selectionnée(s).!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
