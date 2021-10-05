
namespace HHBK_Chemicals_ERP_CS
{
    partial class co
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
            this.comboBoxRechnungsnummer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKundennummer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRechnungssumme = new System.Windows.Forms.TextBox();
            this.textBoxSummeUeberweisung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechnungsnummer";
            // 
            // comboBoxRechnungsnummer
            // 
            this.comboBoxRechnungsnummer.FormattingEnabled = true;
            this.comboBoxRechnungsnummer.Location = new System.Drawing.Point(109, 3);
            this.comboBoxRechnungsnummer.Name = "comboBoxRechnungsnummer";
            this.comboBoxRechnungsnummer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRechnungsnummer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kundennummer";
            // 
            // comboBoxKundennummer
            // 
            this.comboBoxKundennummer.FormattingEnabled = true;
            this.comboBoxKundennummer.Location = new System.Drawing.Point(109, 30);
            this.comboBoxKundennummer.Name = "comboBoxKundennummer";
            this.comboBoxKundennummer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKundennummer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rechnungssumme";
            // 
            // textBoxRechnungssumme
            // 
            this.textBoxRechnungssumme.Location = new System.Drawing.Point(109, 58);
            this.textBoxRechnungssumme.Name = "textBoxRechnungssumme";
            this.textBoxRechnungssumme.Size = new System.Drawing.Size(121, 20);
            this.textBoxRechnungssumme.TabIndex = 5;
            // 
            // textBoxSummeUeberweisung
            // 
            this.textBoxSummeUeberweisung.Location = new System.Drawing.Point(109, 85);
            this.textBoxSummeUeberweisung.Name = "textBoxSummeUeberweisung";
            this.textBoxSummeUeberweisung.Size = new System.Drawing.Size(121, 20);
            this.textBoxSummeUeberweisung.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Überwiesen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "offen";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // co
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSummeUeberweisung);
            this.Controls.Add(this.textBoxRechnungssumme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxKundennummer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRechnungsnummer);
            this.Controls.Add(this.label1);
            this.Name = "co";
            this.Size = new System.Drawing.Size(235, 139);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRechnungsnummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKundennummer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRechnungssumme;
        private System.Windows.Forms.TextBox textBoxSummeUeberweisung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}
