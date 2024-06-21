using static Progetto_Settimanale_S1_L5_Andrea_Guarnieri.Classe_Contribuente;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Progetto_Settimanale_S1_L5_Andrea_Guarnieri
{
    internal class InputValidator
    {
        // Metodo per richiedere testo con un pattern di validazione
        public string RichiediTesto(string messaggio, string pattern)
        {
            string? input; // Usa un tipo nullable per gestire input null
            do
            {
                Console.Write($"{messaggio}: ");
                input = Console.ReadLine();

                // Controlla se l'input è null o non corrisponde al pattern
                if (input == null || !Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine($"Inserimento non valido. Riprova. ({messaggio} deve rispettare il pattern {pattern})");
                }
            } while (input == null || !Regex.IsMatch(input, pattern));

            return input;
        }

        // Metodo per richiedere una data valida
        public string RichiediData(string messaggio)
        {
            string? input;
            DateTime data;
            do
            {
                Console.Write($"{messaggio}: ");
                input = Console.ReadLine();
            } while (input == null || !DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data));

            return input ?? string.Empty; // Restituisce una stringa vuota come fallback
        }

        // Metodo per richiedere un reddito valido
        public double RichiediReddito(string messaggio)
        {
            string? input;
            double reddito;
            do
            {
                Console.Write($"{messaggio}: ");
                input = Console.ReadLine();
            } while (input == null || !double.TryParse(input, out reddito) || reddito < 0);

            return reddito;
        }

        // Metodo per richiedere una provincia valida
        public string RichiediProvincia(string messaggio)
        {
            string? input;
            bool provinciaValida;
            do
            {
                Console.Write($"{messaggio}: ");
                input = Console.ReadLine();
                input = input?.ToUpper(); // Se input è null, rimane null

                provinciaValida = input != null && Province.ProvinceItaliane.Contains(input);
                if (!provinciaValida)
                {
                    Console.WriteLine($"Inserimento non valido. La provincia '{input}' non è riconosciuta. Riprova.");
                }
            } while (!provinciaValida);

            return input ?? string.Empty; // Restituisce una stringa vuota come fallback
        }

        // Metodo per richiedere un comune di residenza valido
        public string RichiediComuneResidenza(string messaggio)
        {
            string? input;
            do
            {
                Console.Write($"{messaggio}: ");
                input = Console.ReadLine();

                if (input == null || !Regex.IsMatch(input, "^[a-zA-Z]+(?: [a-zA-Z]+)*$"))
                {
                    Console.WriteLine($"Inserimento non valido. Il {messaggio} deve contenere solo lettere, spazi non consecutivi e senza caratteri speciali o numeri.");
                }
            } while (input == null || !Regex.IsMatch(input, "^[a-zA-Z]+(?: [a-zA-Z]+)*$"));

            return input;
        }

        // Metodo per richiedere una scelta valida
        public string RichiediScelta(string messaggio, string[] opzioniValide)
        {
            string? input;
            do
            {
                Console.Write($"{messaggio}: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || !opzioniValide.Contains(input))
                {
                    Console.WriteLine($"Scelta non valida. Inserisci una delle seguenti opzioni: {string.Join(", ", opzioniValide)}.");
                }
            } while (string.IsNullOrWhiteSpace(input) || !opzioniValide.Contains(input));

            return input;
        }
    }
}
