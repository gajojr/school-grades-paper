using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace main
{
    class Listic
    {
        string ime_ucenika;
        string prezime_ucenika;
        byte redni_broj_ucenika;
        string ime_razrednog_staresine;
        string prezime_razrednog_staresine;

        public Listic()
        {
            ime_ucenika = "";
            prezime_ucenika = "";
            redni_broj_ucenika = 0;
            ime_razrednog_staresine = "";
            prezime_razrednog_staresine = "";
        }

        public Listic(string ime_ucenika, string prezime_ucenika, byte redni_broj_ucenika, 
            string ime_razrednog_staresine, string prezime_razrednog_staresine)
        {
            this.ime_ucenika = ime_ucenika;
            this.prezime_ucenika = prezime_ucenika;
            this.redni_broj_ucenika = redni_broj_ucenika;
            this.ime_razrednog_staresine = ime_razrednog_staresine;
            this.prezime_razrednog_staresine = prezime_razrednog_staresine;
        }

        public void StampajInfo()
        {
            Console.WriteLine("Ime ucenika: {0}\nPrezime ucenika: {1}\nRedni broj ucenika:{2}\nIme razrednog: {3}\nPrezime razrednog: {4}\n", this.ime_ucenika, this.prezime_ucenika, this.redni_broj_ucenika, this.ime_razrednog_staresine, this.prezime_razrednog_staresine);
        }

        string[] ocene_srpski = new string[4];
        string[] ocene_engleski = new string[4];
        string[] ocene_fizicko = new string[4];
        string[] ocene_matematika = new string[4];
        string[] ocene_sociologija = new string[4];
        string[] ocene_programiranje = new string[4];
        string[] ocene_sistemi = new string[4];
        string[] ocene_web = new string[4];
        string[] ocene_mreze = new string[4];
        string[] ocene_baze = new string[4];
        string[] ocene_izborni = new string[4];
        string nebitni_predmet;

        public void UnesiOcene()
        {
            Console.Write("Unesi ocene za srpski: ");
            this.ocene_srpski = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za engleski: ");
            this.ocene_engleski = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za fizicko: ");
            this.ocene_fizicko = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za matematiku: ");
            this.ocene_matematika = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za sociologiju: ");
            this.ocene_sociologija = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za programiranje: ");
            this.ocene_programiranje = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za sisteme: ");
            this.ocene_sistemi = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za web: ");
            this.ocene_web = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za mreze: ");
            this.ocene_mreze = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za baze: ");
            this.ocene_baze = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za izborni: ");
            this.ocene_izborni = Console.ReadLine().Split(' ');
            Console.Write("Unesi ocene za nebitan predmet: ");
            this.nebitni_predmet = Console.ReadLine();
        }

        public void IspisOcena()
        {
            Ispis(ocene_srpski);
            Ispis(ocene_engleski);
            Ispis(ocene_fizicko);
            Ispis(ocene_matematika);
            Ispis(ocene_sociologija);
            Ispis(ocene_programiranje);
            Ispis(ocene_sistemi);
            Ispis(ocene_web);
            Ispis(ocene_mreze);
            Ispis(ocene_baze);
            Ispis(ocene_izborni);
            Console.WriteLine("Ocena iz nebitnog predmeta: {0}", nebitni_predmet);
        }

        string[] predmeti = new string[12] { "Srpski jezik i književnost", "Engleski jezik", "Fizičko vaspitanje",
        "Matematika", "Sociologija sa pravima građana", "Programiranje", "Računarski sistemi", "Veb programiranje",
        "Računarske mreže i internet servisi", "Baze podataka", "Izborni predmeti", " Građansko vaspitanje/Verska nastava"};

        // globalni brojac za iteraciju kroz niz predmeti u Ispis metodi
        int br = 0;

        private void Ispis(string[] predmet)
        {
            Console.WriteLine("Ocene iz predmeta {0}", predmeti[this.br]);
            this.br++;
            foreach(string ocena in predmet)
            {
                Console.Write("{0} ", ocena);
            }

            Console.WriteLine();
        }
    }
}
