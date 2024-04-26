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
    public partial class FrmEinAuszahlen : Form
    {
        // Konstruktor
        public FrmEinAuszahlen()
        {
            InitializeComponent();
        }

        // Eigenschaften, um auf die privaten Steuerelemente zugreifen zu können
        public double Kontostand
        {
            set { tbxKontostand.Text = value.ToString("0.00"); }
        }
        public double Betrag
        {
            get { return Convert.ToDouble(tbxBetrag.Text); }
        }

    }
}
