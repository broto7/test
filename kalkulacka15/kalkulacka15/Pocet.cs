using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka15
{
    class Pocet
    {
        public double Hodnota { get; set; }
        public double Cislo { get; set; }
        public string Vypocet { get; set; }
        public bool Op { get; set; }
        public bool JeC { get; set; }

        public static double Scitani(Double Hodnota, Double Cislo)
        {
            return Hodnota + Cislo;
        }
        public static double Nasobeni(Double Hodnota, Double Cislo)
        {
            return Hodnota * Cislo;
        }
        public static double Deleni(Double Hodnota, Double Cislo)
        {
            return Hodnota / Cislo;
        }
        public static double Odecitani(Double Hodnota, Double Cislo)
        {
            return Hodnota - Cislo;
        }
    }
}
