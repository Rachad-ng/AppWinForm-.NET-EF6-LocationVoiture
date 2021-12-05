using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationV2
{
    public partial class UserControlVoiture : UserControl
    {
        private DataGridViewRowCollection rows;
        private ComboBox.ObjectCollection comboVilles;
        private ComboBox.ObjectCollection comboAgences;

        public UserControlVoiture()
        {
            InitializeComponent();
            rows = dgv_voiture.Rows;
            comboVilles = comb_ville.Items;
            comboAgences = comb_agence.Items;
            comboVilles.Add("Select ville : ");
        }

        private void UserControlVoiture_Load(object sender, EventArgs e)
        {
            // Chargement du combo des villes
            using (var db = new ModelContainer())
            {
                List<string> villes = db.Agences.Select(a => a.ville).Distinct().ToList();
                Utility.chargerCombo(ref comboVilles, villes);

                comb_ville.SelectedIndex = 0;
            }
        }

        private void comb_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkBox.Checked)
            {
                comboAgences.Clear();
                comboAgences.Add("Select agence : ");

                // Le traitement du chargement du DGV , va s'executer puisque l'événement "comb_agence_SelectedIndexChanged" va se déclencher.
                comb_agence.SelectedIndex = 0;

                if (comb_ville.SelectedIndex != 0)
                {
                    string ville = comb_ville.SelectedItem.ToString();

                    using (var db = new ModelContainer())
                    {
                        List<string> rsAgences = db.Agences.Where(a => a.ville == ville).Select(a => a.rs).ToList();
                        Utility.chargerCombo(ref comboAgences, rsAgences);
                    }
                }
            }
            else
                MessageBox.Show("Décocher le checkbox pour filtrer les données.!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comb_agence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkBox.Checked)
            {
                string ville = comb_ville.Text;
                if (comb_agence.SelectedIndex != 0)
                {
                    string rsAgence = comb_agence.SelectedItem.ToString();

                    using (var db = new ModelContainer())
                    {
                        ModelContainer DB = db;
                        try
                        {
                            Utility.chargerVoitureDGVFilterVilleAgence(ref DB, ref rows, ville, rsAgence);
                        }
                        catch (Exception)
                        {
                            // Rien à afficher dans le DGV , puisqu'il n'y a aucune voiture dans la ville selectionner.
                        }
                    }
                }
                else if (comb_ville.SelectedIndex != 0)
                {
                    using (var db = new ModelContainer())
                    {
                        ModelContainer DB = db;
                        try
                        {
                            Utility.chargerVoitureDGVFilterVille(ref DB, ref rows, ville);
                        }
                        catch (Exception)
                        {
                            // Rien à afficher dans le DGV , puisqu'il n'y a aucune voiture dans la ville selectionner. 
                        }
                    }
                }
            }
            else
                MessageBox.Show("Décocher le checkbox pour filtrer les données.!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void text_matricule_TextChanged(object sender, EventArgs e)
        {
            string keyword = text_matricule.Text;

            if (keyword != "")
            { 
                using (var db = new ModelContainer())
                {
                    ModelContainer DB = db;
                    Utility.chargerVoitureDGVFilterKeyword(ref DB, ref rows, keyword);
                }
            }
            else
            {
                if (!checkBox.Checked)
                {
                    string ville = comb_ville.Text;
                    if (comb_ville.SelectedIndex != 0 && comb_agence.SelectedIndex != 0)
                    {
                        string rsAgence = comb_agence.Text;
                        using (var db = new ModelContainer())
                        {
                            ModelContainer DB = db;
                            try
                            {
                                Utility.chargerVoitureDGVFilterVilleAgence(ref DB, ref rows, ville, rsAgence);
                            }
                            catch (Exception)
                            {
                                // Rien à afficher dans le DGV , puisqu'il n'y a aucune voiture dans l'agence selectionner.
                            }
                        }
                    }
                    else if (comb_ville.SelectedIndex != 0)
                    {
                        using (var db = new ModelContainer())
                        {
                            ModelContainer DB = db;
                            try
                            {
                                Utility.chargerVoitureDGVFilterVille(ref DB, ref rows, ville);
                            }
                            catch (Exception)
                            {
                                // Rien à afficher dans le DGV , puisqu'il n'y a aucune voiture dans la ville selectionner.
                            }
                        }
                    }
                }
                else
                {
                    using (var db = new ModelContainer())
                    {
                        ModelContainer DB = db;
                        try
                        {
                            Utility.chargerVoitureDGV(ref DB, ref rows);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Aucun voiture.!! Consulter l'administrateur pour plus d'informations", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                string rsAgence = comb_agence.Text;
                using (var db = new ModelContainer())
                {
                    ModelContainer DB = db;
                    try
                    {
                       Utility.chargerVoitureDGV(ref DB, ref rows);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Aucun voiture.!! Consulter l'administrateur pour plus d'informations", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                string ville = comb_ville.Text;
                if (comb_ville.SelectedIndex != 0 && comb_agence.SelectedIndex != 0)
                {
                    string rsAgence = comb_agence.Text;
                    using (var db = new ModelContainer())
                    {
                        ModelContainer DB = db;
                        try
                        {
                            Utility.chargerVoitureDGVFilterVilleAgence(ref DB, ref rows, ville, rsAgence);
                        }
                        catch (Exception)
                        {
                            // Rien à afficher dans le DGV , puisqu'il n'y a aucune voiture dans l'agence selectionner. 
                        }
                    }
                }
                else if (comb_ville.SelectedIndex != 0)
                {
                    using (var db = new ModelContainer())
                    {
                        ModelContainer DB = db;
                        try
                        {
                            Utility.chargerVoitureDGVFilterVille(ref DB, ref rows, ville);
                        }
                        catch (Exception)
                        {
                            // Rien à afficher dans le DGV , puisqu'il n'y a aucune voiture dans la ville selectionner. 
                        }
                    }
                }
            }
        }
    }
}
