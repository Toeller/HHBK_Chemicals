namespace HHBK_Chemicals_ERP_CS
{
    partial class ViewLagereingang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lagerpositionsnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grundstoffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grundstoffmenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gundstoffeinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lagerpositionsnummer,
            this.Grundstoffname,
            this.Grundstoffmenge,
            this.Gundstoffeinheit});
            this.dataGridView1.Location = new System.Drawing.Point(168, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 281);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Lagerpositionsnummer
            // 
            this.Lagerpositionsnummer.HeaderText = "Nr.";
            this.Lagerpositionsnummer.Name = "Lagerpositionsnummer";
            this.Lagerpositionsnummer.ReadOnly = true;
            this.Lagerpositionsnummer.Width = 40;
            // 
            // Grundstoffname
            // 
            this.Grundstoffname.HeaderText = "Grundstoffname";
            this.Grundstoffname.Name = "Grundstoffname";
            // 
            // Grundstoffmenge
            // 
            this.Grundstoffmenge.HeaderText = "Grundstoffmenge";
            this.Grundstoffmenge.Name = "Grundstoffmenge";
            // 
            // Gundstoffeinheit
            // 
            this.Gundstoffeinheit.HeaderText = "Gundstoffeinheit";
            this.Gundstoffeinheit.Name = "Gundstoffeinheit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ViewLagereingang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewLagereingang";
            this.Text = "ViewLagereingang";
            this.Load += new System.EventHandler(this.ViewLagereingang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lagerpositionsnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grundstoffname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grundstoffmenge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gundstoffeinheit;
        private System.Windows.Forms.Button button1;
    }
}