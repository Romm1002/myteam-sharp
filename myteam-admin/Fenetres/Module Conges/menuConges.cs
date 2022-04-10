using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myteam_admin.Modeles;

namespace myteam_admin.Fenetres
{
    public partial class menuConges : UserControl
    {
        Accueil accueil;
        public menuConges(Accueil accueil)
        {
            this.accueil = accueil;
            InitializeComponent();

            // POPULATE DGV CAONGES
            foreach (Conges conge in accueil.app.getConges())
            {
                tableauConges.Rows.Add(conge.getIdConge(), conge.getUtilisateur().getId(), conge.getUtilisateur().getNom(), conge.getUtilisateur().getPrenom(), conge.getDateDebut().ToString("dd-MM-yyyy"), conge.getDateFin().ToString("dd-MM-yyyy"), conge.getCommentaire());
                switch (conge.getStatus())
                {
                    case 0:
                        tableauConges.Rows[tableauConges.RowCount - 1].Cells[7].Value = "En attente";
                        break;
                    case 1:
                        tableauConges.Rows[tableauConges.RowCount - 1].Cells[7].Value = "Refusé";
                        break;
                    case 2:
                        tableauConges.Rows[tableauConges.RowCount - 1].Cells[7].Value = "Accepté";
                        break;
                    default:
                        tableauConges.Rows[tableauConges.RowCount - 1].Cells[7].Value = "-";
                        break;
                }
            }

            // INITIALIZE STATS
            stat1.Text = accueil.app.getCountCongesActuel().ToString();
            stat2.Text = accueil.app.getCountCongesAVenir().ToString();
            stat3.Text = accueil.app.getCountCongesEnAttente().ToString();
        }

    }
}
