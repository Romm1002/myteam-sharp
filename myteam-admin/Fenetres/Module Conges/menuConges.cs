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
            }

            // INITIALIZE STATS
            stat1.Text = accueil.app.getCountCongesActuel().ToString();
            stat2.Text = accueil.app.getCountCongesAVenir().ToString();
            stat3.Text = accueil.app.getCountCongesEnAttente().ToString();
        }

    }
}
