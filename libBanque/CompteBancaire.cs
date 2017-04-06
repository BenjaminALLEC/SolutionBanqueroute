using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBanque
{
    public class CompteBancaire
    {
        #region Propriétés privées de la classe
        //private properties
        private string numCompte;
        private string nomTitulaire;
        private Decimal soldeCompte;
        #endregion

        #region property (accesseurs)
        //property (accesseurs)
        public string NumCompte
        {
            get { return numCompte; }
            set { numCompte = value; }
        }
        public string NomTitulaire
        {
            get { return nomTitulaire; }
            set { nomTitulaire = value; }
        }
        public Decimal SoldeCompte
        {
            get { return soldeCompte; }
        }
        #endregion

        #region Constructeurs de la classe
        /// <summary>
        /// Initialise une  nouvelle instance de la classe libanque.CompteBancaire
        /// </summary>
        /// <param name="sonNumero">Le numéro du compte bancaire</param>
        /// <param name="sonTitulaire">Le nom du titulaire du compte : nom + prénom</param>
        /// <remarks>Le solde du compte sera initialisé à 0
        public CompteBancaire(string sonNumero, string sonTitulaire)
        {
            numCompte = sonNumero;
            nomTitulaire = sonTitulaire;
            soldeCompte = 0;
        }

        public CompteBancaire(string sonNumero, string sonTitulaire, decimal sonSoldeInitial)
        {
            numCompte = sonNumero;
            nomTitulaire = sonTitulaire;
            soldeCompte = sonSoldeInitial;
        }
        #endregion
    }
}