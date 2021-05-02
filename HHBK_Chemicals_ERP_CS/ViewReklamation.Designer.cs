
namespace HHBK_Chemicals_ERP_CS
{
    partial class ViewReklamation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxKundennummer = new System.Windows.Forms.TextBox();
            this.textBoxBestellnummer = new System.Windows.Forms.TextBox();
            this.textBoxArtikelnummer = new System.Windows.Forms.TextBox();
            this.textBoxReklamationsgrund = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kundennummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bestellungsnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artikelnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reklamations Grund";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxKundennummer
            // 
            this.textBoxKundennummer.Location = new System.Drawing.Point(12, 63);
            this.textBoxKundennummer.Name = "textBoxKundennummer";
            this.textBoxKundennummer.Size = new System.Drawing.Size(320, 20);
            this.textBoxKundennummer.TabIndex = 5;
            // 
            // textBoxBestellnummer
            // 
            this.textBoxBestellnummer.Location = new System.Drawing.Point(12, 119);
            this.textBoxBestellnummer.Name = "textBoxBestellnummer";
            this.textBoxBestellnummer.Size = new System.Drawing.Size(320, 20);
            this.textBoxBestellnummer.TabIndex = 6;
            // 
            // textBoxArtikelnummer
            // 
            this.textBoxArtikelnummer.Location = new System.Drawing.Point(12, 178);
            this.textBoxArtikelnummer.Name = "textBoxArtikelnummer";
            this.textBoxArtikelnummer.Size = new System.Drawing.Size(322, 20);
            this.textBoxArtikelnummer.TabIndex = 7;
            // 
            // textBoxReklamationsgrund
            // 
            this.textBoxReklamationsgrund.Location = new System.Drawing.Point(12, 229);
            this.textBoxReklamationsgrund.Multiline = true;
            this.textBoxReklamationsgrund.Name = "textBoxReklamationsgrund";
            this.textBoxReklamationsgrund.Size = new System.Drawing.Size(320, 66);
            this.textBoxReklamationsgrund.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bitte Füllen sie folgende Felder aus um die Reklamation einzuleiten";
            // 
            // TextBoxAusgabe
            // 
            this.TextBoxAusgabe.Location = new System.Drawing.Point(15, 357);
            this.TextBoxAusgabe.Multiline = true;
            this.TextBoxAusgabe.Name = "TextBoxAusgabe";
            this.TextBoxAusgabe.ReadOnly = true;
            this.TextBoxAusgabe.Size = new System.Drawing.Size(317, 36);
            this.TextBoxAusgabe.TabIndex = 10;
            // 
            // ViewReklamation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 409);
            this.Controls.Add(this.TextBoxAusgabe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxReklamationsgrund);
            this.Controls.Add(this.textBoxArtikelnummer);
            this.Controls.Add(this.textBoxBestellnummer);
            this.Controls.Add(this.textBoxKundennummer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewReklamation";
            this.Text = "Reklamation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxKundennummer;
        private System.Windows.Forms.TextBox textBoxBestellnummer;
        private System.Windows.Forms.TextBox textBoxArtikelnummer;
        private System.Windows.Forms.TextBox textBoxReklamationsgrund;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxAusgabe;
    }
}