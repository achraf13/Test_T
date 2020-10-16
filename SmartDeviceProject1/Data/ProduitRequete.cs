using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProject1.Data
{
    class ProduitRequete
    {
        public Boolean AjouterProduit(String codeBarre, String imageProduit,
            SqlCeConnection connexion)
        {

            String dateEnregistrement = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            //String dateEnregistrement = t.ToString("dd/mm/yyyy hh:mm:ss");
            String requeteInsererProduit = "Insert into Produit (codeBarre_produit,image_produit) " +
                                      " Values ('" + codeBarre + "','" + imageProduit + "' ) ";
            int nbr = Requete.ExecuteUpdateN(requeteInsererProduit, connexion);

            if (nbr == 1 )
            {
                return true;
            }

            return false;
        }
        public Boolean AjouterDateProduit(String codeBarre, DateTime datePeremption,
            SqlCeConnection connexion)
        {

            String dateEnregistrement = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            //String dateEnregistrement = t.ToString("dd/mm/yyyy hh:mm:ss");
            String requeteInsererProduit = "Insert into datePeremption (codeBarre_produit,date_peremption) " +
                                      " Values ('" + codeBarre + "','" + datePeremption + "' ) ";
            int nbr = Requete.ExecuteUpdateN(requeteInsererProduit, connexion);

            if (nbr == 1)
            {
                return true;
            }

            return false;
        }
        public DataSet ListeProduits(SqlCeConnection connexion)
        {
            try
            {
                string requete = " Select * " +
                                 " from  Produit " ;
                DataSet ds = Requete.ExecuteSelectN(requete, connexion);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public int VerifierProduitBddLocal(String codeBarre,SqlCeConnection connexion)
        {
            int retour = -1;
            try
            {
                string requete = " Select * " +
                                 " from  Produit where codeBarre_produit='"+codeBarre+"'";
                DataSet ds = Requete.ExecuteSelectN(requete, connexion);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    retour= 1;
                }
            }
            catch(Exception ex)
            {
                
            }
            return retour;
        }
    }
}
