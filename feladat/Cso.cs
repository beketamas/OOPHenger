using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    public class Cso : Henger
    {
        double falVastagsag;
        
        public Cso(double sugar, double magassag) : base(sugar ,magassag)
        {
            falVastagsag = 1;
        }
        
        

        public Cso(double sugar, double magassag, double falVastagag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagag;
        }

        public double FalVastagsag { get => falVastagsag; }

        public override double Terfogat() => base.Terfogat() - Math.Pow(GetSugar - falVastagsag,2) * Math.PI *GetMagassag;

        public override string? ToString() => base.ToString()+ $"falvastagsága:{falVastagsag}";
    }
}
