using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankV1
{
    class Konto
    {
        // Attribute
        private int kontoNr;
        private static int nextKontoNr = 101;
        private string inhaber;
        private double saldo;

        // Eigenschaften
        public int KontoNr
        {
            get { return kontoNr; }
        }
        public string Inhaber
        {
            get { return inhaber; }
            set { inhaber = value; }
        }
        public double Saldo
        {
            get { return saldo; }
        }
        public static int NextKontoNr
        {
            get { return nextKontoNr; }
        }

        // Konstruktoren
        public Konto()
        {
            // Erstellt eine neue einzigartige KontoNr
            kontoNr = nextKontoNr++;
            Inhaber = "";
            saldo = 0;
        }
        public Konto(string inhaber) : this()
        {
            Inhaber = inhaber;
        }
        public Konto(string inhaber, double betrag) : this(inhaber)
        {
            saldo = betrag;
        }

        // Methoden
        public double Einzahlen(double betrag)
        {
            saldo += betrag;
            return saldo;
        }
        public double Auszahlen(double betrag)
        {
            saldo -= betrag;
            return saldo;
        }

        public override string ToString()
        {
            if (inhaber == "")
                return "KontoNr: " + kontoNr;
            else
                return "KontoNr: " + kontoNr + ", " + inhaber;
        }
    }


}
