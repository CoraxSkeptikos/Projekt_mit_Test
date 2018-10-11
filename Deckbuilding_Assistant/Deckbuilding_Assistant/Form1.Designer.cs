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
            this.LBLcmctb = new System.Windows.Forms.Label();
            this.LBLlaender = new System.Windows.Forms.Label();
            this.LBLwahrscheinlichkeitsbzch = new System.Windows.Forms.Label();
            this.BTberechnen = new System.Windows.Forms.Button();
            this.LBLmanakostenbzch = new System.Windows.Forms.Label();
            this.LBLmanakostenwert = new System.Windows.Forms.Label();
            this.LBLsatzmittelteil = new System.Windows.Forms.Label();
            this.LBLrundebzch = new System.Windows.Forms.Label();
            this.LBLrundewert = new System.Windows.Forms.Label();
            this.LBLsatzende = new System.Windows.Forms.Label();
            this.TBwahrscheinlichkeit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBbibliothek
            // 
            this.TBbibliothek.Location = new System.Drawing.Point(47, 77);
            this.TBbibliothek.Margin = new System.Windows.Forms.Padding(4);
            this.TBbibliothek.Name = "TBbibliothek";
            this.TBbibliothek.Size = new System.Drawing.Size(164, 29);
            this.TBbibliothek.TabIndex = 0;
            // 
            // TBcmc
            // 
            this.TBcmc.Location = new System.Drawing.Point(47, 176);
            this.TBcmc.Margin = new System.Windows.Forms.Padding(4);
            this.TBcmc.Name = "TBcmc";
            this.TBcmc.Size = new System.Drawing.Size(164, 29);
            this.TBcmc.TabIndex = 1;
            // 
            // TBlaender
            // 
            this.TBlaender.Location = new System.Drawing.Point(47, 272);
            this.TBlaender.Margin = new System.Windows.Forms.Padding(4);
            this.TBlaender.Name = "TBlaender";
            this.TBlaender.Size = new System.Drawing.Size(164, 29);
            this.TBlaender.TabIndex = 2;
            // 
            // LBLbibliothek
            // 
            this.LBLbibliothek.AutoSize = true;
            this.LBLbibliothek.Location = new System.Drawing.Point(47, 44);
            this.LBLbibliothek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLbibliothek.Name = "LBLbibliothek";
            this.LBLbibliothek.Size = new System.Drawing.Size(150, 24);
            this.LBLbibliothek.TabIndex = 3;
            this.LBLbibliothek.Text = "Bibliotheksgröße";
            // 
            // LBLcmctb
            // 
            this.LBLcmctb.AutoSize = true;
            this.LBLcmctb.Location = new System.Drawing.Point(47, 144);
            this.LBLcmctb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLcmctb.Name = "LBLcmctb";
            this.LBLcmctb.Size = new System.Drawing.Size(112, 24);
            this.LBLcmctb.TabIndex = 4;
            this.LBLcmctb.Text = "Manakosten";
            // 
            // LBLlaender
            // 
            this.LBLlaender.AutoSize = true;
            this.LBLlaender.Location = new System.Drawing.Point(47, 240);
            this.LBLlaender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLlaender.Name = "LBLlaender";
            this.LBLlaender.Size = new System.Drawing.Size(175, 24);
            this.LBLlaender.TabIndex = 5;
            this.LBLlaender.Text = "Länder in Bibliothek";
            // 
            // LBLwahrscheinlichkeitsbzch
            // 
            this.LBLwahrscheinlichkeitsbzch.AutoSize = true;
            this.LBLwahrscheinlichkeitsbzch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLwahrscheinlichkeitsbzch.Location = new System.Drawing.Point(13, 314);
            this.LBLwahrscheinlichkeitsbzch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLwahrscheinlichkeitsbzch.Name = "LBLwahrscheinlichkeitsbzch";
            this.LBLwahrscheinlichkeitsbzch.Size = new System.Drawing.Size(315, 20);
            this.LBLwahrscheinlichkeitsbzch.TabIndex = 6;
            this.LBLwahrscheinlichkeitsbzch.Text = "Die Wahrscheinlichkeit einen Zauberspruch";
            // 
            // BTberechnen
            // 
            this.BTberechnen.BackColor = System.Drawing.Color.RosyBrown;
            this.BTberechnen.ForeColor = System.Drawing.Color.Black;
            this.BTberechnen.Location = new System.Drawing.Point(278, 87);
            this.BTberechnen.Margin = new System.Windows.Forms.Padding(4);
            this.BTberechnen.Name = "BTberechnen";
            this.BTberechnen.Size = new System.Drawing.Size(163, 207);
            this.BTberechnen.TabIndex = 8;
            this.BTberechnen.Text = "Berechnen";
            this.BTberechnen.UseVisualStyleBackColor = false;
            this.BTberechnen.Click += new System.EventHandler(this.BTberechnen_Click);
            // 
            // LBLmanakostenbzch
            // 
            this.LBLmanakostenbzch.AutoSize = true;
            this.LBLmanakostenbzch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLmanakostenbzch.Location = new System.Drawing.Point(13, 334);
            this.LBLmanakostenbzch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLmanakostenbzch.Name = "LBLmanakostenbzch";
            this.LBLmanakostenbzch.Size = new System.Drawing.Size(243, 20);
            this.LBLmanakostenbzch.TabIndex = 9;
            this.LBLmanakostenbzch.Text = "von umgewandelten Manakosten";
            // 
            // LBLmanakostenwert
            // 
            this.LBLmanakostenwert.AutoSize = true;
            this.LBLmanakostenwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLmanakostenwert.Location = new System.Drawing.Point(264, 334);
            this.LBLmanakostenwert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLmanakostenwert.Name = "LBLmanakostenwert";
            this.LBLmanakostenwert.Size = new System.Drawing.Size(20, 20);
            this.LBLmanakostenwert.TabIndex = 10;
            this.LBLmanakostenwert.Text = "X";
            // 
            // LBLsatzmittelteil
            // 
            this.LBLsatzmittelteil.AutoSize = true;
            this.LBLsatzmittelteil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLsatzmittelteil.Location = new System.Drawing.Point(13, 354);
            this.LBLsatzmittelteil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLsatzmittelteil.Name = "LBLsatzmittelteil";
            this.LBLsatzmittelteil.Size = new System.Drawing.Size(458, 20);
            this.LBLsatzmittelteil.TabIndex = 11;
            this.LBLsatzmittelteil.Text = "spielen zu können (angenommen er befindet sich auf der Hand)";
            // 
            // LBLrundebzch
            // 
            this.LBLrundebzch.AutoSize = true;
            this.LBLrundebzch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLrundebzch.Location = new System.Drawing.Point(13, 374);
            this.LBLrundebzch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLrundebzch.Name = "LBLrundebzch";
            this.LBLrundebzch.Size = new System.Drawing.Size(106, 20);
            this.LBLrundebzch.TabIndex = 12;
            this.LBLrundebzch.Text = "liegt in Runde";
            // 
            // LBLrundewert
            // 
            this.LBLrundewert.AutoSize = true;
            this.LBLrundewert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLrundewert.Location = new System.Drawing.Point(127, 374);
            this.LBLrundewert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLrundewert.Name = "LBLrundewert";
            this.LBLrundewert.Size = new System.Drawing.Size(20, 20);
            this.LBLrundewert.TabIndex = 13;
            this.LBLrundewert.Text = "X";
            // 
            // LBLsatzende
            // 
            this.LBLsatzende.AutoSize = true;
            this.LBLsatzende.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLsatzende.Location = new System.Drawing.Point(155, 374);
            this.LBLsatzende.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLsatzende.Name = "LBLsatzende";
            this.LBLsatzende.Size = new System.Drawing.Size(34, 20);
            this.LBLsatzende.TabIndex = 14;
            this.LBLsatzende.Text = "bei:";
            // 
            // TBwahrscheinlichkeit
            // 
            this.TBwahrscheinlichkeit.BackColor = System.Drawing.Color.PeachPuff;
            this.TBwahrscheinlichkeit.Location = new System.Drawing.Point(196, 374);
            this.TBwahrscheinlichkeit.Name = "TBwahrscheinlichkeit";
            this.TBwahrscheinlichkeit.ReadOnly = true;
            this.TBwahrscheinlichkeit.Size = new System.Drawing.Size(100, 29);
            this.TBwahrscheinlichkeit.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(483, 424);
            this.Controls.Add(this.TBwahrscheinlichkeit);
            this.Controls.Add(this.LBLsatzende);
            this.Controls.Add(this.LBLrundewert);
            this.Controls.Add(this.LBLrundebzch);
            this.Controls.Add(this.LBLsatzmittelteil);
            this.Controls.Add(this.LBLmanakostenwert);
            this.Controls.Add(this.LBLmanakostenbzch);
            this.Controls.Add(this.BTberechnen);
            this.Controls.Add(this.LBLwahrscheinlichkeitsbzch);
            this.Controls.Add(this.LBLlaender);
            this.Controls.Add(this.LBLcmctb);
            this.Controls.Add(this.LBLbibliothek);
            this.Controls.Add(this.TBlaender);
            this.Controls.Add(this.TBcmc);
            this.Controls.Add(this.TBbibliothek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label LBLcmctb;
        private System.Windows.Forms.Label LBLlaender;
        private System.Windows.Forms.Label LBLwahrscheinlichkeitsbzch;
        private System.Windows.Forms.Button BTberechnen;
        private System.Windows.Forms.Label LBLmanakostenbzch;
        private System.Windows.Forms.Label LBLmanakostenwert;
        private System.Windows.Forms.Label LBLsatzmittelteil;
        private System.Windows.Forms.Label LBLrundebzch;
        private System.Windows.Forms.Label LBLrundewert;
        private System.Windows.Forms.Label LBLsatzende;
        private System.Windows.Forms.TextBox TBwahrscheinlichkeit;
    }
}

