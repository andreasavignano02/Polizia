using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Polizia.Models
{
    public class Anagrafe
    {
        public int IdAnagrafica { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Indirizzo { get; set; }

        public string City { get; set; }

        public string CodiceFiscale { get; set;}

        public int IdVerbale { get; set; }
        
    }
}