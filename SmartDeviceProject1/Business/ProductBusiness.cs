using System;
using System.Data.SqlServerCe;
using System.Net;

using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SmartDeviceProject1.Data;

namespace SmartDeviceProject1.Business
{
    class ProductBusiness
    {
        private ProduitRequete objReq;
        SqlCeConnection connexion = Connexion.getInstance().OpenConnection();
        public ProductBusiness()
        {}
        public void AjouterProduit(String codeBarre,DateTime datePeremption)
        {
            objReq= new ProduitRequete();
            if (objReq.VerifierProduitBddLocal(codeBarre, connexion) > 0)
            {
                //si le produit existe dans la base de données
                //mettre a jour la date de peremption
            }
            else
            {
                //si le produit n'existe pas dans la base de données on l'enregistre dans la base local
                if (verifierProduitWebService(codeBarre))
                {
                    // enregistrer le produit dans la base

                    objReq.AjouterProduit(codeBarre, "image", connexion);
                    objReq.AjouterDateProduit(codeBarre, datePeremption, connexion);
                }
                else
                {
                    MessageBox.Show("Ce code à barres n'existe pas dans la base serveur");
                }   
            }  
        }

        private Boolean verifierProduitWebService(String codeBarre)
        {
            try
            {
                String urlCompt = "http://world.openfoodfacts.org/api/v0/product/" +
                                  "737628064502.json";
                var request = WebRequest.Create(urlCompt);
                request.Headers["Authorization"] = "64f49d6c6b6bdcdff1bbdf8154ec48bc";
                request.ContentType = "application/json";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        var json = sr.ReadToEnd();
                        var result = (JObject)JsonConvert.DeserializeObject(json);
                    }
                }

            }
            catch (Exception ex)
            {
                //logger les erreurs
                if (ex is WebException)
                {
                    MessageBox.Show("Problème de connexion avec le serveur");

                }

            }
            return true;
        }

     
    }
}
