
namespace HHBK_Chemicals_ERP_CS
{
    partial class ViewRechnungErstellen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelHHBK_Chemicals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(12, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 119);
            this.textBox1.TabIndex = 0;
            // 
            // labelHHBK_Chemicals
            // 
            this.labelHHBK_Chemicals.AutoSize = true;
            this.labelHHBK_Chemicals.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHHBK_Chemicals.Location = new System.Drawing.Point(226, 9);
            this.labelHHBK_Chemicals.Name = "labelHHBK_Chemicals";
            this.labelHHBK_Chemicals.Size = new System.Drawing.Size(243, 33);
            this.labelHHBK_Chemicals.TabIndex = 1;
            this.labelHHBK_Chemicals.Text = "HHBK-Chemicals";
            this.labelHHBK_Chemicals.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewRechnungErstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 623);
            this.Controls.Add(this.labelHHBK_Chemicals);
            this.Controls.Add(this.textBox1);
            this.Name = "ViewRechnungErstellen";
            this.Text = "ViewRechnungErstellen";
            this.Load += new System.EventHandler(this.ViewRechnungErstellen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelHHBK_Chemicals;
    }
}