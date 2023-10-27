using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    public class Henger
    {
        double magassag;
        double sugar;
        static int szuletesSzamlalo;

        public Henger(double sugar,double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }

        public double GetMagassag => magassag;
        public double GetSugar  => sugar;
        public static int SzuletesSzamlalo  => szuletesSzamlalo;

        public virtual double Terfogat() => Math.Pow(this.sugar, 2) * Math.PI * magassag;

        public override string? ToString() => $"Jellemzők >> térfogat:{Terfogat():f2}; sugár:{sugar}; magasság:{magassag}";
    }
}
