using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_L4
{
    internal class Class1
    {
        public static class User
        {
            public static string username;
            public static string password;
            public static bool IsLogged;
            public static DateTime DataOraLog;

            public static void Login()
            {
                Console.WriteLine("Inserisci username:");
                User.username = Console.ReadLine();

                Console.WriteLine("Inserisci password:");
                User.password = Console.ReadLine();

                Console.WriteLine("Conferma password:");
                string conferma = Console.ReadLine();

                if ((User.password == conferma) && (User.username != ""))
                {
                    IsLogged = true;
                    DataOraLog = DateTime.Now;
                    Console.WriteLine($"Utente correttamente loggato alle ore {DataOraLog}");
                }
                else
                {
                    Console.WriteLine("Non è possibile effettuare il login");
                }
            }

            public static void Logout()
            {
                username = "";
                password = "";
                IsLogged = false;
                Console.WriteLine("Nessun utente loggato al sistema");
            }

            public static void StampaDataEOraLogin()
            {
                if (User.IsLogged == true)
                {
                    Console.WriteLine($"L'utente {User.username} ha effettuato l'accesso il {User.DataOraLog}");
                }
                else
                {
                    Console.WriteLine("Non risultano utenti loggati a sistema");
                }
            }
        }

    }
}
