using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    /* 
     * 
    Esercizio 2: Agenzia immobiliare
    Si vuole progettare un’applicazione in grado di gestire un’agenzia
    immobiliare.
    Gli immobili sono caratterizzati da:
 - un codice alfanumerico,
 - indirizzo,
 - cap,
 - città
 - una superficie espressa in mq attraverso un numero intero.

 L’agenzia gestisce diverse tipologie di immobili:
 - Box,
 - Appartamenti
 - Ville.

 Per i box è riportato il numero di posti auto.
 Per gli appartamenti è riportato in numero di vani e il numero di bagni.
 Per le ville è previsto,

 in aggiunta rispetto all’appartamento, la dimensione in mq di giardino.
 Ridefinire per ciascuna delle tre classi il metodo ToString in modo da fornire
 una descrizione completa dell'immobile. StampaSchedaImmobile
 Provare a pensare ad una funzione di ricerca.
     */

    class Agenzia
    {
        public string Nome { get; set; }
        public List<Immobile> Immobili { get; set; }
        public Agenzia(string Nome)
        {
            this.Nome = Nome;
            this.Immobili = new List<Immobile>();
        }
        
        public void AddImmobile(Immobile Immobile)
        {
            this.Immobili.Add(Immobile);
        }
        public List<Immobile> SearchImmobili(string key)
        {
            return this.Immobili.FindAll(i => i.Contains(key));

            /*  // altro modo per scrivere SearchImmobili
             *  
             *  List <Immobile> MiaSottoLista = new List<Immobile>();
             *  
             *  foreach(Immobile ele in Immobili)
             *  {
             *      if( ele.Contains(Key))
             *      {
             *      MiaSottoLista.Add(elemento);
             *      }
             *  }
             *  
             *  return MiaSottoLista; 
             
             */
        }
    }

}

