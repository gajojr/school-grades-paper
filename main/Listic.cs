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
    }
}
