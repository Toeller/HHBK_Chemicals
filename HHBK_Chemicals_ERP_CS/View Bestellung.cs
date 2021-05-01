using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHBK_Chemicals_ERP_CS
{
    public partial class Form1 : Form,IView_Bestellung
    {
        private Button button1;
        private Button button2;
        private Label labelKundendaten;
        private Label labelAdresse;
        private Label labelArtikelnummer;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;

        IModel IView_Bestellung.model1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IController_Bestellung IView_Bestellung.controler1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Form1()
        {
            InitializeComponent();
        }

        int IView_Bestellung.Anlegen()
        {
            throw new NotImplementedException();
        }

        int IView_Bestellung.Aondern()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelKundendaten = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelArtikelnummer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bestellen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "Löschen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelKundendaten
            // 
            this.labelKundendaten.AutoSize = true;
            this.labelKundendaten.Location = new System.Drawing.Point(65, 61);
            this.labelKundendaten.Name = "labelKundendaten";
            this.labelKundendaten.Size = new System.Drawing.Size(105, 20);
            this.labelKundendaten.TabIndex = 11;
            this.labelKundendaten.Text = "Kundendaten";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(65, 106);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(68, 20);
            this.labelAdresse.TabIndex = 12;
            this.labelAdresse.Text = "Adresse";
            // 
            // labelArtikelnummer
            // 
            this.labelArtikelnummer.AutoSize = true;
            this.labelArtikelnummer.Location = new System.Drawing.Point(65, 149);
            this.labelArtikelnummer.Name = "labelArtikelnummer";
            this.labelArtikelnummer.Size = new System.Drawing.Size(111, 20);
            this.labelArtikelnummer.TabIndex = 13;
            this.labelArtikelnummer.Text = "Artikelnummer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 16;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(471, 346);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelArtikelnummer);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelKundendaten);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Bestellung";
            this.ResumeLayout(false);
            this.PerformLayout(); 

        }
        */
        int IView_Bestellung.Louschen()
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
