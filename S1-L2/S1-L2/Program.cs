namespace S1_L2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Mario", "Rossi", 30);

            Console.WriteLine(persona.GetNome()); // Output: Mario
            Console.WriteLine(persona.GetCognome()); // Output: Rossi
            Console.WriteLine(persona.GetEta()); // Output: 30
            Console.WriteLine(persona.GetDettagli()); // Output: Nome: Mario, Cognome: Rossi, Età: 30
        }
    }
}
