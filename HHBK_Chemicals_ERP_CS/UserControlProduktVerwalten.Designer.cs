
namespace HHBK_Chemicals_ERP_CS
{
    partial class UserControlProduktVerwalten
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVerkaufseinheit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEinheit = new System.Windows.Forms.TextBox();
            this.textBoxPreisVK = new System.Windows.Forms.TextBox();
            this.buttonNeu = new System.Windows.Forms.Button();
            this.buttonAendern = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.comboBoxArtikelnummer = new System.Windows.Forms.ComboBox();
            this.comboBoxArtikelname = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artikelnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artikelname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Verkaufseinheit";
            // 
            // textBoxVerkaufseinheit
            // 
            this.textBoxVerkaufseinheit.Location = new System.Drawing.Point(102, 56);
            this.textBoxVerkaufseinheit.Name = "textBoxVerkaufseinheit";
            this.textBoxVerkaufseinheit.Size = new System.Drawing.Size(156, 20);
            this.textBoxVerkaufseinheit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Einheit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "VK-Preis";
            // 
            // textBoxEinheit
            // 
            this.textBoxEinheit.Location = new System.Drawing.Point(102, 82);
            this.textBoxEinheit.Name = "textBoxEinheit";
            this.textBoxEinheit.Size = new System.Drawing.Size(156, 20);
            this.textBoxEinheit.TabIndex = 8;
            // 
            // textBoxPreisVK
            // 
            this.textBoxPreisVK.Location = new System.Drawing.Point(102, 109);
            this.textBoxPreisVK.Name = "textBoxPreisVK";
            this.textBoxPreisVK.Size = new System.Drawing.Size(156, 20);
            this.textBoxPreisVK.TabIndex = 9;
            // 
            // buttonNeu
            // 
            this.buttonNeu.Location = new System.Drawing.Point(6, 144);
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(75, 23);
            this.buttonNeu.TabIndex = 10;
            this.buttonNeu.Text = "neu";
            this.buttonNeu.UseVisualStyleBackColor = true;
            this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
            // 
            // buttonAendern
            // 
            this.buttonAendern.Location = new System.Drawing.Point(102, 144);
            this.buttonAendern.Name = "buttonAendern";
            this.buttonAendern.Size = new System.Drawing.Size(156, 23);
            this.buttonAendern.TabIndex = 12;
            this.buttonAendern.Text = "speichern/ändern";
            this.buttonAendern.UseVisualStyleBackColor = true;
            this.buttonAendern.Click += new System.EventHandler(this.buttonAendern_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(278, 144);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 13;
            this.buttonLoeschen.Text = "löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // comboBoxArtikelnummer
            // 
            this.comboBoxArtikelnummer.FormattingEnabled = true;
            this.comboBoxArtikelnummer.Location = new System.Drawing.Point(102, 4);
            this.comboBoxArtikelnummer.Name = "comboBoxArtikelnummer";
            this.comboBoxArtikelnummer.Size = new System.Drawing.Size(156, 21);
            this.comboBoxArtikelnummer.TabIndex = 14;
            // 
            // comboBoxArtikelname
            // 
            this.comboBoxArtikelname.FormattingEnabled = true;
            this.comboBoxArtikelname.Location = new System.Drawing.Point(102, 30);
            this.comboBoxArtikelname.Name = "comboBoxArtikelname";
            this.comboBoxArtikelname.Size = new System.Drawing.Size(156, 21);
            this.comboBoxArtikelname.TabIndex = 15;
            // 
            // UserControlProduktVerwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxArtikelname);
            this.Controls.Add(this.comboBoxArtikelnummer);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonAendern);
            this.Controls.Add(this.buttonNeu);
            this.Controls.Add(this.textBoxPreisVK);
            this.Controls.Add(this.textBoxEinheit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVerkaufseinheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlProduktVerwalten";
            this.Size = new System.Drawing.Size(360, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVerkaufseinheit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEinheit;
        private System.Windows.Forms.TextBox textBoxPreisVK;
        private System.Windows.Forms.Button buttonNeu;
        private System.Windows.Forms.Button buttonAendern;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.ComboBox comboBoxArtikelnummer;
        private System.Windows.Forms.ComboBox comboBoxArtikelname;
    }
}
