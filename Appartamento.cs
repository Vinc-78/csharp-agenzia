using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    public class Appartamento : Immobile
    {
        public int NumeroVani { get; set; }
        public int NumeroBagni { get; set; }

        public Appartamento(string Codice, string Indirizzo, string Cap, string Città, int Superficie, int NumeriVani, int NumeroBagni) : base(Codice, Indirizzo, Cap, Città, Superficie)
        {
            this.NumeroBagni = NumeriVani;
            this.NumeroVani = NumeroBagni;
        }

        public override string ToString()
        {
            return string.Format("Appartamento:\n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\nNumeroVani: {1}\nNumeroBagni: {2}",
                base.Write(),
                this.NumeroVani,
                this.NumeroBagni);

        }

        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.NumeroVani.ToString().Contains(key)) return true;
            else if (this.NumeroBagni.ToString().Contains(key)) return true;
            else return false;
        }
    }
}
