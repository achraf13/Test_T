using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceProject1.Business;

namespace SmartDeviceProject1.Screen
{
    public partial class AjouterProduit : Form
    {
        private String codeBarre;
        private DateTime datePeremption;
        private Business.ProductBusiness objProductBusiness;
        public AjouterProduit()
        {
            InitializeComponent();
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            if (textBox_codeBarre.Text == "")
            {
                MessageBox.Show("Veuillez remplir le champ code à barres");
            }
            else
            {
                datePeremption = dateTimePicker_peremption.Value;
                codeBarre = textBox_codeBarre.Text;
                objProductBusiness= new ProductBusiness();
                objProductBusiness.AjouterProduit(codeBarre, datePeremption);
            }
        }

        
    }
}