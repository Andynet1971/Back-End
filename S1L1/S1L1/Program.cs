namespace S1L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta mario = new Atleta();
            mario.Nome = "Mario";
            mario.Cogome = "Rossi";
            mario.Sport = "Calcetto";
            mario.descriviti();

            Animale anim = new Animale();
            anim.Nome = "Cavallo";
            anim.Razza = "Equino";
            anim.Tipo = "erbivoro";
            anim.descriviti2();

        }
    }
}
