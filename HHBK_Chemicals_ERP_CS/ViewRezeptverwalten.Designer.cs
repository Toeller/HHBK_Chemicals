
namespace HHBK_Chemicals_ERP_CS
{
    partial class ViewRezeptverwalten
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
            this.buttonEingeben = new System.Windows.Forms.Button();
            this.buttonÄndern = new System.Windows.Forms.Button();
            this.buttonLöschen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRezept = new System.Windows.Forms.TextBox();
            this.buttonRezepteAnzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEingeben
            // 
            this.buttonEingeben.Location = new System.Drawing.Point(12, 32);
            this.buttonEingeben.Name = "buttonEingeben";
            this.buttonEingeben.Size = new System.Drawing.Size(75, 23);
            this.buttonEingeben.TabIndex = 0;
            this.buttonEingeben.Text = "Eingeben";
            this.buttonEingeben.UseVisualStyleBackColor = true;
            // 
            // buttonÄndern
            // 
            this.buttonÄndern.Location = new System.Drawing.Point(93, 32);
            this.buttonÄndern.Name = "buttonÄndern";
            this.buttonÄndern.Size = new System.Drawing.Size(75, 23);
            this.buttonÄndern.TabIndex = 1;
            this.buttonÄndern.Text = "Ändern";
            this.buttonÄndern.UseVisualStyleBackColor = true;
            // 
            // buttonLöschen
            // 
            this.buttonLöschen.Location = new System.Drawing.Point(174, 32);
            this.buttonLöschen.Name = "buttonLöschen";
            this.buttonLöschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLöschen.TabIndex = 2;
            this.buttonLöschen.Text = "Löschen";
            this.buttonLöschen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rezept:";
            // 
            // textBoxRezept
            // 
            this.textBoxRezept.Location = new System.Drawing.Point(59, 6);
            this.textBoxRezept.Name = "textBoxRezept";
            this.textBoxRezept.Size = new System.Drawing.Size(190, 20);
            this.textBoxRezept.TabIndex = 4;
            // 
            // buttonRezepteAnzeigen
            // 
            this.buttonRezepteAnzeigen.Location = new System.Drawing.Point(12, 61);
            this.buttonRezepteAnzeigen.Name = "buttonRezepteAnzeigen";
            this.buttonRezepteAnzeigen.Size = new System.Drawing.Size(237, 23);
            this.buttonRezepteAnzeigen.TabIndex = 5;
            this.buttonRezepteAnzeigen.Text = "Rezepte anzeigen";
            this.buttonRezepteAnzeigen.UseVisualStyleBackColor = true;
            // 
            // ViewRezeptverwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 102);
            this.Controls.Add(this.buttonRezepteAnzeigen);
            this.Controls.Add(this.textBoxRezept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLöschen);
            this.Controls.Add(this.buttonÄndern);
            this.Controls.Add(this.buttonEingeben);
            this.Name = "ViewRezeptverwalten";
            this.Text = "Rezeptverwalten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEingeben;
        private System.Windows.Forms.Button buttonÄndern;
        private System.Windows.Forms.Button buttonLöschen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRezept;
        private System.Windows.Forms.Button buttonRezepteAnzeigen;
    }
}