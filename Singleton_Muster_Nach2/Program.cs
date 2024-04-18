using System;

namespace Singleton_Muster_Nach2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrkGeneral King = OrkGeneral.getInstance();
            King.setName("Ork_Malakas der I");
            OrkGeneral King3 = OrkGeneral.getInstance();
            King3.setName("Ork_Malakas der III");
            OrkGeneral King2 = OrkGeneral.getInstance();
            King2.setName("Ork_Malakas der II");
           
            Console.WriteLine(King.AngrifsBefell());
            Console.WriteLine(King2.AngrifsBefell());
            Console.WriteLine(King3.AngrifsBefell());
            Console.WriteLine(King2.RückzugsBefell());
            Console.WriteLine(King3.RückzugsBefell());
            Console.WriteLine(King.RückzugsBefell());
            Console.WriteLine($"Name des General:{King3.name}");
           
            Console.ReadKey();
        }
    }
}
