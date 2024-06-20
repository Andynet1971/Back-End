using static S1_L4.Class1;

namespace S1_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScriviMenu();
        }

        public static void ScriviMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("==============OPERAZIONI===============");
            Console.WriteLine("Scegli l'operazione da effettuare:");
            Console.WriteLine("1.: Login");
            Console.WriteLine("2.: Logout");
            Console.WriteLine("3.: Verifica ora e data di login");

            var scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    User.Login();
                    break;
                case "2":
                    User.Logout();
                    break;
                case "3":
                    User.StampaDataEOraLogin();
                    break;
            }
            ScriviMenu();

        }
    }
}
