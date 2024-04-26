namespace BankV1
{
    partial class FrmEinAuszahlen
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
            this.lblBetrag = new System.Windows.Forms.Label();
            this.tbxBetrag = new System.Windows.Forms.TextBox();
            this.btnAbbruch = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblKontostand = new System.Windows.Forms.Label();
            this.tbxKontostand = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBetrag
            // 
            this.lblBetrag.AutoSize = true;
            this.lblBetrag.Location = new System.Drawing.Point(12, 69);
            this.lblBetrag.Name = "lblBetrag";
            this.lblBetrag.Size = new System.Drawing.Size(114, 32);
            this.lblBetrag.TabIndex = 0;
            this.lblBetrag.Text = "Betrag: ";
            // 
            // tbxBetrag
            // 
            this.tbxBetrag.Location = new System.Drawing.Point(190, 62);
            this.tbxBetrag.Name = "tbxBetrag";
            this.tbxBetrag.Size = new System.Drawing.Size(142, 38);
            this.tbxBetrag.TabIndex = 0;
            this.tbxBetrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAbbruch
            // 
            this.btnAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbruch.Location = new System.Drawing.Point(12, 117);
            this.btnAbbruch.Name = "btnAbbruch";
            this.btnAbbruch.Size = new System.Drawing.Size(167, 51);
            this.btnAbbruch.TabIndex = 2;
            this.btnAbbruch.Text = "Abbrechen";
            this.btnAbbruch.UseVisualStyleBackColor = true;
            // 
            // btnOkay
            // 
            this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkay.Location = new System.Drawing.Point(190, 117);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(167, 51);
            this.btnOkay.TabIndex = 1;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            // 
            // lblKontostand
            // 
            this.lblKontostand.AutoSize = true;
            this.lblKontostand.Location = new System.Drawing.Point(12, 13);
            this.lblKontostand.Name = "lblKontostand";
            this.lblKontostand.Size = new System.Drawing.Size(168, 32);
            this.lblKontostand.TabIndex = 3;
            this.lblKontostand.Text = "Kontostand:";
            // 
            // tbxKontostand
            // 
            this.tbxKontostand.Location = new System.Drawing.Point(190, 10);
            this.tbxKontostand.Name = "tbxKontostand";
            this.tbxKontostand.ReadOnly = true;
            this.tbxKontostand.Size = new System.Drawing.Size(167, 38);
            this.tbxKontostand.TabIndex = 0;
            this.tbxKontostand.TabStop = false;
            this.tbxKontostand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(338, 65);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(31, 32);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "€";
            // 
            // FrmEinAuszahlen
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbbruch;
            this.ClientSize = new System.Drawing.Size(537, 197);
            this.Controls.Add(this.lblKontostand);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.btnAbbruch);
            this.Controls.Add(this.tbxKontostand);
            this.Controls.Add(this.tbxBetrag);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblBetrag);
            this.Name = "FrmEinAuszahlen";
            this.Text = "Ein-/Auszahlen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBetrag;
        private System.Windows.Forms.TextBox tbxBetrag;
        private System.Windows.Forms.Button btnAbbruch;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label lblKontostand;
        private System.Windows.Forms.TextBox tbxKontostand;
        private System.Windows.Forms.Label lblEuro;
    }
}