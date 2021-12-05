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
    public partial class UserControlGestionVoiture : UserControl
    {
        private Form1 form;
        private int idAgence;
        private DataGridViewRowCollection rows;
        private ComboBox.ObjectCollection comboMarque;
        private ComboBox.ObjectCollection comboSeries;
        public UserControlGestionVoiture()
        {
            InitializeComponent();
        }

        private void UserControlGestionVoiture_Load(object sender, EventArgs e)
        {
            form = (Form1)this.FindForm();
            comboMarque = comb_marque.Items;
            comboSeries = comb_serie.Items;
            idAgence = form.IdAgence;

            // Chargement du DataGridView
            rows = dgv_voiture.Rows;

            using (var db = new ModelContainer())
            {
                try
                {
                    ModelContainer DB = db;
                    Utility.chargerGestionVoitureDGV(ref DB, ref rows, idAgence);
                }
                catch (Exception)
                {
                    // Rien à afficher dans le DGV , puisque l'agence n'a aucune voiture pour le momoent.
                }

                // Chargement du ComboBox des marques.
                comboMarque.Add("Select marque : ");

                List<string> marques = db.Marques.Select(m => m.libelle).ToList();
                Utility.chargerCombo(ref comboMarque, marques);

                comb_marque.SelectedIndex = 0;

                comb_serie.Items.Add("Select serie : ");
                comb_serie.SelectedIndex = 0;
            }
        }

        private void comb_marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSeries.Clear();
            text_matricule.Text = "";
            text_prix.Text = "";

            comboSeries.Add("Select serie : ");
            comb_serie.SelectedIndex = 0;

            // Chargement des series qui correspondent à la marque selectionner.
            if (comb_marque.SelectedIndex != 0)
            {
                string marque = comb_marque.SelectedItem.ToString();

                using (var db = new ModelContainer())
                {
                    List<string> series = db.Series.Where(s => s.Marque.libelle == marque).Select(s => s.libelle).ToList();
                    Utility.chargerCombo(ref comboSeries, series);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string serie = comb_serie.SelectedItem.ToString();
            string matricule = text_matricule.Text.Trim();
            string priceInput = text_prix.Text.Trim();

            if (dataValid(serie, ref matricule, priceInput))
            {
                Voiture voiture = new Voiture();

                voiture.AgenceId = idAgence;
                voiture.matricule = matricule;
                voiture.prix_jour = int.Parse(priceInput);

                using (var db = new ModelContainer())
                {
                    Serie sr = db.Series.Where(s => s.libelle == serie).ToList().First();
                    voiture.Serie = sr;
                    db.Voitures.Add(voiture);

                    db.SaveChanges();

                    // Refrichir le tableau
                    ModelContainer DB = db;
                    Utility.chargerGestionVoitureDGV(ref DB, ref rows, idAgence);
                }
            }
        }

        private Boolean dataValid(string serie, ref string matricule, string priceInput)
        {
            return requiredDataExist(serie, matricule, priceInput) && matriculeValid(ref matricule) && priceValid(priceInput);
        }

        private Boolean requiredDataExist(string serie, string matricule, string priceInput)
        {
            if (serie == "Select serie : " || matricule == "" || priceInput == "")
            {
                MessageBox.Show("Vous devez saisir toutes les informations nécessaire.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Boolean matriculeValid(ref string matricule)
        {
            string pattern = @"^[0-9]{1,5}-[ABDHWT]-[0-9]{1,2}$";

            if (Regex.IsMatch(matricule, pattern, RegexOptions.IgnoreCase))
            {
                matricule = matricule.ToUpper();
                string matriculeTemp = matricule;

                using (var db = new ModelContainer())
                {
                    if (db.Voitures.Where(v => v.matricule == matriculeTemp).Count() == 0)
                        return true;
                    else
                        MessageBox.Show("Le matricule est déja utilisé.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("La forme du matricule n'est pas valid.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private Boolean priceValid(string prixInput)
        {
            try
            {
                int prix = int.Parse(prixInput);
                if (prix < 0 || prix > 10000)
                    MessageBox.Show("Le prix n'est pas valid.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Le prix n'est pas valid.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void dgv_voiture_SelectionChanged(object sender, EventArgs e)
        {
            // Syncronisation des champs avec la ligne du DGV selectée.
            DataGridViewSelectedRowCollection selectedRows = dgv_voiture.SelectedRows;
            if (selectedRows.Count > 0)
            {
                DataGridViewCellCollection cells = selectedRows[0].Cells;
                comb_marque.SelectedItem = cells[0].Value.ToString();
                comb_serie.SelectedItem = cells[1].Value.ToString();
                text_matricule.Text = cells[2].Value.ToString();
                text_prix.Text = cells[3].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string serie = comb_serie.SelectedItem.ToString();
            string matricule = text_matricule.Text.Trim();
            string priceInput = text_prix.Text.Trim();

            if (requiredDataExist(serie, matricule, priceInput) && priceValid(priceInput))
            {
                DataGridViewRow selectedRow = dgv_voiture.SelectedRows[0];
                string oldMatricule = selectedRow.Cells[2].Value.ToString();

                if (oldMatricule == matricule || matriculeValid(ref matricule))
                {
                    string marque = comb_marque.SelectedItem.ToString();

                    using (var db = new ModelContainer())
                    {
                        Voiture voiture = db.Voitures.Where(v => v.matricule == oldMatricule).ToList().First();
                        voiture.Serie = db.Series.Where(s => s.libelle == serie).ToList().First();
                        voiture.prix_jour = int.Parse(priceInput);

                        db.SaveChanges();
                    }
                    selectedRow.Cells[0].Value = marque;
                    selectedRow.Cells[1].Value = serie;
                    selectedRow.Cells[2].Value = matricule;
                    selectedRow.Cells[3].Value = priceInput;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgv_voiture.SelectedRows;

            if (rows.Count > 0)
            {
                List<string> matriculeList = new List<string>();

                using (var db = new ModelContainer())
                {
                    string matricule;
                    Voiture voiture;
                    foreach (DataGridViewRow row in rows)
                    {
                        matricule = row.Cells[2].Value.ToString();
                        voiture = db.Voitures.Where(v => v.matricule == matricule).First();
                        db.Voitures.Remove(voiture);
                        dgv_voiture.Rows.Remove(row);
                    }
                    db.SaveChanges();
                }
            }
            else
                MessageBox.Show("Vous devez selectionner le(s) voiture(s) à supprimer.!! Ressayez..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            UserControlListVoiture userControlListVoiture = new UserControlListVoiture();

            Panel panel = (Panel) form.Controls.Find("panel", false).First();
            panel.Controls.Add(userControlListVoiture);

            this.Hide();
        }
    }
}
