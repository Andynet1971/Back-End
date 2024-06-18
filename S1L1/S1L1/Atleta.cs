using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1L1
{
    internal class Atleta
    {
        // ATTRIBUTI
        string nome;
        string cognome;
        string sport;

        // PROPRIETA'

        public string Nome { get { return nome; } set { nome = value; } }
        public string Cogome { get { return cognome; } set { cognome = value; } }
        public string Sport { get { return sport; } set { sport = value; } }

        // METODI
        public void descriviti()
        {
            Console.WriteLine("Mi chiamo " + nome + " " + cognome + "e pratico " + sport);
        }
    }
}
