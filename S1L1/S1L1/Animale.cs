using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1L1
{
    internal class Animale
    {
        // ATTRIBUTI
        string nome;
        string razza;
        string tipo;

        // PROPRIETA'

        public string Nome { get { return nome; } set { nome = value; } }
        public string Razza { get { return razza; } set { razza = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }

        // METODI
        public void descriviti2()
        {
            Console.WriteLine("Sono un " + nome + " di razza " + razza + "e sono un " + tipo);
        }
    }
}

