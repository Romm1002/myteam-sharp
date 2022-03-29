using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;
using System.Windows.Forms;

namespace myteam_admin.Fenetres
{
    public partial class menuMessagesSignales : UserControl
    {
        private Accueil accueil;

        Messages messages = new Messages();
        Modeles.Application app = new Modeles.Application();
        public menuMessagesSignales()
        {
            InitializeComponent();

            
        }
    }
}
