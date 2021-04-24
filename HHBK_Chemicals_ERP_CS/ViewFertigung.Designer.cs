namespace HHBK_Chemicals_ERP_CS
{
    partial class ViewFertigung
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
            this.labelStartzeit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelHerstellungsdatum = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelStartzeit
            // 
            this.labelStartzeit.AutoSize = true;
            this.labelStartzeit.Location = new System.Drawing.Point(69, 45);
            this.labelStartzeit.Name = "labelStartzeit";
            this.labelStartzeit.Size = new System.Drawing.Size(45, 13);
            this.labelStartzeit.TabIndex = 0;
            this.labelStartzeit.Text = "Startzeit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelHerstellungsdatum
            // 
            this.labelHerstellungsdatum.AutoSize = true;
            this.labelHerstellungsdatum.Location = new System.Drawing.Point(20, 119);
            this.labelHerstellungsdatum.Name = "labelHerstellungsdatum";
            this.labelHerstellungsdatum.Size = new System.Drawing.Size(94, 13);
            this.labelHerstellungsdatum.TabIndex = 2;
            this.labelHerstellungsdatum.Text = "Herstellungsdatum";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // ViewFertigung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelHerstellungsdatum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelStartzeit);
            this.Name = "ViewFertigung";
            this.Text = "ViewFertigung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartzeit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelHerstellungsdatum;
        private System.Windows.Forms.TextBox textBox2;
    }
}