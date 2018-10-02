namespace Deckbuilding_Assistant
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBbibliothek = new System.Windows.Forms.TextBox();
            this.TBcmc = new System.Windows.Forms.TextBox();
            this.TBlaender = new System.Windows.Forms.TextBox();
            this.LBLbibliothek = new System.Windows.Forms.Label();
            this.LBLcmc = new System.Windows.Forms.Label();
            this.LBLlaender = new System.Windows.Forms.Label();
            this.LBLwahrscheinlichkeitsbezeichnung = new System.Windows.Forms.Label();
            this.LBLwahrscheinlichkeitswert = new System.Windows.Forms.Label();
            this.BTberechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBbibliothek
            // 
            this.TBbibliothek.Location = new System.Drawing.Point(49, 77);
            this.TBbibliothek.Name = "TBbibliothek";
            this.TBbibliothek.Size = new System.Drawing.Size(100, 20);
            this.TBbibliothek.TabIndex = 0;
            // 
            // TBcmc
            // 
            this.TBcmc.Location = new System.Drawing.Point(49, 136);
            this.TBcmc.Name = "TBcmc";
            this.TBcmc.Size = new System.Drawing.Size(100, 20);
            this.TBcmc.TabIndex = 1;
            // 
            // TBlaender
            // 
            this.TBlaender.Location = new System.Drawing.Point(49, 192);
            this.TBlaender.Name = "TBlaender";
            this.TBlaender.Size = new System.Drawing.Size(100, 20);
            this.TBlaender.TabIndex = 2;
            // 
            // LBLbibliothek
            // 
            this.LBLbibliothek.AutoSize = true;
            this.LBLbibliothek.Location = new System.Drawing.Point(49, 58);
            this.LBLbibliothek.Name = "LBLbibliothek";
            this.LBLbibliothek.Size = new System.Drawing.Size(85, 13);
            this.LBLbibliothek.TabIndex = 3;
            this.LBLbibliothek.Text = "Bibliotheksgröße";
            // 
            // LBLcmc
            // 
            this.LBLcmc.AutoSize = true;
            this.LBLcmc.Location = new System.Drawing.Point(49, 117);
            this.LBLcmc.Name = "LBLcmc";
            this.LBLcmc.Size = new System.Drawing.Size(66, 13);
            this.LBLcmc.TabIndex = 4;
            this.LBLcmc.Text = "Manakosten";
            // 
            // LBLlaender
            // 
            this.LBLlaender.AutoSize = true;
            this.LBLlaender.Location = new System.Drawing.Point(49, 173);
            this.LBLlaender.Name = "LBLlaender";
            this.LBLlaender.Size = new System.Drawing.Size(100, 13);
            this.LBLlaender.TabIndex = 5;
            this.LBLlaender.Text = "Länder in Bibliothek";
            // 
            // LBLwahrscheinlichkeitsbezeichnung
            // 
            this.LBLwahrscheinlichkeitsbezeichnung.AutoSize = true;
            this.LBLwahrscheinlichkeitsbezeichnung.Location = new System.Drawing.Point(49, 244);
            this.LBLwahrscheinlichkeitsbezeichnung.Name = "LBLwahrscheinlichkeitsbezeichnung";
            this.LBLwahrscheinlichkeitsbezeichnung.Size = new System.Drawing.Size(97, 13);
            this.LBLwahrscheinlichkeitsbezeichnung.TabIndex = 6;
            this.LBLwahrscheinlichkeitsbezeichnung.Text = "Wahrscheinlichkeit";
            // 
            // LBLwahrscheinlichkeitswert
            // 
            this.LBLwahrscheinlichkeitswert.AutoSize = true;
            this.LBLwahrscheinlichkeitswert.Location = new System.Drawing.Point(103, 267);
            this.LBLwahrscheinlichkeitswert.Name = "LBLwahrscheinlichkeitswert";
            this.LBLwahrscheinlichkeitswert.Size = new System.Drawing.Size(46, 13);
            this.LBLwahrscheinlichkeitswert.TabIndex = 7;
            this.LBLwahrscheinlichkeitswert.Text = "XX,XX%";
            // 
            // BTberechnen
            // 
            this.BTberechnen.Location = new System.Drawing.Point(187, 77);
            this.BTberechnen.Name = "BTberechnen";
            this.BTberechnen.Size = new System.Drawing.Size(110, 135);
            this.BTberechnen.TabIndex = 8;
            this.BTberechnen.Text = "Berechnen";
            this.BTberechnen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 304);
            this.Controls.Add(this.BTberechnen);
            this.Controls.Add(this.LBLwahrscheinlichkeitswert);
            this.Controls.Add(this.LBLwahrscheinlichkeitsbezeichnung);
            this.Controls.Add(this.LBLlaender);
            this.Controls.Add(this.LBLcmc);
            this.Controls.Add(this.LBLbibliothek);
            this.Controls.Add(this.TBlaender);
            this.Controls.Add(this.TBcmc);
            this.Controls.Add(this.TBbibliothek);
            this.Name = "Form1";
            this.Text = "Deckbau Assistent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBbibliothek;
        private System.Windows.Forms.TextBox TBcmc;
        private System.Windows.Forms.TextBox TBlaender;
        private System.Windows.Forms.Label LBLbibliothek;
        private System.Windows.Forms.Label LBLcmc;
        private System.Windows.Forms.Label LBLlaender;
        private System.Windows.Forms.Label LBLwahrscheinlichkeitsbezeichnung;
        private System.Windows.Forms.Label LBLwahrscheinlichkeitswert;
        private System.Windows.Forms.Button BTberechnen;
    }
}

