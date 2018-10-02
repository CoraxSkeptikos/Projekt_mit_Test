namespace ABC_Analyse_Tool
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MengeKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MengeProzent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreisProKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WertAbsolut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WertProzent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.labelWertanteilA = new System.Windows.Forms.Label();
            this.labelWertanteilC = new System.Windows.Forms.Label();
            this.labelValueA = new System.Windows.Forms.Label();
            this.labelValueC = new System.Windows.Forms.Label();
            this.buttonDruck = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.labelABC = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bezeichnung,
            this.MengeKg,
            this.MengeProzent,
            this.PreisProKg,
            this.WertAbsolut,
            this.WertProzent,
            this.Kategorie});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // Bezeichnung
            // 
            this.Bezeichnung.HeaderText = "Bezeichnung";
            this.Bezeichnung.Name = "Bezeichnung";
            this.Bezeichnung.ReadOnly = true;
            // 
            // MengeKg
            // 
            this.MengeKg.HeaderText = "Menge in kg";
            this.MengeKg.Name = "MengeKg";
            this.MengeKg.ReadOnly = true;
            // 
            // MengeProzent
            // 
            this.MengeProzent.HeaderText = "Menge in %";
            this.MengeProzent.Name = "MengeProzent";
            this.MengeProzent.ReadOnly = true;
            // 
            // PreisProKg
            // 
            this.PreisProKg.HeaderText = "Preis pro kg";
            this.PreisProKg.Name = "PreisProKg";
            this.PreisProKg.ReadOnly = true;
            // 
            // WertAbsolut
            // 
            this.WertAbsolut.HeaderText = "Wert absolut";
            this.WertAbsolut.Name = "WertAbsolut";
            this.WertAbsolut.ReadOnly = true;
            // 
            // WertProzent
            // 
            this.WertProzent.HeaderText = "Wert in %";
            this.WertProzent.Name = "WertProzent";
            this.WertProzent.ReadOnly = true;
            // 
            // Kategorie
            // 
            this.Kategorie.HeaderText = "Kategorie";
            this.Kategorie.Name = "Kategorie";
            this.Kategorie.ReadOnly = true;
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(12, 395);
            this.trackBarA.Maximum = 90;
            this.trackBarA.Minimum = 1;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(744, 45);
            this.trackBarA.TabIndex = 1;
            this.trackBarA.Value = 70;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(12, 455);
            this.trackBarC.Maximum = 30;
            this.trackBarC.Minimum = 1;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(744, 45);
            this.trackBarC.TabIndex = 2;
            this.trackBarC.Value = 10;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBarC_Scroll);
            // 
            // labelWertanteilA
            // 
            this.labelWertanteilA.AutoSize = true;
            this.labelWertanteilA.Location = new System.Drawing.Point(12, 379);
            this.labelWertanteilA.Name = "labelWertanteilA";
            this.labelWertanteilA.Size = new System.Drawing.Size(103, 13);
            this.labelWertanteilA.TabIndex = 3;
            this.labelWertanteilA.Text = "Werteanteil A-Güter:";
            // 
            // labelWertanteilC
            // 
            this.labelWertanteilC.AutoSize = true;
            this.labelWertanteilC.Location = new System.Drawing.Point(9, 439);
            this.labelWertanteilC.Name = "labelWertanteilC";
            this.labelWertanteilC.Size = new System.Drawing.Size(103, 13);
            this.labelWertanteilC.TabIndex = 4;
            this.labelWertanteilC.Text = "Werteanteil C-Güter:";
            // 
            // labelValueA
            // 
            this.labelValueA.AutoSize = true;
            this.labelValueA.Location = new System.Drawing.Point(116, 379);
            this.labelValueA.Name = "labelValueA";
            this.labelValueA.Size = new System.Drawing.Size(19, 13);
            this.labelValueA.TabIndex = 5;
            this.labelValueA.Text = "70";
            // 
            // labelValueC
            // 
            this.labelValueC.AutoSize = true;
            this.labelValueC.Location = new System.Drawing.Point(116, 439);
            this.labelValueC.Name = "labelValueC";
            this.labelValueC.Size = new System.Drawing.Size(19, 13);
            this.labelValueC.TabIndex = 6;
            this.labelValueC.Text = "10";
            // 
            // buttonDruck
            // 
            this.buttonDruck.Location = new System.Drawing.Point(766, 429);
            this.buttonDruck.Name = "buttonDruck";
            this.buttonDruck.Size = new System.Drawing.Size(146, 44);
            this.buttonDruck.TabIndex = 16;
            this.buttonDruck.Text = "Drucken";
            this.buttonDruck.UseVisualStyleBackColor = true;
            this.buttonDruck.Click += new System.EventHandler(this.buttonDruck_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // labelABC
            // 
            this.labelABC.AutoSize = true;
            this.labelABC.Location = new System.Drawing.Point(755, 487);
            this.labelABC.Name = "labelABC";
            this.labelABC.Size = new System.Drawing.Size(94, 13);
            this.labelABC.TabIndex = 17;
            this.labelABC.Text = "ABC-Analyse vom:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(851, 487);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(61, 13);
            this.labelDatum.TabIndex = 18;
            this.labelDatum.Text = "00.00.0000";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(758, 33);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Mengenanteile";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series3.YValuesPerPoint = 2;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(154, 334);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Mengenanteile:";
            this.chart1.Titles.Add(title3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 506);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelABC);
            this.Controls.Add(this.buttonDruck);
            this.Controls.Add(this.labelValueC);
            this.Controls.Add(this.labelValueA);
            this.Controls.Add(this.labelWertanteilC);
            this.Controls.Add(this.labelWertanteilA);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "ABC-Analyse";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MengeKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn MengeProzent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreisProKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn WertAbsolut;
        private System.Windows.Forms.DataGridViewTextBoxColumn WertProzent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorie;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.Label labelWertanteilA;
        private System.Windows.Forms.Label labelWertanteilC;
        private System.Windows.Forms.Label labelValueA;
        private System.Windows.Forms.Label labelValueC;
        private System.Windows.Forms.Button buttonDruck;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label labelABC;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

