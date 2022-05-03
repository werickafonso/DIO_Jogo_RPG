using JogoDeRPG.srt.Entities;

namespace jogoDeRPG
{
    class program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "knight");
            Wizard wizard = new Wizard("Jenica", 42, "white wizard");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard");


            Console.WriteLine(arus.ToString());
            Console.WriteLine(wizard.ToString());
            Console.WriteLine(ninja.ToString());
            Console.WriteLine(blackWizard.ToString());

            Console.WriteLine(arus.Attack());
            
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));

            Console.WriteLine(ninja.Attack());
            Console.WriteLine(ninja.Attack(3));
            Console.WriteLine(ninja.Attack(9));

            
            Console.WriteLine(blackWizard.Attack());
            Console.WriteLine(blackWizard.Attack(4));
            Console.WriteLine(blackWizard.Attack(10));
        }
    }
}