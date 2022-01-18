using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myteam_admin.Fenetres
{
    public partial class menuModifierUtilisateur : UserControl
    {
        private Accueil accueil;
        public menuModifierUtilisateur(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;

        }
    }
}
