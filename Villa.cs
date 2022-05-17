using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    public class Villa : Appartamento
    {
        public int Giardino { get; set; }

        public Villa(string Codice, string Indirizzo, string Cap, string Città, int Superficie, int NumeriVani, int NumeroBagni, int Giardino) : base(Codice, Indirizzo, Cap, Città, Superficie, NumeriVani, NumeroBagni)
        {
            this.Giardino = Giardino;
            
        }

        public override string ToString()
        {
            return String.Format("Villa:\n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\nGiardino: {1}",
                              base.Write(),
                              this.Giardino
                ); 

        }
        public  bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.Giardino.ToString().Contains(key)) return true;
            else return false;
        }
    }
}
