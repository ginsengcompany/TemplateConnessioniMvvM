using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicezioneConcorsi.Models
{
    public class Concorso
    {
        public int id_concorso { get; set; }

        public string descrizione { get; set; }

        public string errore { get; set; }

        public Concorso(int id, string desc)
        {
            id_concorso = id;
            descrizione = desc;
        }

        public Concorso() { }


    }
}
