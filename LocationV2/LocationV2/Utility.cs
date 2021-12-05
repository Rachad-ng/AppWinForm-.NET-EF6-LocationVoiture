using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationV2
{
    class Utility
    {
        public static void chargerCombo(ref ComboBox.ObjectCollection combo, List<string> comboItems)
        {
            foreach (string item in comboItems)
                combo.Add(item);
        }

        public static void chargerGestionVoitureDGV(ref ModelContainer db, ref DataGridViewRowCollection rows, int idAgence)
        {
            ModelContainer DB = db;
            rows.Clear();
            var data = (from a in DB.Agences.Where(a => a.Id == idAgence)
                        from v in DB.Voitures.Where(v => v.AgenceId == a.Id).DefaultIfEmpty()
                        from s in DB.Series.Where(s => s.Id == v.SerieId).DefaultIfEmpty()
                        from m in DB.Marques.Where(m => m.Id == s.MarqueId).DefaultIfEmpty()
                        select new
                        {
                            marque = m.libelle,
                            serie = s.libelle,
                            matricule = v.matricule,
                            prix = v.prix_jour
                        }).ToList();

            foreach (var item in data)
                rows.Add(item.marque, item.serie, item.matricule, item.prix);
        }

        public static void chargerVoitureDGV(ref ModelContainer db, ref DataGridViewRowCollection rows)
        {
            rows.Clear();

            var data = db.Voitures.ToList();

            foreach (var item in data)
                rows.Add(item.Serie.Marque.libelle, item.Serie.libelle, item.matricule, item.prix_jour);
        }

        public static void chargerVoitureDGVFilterVille(ref ModelContainer db, ref DataGridViewRowCollection rows, string ville)
        {
            rows.Clear();

            var data = db.Voitures.Where(v => v.Agence.ville == ville).ToList();

            foreach (var item in data)
                rows.Add(item.Serie.Marque.libelle, item.Serie.libelle, item.matricule, item.prix_jour);
        }

        public static void chargerVoitureDGVFilterVilleAgence(ref ModelContainer db, ref DataGridViewRowCollection rows, string ville, string rsAgence)
        {
            rows.Clear();

            var data = db.Voitures.Where(v => v.Agence.ville == ville && v.Agence.rs == rsAgence).ToList();

            foreach (var item in data)
                rows.Add(item.Serie.Marque.libelle, item.Serie.libelle, item.matricule, item.prix_jour);
        }

        public static void chargerVoitureDGVFilterKeyword(ref ModelContainer db, ref DataGridViewRowCollection rows, string keyword)
        {
            rows.Clear();

            var data = db.Voitures.Where(v => SqlFunctions.PatIndex(keyword + "%", v.matricule) > 0).ToList();

            foreach (var item in data)
                rows.Add(item.Serie.Marque.libelle, item.Serie.libelle, item.matricule, item.prix_jour);
        }
    }
}
