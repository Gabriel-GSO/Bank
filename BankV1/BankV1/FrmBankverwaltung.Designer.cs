namespace BankV1
{
    partial class FrmBankverwaltung
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
            this.lbxKonten = new System.Windows.Forms.ListBox();
            this.lblKontonummer = new System.Windows.Forms.Label();
            this.tbxKontoNr = new System.Windows.Forms.TextBox();
            this.lblInhaber = new System.Windows.Forms.Label();
            this.tbxInhaber = new System.Windows.Forms.TextBox();
            this.lblKontostand = new System.Windows.Forms.Label();
            this.tbxKontostand = new System.Windows.Forms.TextBox();
            this.btnEinzahlen = new System.Windows.Forms.Button();
            this.btnAuszahlen = new System.Windows.Forms.Button();
            this.btnNeuesKonto = new System.Windows.Forms.Button();
            this.lblEuro = new System.Windows.Forms.Label();
            this.btnKontoLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxKonten
            // 
            this.lbxKonten.FormattingEnabled = true;
            this.lbxKonten.Location = new System.Drawing.Point(5, 5);
            this.lbxKonten.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lbxKonten.Name = "lbxKonten";
            this.lbxKonten.Size = new System.Drawing.Size(136, 95);
            this.lbxKonten.TabIndex = 1;
            this.lbxKonten.SelectedIndexChanged += new System.EventHandler(this.lbxKonten_SelectedIndexChanged);
            // 
            // lblKontonummer
            // 
            this.lblKontonummer.AutoSize = true;
            this.lblKontonummer.Location = new System.Drawing.Point(147, 6);
            this.lblKontonummer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKontonummer.Name = "lblKontonummer";
            this.lblKontonummer.Size = new System.Drawing.Size(52, 13);
            this.lblKontonummer.TabIndex = 0;
            this.lblKontonummer.Text = "Konto-Nr:";
            // 
            // tbxKontoNr
            // 
            this.tbxKontoNr.Enabled = false;
            this.tbxKontoNr.Location = new System.Drawing.Point(210, 5);
            this.tbxKontoNr.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxKontoNr.Name = "tbxKontoNr";
            this.tbxKontoNr.Size = new System.Drawing.Size(78, 20);
            this.tbxKontoNr.TabIndex = 4;
            this.tbxKontoNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInhaber
            // 
            this.lblInhaber.AutoSize = true;
            this.lblInhaber.Location = new System.Drawing.Point(147, 28);
            this.lblInhaber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblInhaber.Name = "lblInhaber";
            this.lblInhaber.Size = new System.Drawing.Size(49, 13);
            this.lblInhaber.TabIndex = 0;
            this.lblInhaber.Text = "Inhaber: ";
            // 
            // tbxInhaber
            // 
            this.tbxInhaber.Enabled = false;
            this.tbxInhaber.Location = new System.Drawing.Point(210, 26);
            this.tbxInhaber.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxInhaber.Name = "tbxInhaber";
            this.tbxInhaber.Size = new System.Drawing.Size(78, 20);
            this.tbxInhaber.TabIndex = 5;
            this.tbxInhaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblKontostand
            // 
            this.lblKontostand.AutoSize = true;
            this.lblKontostand.Location = new System.Drawing.Point(147, 51);
            this.lblKontostand.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKontostand.Name = "lblKontostand";
            this.lblKontostand.Size = new System.Drawing.Size(64, 13);
            this.lblKontostand.TabIndex = 0;
            this.lblKontostand.Text = "Kontostand:";
            // 
            // tbxKontostand
            // 
            this.tbxKontostand.Enabled = false;
            this.tbxKontostand.Location = new System.Drawing.Point(210, 49);
            this.tbxKontostand.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbxKontostand.Name = "tbxKontostand";
            this.tbxKontostand.Size = new System.Drawing.Size(68, 20);
            this.tbxKontostand.TabIndex = 6;
            this.tbxKontostand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEinzahlen
            // 
            this.btnEinzahlen.Location = new System.Drawing.Point(210, 78);
            this.btnEinzahlen.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnEinzahlen.Name = "btnEinzahlen";
            this.btnEinzahlen.Size = new System.Drawing.Size(36, 21);
            this.btnEinzahlen.TabIndex = 7;
            this.btnEinzahlen.Text = "Einz.";
            this.btnEinzahlen.UseVisualStyleBackColor = true;
            this.btnEinzahlen.Click += new System.EventHandler(this.btnEinzahlen_Click);
            // 
            // btnAuszahlen
            // 
            this.btnAuszahlen.Location = new System.Drawing.Point(249, 78);
            this.btnAuszahlen.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAuszahlen.Name = "btnAuszahlen";
            this.btnAuszahlen.Size = new System.Drawing.Size(36, 21);
            this.btnAuszahlen.TabIndex = 8;
            this.btnAuszahlen.Text = "Ausz.";
            this.btnAuszahlen.UseVisualStyleBackColor = true;
            this.btnAuszahlen.Click += new System.EventHandler(this.btnAuszahlen_Click);
            // 
            // btnNeuesKonto
            // 
            this.btnNeuesKonto.Location = new System.Drawing.Point(5, 101);
            this.btnNeuesKonto.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnNeuesKonto.Name = "btnNeuesKonto";
            this.btnNeuesKonto.Size = new System.Drawing.Size(51, 23);
            this.btnNeuesKonto.TabIndex = 2;
            this.btnNeuesKonto.Text = "+";
            this.btnNeuesKonto.UseVisualStyleBackColor = true;
            this.btnNeuesKonto.Click += new System.EventHandler(this.btnNeuesKonto_Click);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(277, 51);
            this.lblEuro.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(13, 13);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "€";
            // 
            // btnKontoLoeschen
            // 
            this.btnKontoLoeschen.Location = new System.Drawing.Point(88, 101);
            this.btnKontoLoeschen.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnKontoLoeschen.Name = "btnKontoLoeschen";
            this.btnKontoLoeschen.Size = new System.Drawing.Size(51, 23);
            this.btnKontoLoeschen.TabIndex = 3;
            this.btnKontoLoeschen.Text = ".";
            this.btnKontoLoeschen.UseVisualStyleBackColor = true;
            this.btnKontoLoeschen.Click += new System.EventHandler(this.btnKontoLoeschen_Click);
            // 
            // FrmBankverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 143);
            this.Controls.Add(this.btnKontoLoeschen);
            this.Controls.Add(this.btnNeuesKonto);
            this.Controls.Add(this.btnAuszahlen);
            this.Controls.Add(this.btnEinzahlen);
            this.Controls.Add(this.tbxKontostand);
            this.Controls.Add(this.tbxInhaber);
            this.Controls.Add(this.tbxKontoNr);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblKontostand);
            this.Controls.Add(this.lblInhaber);
            this.Controls.Add(this.lblKontonummer);
            this.Controls.Add(this.lbxKonten);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FrmBankverwaltung";
            this.Text = "Bankvewaltung V1";
            this.Load += new System.EventHandler(this.FrmBankverwaltung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKonten;
        private System.Windows.Forms.Label lblKontonummer;
        private System.Windows.Forms.TextBox tbxKontoNr;
        private System.Windows.Forms.Label lblInhaber;
        private System.Windows.Forms.TextBox tbxInhaber;
        private System.Windows.Forms.Label lblKontostand;
        private System.Windows.Forms.TextBox tbxKontostand;
        private System.Windows.Forms.Button btnEinzahlen;
        private System.Windows.Forms.Button btnAuszahlen;
        private System.Windows.Forms.Button btnNeuesKonto;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Button btnKontoLoeschen;
    }
}

