using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodosli u program, unesite C da napravite novi listic, R da pronadjate postojeci, U da updatujete postojeci, D da obrisete postojeci");
            biranje_moda:
            char komanda = char.Parse(Console.ReadLine());
            switch(komanda)
            {
                case 'C':
                case 'c':
                    Console.Write("Unesi ime ucenika: ");
                    string ime_ucenika = Console.ReadLine();
                    Console.Write("Unesi prezime ucenika: ");
                    string prezime_ucenika = Console.ReadLine();
                    Console.Write("Unesi redni broj ucenika: ");
                    byte redni_broj_ucenika = byte.Parse(Console.ReadLine());
                    Console.Write("Unesi ime razrednog staresine: ");
                    string ime_razrednog_staresine = Console.ReadLine();
                    Console.Write("Unesi prezime razrednog staresine: ");
                    string prezime_razrednog_staresine = Console.ReadLine();
                    Listic novi_listic = new Listic(ime_ucenika, prezime_ucenika, redni_broj_ucenika, ime_razrednog_staresine, prezime_razrednog_staresine);
                    Console.Write("\n\n");
                    novi_listic.StampajInfo();
                    novi_listic.UnesiOcene();
                    Console.Write("\n\n");
                    novi_listic.IspisOcena();
                    break;
                case 'R':
                case 'r':
                    Console.WriteLine("Usli ste u read mode");
                    break;
                case 'U':
                case 'u':
                    Console.WriteLine("Usli ste u update mode");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Usli ste u delete mode");
                    break;
                default:
                    Console.WriteLine("Uneli ste nevazecu komandu");
                    Console.Write("Pokusajte ponovo: ");
                    goto biranje_moda;
            }

            Console.ReadKey();
        }
    }
}
