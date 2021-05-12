using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooster.Classes
{
    class Utilisateur
    {
        // Attributs privés de la classe

        /// <summary>
        /// Numéro de l'utilisateur
        /// </summary>
        private int id;

        /// <summary>
        /// Pseudo de l'utilisateur
        /// </summary>
        private String pseudo;

        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        private String email;


        /// <summary>
        /// Date de début d'inscription de l'utilisateur
        /// </summary>
        private DateTime dateDebut;


        /// <summary>
        /// Retourne un objet REVUE concerné par l'abonnement
        /// </summary>
        private Utilisateur unUtilisateur;

        public Utilisateur()
        {

        }


        public Utilisateur(int id, String pseudo, String email, DateTime datedeb, Utilisateur lUtilisateur)
        {
            this.id = id;
            this.pseudo = pseudo;
            this.email = email;
            this.dateDebut = datedeb  ;
            this.unUtilisateur = lUtilisateur;
        }


        /// <summary>
        /// Retourne le numéro de l'abonnement
        /// </summary>
        /// <returns>int</returns>
        public int getId() { return id; }

        /// <summary>
        /// Retourne le nom de l'abonné
        /// </summary>
        /// <returns>String</returns>
        public String getPseudo() { return pseudo; }


        /// <summary>
        /// Retourne le prénom de l'abonné
        /// </summary>
        /// <returns>String</returns>
        public String getEmail() { return email; }


        /// <summary>
        /// Retourne la date de début de l'abonnement
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime getDateDebut() { return dateDebut; }


        /// <summary>
        /// Retourne l'objet revue de l'abonnement
        /// </summary>
        /// <returns>Revue</returns>
        public Utilisateur getUtilisateur() { return unUtilisateur; }


        /// <summary>
        /// Définir le numéro de l'utilisateur
        /// </summary>
        /// <param name="id"></param>
        public void setId(int id) { this.id = id; }


        /// <summary>
        /// Définir le pseudo de l'utilisateur
        /// </summary>
        /// <param name="pseudo"></param>
        public void setPseudo(String pseudo) { this.pseudo = pseudo; }


        /// <summary>
        /// Définir l'email de l'utilisateur
        /// </summary>
        /// <param name="email"></param>
        public void setEmail(String email) { this.email = email; }


        /// <summary>
        /// Définir la date d'inscription
        /// </summary>
        /// <param name="dateDebut"></param>
        public void setDateDebut(DateTime dateDebut) { this.dateDebut = dateDebut; }




        /// <summary>
        /// Définir la revue de l'abonné
        /// </summary>
        /// <param name="unUtilisateur"></param>
        public void setutilisateur(Utilisateur unUtilisateur) { this.unUtilisateur = unUtilisateur; }
    }
}
