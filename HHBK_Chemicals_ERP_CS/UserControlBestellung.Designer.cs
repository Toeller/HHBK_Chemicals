
namespace HHBK_Chemicals_ERP_CS
{
    partial class UserControlBestellung
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNeu = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAendern = new System.Windows.Forms.Button();
            this.buttonNeueBestellung = new System.Windows.Forms.Button();
            this.textBoxKundennummer = new System.Windows.Forms.TextBox();
            this.textBoxBestellungsnummer = new System.Windows.Forms.TextBox();
            this.textBoxBestelldatum = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bestellpositionsnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikelname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VKE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreisVK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestellungsnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kundennummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bestelldatum";
            // 
            // buttonNeu
            // 
            this.buttonNeu.Location = new System.Drawing.Point(168, 291);
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(75, 23);
            this.buttonNeu.TabIndex = 11;
            this.buttonNeu.Text = "neu";
            this.buttonNeu.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(6, 291);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 12;
            this.buttonLoeschen.Text = "löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Gesammtsumme: 0,00€";
            // 
            // buttonAendern
            // 
            this.buttonAendern.Location = new System.Drawing.Point(87, 291);
            this.buttonAendern.Name = "buttonAendern";
            this.buttonAendern.Size = new System.Drawing.Size(75, 23);
            this.buttonAendern.TabIndex = 17;
            this.buttonAendern.Text = "ändern";
            this.buttonAendern.UseVisualStyleBackColor = true;
            // 
            // buttonNeueBestellung
            // 
            this.buttonNeueBestellung.Location = new System.Drawing.Point(581, 291);
            this.buttonNeueBestellung.Name = "buttonNeueBestellung";
            this.buttonNeueBestellung.Size = new System.Drawing.Size(220, 23);
            this.buttonNeueBestellung.TabIndex = 18;
            this.buttonNeueBestellung.Text = "Neue Bestellung";
            this.buttonNeueBestellung.UseVisualStyleBackColor = true;
            // 
            // textBoxKundennummer
            // 
            this.textBoxKundennummer.Location = new System.Drawing.Point(109, 4);
            this.textBoxKundennummer.Name = "textBoxKundennummer";
            this.textBoxKundennummer.Size = new System.Drawing.Size(100, 20);
            this.textBoxKundennummer.TabIndex = 19;
            // 
            // textBoxBestellungsnummer
            // 
            this.textBoxBestellungsnummer.Location = new System.Drawing.Point(109, 30);
            this.textBoxBestellungsnummer.Name = "textBoxBestellungsnummer";
            this.textBoxBestellungsnummer.Size = new System.Drawing.Size(100, 20);
            this.textBoxBestellungsnummer.TabIndex = 20;
            // 
            // textBoxBestelldatum
            // 
            this.textBoxBestelldatum.Location = new System.Drawing.Point(109, 57);
            this.textBoxBestelldatum.Name = "textBoxBestelldatum";
            this.textBoxBestelldatum.Size = new System.Drawing.Size(100, 20);
            this.textBoxBestelldatum.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bestellpositionsnummer,
            this.Menge,
            this.Artikelnummer,
            this.Artikelname,
            this.VKE,
            this.PreisVK,
            this.Summe});
            this.dataGridView1.Location = new System.Drawing.Point(6, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Bestellpositionsnummer
            // 
            this.Bestellpositionsnummer.HeaderText = "Bestellpositionsnummer";
            this.Bestellpositionsnummer.Name = "Bestellpositionsnummer";
            this.Bestellpositionsnummer.Width = 150;
            // 
            // Menge
            // 
            this.Menge.HeaderText = "Menge";
            this.Menge.Name = "Menge";
            // 
            // Artikelnummer
            // 
            this.Artikelnummer.HeaderText = "Artikelnummer";
            this.Artikelnummer.Name = "Artikelnummer";
            // 
            // Artikelname
            // 
            this.Artikelname.HeaderText = "Artikelname";
            this.Artikelname.Name = "Artikelname";
            // 
            // VKE
            // 
            this.VKE.HeaderText = "VKE";
            this.VKE.Name = "VKE";
            // 
            // PreisVK
            // 
            this.PreisVK.HeaderText = "PreisVK";
            this.PreisVK.Name = "PreisVK";
            // 
            // Summe
            // 
            this.Summe.HeaderText = "Summe";
            this.Summe.Name = "Summe";
            // 
            // UserControlBestellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxBestelldatum);
            this.Controls.Add(this.textBoxBestellungsnummer);
            this.Controls.Add(this.textBoxKundennummer);
            this.Controls.Add(this.buttonNeueBestellung);
            this.Controls.Add(this.buttonAendern);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonNeu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlBestellung";
            this.Size = new System.Drawing.Size(809, 348);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNeu;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAendern;
        private System.Windows.Forms.Button buttonNeueBestellung;
        private System.Windows.Forms.TextBox textBoxKundennummer;
        private System.Windows.Forms.TextBox textBoxBestellungsnummer;
        private System.Windows.Forms.TextBox textBoxBestelldatum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bestellpositionsnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelname;
        private System.Windows.Forms.DataGridViewTextBoxColumn VKE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreisVK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summe;
    }
}
