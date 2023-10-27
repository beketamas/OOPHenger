using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    public class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double sugar, double magassag) : base(sugar,magassag)
        {
            fajsuly = 7.87;
        }

        public TomorHenger(double sugar, double magassag, int fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public double Suly => fajsuly * Terfogat();

        public double GetFajsuly => fajsuly;

        public override string? ToString() => base.ToString() + $"falvastagsága:{fajsuly}";
    }
}
