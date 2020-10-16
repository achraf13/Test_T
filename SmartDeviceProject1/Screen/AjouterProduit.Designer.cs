namespace SmartDeviceProject1.Screen
{
    partial class AjouterProduit
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
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_codeBarre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_peremption = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_enregistrer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button_enregistrer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_enregistrer.Location = new System.Drawing.Point(27, 171);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(206, 29);
            this.button_enregistrer.TabIndex = 11;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.Text = "Code à barres ";
            // 
            // textBox_codeBarre
            // 
            this.textBox_codeBarre.Location = new System.Drawing.Point(93, 58);
            this.textBox_codeBarre.Name = "textBox_codeBarre";
            this.textBox_codeBarre.Size = new System.Drawing.Size(140, 23);
            this.textBox_codeBarre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.Text = "Ajouter un produit\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 45);
            this.label3.Text = "Date de péremption";
            // 
            // dateTimePicker_peremption
            // 
            this.dateTimePicker_peremption.Location = new System.Drawing.Point(93, 111);
            this.dateTimePicker_peremption.Name = "dateTimePicker_peremption";
            this.dateTimePicker_peremption.Size = new System.Drawing.Size(140, 24);
            this.dateTimePicker_peremption.TabIndex = 16;
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(260, 288);
            this.Controls.Add(this.dateTimePicker_peremption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_enregistrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_codeBarre);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "AjouterProduit";
            this.Text = "Ajouter produit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_codeBarre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_peremption;
    }
}