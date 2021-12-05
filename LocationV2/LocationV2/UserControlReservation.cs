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
    public partial class UserControlReservation : UserControl
    {
        private int idAgence;
        private Form1 form;
        private ComboBox.ObjectCollection comboMarques;
        private ComboBox.ObjectCollection comboSeries;
        private ComboBox.ObjectCollection comboMatricules;
        private DataGridViewRowCollection rows;

        public UserControlReservation()
        {
            InitializeComponent();
            rows = dgv_reservation.Rows;
            comboMarques = comb_marque.Items;
            comboSeries = comb_serie.Items;
            comboMatricules = comb_matricule.Items;
        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            form = (Form1) this.FindForm();
            idAgence = form.IdAgence;

            // Chargement du ComboBox des marques.
            comboMarques.Add("Select marque : ");

            using (var db = new ModelContainer())
            {
                List<string> marques = db.Voitures.Where(v => v.AgenceId == idAgence).Select(v => v.Serie.Marque.libelle).ToList();
                Utility.chargerCombo(ref comboMarques, marques);
            }
            // Initialisation d'etats des ComboBox
            comb_marque.SelectedIndex = 0;
        }

        private void comb_marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            rows.Clear();
            comboSeries.Clear();
            comboMatricules.Clear();

            comboSeries.Add("Select serie : ");
            comb_serie.SelectedIndex = 0;

            if (comb_marque.SelectedIndex != 0)
            {
                string marque = comb_marque.SelectedItem.ToString();

                // Remplir les series disponible de la marque selectionner dans le combo correspondant.
                using (var db = new ModelContainer())
                {
                    List<string> series = db.Series.Where(s => s.Marque.libelle == marque).Select(s => s.libelle).ToList();
                    Utility.chargerCombo(ref comboSeries, series);
                }
            }
        }

        private void comb_serie_SelectedIndexChanged(object sender, EventArgs e)
        {
            rows.Clear();
            comboMatricules.Clear();

            comboMatricules.Add("Select matricule : ");
            comb_matricule.SelectedIndex = 0;

            if (comb_serie.SelectedIndex != 0)
            {
                string serie = comb_serie.SelectedItem.ToString();

                // Remplir les matricules disponibles de la serie selectionner dans le combo correspondant.
                using (var db = new ModelContainer())
                {
                    List<string> matricules = db.Voitures.Where(v => v.AgenceId == idAgence && v.Serie.libelle == serie).Select(v => v.matricule).ToList();
                    Utility.chargerCombo(ref comboMatricules, matricules);
                }
            }
        }

        private void comb_matricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            rows.Clear();

            string selectedMatricule = comb_matricule.SelectedItem.ToString();
            if (selectedMatricule != "Select matricule : ")
            {
                // Afficher les reservation du cette voiture qui ne correspondent pas aux locations dans le DGV.
                using (var db = new ModelContainer())
                {
                    int i;
                    var data = db.Reservations.Where(r => r.Voiture.matricule == selectedMatricule && !db.Locations.Select(l => l.Reservation.Id).Contains(r.Id)).Select(r => new { r.date_debut, r.date_fin, r.valid }).ToList();
                    foreach (var item in data)
                    {
                        i = rows.Add(item.date_debut, item.date_fin);
                        if (item.valid == 1)
                            rows[i].DefaultCellStyle.BackColor = Color.Green;
                        else
                            rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgv_reservation.SelectedRows;
            if (selectedRows.Count > 0)
            {
                string matricule = comb_matricule.SelectedItem.ToString();

                using (var db = new ModelContainer())
                {
                    DateTime dateDebut = DateTime.Now;

                    // Pour chauque reservation selectionner
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        try
                        {
                            // Convertir la date du ligne actuelle du string au datetime pour l'utiliser dans le fitrage.
                            dateDebut = DateTime.Parse(row.Cells[0].Value.ToString());

                            // Valider la reservation qui correspond a cette date si elle existe.
                            Reservation reservation = db.Reservations.Where(r => r.Voiture.matricule == matricule && r.date_debut == dateDebut).First();
                            reservation.valid = 1;
                            db.SaveChanges();

                            // Recharge du DGV en tenant compte les confirmations efféctués
                            rows.Clear();
                            int i;
                            var data = db.Reservations.Where(r => r.Voiture.matricule == matricule && !db.Locations.Select(l => l.Reservation.Id).Contains(r.Id)).Select(r => new { r.date_debut, r.date_fin, r.valid }).ToList();
                            foreach (var item in data)
                            {
                                i = rows.Add(item.date_debut, item.date_fin);
                                if (item.valid == 1)
                                    rows[i].DefaultCellStyle.BackColor = Color.Green;
                                else
                                    rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("La confirmation est echouée.!! Ressayez..", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                   
                }
            }
            else
                MessageBox.Show("Acune(s) reservation(s) selectionnée(s) à valider.!! Ressayez..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgv_reservation.SelectedRows;
            if (selectedRows.Count > 0)
            {
                string matricule = comb_matricule.SelectedItem.ToString();

                using (var db = new ModelContainer())
                {
                    DateTime dateDebut = DateTime.Now;
                    Reservation reservation;
                    Location location;

                    // Pour chauque reservation selectionner
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        try
                        {
                            // Convertir la date du ligne actuelle du string au datetime pour l'utiliser dans le fitrage.
                            dateDebut = DateTime.Parse(row.Cells[0].Value.ToString());

                            // On recupere la reservation qui correspond à la voiture selectionner et à la date du debut de la ligne actuelle.
                            reservation = db.Reservations.Where(r => r.Voiture.matricule == matricule && r.date_debut == dateDebut).First();

                            // Création et initialisation et l'ajout de la nouvelle location.
                            location = new Location();
                            location.Reservation = reservation;
                            location.date_debut = reservation.date_debut;
                            location.date_retour = DateTime.Parse("01-01-1990");
                            location.kilometrage = 0;

                            db.Locations.Add(location);
                            db.SaveChanges();

                            MessageBox.Show("La confirmation est effectué avec succes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("La conversion du date est echouée.!! Ressayez..", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    // Recharge du DGV en tenant compte les confirmations efféctués.
                    rows.Clear();
                    int i;
                    var data = db.Reservations.Where(r => r.Voiture.matricule == matricule && !db.Locations.Select(l => l.Reservation.Id).Contains(r.Id)).Select(r => new { r.date_debut, r.date_fin, r.valid }).ToList();
                    foreach (var item in data)
                    {
                        i = rows.Add(item.date_debut, item.date_fin);
                        if (item.valid == 1)
                            rows[i].DefaultCellStyle.BackColor = Color.Green;
                        else
                            rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            else
                MessageBox.Show("Acune(s) reservation(s) selectionnée(s) à confirmer.!! Ressayez..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
