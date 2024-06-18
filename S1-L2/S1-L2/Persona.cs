using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_L2
{
    internal class Persona
    {
        // Proprietà private
        private string nome;
        private string cognome;
        private int eta;

        // Costruttore
        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }

        // Metodo per ottenere il nome
        public string GetNome()
        {
            return nome;
        }

        // Metodo per ottenere il cognome
        public string GetCognome()
        {
            return cognome;
        }

        // Metodo per ottenere l'età
        public int GetEta()
        {
            return eta;
        }

        // Metodo per ottenere i dettagli della persona
        public string GetDettagli()
        {
            return $"Nome: {nome}, Cognome: {cognome}, Età: {eta}";
        }
    }
}
