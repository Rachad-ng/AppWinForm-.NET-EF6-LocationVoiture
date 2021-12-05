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
    public partial class UserControlListVoiture : UserControl
    {
        private Form1 form;
        private int idAgence;
        public UserControlListVoiture()
        {
            InitializeComponent();
        }

        private void UserControlListVoiture_Load(object sender, EventArgs e)
        {
            form = (Form1)this.FindForm();
            idAgence = form.IdAgence;

            using (var db = new ModelContainer())
            { 
                try
                {
                    var data = from g in ((from v in db.Voitures.Where(v => v.AgenceId == idAgence)
                                           from s in db.Series.Where(s => s.Id == v.SerieId)
                                           from m in db.Marques.Where(m => m.Id == s.MarqueId)
                                           from r in db.Reservations.Where(r => r.VoitureId == v.Id)
                                           from l in db.Locations.Where(l => l.Reservation.Id == r.Id)
                                           select new
                                           {
                                               marque = m.libelle,
                                               serie = s.libelle,
                                               matricule = v.matricule,
                                               kilometrage = l.kilometrage
                                           }).ToList())
                               group g by new { g.marque, g.serie, g.matricule } into f
                               select new
                               {
                                   marque = f.Key.marque,
                                   serie = f.Key.serie,
                                   matricule = f.Key.matricule,
                                   kilometrage = f.Sum(y => y.kilometrage)
                               };
                    
                    DataGridViewRowCollection rows = dgv_voiture.Rows;
                    foreach (var item in data)
                        rows.Add(item.marque, item.serie, item.matricule, item.kilometrage);
                }
                catch (Exception)
                {
                    MessageBox.Show("Aucune location pour le moment,, Contacter l'administrateur pour plus d'informations", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
