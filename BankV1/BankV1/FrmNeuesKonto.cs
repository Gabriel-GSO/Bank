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
    public partial class FrmNeuesKonto : Form
    {
        // ...
        public FrmNeuesKonto()
        {
            InitializeComponent();
        }

        // Eigenschaften, um auf die privaten Steuerelemente zugreifen zu können
        public int KontoNr
        {
            get { return Convert.ToInt32(tbxKontoNr.Text); }
            set { tbxKontoNr.Text = value.ToString(); }
        }
        public string Inhaber
        {
            get { return tbxInhaber.Text; }
            set { tbxInhaber.Text = value; }
        }
        public double Betrag
        {
            get { return Convert.ToDouble(tbxBetrag.Text); }
            set { tbxBetrag.Text = value.ToString("0.00"); }
        }
    }
}
