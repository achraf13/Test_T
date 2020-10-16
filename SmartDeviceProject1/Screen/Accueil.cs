using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1.Screen
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btn_ajouter_produit_Click(object sender, EventArgs e)
        {
            AjouterProduit objAjouterProduit= new AjouterProduit();
            objAjouterProduit.ShowDialog();
        }

        private void btn_liste_produits_Click(object sender, EventArgs e)
        {
            ListeProduits objListeProduits= new ListeProduits();
            objListeProduits.ShowDialog();
        }

    }
}