namespace Der_Kran
{
    partial class Der_Kran
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
            this.Rumpf = new System.Windows.Forms.Panel();
            this.KranHals = new System.Windows.Forms.Panel();
            this.AuslegerPanel = new System.Windows.Forms.Panel();
            this.Haken = new System.Windows.Forms.Panel();
            this.btc_HakenAus = new System.Windows.Forms.Button();
            this.btc_HakenEin = new System.Windows.Forms.Button();
            this.btc_AuslegerAus = new System.Windows.Forms.Button();
            this.btc_AuslegerEin = new System.Windows.Forms.Button();
            this.btc_KranRechts = new System.Windows.Forms.Button();
            this.btc_KranLinks = new System.Windows.Forms.Button();
            this.btc_KranHalsAusfahren = new System.Windows.Forms.Button();
            this.btc_KranHalsEinfahren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rumpf
            // 
            this.Rumpf.BackColor = System.Drawing.Color.Black;
            this.Rumpf.Location = new System.Drawing.Point(179, 317);
            this.Rumpf.Name = "Rumpf";
            this.Rumpf.Size = new System.Drawing.Size(68, 14);
            this.Rumpf.TabIndex = 1;
            this.Rumpf.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // KranHals
            // 
            this.KranHals.BackColor = System.Drawing.Color.Black;
            this.KranHals.Location = new System.Drawing.Point(204, 179);
            this.KranHals.Name = "KranHals";
            this.KranHals.Size = new System.Drawing.Size(16, 140);
            this.KranHals.TabIndex = 2;
            this.KranHals.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AuslegerPanel
            // 
            this.AuslegerPanel.BackColor = System.Drawing.Color.Black;
            this.AuslegerPanel.Location = new System.Drawing.Point(137, 179);
            this.AuslegerPanel.Name = "AuslegerPanel";
            this.AuslegerPanel.Size = new System.Drawing.Size(80, 13);
            this.AuslegerPanel.TabIndex = 3;
            this.AuslegerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Haken
            // 
            this.Haken.BackColor = System.Drawing.Color.Black;
            this.Haken.Location = new System.Drawing.Point(137, 192);
            this.Haken.Name = "Haken";
            this.Haken.Size = new System.Drawing.Size(12, 40);
            this.Haken.TabIndex = 4;
            this.Haken.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btc_HakenAus
            // 
            this.btc_HakenAus.Location = new System.Drawing.Point(344, 43);
            this.btc_HakenAus.Name = "btc_HakenAus";
            this.btc_HakenAus.Size = new System.Drawing.Size(103, 23);
            this.btc_HakenAus.TabIndex = 5;
            this.btc_HakenAus.Text = "Haken Aus";
            this.btc_HakenAus.UseVisualStyleBackColor = true;
            this.btc_HakenAus.Click += new System.EventHandler(this.btc_HakenAus_Click);
            // 
            // btc_HakenEin
            // 
            this.btc_HakenEin.Location = new System.Drawing.Point(344, 89);
            this.btc_HakenEin.Name = "btc_HakenEin";
            this.btc_HakenEin.Size = new System.Drawing.Size(103, 23);
            this.btc_HakenEin.TabIndex = 6;
            this.btc_HakenEin.Text = "Haken Ein";
            this.btc_HakenEin.UseVisualStyleBackColor = true;
            this.btc_HakenEin.Click += new System.EventHandler(this.btc_HakenEin_Click);
            // 
            // btc_AuslegerAus
            // 
            this.btc_AuslegerAus.Location = new System.Drawing.Point(344, 137);
            this.btc_AuslegerAus.Name = "btc_AuslegerAus";
            this.btc_AuslegerAus.Size = new System.Drawing.Size(103, 23);
            this.btc_AuslegerAus.TabIndex = 7;
            this.btc_AuslegerAus.Text = "Ausleger Aus";
            this.btc_AuslegerAus.UseVisualStyleBackColor = true;
            this.btc_AuslegerAus.Click += new System.EventHandler(this.btc_AuslegerAus_Click);
            // 
            // btc_AuslegerEin
            // 
            this.btc_AuslegerEin.Location = new System.Drawing.Point(344, 179);
            this.btc_AuslegerEin.Name = "btc_AuslegerEin";
            this.btc_AuslegerEin.Size = new System.Drawing.Size(103, 23);
            this.btc_AuslegerEin.TabIndex = 8;
            this.btc_AuslegerEin.Text = "Ausleger Ein";
            this.btc_AuslegerEin.UseVisualStyleBackColor = true;
            this.btc_AuslegerEin.Click += new System.EventHandler(this.btc_AuslegerEin_Click);
            // 
            // btc_KranRechts
            // 
            this.btc_KranRechts.Location = new System.Drawing.Point(344, 227);
            this.btc_KranRechts.Name = "btc_KranRechts";
            this.btc_KranRechts.Size = new System.Drawing.Size(103, 23);
            this.btc_KranRechts.TabIndex = 9;
            this.btc_KranRechts.Text = "Kran Rechts";
            this.btc_KranRechts.UseVisualStyleBackColor = true;
            this.btc_KranRechts.Click += new System.EventHandler(this.btc_KranRechts_Click);
            // 
            // btc_KranLinks
            // 
            this.btc_KranLinks.Location = new System.Drawing.Point(344, 276);
            this.btc_KranLinks.Name = "btc_KranLinks";
            this.btc_KranLinks.Size = new System.Drawing.Size(103, 23);
            this.btc_KranLinks.TabIndex = 10;
            this.btc_KranLinks.Text = "Kran Links";
            this.btc_KranLinks.UseVisualStyleBackColor = true;
            this.btc_KranLinks.Click += new System.EventHandler(this.btc_KranLinks_Click);
            // 
            // btc_KranHalsAusfahren
            // 
            this.btc_KranHalsAusfahren.Location = new System.Drawing.Point(344, 326);
            this.btc_KranHalsAusfahren.Name = "btc_KranHalsAusfahren";
            this.btc_KranHalsAusfahren.Size = new System.Drawing.Size(103, 23);
            this.btc_KranHalsAusfahren.TabIndex = 11;
            this.btc_KranHalsAusfahren.Text = "Kran Aus";
            this.btc_KranHalsAusfahren.UseVisualStyleBackColor = true;
            this.btc_KranHalsAusfahren.Click += new System.EventHandler(this.btc_KranHalsAusfahren_Click);
            // 
            // btc_KranHalsEinfahren
            // 
            this.btc_KranHalsEinfahren.Location = new System.Drawing.Point(344, 369);
            this.btc_KranHalsEinfahren.Name = "btc_KranHalsEinfahren";
            this.btc_KranHalsEinfahren.Size = new System.Drawing.Size(103, 23);
            this.btc_KranHalsEinfahren.TabIndex = 12;
            this.btc_KranHalsEinfahren.Text = "Kran Ein";
            this.btc_KranHalsEinfahren.UseVisualStyleBackColor = true;
            this.btc_KranHalsEinfahren.Click += new System.EventHandler(this.btc_KranHalsEinfahren_Click);
            // 
            // Der_Kran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(476, 416);
            this.Controls.Add(this.btc_KranHalsEinfahren);
            this.Controls.Add(this.btc_KranHalsAusfahren);
            this.Controls.Add(this.btc_KranLinks);
            this.Controls.Add(this.btc_KranRechts);
            this.Controls.Add(this.btc_AuslegerEin);
            this.Controls.Add(this.btc_AuslegerAus);
            this.Controls.Add(this.btc_HakenEin);
            this.Controls.Add(this.btc_HakenAus);
            this.Controls.Add(this.Haken);
            this.Controls.Add(this.AuslegerPanel);
            this.Controls.Add(this.KranHals);
            this.Controls.Add(this.Rumpf);
            this.Name = "Der_Kran";
            this.Text = "Der Kran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Rumpf;
        private System.Windows.Forms.Panel KranHals;
        private System.Windows.Forms.Panel AuslegerPanel;
        private System.Windows.Forms.Panel Haken;
        private System.Windows.Forms.Button btc_HakenAus;
        private System.Windows.Forms.Button btc_HakenEin;
        private System.Windows.Forms.Button btc_AuslegerAus;
        private System.Windows.Forms.Button btc_AuslegerEin;
        private System.Windows.Forms.Button btc_KranRechts;
        private System.Windows.Forms.Button btc_KranLinks;
        private System.Windows.Forms.Button btc_KranHalsAusfahren;
        private System.Windows.Forms.Button btc_KranHalsEinfahren;
    }
}

