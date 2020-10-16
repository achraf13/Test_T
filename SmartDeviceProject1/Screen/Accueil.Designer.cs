namespace SmartDeviceProject1.Screen
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btn_ajouter_produit = new System.Windows.Forms.Button();
            this.btn_liste_produits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ajouter_produit
            // 
            this.btn_ajouter_produit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ajouter_produit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ajouter_produit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ajouter_produit.Location = new System.Drawing.Point(83, 55);
            this.btn_ajouter_produit.Name = "btn_ajouter_produit";
            this.btn_ajouter_produit.Size = new System.Drawing.Size(333, 53);
            this.btn_ajouter_produit.TabIndex = 12;
            this.btn_ajouter_produit.Text = "Ajouter un nouveau produit";
            this.btn_ajouter_produit.Click += new System.EventHandler(this.btn_ajouter_produit_Click);
            // 
            // btn_liste_produits
            // 
            this.btn_liste_produits.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_liste_produits.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_liste_produits.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_liste_produits.Location = new System.Drawing.Point(83, 142);
            this.btn_liste_produits.Name = "btn_liste_produits";
            this.btn_liste_produits.Size = new System.Drawing.Size(333, 53);
            this.btn_liste_produits.TabIndex = 13;
            this.btn_liste_produits.Text = "Liste des produits ";
            this.btn_liste_produits.Click += new System.EventHandler(this.btn_liste_produits_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(516, 299);
            this.Controls.Add(this.btn_liste_produits);
            this.Controls.Add(this.btn_ajouter_produit);
            this.Menu = this.mainMenu1;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter_produit;
        private System.Windows.Forms.Button btn_liste_produits;
    }
}