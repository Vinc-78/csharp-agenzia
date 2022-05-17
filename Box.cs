using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{

  public class Box : Immobile
    {
        public int PostiAuto { get; set; }

        public Box(string Codice, string Indirizzo, string Cap, string Città, int Superficie, int Postiauto) : base(Codice, Indirizzo, Cap, Città, Superficie)
        {
            this.PostiAuto = PostiAuto;
        }

        public override string ToString()
        {
            return string.Format("Box:\n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\nPostiAuto: {1}",
                                base.Write(),
                                this.PostiAuto);
        }

        public  bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.PostiAuto.ToString().Contains(key)) return true;
            else return false;
        }

    }
}
