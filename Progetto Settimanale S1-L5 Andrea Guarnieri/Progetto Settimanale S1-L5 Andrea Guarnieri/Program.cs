using static Progetto_Settimanale_S1_L5_Andrea_Guarnieri.Classe_Contribuente;

namespace Progetto_Settimanale_S1_L5_Andrea_Guarnieri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputValidator validator = new InputValidator();

            while (true)
            {
                // Utilizza il metodo RichiediScelta per assicurarsi che la scelta sia valida
                Console.WriteLine("1. Inserisci dati contribuente");
                Console.WriteLine("2. Esci");
                Console.WriteLine("");
                string scelta = validator.RichiediScelta("Seleziona un'opzione (1 o 2)", new[] { "1", "2" });

                if (scelta == "1")
                {
                    Contribuente contribuente = Contribuente.CreaContribuente(validator);
                    Console.WriteLine("");
                    Console.WriteLine("==================================================");
                    Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
                    Console.WriteLine(contribuente);
                    Console.WriteLine("==================================================");
                    Console.WriteLine("");
                }
                else if (scelta == "2")
                {
                    break; // Esce dal loop e termina il programma
                }
            }
        }
    }
}
