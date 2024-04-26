namespace BankV1
{
    partial class FrmNeuesKonto
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
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblKontoNr = new System.Windows.Forms.Label();
            this.tbxKontoNr = new System.Windows.Forms.TextBox();
            this.lblInhaber = new System.Windows.Forms.Label();
            this.tbxInhaber = new System.Windows.Forms.TextBox();
            this.lblStartbetrag = new System.Windows.Forms.Label();
            this.tbxBetrag = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbrechen.Location = new System.Drawing.Point(12, 180);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(196, 63);
            this.btnAbbrechen.TabIndex = 0;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // btnOkay
            // 
            this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkay.Location = new System.Drawing.Point(245, 180);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(196, 63);
            this.btnOkay.TabIndex = 2;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            // 
            // lblKontoNr
            // 
            this.lblKontoNr.AutoSize = true;
            this.lblKontoNr.Location = new System.Drawing.Point(13, 13);
            this.lblKontoNr.Name = "lblKontoNr";
            this.lblKontoNr.Size = new System.Drawing.Size(143, 32);
            this.lblKontoNr.TabIndex = 1;
            this.lblKontoNr.Text = "Konto-Nr: ";
            // 
            // tbxKontoNr
            // 
            this.tbxKontoNr.Enabled = false;
            this.tbxKontoNr.Location = new System.Drawing.Point(172, 7);
            this.tbxKontoNr.Name = "tbxKontoNr";
            this.tbxKontoNr.Size = new System.Drawing.Size(269, 38);
            this.tbxKontoNr.TabIndex = 2;
            this.tbxKontoNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInhaber
            // 
            this.lblInhaber.AutoSize = true;
            this.lblInhaber.Location = new System.Drawing.Point(19, 64);
            this.lblInhaber.Name = "lblInhaber";
            this.lblInhaber.Size = new System.Drawing.Size(119, 32);
            this.lblInhaber.TabIndex = 3;
            this.lblInhaber.Text = "Inhaber:";
            // 
            // tbxInhaber
            // 
            this.tbxInhaber.Location = new System.Drawing.Point(172, 61);
            this.tbxInhaber.Name = "tbxInhaber";
            this.tbxInhaber.Size = new System.Drawing.Size(269, 38);
            this.tbxInhaber.TabIndex = 1;
            // 
            // lblStartbetrag
            // 
            this.lblStartbetrag.AutoSize = true;
            this.lblStartbetrag.Location = new System.Drawing.Point(18, 111);
            this.lblStartbetrag.Name = "lblStartbetrag";
            this.lblStartbetrag.Size = new System.Drawing.Size(171, 32);
            this.lblStartbetrag.TabIndex = 4;
            this.lblStartbetrag.Text = "Startbetrag: ";
            // 
            // tbxBetrag
            // 
            this.tbxBetrag.Location = new System.Drawing.Point(172, 111);
            this.tbxBetrag.Name = "tbxBetrag";
            this.tbxBetrag.Size = new System.Drawing.Size(241, 38);
            this.tbxBetrag.TabIndex = 3;
            this.tbxBetrag.Text = "0,00";
            this.tbxBetrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(419, 114);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(31, 32);
            this.lblEuro.TabIndex = 4;
            this.lblEuro.Text = "€";
            // 
            // FrmNeuesKonto
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbbrechen;
            this.ClientSize = new System.Drawing.Size(554, 298);
            this.Controls.Add(this.tbxBetrag);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblStartbetrag);
            this.Controls.Add(this.lblInhaber);
            this.Controls.Add(this.tbxInhaber);
            this.Controls.Add(this.tbxKontoNr);
            this.Controls.Add(this.lblKontoNr);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnAbbrechen);
            this.Name = "FrmNeuesKonto";
            this.Text = "NeuesKonto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label lblKontoNr;
        private System.Windows.Forms.TextBox tbxKontoNr;
        private System.Windows.Forms.Label lblInhaber;
        private System.Windows.Forms.TextBox tbxInhaber;
        private System.Windows.Forms.Label lblStartbetrag;
        private System.Windows.Forms.TextBox tbxBetrag;
        private System.Windows.Forms.Label lblEuro;
    }
}