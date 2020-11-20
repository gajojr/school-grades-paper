using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi ime ucenika: ");
            string ime_ucenika = Console.ReadLine();
            Console.Write("Unesi prezime ucenika: ");
            string prezime_ucenika = Console.ReadLine();
            Console.Write("Unesi redni broj ucenika: ");
            byte redni_broj_ucenika = Byte.Parse(Console.ReadLine());
            Console.Write("Unesi ime razrednog staresine: ");
            string ime_razrednog_staresine = Console.ReadLine();
            Console.Write("Unesi prezime razrednog staresine: ");
            string prezime_razrednog_staresine = Console.ReadLine();
            Listic neki = new Listic(ime_ucenika, prezime_ucenika, redni_broj_ucenika, ime_razrednog_staresine, prezime_razrednog_staresine);
            neki.StampajInfo();

            Console.ReadKey();
        }
    }
}
