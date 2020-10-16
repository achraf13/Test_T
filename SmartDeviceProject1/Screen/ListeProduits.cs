using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceProject1.Model;

namespace SmartDeviceProject1.Screen
{
    public partial class ListeProduits : Form
    {
        public ListeProduits()
        {
            InitializeComponent();
        }

        private void ListeProduits_Load(object sender, EventArgs e)
        {
            List<ProductModel> ListProduits = new List<ProductModel>();
            ListProduits.Add(new ProductModel("0123","image1"));
            ListProduits.Add(new ProductModel("4567", "image2"));
            dataGrid_list_product.DataSource = ListProduits;
            DataGridTableStyle tableStyle = new DataGridTableStyle();
            tableStyle.MappingName = ListProduits.GetType().ToString();
            DataGridTextBoxColumn tbcName = new DataGridTextBoxColumn();
            tbcName.Width = 4000;
            tbcName.MappingName = "UNO";
            tbcName.HeaderText = "UNO 1";
            tableStyle.GridColumnStyles.Add(tbcName);
            dataGrid_list_product.TableStyles.Clear();
            dataGrid_list_product.TableStyles.Add(tableStyle);
        }
    }
}