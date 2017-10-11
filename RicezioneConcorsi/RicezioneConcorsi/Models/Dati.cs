using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicezioneConcorsi.Models
{
    class Dati
    {
        private static Dati instance;
        

        public Dati()
        {

        }
        public static Dati Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Dati();
                }
                return instance;
            }
        }
        public string Username { get; set; }
    }
}
