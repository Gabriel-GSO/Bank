using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankV1
{
    public partial class FrmBankverwaltung : Form
    {
        // Attribute
        private List<Konto> konten = new List<Konto>();

        // Konstruktor
        public FrmBankverwaltung()
        {
            InitializeComponent();
        }

        // Ereignisse
        private void FrmBankverwaltung_Load(object sender, EventArgs e)
        {
            // Beispielkonten - Nur zum Test
            Konto k1 = new Konto();
            k1.Einzahlen(100);
            k1.Inhaber = "Emil Eins";

            Konto k2 = new Konto("Zora Zwei");

            Konto k3 = new Konto("Dora Drei", 300);

            // Konten zur Liste hinzufügen
            konten.Add(k1);
            konten.Add(k2);
            konten.Add(k3);

            // Liste der lbx zuweisen
            lbxKonten.DataSource = konten;
        }

        private void lbxKonten_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ist ein Konto ausgewählt?
            if(lbxKonten.SelectedIndex >= 0)
            {
                // Informationen zum Konto in Textboxen anzeigen
                tbxKontoNr.Text = konten[lbxKonten.SelectedIndex].KontoNr.ToString();
                tbxInhaber.Text = konten[lbxKonten.SelectedIndex].Inhaber;
                tbxKontostand.Text = konten[lbxKonten.SelectedIndex].Saldo.ToString("0.00");
            }
        }

        private void btnEinzahlen_Click(object sender, EventArgs e)
        {
            // Referenz auf ausgewähltes Konto
            Konto konto = (Konto)lbxKonten.SelectedItem;

            // Dialog erstellen
            FrmEinAuszahlen frmEinAuszahlen = new FrmEinAuszahlen();

            // Dialog initialisieren
            frmEinAuszahlen.Text = "Einzahlen";
            frmEinAuszahlen.Kontostand = konto.Saldo; 

            // Dialog anzeigen 
            DialogResult dr = frmEinAuszahlen.ShowDialog();

            // Wurde OK geklickt? 
            if(dr == DialogResult.OK)
            {
                // Betrag aus Dialog holen und einzahlen 
                double betrag = frmEinAuszahlen.Betrag;
                konto.Einzahlen(betrag);

                // UI updaten
                tbxKontostand.Text = konto.Saldo.ToString("0.00");

                // Fokus auf Listbox
                lbxKonten.Focus();
            }
        }

        private void btnAuszahlen_Click(object sender, EventArgs e)
        {
            // Referenz au ausgewähltes Konto
            Konto konto = (Konto)lbxKonten.SelectedItem;

            // Dialog erstellen
            FrmEinAuszahlen frmEinAuszahlen = new FrmEinAuszahlen();

            // Dialog initialisieren
            frmEinAuszahlen.Text = "Auszahlen";
            frmEinAuszahlen.Kontostand = konto.Saldo;

            // Dialog anzeigen 
            DialogResult dr = frmEinAuszahlen.ShowDialog();

            // Wurde OK geklickt? 
            if (dr == DialogResult.OK)
            {
                // Betrag aus Dialog holen und einzahlen 
                double betrag = frmEinAuszahlen.Betrag;
                konto.Auszahlen(betrag);

                // UI updaten
                tbxKontostand.Text = konto.Saldo.ToString("0.00");

                // Fokus auf Listbox
                lbxKonten.Focus();
            }
        }

        private void btnNeuesKonto_Click(object sender, EventArgs e)
        {
            // Dialog erstellen
            FrmNeuesKonto frmNeuesKonto = new FrmNeuesKonto();

            // Kontonummer hinzufügen
            frmNeuesKonto.KontoNr = Konto.NextKontoNr;

            // Dialog anzeigen
            DialogResult dr = frmNeuesKonto.ShowDialog();

            // Wurde OK geklickt?
            if(dr == DialogResult.OK)
            {
                // Inhaber und Startbetrag aus Dialog auslesen und neues Konto instanziieren
                Konto konto = new Konto(frmNeuesKonto.Inhaber, frmNeuesKonto.Betrag);

                // Konto zu Kontoliste hinzufügen
                konten.Add(konto);

                // lbx aktualisieren
                lbxKonten.DataSource = null;
                lbxKonten.DataSource = konten;

                // Fokus auf neuen Eintrag
                lbxKonten.Focus();
                lbxKonten.SelectedIndex = lbxKonten.Items.Count - 1;
            }
        }

        private void btnKontoLoeschen_Click(object sender, EventArgs e)
        {
            // Welche Konto ist ausgewählt? 
            Konto k = (Konto)lbxKonten.SelectedItem;

            // Sicherheitsfrage 
            DialogResult dr = MessageBox.Show("Konto " + k.KontoNr + " löschen?", "Konto löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // Wurde Ja geklickt? 
            if (dr == DialogResult.Yes)
            {
                // Konto aus Liste löschen
                konten.Remove(k);

                // lbx aktualisieren
                lbxKonten.DataSource = null;
                lbxKonten.DataSource = konten;

                // Fokus auf ersten Eintrag
                lbxKonten.Focus();
                lbxKonten.SelectedIndex = lbxKonten.Items.Count - 1;
            }
        }
    }
}
