using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_Bestellung
{
    public partial class Form1 : Form,IView_Bestellung
    {
        private Button buttonBestellunganzeigen;
        private Label labelProdunktdeteils;
        private Label labelPreis;
        private Button buttonBestellung;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.buttonBestellung = new System.Windows.Forms.Button();
            this.buttonBestellunganzeigen = new System.Windows.Forms.Button();
            this.labelProdunktdeteils = new System.Windows.Forms.Label();
            this.labelPreis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBestellung
            // 
            this.buttonBestellung.Location = new System.Drawing.Point(12, 27);
            this.buttonBestellung.Name = "buttonBestellung";
            this.buttonBestellung.Size = new System.Drawing.Size(178, 49);
            this.buttonBestellung.TabIndex = 0;
            this.buttonBestellung.Text = "Produnkt Bestellung";
            this.buttonBestellung.UseVisualStyleBackColor = true;
            // 
            // buttonBestellunganzeigen
            // 
            this.buttonBestellunganzeigen.Location = new System.Drawing.Point(12, 100);
            this.buttonBestellunganzeigen.Name = "buttonBestellunganzeigen";
            this.buttonBestellunganzeigen.Size = new System.Drawing.Size(178, 50);
            this.buttonBestellunganzeigen.TabIndex = 1;
            this.buttonBestellunganzeigen.Text = "Bestellung anzeigen";
            this.buttonBestellunganzeigen.UseVisualStyleBackColor = true;
            // 
            // labelProdunktdeteils
            // 
            this.labelProdunktdeteils.AutoSize = true;
            this.labelProdunktdeteils.Location = new System.Drawing.Point(20, 190);
            this.labelProdunktdeteils.Name = "labelProdunktdeteils";
            this.labelProdunktdeteils.Size = new System.Drawing.Size(119, 20);
            this.labelProdunktdeteils.TabIndex = 2;
            this.labelProdunktdeteils.Text = "Produnktdeteils";
            // 
            // labelPreis
            // 
            this.labelPreis.AutoSize = true;
            this.labelPreis.Location = new System.Drawing.Point(24, 234);
            this.labelPreis.Name = "labelPreis";
            this.labelPreis.Size = new System.Drawing.Size(44, 20);
            this.labelPreis.TabIndex = 3;
            this.labelPreis.Text = "Preis";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(601, 309);
            this.Controls.Add(this.labelPreis);
            this.Controls.Add(this.labelProdunktdeteils);
            this.Controls.Add(this.buttonBestellunganzeigen);
            this.Controls.Add(this.buttonBestellung);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
