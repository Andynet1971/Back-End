namespace Progetto_Settimanale_S1_L5_Andrea_Guarnieri
{
    internal class Classe_Contribuente
    {
        public class Contribuente
        {
            // Proprietà della classe Contribuente
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string DataNascita { get; set; }
            public string CodiceFiscale { get; set; }
            public string Sesso { get; set; }
            public string ComuneResidenza { get; set; }
            public double RedditoAnnuale { get; set; }
            public string Provincia { get; set; }

            // Costruttore della classe Contribuente
            public Contribuente(string nome, string cognome, string dataNascita, string codiceFiscale, string sesso, string comuneResidenza, double redditoAnnuale, string provincia)
            {
                Nome = nome;
                Cognome = cognome;
                DataNascita = dataNascita;
                CodiceFiscale = codiceFiscale;
                Sesso = sesso;
                ComuneResidenza = comuneResidenza;
                Provincia = provincia;
                RedditoAnnuale = redditoAnnuale;
            }

            // Metodo statico per creare un nuovo contribuente utilizzando l'InputValidator
            public static Contribuente CreaContribuente(InputValidator validator)
            {
                Console.WriteLine("Inserisci i dati del contribuente:");

                // Richiede i dati del contribuente tramite l'InputValidator
                string nome = validator.RichiediTesto("Nome", "^[a-zA-Z]+$");
                string cognome = validator.RichiediTesto("Cognome", "^[a-zA-Z]+$");
                string dataNascita = validator.RichiediData("Data di nascita (gg/mm/aaaa)");
                string codiceFiscale = validator.RichiediTesto("Codice fiscale", "^[a-zA-Z0-9]{16}$");
                string sesso = validator.RichiediTesto("Sesso (M/F)", "^[MFmf]$").ToUpper();
                string comuneResidenza = validator.RichiediComuneResidenza("Comune di residenza");
                string provincia = validator.RichiediProvincia("Provincia (sigla)");
                double redditoAnnuale = validator.RichiediReddito("Reddito annuale");

                // Restituisce un nuovo oggetto Contribuente
                return new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale, provincia);
            }

            // Metodo per calcolare l'imposta basata sul reddito annuale
            public double CalcolaImposta()
            {
                double imposta = 0.0;
                double reddito = RedditoAnnuale;

                // Calcola l'imposta basandosi sugli scaglioni di reddito
                if (reddito <= 15000)
                {
                    imposta = reddito * 0.23;
                }
                else if (reddito <= 28000)
                {
                    imposta = 3450 + (reddito - 15000) * 0.27;
                }
                else if (reddito <= 55000)
                {
                    imposta = 6960 + (reddito - 28000) * 0.38;
                }
                else if (reddito <= 75000)
                {
                    imposta = 17220 + (reddito - 55000) * 0.41;
                }
                else
                {
                    imposta = 25420 + (reddito - 75000) * 0.43;
                }

                return imposta;
            }

            // Override del metodo ToString per stampare i dettagli del contribuente
            public override string ToString()
            {
                return $"Contribuente: {Nome} {Cognome}, nato il {DataNascita} ({Sesso}), residente in {ComuneResidenza}, provincia: {Provincia}, codice fiscale: {CodiceFiscale}\n" +
                       $"Reddito dichiarato:  {RedditoAnnuale:0.00}\n" +
                       $"IMPOSTA DA VERSARE:  {CalcolaImposta():0.00}";
            }
        }

        // Classe statica contenente l'elenco delle province italiane
        public static class Province
        {
            public static readonly HashSet<string> ProvinceItaliane = new HashSet<string>
            {
                "AG", "AL", "AN", "AO", "AR", "AP", "AT", "AV", "BA", "BT", "BL", "BN", "BG", "BI", "BO", "BZ",
                "BS", "BR", "CA", "CL", "CB", "CI", "CE", "CT", "CZ", "CH", "CO", "CS", "CR", "KR", "CN", "EN",
                "FM", "FE", "FI", "FG", "FC", "FR", "GE", "GO", "GR", "IM", "IS", "SP", "LT", "LE", "LC", "LI",
                "LO", "LU", "MC", "MN", "MS", "MT", "ME", "MI", "MO", "MB", "NA", "NO", "NU", "OR", "PD", "PA",
                "PR", "PV", "PG", "PU", "PE", "PC", "PI", "PT", "PN", "PZ", "PO", "RG", "RA", "RC", "RE", "RI",
                "RN", "RM", "RO", "SA", "SS", "SV", "SI", "SR", "SO", "TA", "TE", "TR", "TO", "TP", "TN", "TV",
                "TS", "UD", "VA", "VE", "VB", "VC", "VR", "VV", "VI", "VT", "VS"
            };
        }
    }
}
