
namespace HHBK_Chemicals_ERP_CS
{
    partial class UserControlReklamation
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
            this.groupBoxReklamationsgrund = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxBestellnummer = new System.Windows.Forms.ComboBox();
            this.groupBoxReklamationsgrund.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestellnummer";
            // 
            // groupBoxReklamationsgrund
            // 
            this.groupBoxReklamationsgrund.Controls.Add(this.textBox1);
            this.groupBoxReklamationsgrund.Controls.Add(this.radioButton3);
            this.groupBoxReklamationsgrund.Controls.Add(this.radioButton2);
            this.groupBoxReklamationsgrund.Controls.Add(this.radioButton1);
            this.groupBoxReklamationsgrund.Location = new System.Drawing.Point(7, 43);
            this.groupBoxReklamationsgrund.Name = "groupBoxReklamationsgrund";
            this.groupBoxReklamationsgrund.Size = new System.Drawing.Size(215, 168);
            this.groupBoxReklamationsgrund.TabIndex = 2;
            this.groupBoxReklamationsgrund.TabStop = false;
            this.groupBoxReklamationsgrund.Text = "Reklamationsgrund";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "falscher Artikel";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "zu spät geliefert";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(99, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "sonstiger Grund";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 72);
            this.textBox1.TabIndex = 3;
            // 
            // comboBoxBestellnummer
            // 
            this.comboBoxBestellnummer.FormattingEnabled = true;
            this.comboBoxBestellnummer.Location = new System.Drawing.Point(86, 4);
            this.comboBoxBestellnummer.Name = "comboBoxBestellnummer";
            this.comboBoxBestellnummer.Size = new System.Drawing.Size(114, 21);
            this.comboBoxBestellnummer.TabIndex = 3;
            // 
            // UserControlReklamation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxBestellnummer);
            this.Controls.Add(this.groupBoxReklamationsgrund);
            this.Controls.Add(this.label1);
            this.Name = "UserControlReklamation";
            this.Size = new System.Drawing.Size(230, 219);
            this.groupBoxReklamationsgrund.ResumeLayout(false);
            this.groupBoxReklamationsgrund.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxReklamationsgrund;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBoxBestellnummer;
    }
}
