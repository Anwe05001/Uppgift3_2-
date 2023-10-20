using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hej, har du gått ut ur gymnasiet?");
        Console.WriteLine("Svara med ett Ja eller Nej");

        string svar = Console.ReadLine();

        Console.WriteLine("Hur gammal är du?");
        Console.WriteLine("Svara i år");

        string ålder = Console.ReadLine();

        // int ja = int.Parse(gått);
        int vuxen = int.Parse(ålder);

        if (svar == "Ja" && vuxen < 22)
        {
            Console.WriteLine("Vi vill gärna anställa dig!");
        }
        else
        {
            Console.WriteLine("Vi vill tyvärr inte hyra dig");
        }

        Console.ReadKey();
    }
}