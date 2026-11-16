using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kektura_gyak.Class
{
    public class Szakaszok
    {
        public string Indulopont { get; set; }
        public string Vegpont { get; set; }
        public decimal Hossz { get; set; }
        public int Emelkedes { get; set; }
        public int Lejtes { get; set; }
        public string PecseteloHely { get; set; }


        // https://learn.microsoft.com/en-us/dotnet/api/system.icomparable.compareto?view=net-10.0
        /*int IComparable<Szakaszok>.CompareTo(Szakaszok other)
        {
            if (other.Hossz > this.Hossz)
                return -1;
            else if (other.Hossz == this.Hossz)
                return 0;
            else if (other.Hossz < this.Hossz)
                return 1;
        }*/
    }
}
