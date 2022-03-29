using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myteam_admin.Modeles;

namespace myteam_admin.Modeles
{
    public class Conges
    {
        int idConge, status;
        string commentaire, raison;
        DateTime dateDebut, dateFin;
        Utilisateurs utilisateur;

        public Conges() { }
        public Conges(int idConge, Utilisateurs utilisateur, DateTime dateDebut, DateTime dateFin, string commentaire, int status, string raison)
        {
            this.idConge = idConge;
            this.utilisateur = utilisateur;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.commentaire = commentaire;
            this.status = status;
            this.raison = raison;
        }

        public int getIdConge()
        {
            return idConge;
        }
        public Utilisateurs getUtilisateur()
        {
            return utilisateur;
        }
        public int getStatus()
        {
            return status;
        }
        public string getCommentaire()
        {
            return commentaire;
        }
        public string getRaison()
        {
            return raison;
        }
        public DateTime getDateDebut()
        {
            return dateDebut;
        }
        public DateTime getDateFin()
        {
            return dateFin;
        }
    }

}
