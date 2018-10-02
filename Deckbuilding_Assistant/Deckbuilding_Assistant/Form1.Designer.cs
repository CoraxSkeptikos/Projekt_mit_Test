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
            this.TBbibliothek.Location = new System.Drawing.Point(47, 77);
            this.TBbibliothek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBbibliothek.Name = "TBbibliothek";
            this.TBbibliothek.Size = new System.Drawing.Size(164, 28);
            this.TBbibliothek.TabIndex = 0;
            // 
            // TBcmc
            // 
            this.TBcmc.Location = new System.Drawing.Point(47, 176);
            this.TBcmc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBcmc.Name = "TBcmc";
            this.TBcmc.Size = new System.Drawing.Size(164, 28);
            this.TBcmc.TabIndex = 1;
            // 
            // TBlaender
            // 
            this.TBlaender.Location = new System.Drawing.Point(47, 272);
            this.TBlaender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBlaender.Name = "TBlaender";
            this.TBlaender.Size = new System.Drawing.Size(164, 28);
            this.TBlaender.TabIndex = 2;
            // 
            // LBLbibliothek
            // 
            this.LBLbibliothek.AutoSize = true;
            this.LBLbibliothek.Location = new System.Drawing.Point(47, 44);
            this.LBLbibliothek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLbibliothek.Name = "LBLbibliothek";
            this.LBLbibliothek.Size = new System.Drawing.Size(124, 22);
            this.LBLbibliothek.TabIndex = 3;
            this.LBLbibliothek.Text = "Bibliotheksgröße";
            // 
            // LBLcmc
            // 
            this.LBLcmc.AutoSize = true;
            this.LBLcmc.Location = new System.Drawing.Point(47, 144);
            this.LBLcmc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLcmc.Name = "LBLcmc";
            this.LBLcmc.Size = new System.Drawing.Size(95, 22);
            this.LBLcmc.TabIndex = 4;
            this.LBLcmc.Text = "Manakosten";
            // 
            // LBLlaender
            // 
            this.LBLlaender.AutoSize = true;
            this.LBLlaender.Location = new System.Drawing.Point(47, 240);
            this.LBLlaender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLlaender.Name = "LBLlaender";
            this.LBLlaender.Size = new System.Drawing.Size(152, 22);
            this.LBLlaender.TabIndex = 5;
            this.LBLlaender.Text = "Länder in Bibliothek";
            // 
            // LBLwahrscheinlichkeitsbezeichnung
            // 
            this.LBLwahrscheinlichkeitsbezeichnung.AutoSize = true;
            this.LBLwahrscheinlichkeitsbezeichnung.Location = new System.Drawing.Point(167, 349);
            this.LBLwahrscheinlichkeitsbezeichnung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLwahrscheinlichkeitsbezeichnung.Name = "LBLwahrscheinlichkeitsbezeichnung";
            this.LBLwahrscheinlichkeitsbezeichnung.Size = new System.Drawing.Size(142, 22);
            this.LBLwahrscheinlichkeitsbezeichnung.TabIndex = 6;
            this.LBLwahrscheinlichkeitsbezeichnung.Text = "Wahrscheinlichkeit";
            // 
            // LBLwahrscheinlichkeitswert
            // 
            this.LBLwahrscheinlichkeitswert.AutoSize = true;
            this.LBLwahrscheinlichkeitswert.Location = new System.Drawing.Point(238, 384);
            this.LBLwahrscheinlichkeitswert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLwahrscheinlichkeitswert.Name = "LBLwahrscheinlichkeitswert";
            this.LBLwahrscheinlichkeitswert.Size = new System.Drawing.Size(71, 22);
            this.LBLwahrscheinlichkeitswert.TabIndex = 7;
            this.LBLwahrscheinlichkeitswert.Text = "XX,XX%";
            // 
            // BTberechnen
            // 
            this.BTberechnen.BackColor = System.Drawing.Color.RosyBrown;
            this.BTberechnen.ForeColor = System.Drawing.Color.Black;
            this.BTberechnen.Location = new System.Drawing.Point(278, 87);
            this.BTberechnen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTberechnen.Name = "BTberechnen";
            this.BTberechnen.Size = new System.Drawing.Size(163, 207);
            this.BTberechnen.TabIndex = 8;
            this.BTberechnen.Text = "Berechnen";
            this.BTberechnen.UseVisualStyleBackColor = false;
            this.BTberechnen.Click += new System.EventHandler(this.BTberechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(502, 437);
            this.Controls.Add(this.BTberechnen);
            this.Controls.Add(this.LBLwahrscheinlichkeitswert);
            this.Controls.Add(this.LBLwahrscheinlichkeitsbezeichnung);
            this.Controls.Add(this.LBLlaender);
            this.Controls.Add(this.LBLcmc);
            this.Controls.Add(this.LBLbibliothek);
            this.Controls.Add(this.TBlaender);
            this.Controls.Add(this.TBcmc);
            this.Controls.Add(this.TBbibliothek);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

