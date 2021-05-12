using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fooster.Classes
{
    class Produit
    {
        // Attributs privés de la classe

        /// <summary>
        /// Numéro du produit
        /// </summary>
        private int idTab;

        /// <summary>
        /// Nom du produit
        /// </summary>
        private String NameP;

        /// <summary>
        /// Description du produit
        /// </summary>
        private String DescP;

        /// <summary>
        /// Catégorie du produit
        /// </summary>
        private String CatP;

        /// <summary>
        /// Prix du produit
        /// </summary>
        private double PrixP;

        /// <summary>
        /// Retourne un objet Produit
        /// </summary>
        private Produit unProduit;


        public Produit()
        {

        }


        public Produit(int idTab, String NameP, String DescP, String CatP, double PrixP, Produit leProduit)
        {
            this.idTab = idTab;
            this.NameP = NameP;
            this.DescP = DescP;
            this.CatP = CatP;
            this.PrixP = PrixP;

            this.unProduit = leProduit;
        }


        /// <summary>
        /// Retourne le numéro d'un produit
        /// </summary>
        /// <returns>int</returns>
        public int getIdTab() { return idTab; }

        /// <summary>
        /// Retourne le nom d'un produit
        /// </summary>
        /// <returns>String</returns>
        public String getNameP() { return NameP; }


        /// <summary>
        /// Retourne la description d'un produit
        /// </summary>
        /// <returns>String</returns>
        public String getDescP() { return DescP; }

        /// <summary>
        /// Retourne la catégorie d'un produit
        /// </summary>
        /// <returns>String</returns>
        public String getCatP() { return CatP; }

        /// <summary>
        /// Retourne le prix d'un produit
        /// </summary>
        /// <returns>String</returns>
        public double getPrixP() { return PrixP; }



        /// <summary>
        /// Retourne l'objet Produit
        /// </summary>
        /// <returns>Revue</returns>
        public Produit getProduit() { return unProduit; }


        /// <summary>
        /// Définir le numéro d'un produit
        /// </summary>
        /// <param name="idTab"></param>
        public void setIdTab(int idTab) { this.idTab = idTab; }


        /// <summary>
        /// Définir le nom d'un produit
        /// </summary>
        /// <param name="NameP"></param>
        public void setNameP(String NameP) { this.NameP = NameP; }


        /// <summary>
        /// Définir la description d'un produit
        /// </summary>
        /// <param name="DescP"></param>
        public void setDescP(String DescP) { this.DescP = DescP; }

        /// <summary>
        /// Définir la catégories d'un produit
        /// </summary>
        /// <param name="CatP"></param>
        public void setCatP(String CatP) { this.CatP = CatP; }

        /// <summary>
        /// Définir de prix d'un produit
        /// </summary>
        /// <param name="PrixP"></param>
        public void setPrixP(double PrixP) { this.PrixP = PrixP; }



        /// <summary>
        /// Définir un produit
        /// </summary>
        /// <param name="unProduit"></param>
        public void setProduit(Produit unProduit) { this.unProduit = unProduit; }
    }
}

