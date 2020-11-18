
namespace HHBK_Chemicals_ERP_CS
{
    partial class Julian
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
            this.labelJulian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelJulian
            // 
            this.labelJulian.AutoSize = true;
            this.labelJulian.Location = new System.Drawing.Point(535, 118);
            this.labelJulian.Name = "labelJulian";
            this.labelJulian.Size = new System.Drawing.Size(34, 13);
            this.labelJulian.TabIndex = 0;
            this.labelJulian.Text = "Julian";
            // 
            // Julian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelJulian);
            this.Name = "Julian";
            this.Text = "Julian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJulian;
    }
}