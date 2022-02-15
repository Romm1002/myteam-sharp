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
    public partial class menuModifierUtilisateur : UserControl
    {
        private Accueil accueil;
        private int idUtilisateur;
        public menuModifierUtilisateur(int idUtilisateur, Accueil accueil)
        {
            this.accueil = accueil;
            this.idUtilisateur = idUtilisateur;
            Utilisateurs utilisateurs = new Utilisateurs(idUtilisateur);
            Modeles.Application app = new Modeles.Application();

            InitializeComponent();

            nom.Text = utilisateurs.getNom();

        }
    }
}
